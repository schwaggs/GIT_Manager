using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITRepoManager
{
    public class RepoCell
    {
        public string Path { get; set; }
        public Status.Type Current_Status { get; set; }
        public DateTime Last_Commit { get; set; }               
        public string Last_Commit_Message { get; set; }         

        public Dictionary<string, string> Notes { get; set; }                 
        public Dictionary<string, List<EntryCell>> Logs { get; set; }

        public static class Status
        {
            public enum Type
            {
                NONE = 0,
                NEW = 1,
                DEVELOPMENT = 2,
                PRODUCTION = 3
            }

            public static string ToString(Type temp)
            {
                switch (temp)
                {
                    case Type.NONE:
                        return "None";

                    case Type.NEW:
                        return "New";

                    case Type.DEVELOPMENT:
                        return "Development";

                    case Type.PRODUCTION:
                        return "Production";

                    default:
                        return "";
                }
            }

            public static Type ToType(string temp)
            {
                temp = temp.ToLower();

                switch (temp)
                {
                    case "none":
                        return Type.NONE;

                    case "new":
                        return Type.NEW;

                    case "development":
                        return Type.DEVELOPMENT;

                    case "production":
                        return Type.PRODUCTION;

                    default:
                        return Type.NONE;
                }
            }
        }
    }

    public class EntryCell
    {
        public string ID { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
    }

    public class NoteCell
    {
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
