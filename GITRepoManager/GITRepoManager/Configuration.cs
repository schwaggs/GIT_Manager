using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace GITRepoManager
{
    public static class Configuration
    {
        public static XML.Root Parsed_Raw { get; set; }

        public class XML
        {
            [XmlRoot(ElementName = "root")]
            public class Root
            {
                [XmlElement(ElementName = "Store")]
                public List<Store> Stores { get; set; }
            }

            [XmlRoot(ElementName = "Store")]
            public class Store
            {
                [XmlElement(ElementName = "Location")]
                public string Location { get; set; }

                [XmlElement(ElementName = "Repos")]
                public Repos Repos { get; set; }
            }

            [XmlRoot(ElementName = "Repos")]
            public class Repos
            {
                [XmlElement(ElementName = "Repo")]
                public List<Repo> Items { get; set; }
            }

            [XmlRoot(ElementName = "Repo")]
            public class Repo
            {
                [XmlElement(ElementName = "Name")]
                public string Name { get; set; }

                [XmlElement(ElementName = "Status")]
                public string Status { get; set; }

                [XmlElement(ElementName = "Notes")]
                public Notes Notes { get; set; }
            }

            [XmlRoot(ElementName = "Notes")]
            public class Notes
            {
                [XmlElement(ElementName = "Note")]
                public List<Note> Items { get; set; }
            }

            [XmlRoot(ElementName = "Note")]
            public class Note
            {
                [XmlElement(ElementName = "Title")]
                public string Title { get; set; }

                [XmlElement(ElementName = "Body")]
                public string Body { get; set; }

            }
        }

        public static class Helpers
        {
            public static void Deserialize(string source)
            {
                Parsed_Raw = null;

                XmlSerializer serializer = new XmlSerializer(typeof(XML.Root));
                StreamReader reader = new StreamReader(source);

                XML.Root input = null;
                try
                {
                    input = (XML.Root)serializer.Deserialize(reader);
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                reader.Close();

                Parsed_Raw = input;
                Get_Stores();
                return;
            }






            public static void Serialize_Replace(string destination)
            {
                XML.Root root = new XML.Root();
                root.Stores = new List<XML.Store>();

                XML.Store store = new XML.Store();
                store.Location = "New Location";
                store.Repos = new XML.Repos();

                store.Repos.Items = new List<XML.Repo>();

                XML.Repo repo = new XML.Repo();
                repo.Name = "Test Add";
                repo.Status = "DEVELOPMENT";
                repo.Notes = new XML.Notes();

                repo.Notes.Items = new List<XML.Note>();

                XML.Note note = new XML.Note();
                note.Title = "Test Note 1";
                note.Body = "Test Message 1";

                repo.Notes.Items.Add(note);
                store.Repos.Items.Add(repo);
                root.Stores.Add(store);

                XmlSerializer serializer = new XmlSerializer(typeof(XML.Root));
                StreamWriter writer = new StreamWriter(destination);

                serializer.Serialize(writer, root);
                writer.Close();
            }

            public static void Get_Stores()
            {
                if (Parsed_Raw != null)
                {
                    ManagerData.Stores = new Dictionary<string, StoreCell>();
                    StoreCell currStore = null;

                    try
                    {
                        foreach (XML.Store Parsed_Store in Parsed_Raw.Stores)
                        {
                            currStore = new StoreCell(Parsed_Store.Location);
                            currStore._Repos = Get_Repos(Parsed_Store.Repos);

                            ManagerData.Stores.Add(Parsed_Store.Location, currStore);
                        }
                    }

                    catch (Exception ex)
                    {
                        ManagerData.Stores = null;
                    }
                }
            }
            public static Dictionary<string, RepoCell> Get_Repos(XML.Repos ReposObj)
            {
                Dictionary<string, RepoCell> RepoDict = new Dictionary<string, RepoCell>();

                try
                {
                    foreach (XML.Repo Parsed_Repo in ReposObj.Items)
                    {
                        RepoCell currRepo = Get_Repo(Parsed_Repo);
                        currRepo.Logs = new Dictionary<string, List<EntryCell>>();

                        if (currRepo != null)
                        {
                            RepoDict.Add(Parsed_Repo.Name, currRepo);
                        }
                    }
                }

                catch (Exception ex)
                {
                    RepoDict = null;
                }

                return RepoDict;
            }

            public static RepoCell Get_Repo(XML.Repo RepoObj)
            {
                RepoCell currRepo = null;

                try
                {
                    currRepo = new RepoCell();
                    currRepo.Current_Status = RepoCell.Status.ToType(RepoObj.Status);
                    currRepo.Notes = Get_Notes(RepoObj.Notes);
                }

                catch(Exception ex)
                {
                    
                }

                return currRepo;
            }

            public static Dictionary<string, string> Get_Notes(XML.Notes NotesObj)
            {
                Dictionary<string, string> NoteDict = new Dictionary<string, string>();

                try
                {
                    foreach (XML.Note note in NotesObj.Items)
                    {
                        NoteDict.Add(note.Title, note.Body);
                    }
                }

                catch (Exception ex)
                {
                    NoteDict = null;
                }

                return NoteDict;
            }
        }
    }
}
