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

        public static class File
        {
            public enum NODE_T
            {
                NOTHING,
                STORE,
                REPO,
                NOTE
            };

            public enum ATTRIBUTE_T
            {
                NOTHING,
                LOCATION,
                NAME,
                STATUS,
                TITLE
            };

            public static string NODE_T_ToString(NODE_T node)
            {
                switch (node)
                {
                    case NODE_T.NOTE:
                        return "Note";
                    case NODE_T.REPO:
                        return "Repo";
                    case NODE_T.STORE:
                        return "Store";
                    default:
                        return string.Empty;
                }
            }

            public static string ATTRIBUTE_T_ToString(ATTRIBUTE_T attr)
            {
                switch (attr)
                {
                    case ATTRIBUTE_T.LOCATION:
                        return "Location";
                    case ATTRIBUTE_T.NAME:
                        return "Name";
                    case ATTRIBUTE_T.STATUS:
                        return "Status";
                    case ATTRIBUTE_T.TITLE:
                        return "Title";
                    default:
                        return string.Empty;
                }
            }

            public static NODE_T String_ToNODE_T(string str)
            {
                str = str.ToLower();

                switch (str)
                {
                    case "note":
                        return NODE_T.NOTE;
                    case "repo":
                        return NODE_T.REPO;
                    case "store":
                        return NODE_T.STORE;
                    default:
                        return NODE_T.NOTHING;
                }
            }

            public static ATTRIBUTE_T String_ToATTRIBUTE_T(string str)
            {
                str = str.ToLower();

                switch (str)
                {
                    case "location":
                        return ATTRIBUTE_T.LOCATION;
                    case "name":
                        return ATTRIBUTE_T.NAME;
                    case "status":
                        return ATTRIBUTE_T.STATUS;
                    case "title":
                        return ATTRIBUTE_T.TITLE;
                    default:
                        return ATTRIBUTE_T.NOTHING;
                }
            }
        }

        public static class Helpers
        {
            #region Deserialize Raw Packet Structure

            public static void Deserialize(string source)
            {
                Parsed_Raw = null;

                XmlSerializer deserializer = new XmlSerializer(typeof(XML.Root));
                StreamReader reader = new StreamReader(source);

                XML.Root input = null;
                try
                {
                    input = (XML.Root)deserializer.Deserialize(reader);
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

            #endregion


            #region Replace Config File Data With New Data

            public static void Serialize_Replace(string destination, Dictionary<string, StoreCell> ToAdd)
            {
                XML.Root tempRoot = new XML.Root();
                tempRoot.Stores = new List<XML.Store>();

                foreach (KeyValuePair<string, StoreCell> Store in ToAdd)
                {
                    XML.Store tempStore = new XML.Store();
                    tempStore.Location = Store.Value._Path;
                    tempStore.Repos = new XML.Repos();
                    tempStore.Repos.Items = new List<XML.Repo>();

                    foreach (KeyValuePair<string, RepoCell> Repo in Store.Value._Repos)
                    {
                        XML.Repo tempRepo = new XML.Repo();
                        tempRepo.Name = Repo.Key;
                        tempRepo.Status = RepoCell.Status.ToString(Repo.Value.Current_Status);
                        tempRepo.Notes = new XML.Notes();
                        tempRepo.Notes.Items = new List<XML.Note>();

                        foreach (KeyValuePair<string, string> Note in Repo.Value.Notes)
                        {
                            XML.Note tempNote = new XML.Note();
                            tempNote.Title = Note.Key;
                            tempNote.Body = Note.Value;

                            tempRepo.Notes.Items.Add(tempNote);
                        }

                        tempStore.Repos.Items.Add(tempRepo);
                    }

                    tempRoot.Stores.Add(tempStore);
                }

                XmlSerializer serializer = new XmlSerializer(typeof(XML.Root));
                StreamWriter writer = new StreamWriter(destination);

                serializer.Serialize(writer, tempRoot);
                writer.Close();
            }

            #endregion


            #region Parse The Raw Packet To Class Data

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
                            currStore._Path = Parsed_Store.Location;
                            currStore._Repos = Get_Repos(Parsed_Store.Repos);

                            DirectoryInfo currStoreInfo = new DirectoryInfo(Parsed_Store.Location);
                            ManagerData.Stores.Add(currStoreInfo.Name, currStore);
                        }

                        foreach (StoreCell store in ManagerData.Stores.Values)
                        {
                            foreach (RepoCell repo in store._Repos.Values)
                            {
                                repo.Path = store._Path + @"\" + repo.Name;
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        ManagerData.Stores = null;
                    }
                }
            }

            #endregion


            #region Parse The Repos In The Raw Packet To Class Data

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

            #endregion


            #region Create A Repo Cell For An Config Repo

            public static RepoCell Get_Repo(XML.Repo RepoObj)
            {
                RepoCell currRepo = null;

                try
                {
                    currRepo = new RepoCell();
                    currRepo.Name = RepoObj.Name;
                    currRepo.Current_Status = RepoCell.Status.ToType(RepoObj.Status);
                    currRepo.Notes = Get_Notes(RepoObj.Notes);
                }

                catch(Exception ex)
                {
                    
                }

                return currRepo;
            }

            #endregion


            #region Parse The Notes In The Raw Packet To Class Data

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

            #endregion

            #region Deserialize Condensed Packet Structure

            public static void Deserialize_Condensed(string source)
            {
                source = @"C:\temp\test.gmc";
                // Load the document
                XmlDocument Config = new XmlDocument();
                Config.Load(source);

                ManagerData.Stores = new Dictionary<string, StoreCell>();

                if (Config.DocumentElement.HasChildNodes)
                {
                    #region Get Each Store From Root

                    // Loop through each store node of root
                    foreach (XmlNode Store in Config.DocumentElement)
                    {
                        StoreCell storeCell = null;

                        if (Store.Attributes.Count > 0)
                        {
                            #region Get Store Attributes

                            // Loop through the store node's attributes (Location)
                            foreach (XmlAttribute storeAttr in Store.Attributes)
                            {
                                storeCell = new StoreCell(storeAttr.Value);
                            }

                            #endregion
                        }

                        // If the store node has children (Repos) loop through them
                        if (Store.HasChildNodes)
                        {
                            storeCell._Repos = new Dictionary<string, RepoCell>();
                            RepoCell repoCell = null;

                            #region Get Each Repository From Store

                            foreach (XmlNode Repo in Store.ChildNodes)
                            {
                                if (Repo.Attributes.Count > 0)
                                {
                                    repoCell = new RepoCell();

                                    #region Get Repository Attributes

                                    // Loop through the repo node's attributes (Name, Status)
                                    foreach (XmlAttribute repoAttr in Repo.Attributes)
                                    {
                                        switch (File.String_ToATTRIBUTE_T(repoAttr.Name))
                                        {
                                            case File.ATTRIBUTE_T.NAME:
                                                repoCell.Name = repoAttr.Value;
                                                break;

                                            case File.ATTRIBUTE_T.STATUS:
                                                repoCell.Current_Status = RepoCell.Status.ToType(repoAttr.Value);
                                                break;

                                            default:
                                                break;

                                        }
                                    }

                                    #endregion
                                }

                                // If the repo node has children (Notes) and the repo is valid, loop through them.
                                if (Repo.HasChildNodes && RepoHelpers.Is_Git_Repo(storeCell._Path + @"\" + repoCell.Name))
                                {
                                    repoCell.Notes = new Dictionary<string, string>();

                                    #region Get Each Note From Repository

                                    foreach (XmlNode Note in Repo.ChildNodes)
                                    {
                                        if (Note.Attributes.Count > 0)
                                        {
                                            string Title = string.Empty;
                                            string Body = string.Empty;

                                            #region Get Note Attributes

                                            // Loop through the note node's attributes (Title)
                                            foreach (XmlAttribute noteAttr in Note.Attributes)
                                            {
                                                Title = noteAttr.Value;
                                            }

                                            #endregion

                                            // Get the text of the note as inner text on the object i.e. Note.InnerText
                                            Body = Note.InnerText;

                                            repoCell.Notes.Add(Title, Body);
                                        }
                                    }

                                    #endregion

                                    storeCell._Repos.Add(repoCell.Name, repoCell);
                                }
                            }

                            #endregion
                        }

                        if (storeCell != null)
                        {
                            DirectoryInfo storeInfo = new DirectoryInfo(storeCell._Path);

                            if (storeInfo.Exists)
                            {
                                ManagerData.Stores.Add(storeInfo.Name, storeCell);
                            }
                        }
                    }

                    #endregion
                }
            }

            #endregion
        }
    }
}
