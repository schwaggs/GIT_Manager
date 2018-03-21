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
        #region Old

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

        #endregion

        #region File Class

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

        #endregion

        #region Helpers Class

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

            public static void Deserialize_Condensed(string file)
            {
                // Load the document
                XmlDocument Config = new XmlDocument();
                Config.Load(file);

                if (ManagerData.Stores != null)
                {
                    ManagerData.Stores.Clear();
                }

                else
                {
                    ManagerData.Stores = new Dictionary<string, StoreCell>();
                }

                string currStoreLocation = string.Empty;
                string currRepoName = string.Empty;
                RepoCell.Status.Type currRepoStatus = RepoCell.Status.Type.NONE;
                string currNoteTitle = string.Empty;
                string currNoteMessage = string.Empty;
                StoreCell newStore = null;
                RepoCell newRepo = null;

                // Under the root the layers will be Stores => Repos => Notes
                foreach (XmlNode storeNode in Config.DocumentElement.ChildNodes)
                {
                    foreach (XmlAttribute storeAttr in storeNode.Attributes)
                    {
                        switch (File.String_ToATTRIBUTE_T(storeAttr.Name))
                        {
                            case File.ATTRIBUTE_T.LOCATION:
                                currStoreLocation = storeAttr.Value;
                                break;
                        }
                    }

                    newStore = new StoreCell(currStoreLocation)
                    {
                        _Repos = new Dictionary<string, RepoCell>()
                    };

                    foreach (XmlNode repoNode in storeNode.ChildNodes)
                    {
                        foreach (XmlAttribute repoAttr in repoNode.Attributes)
                        {
                            switch (File.String_ToATTRIBUTE_T(repoAttr.Name))
                            {
                                case File.ATTRIBUTE_T.NAME:
                                    currRepoName = repoAttr.Value;
                                    break;

                                case File.ATTRIBUTE_T.STATUS:
                                    currRepoStatus = RepoCell.Status.ToType(repoAttr.Value);
                                    break;
                            }
                        }

                        newRepo = new RepoCell()
                        {
                            Name = currRepoName,
                            Current_Status = currRepoStatus,
                            Path = currStoreLocation + @"\" + currRepoName,
                            Notes = new Dictionary<string, string>()
                        };

                        foreach (XmlNode noteNode in repoNode.ChildNodes)
                        {
                            foreach (XmlAttribute noteAttr in noteNode.Attributes)
                            {
                                switch (File.String_ToATTRIBUTE_T(noteAttr.Name))
                                {
                                    case File.ATTRIBUTE_T.TITLE:
                                        currNoteTitle = noteAttr.Value;
                                        break;
                                }
                            }

                            currNoteMessage = noteNode.InnerText;

                            newRepo.Notes.Add(currNoteTitle, currNoteMessage);

                            currNoteMessage = string.Empty;
                            currNoteTitle = string.Empty;
                        }

                        newRepo.Logs_Parsed = false;
                        newStore._Repos.Add(currRepoName, newRepo);

                        currRepoStatus = RepoCell.Status.Type.NONE;
                    }

                    if (currStoreLocation != "")
                    {
                        DirectoryInfo dirInfo = new DirectoryInfo(currStoreLocation);

                        ManagerData.Stores.Add(dirInfo.Name, newStore);
                    }
                }
            }

            

            #endregion


            #region Serialize Condensed Packet Structure
            /*
             *  Node for each store, repo, and note
             * 
             *  Attributes
             *  Store:  Location - Path to store
             *  Repo:   Name - Name of the repository, not path
             *          Status - Current status of the repository i.e New, Development, Production
             *  Note    Title - The title of the note
             *  
             *  Other Data
             *  Note body needs to be inner text of the Note node
             */

            public static bool Serialize_Condensed_All(string file)
            {
                XmlDocument Config = new XmlDocument();
                Config.Load(file);

                try
                {
                    Config.DocumentElement.RemoveAll();
                    Config.Save(file);
                }

                catch
                {
                    return false;
                }

                XmlNode storeNode = null;
                XmlNode repoNode = null;
                XmlNode noteNode = null;

                XmlAttribute storeLocationAttr = null;
                XmlAttribute repoNameAttr = Config.CreateAttribute("Name");
                XmlAttribute repoStatusAttr = Config.CreateAttribute("Status");
                XmlAttribute noteTitleAttr = Config.CreateAttribute("Title");

                if (ManagerData.Stores.Count > 0)
                {
                    // Cycle through each store cell and create a node.
                    // The only attribute is the location of the store.
                    foreach (StoreCell storeCell in ManagerData.Stores.Values)
                    {
                        storeLocationAttr = Config.CreateAttribute("Location");
                        storeLocationAttr.Value = storeCell._Path;

                        // Create a store node and add the location attribute
                        storeNode = Config.CreateElement("Store");
                        storeNode.Attributes.Append(storeLocationAttr);

                        try
                        {
                            if (storeCell._Repos.Count > 0)
                            {
                                // Cycle through each store's repo cells and create nodes
                                // Attributes: Name, Status
                                foreach (RepoCell repoCell in storeCell._Repos.Values)
                                {
                                    repoNameAttr = Config.CreateAttribute(File.ATTRIBUTE_T_ToString(File.ATTRIBUTE_T.NAME));
                                    repoNameAttr.Value = repoCell.Name;

                                    repoStatusAttr = Config.CreateAttribute(File.ATTRIBUTE_T_ToString(File.ATTRIBUTE_T.STATUS));
                                    repoStatusAttr.Value = RepoCell.Status.ToString(repoCell.Current_Status);

                                    // Create a repo node and add all it's attributes
                                    repoNode = Config.CreateElement("Repo");
                                    repoNode.Attributes.Append(repoNameAttr);
                                    repoNode.Attributes.Append(repoStatusAttr);

                                    if (repoCell.Notes.Count > 0)
                                    {
                                        // Cycle through each repo's notes and create nodes
                                        // The only attribute is the note's title
                                        // The inner text is the note body
                                        foreach (KeyValuePair<string, string> note in repoCell.Notes)
                                        {
                                            noteTitleAttr = Config.CreateAttribute("Title");
                                            noteTitleAttr.Value = note.Key;

                                            // Create a note node and add it's attribute as well as body
                                            noteNode = Config.CreateElement("Note");
                                            noteNode.Attributes.Append(noteTitleAttr);
                                            noteNode.InnerText = note.Value;

                                            repoNode.AppendChild(noteNode);
                                        }
                                    }

                                    storeNode.AppendChild(repoNode);
                                }
                            }
                        }

                        catch
                        {
                        }

                        // After all information has been added to the store node add it to the file.
                        Config.DocumentElement.AppendChild(storeNode);
                    }
                }

                Config.Save(file);

                return true;
            }

            #endregion


            #region Get Parent A Node (Store, Repo, Note)

            public static List<XmlNode> Search_Nodes(string searchItem, bool getParent)
            {
                List<XmlNode> FoundNodes = new List<XmlNode>();
                searchItem = searchItem.ToLower();
                XmlDocument Config = new XmlDocument();
                //Config.Load(Properties.Settings.Default.ConfigPath);
                Config.Load(@"C:\Temp\test.gmc");

                if (Config.DocumentElement.ChildNodes.Count > 0)
                {
                    foreach (XmlNode storeNode in Config.DocumentElement.ChildNodes)
                    {
                        foreach (XmlAttribute storeAttr in storeNode.Attributes)
                        {
                            if (storeAttr.Value.ToLower() == searchItem)
                            {
                                if (getParent)
                                {
                                    if (!FoundNodes.Contains(storeNode.ParentNode))
                                    {
                                        FoundNodes.Add(storeNode.ParentNode);
                                    }
                                }

                                else
                                {
                                    if (!FoundNodes.Contains(storeNode))
                                    {
                                        FoundNodes.Add(storeNode);
                                    }
                                }
                            }
                        }

                        if (storeNode.ChildNodes.Count > 0)
                        {
                            foreach (XmlNode repoNode in storeNode.ChildNodes)
                            {
                                foreach (XmlAttribute repoAttr in repoNode.Attributes)
                                {
                                    if (repoAttr.Value.ToLower() == searchItem)
                                    {
                                        if (getParent)
                                        {
                                            if (!FoundNodes.Contains(repoNode.ParentNode))
                                            {
                                                FoundNodes.Add(repoNode.ParentNode);
                                            }
                                        }

                                        else
                                        {
                                            if (!FoundNodes.Contains(repoNode))
                                            {
                                                FoundNodes.Add(repoNode);
                                            }
                                        }
                                    }
                                }

                                if (repoNode.ChildNodes.Count > 0)
                                {
                                    foreach (XmlNode noteNode in repoNode.ChildNodes)
                                    {
                                        foreach (XmlAttribute noteAttr in noteNode.Attributes)
                                        {
                                            if (noteAttr.Value.ToLower() == searchItem)
                                            {
                                                if (getParent)
                                                {
                                                    if (!FoundNodes.Contains(noteNode.ParentNode))
                                                    {
                                                        FoundNodes.Add(noteNode.ParentNode);
                                                    }
                                                }

                                                else
                                                {
                                                    if (!FoundNodes.Contains(noteNode))
                                                    {
                                                        FoundNodes.Add(noteNode);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                return FoundNodes;
            }

            public static XmlNode Get_Selected_Store()
            {
                bool HasLocation = false;

                foreach (XmlNode store in Search_Nodes(ManagerData.Selected_Repo.Name, false))
                {
                    foreach (XmlAttribute attr in store.Attributes)
                    {
                        switch (attr.Name)
                        {
                            case "Location":

                                if (attr.Value == ManagerData.Selected_Store._Path)
                                {
                                    HasLocation = true;
                                }

                                break;
                        }
                    }

                    if (HasLocation)
                    {
                        return store;
                    }
                }

                return null;
            }

            public static XmlNode Get_Selected_Repo()
            {
                foreach (XmlNode repo in Search_Nodes(ManagerData.Selected_Repo.Name, false))
                {
                    bool HasName = false;
                    bool HasStatus = false;

                    foreach (XmlAttribute attr in repo.Attributes)
                    {
                        switch (attr.Name)
                        {
                            case "Name":

                                if (attr.Value == ManagerData.Selected_Repo.Name)
                                {
                                    HasName = true;
                                }

                                break;

                            case "Status":

                                if (attr.Value == RepoCell.Status.ToString(ManagerData.Selected_Repo.Current_Status))
                                {
                                    HasStatus = true;
                                }

                                break;
                        }
                    }

                    if (HasName && HasStatus)
                    {
                        return repo;
                    }
                }

                return null;
            }

            #endregion


            #region Append New Store

            public static bool Append_New_Store(StoreCell newStore)
            {
                // Convert store cell to store node
                // Append store node to the XmlDocument.DocumentElement children
                return true;
            }

            #endregion


            #region Append New Repo

            public static bool Append_New_Repo(RepoCell newRepo)
            {
                // Convert repo cell to repo node
                // Get the node of the currently selected store
                // Append the repo node to the store node's children

                return true;
            }

            #endregion


            #region Append New Note

            public static bool Append_New_Note(string noteTitle, string noteBody)
            {
                // Convert the strings to note node
                // Get the node of the currently selected repo
                // Append the note node to the repo node's children

                return true;
            }

            #endregion
        }

        #endregion
    }
}
