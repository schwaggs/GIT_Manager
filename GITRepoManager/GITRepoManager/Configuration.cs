using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GITRepoManager
{
    public static class Configuration
    {
        private class XML
        {
            public class Packet
            {
                public List<Store> Stores { get; set; }

                public class Store
                {
                    public string Name { get; set; }
                    public string Location { get; set; }

                    public List<Repo> Repos { get; set; }

                    public class Repo
                    {
                        public string Name { get; set; }
                        public string Status { get; set; }

                        public List<Note> Notes { get; set; }

                        public class Note
                        {
                            public string Title { get; set; }
                            public string Body { get; set; }
                        }
                    }
                }
            }

            public static class Helpers
            {
                public static List<Packet> Parse()
                {
                    List<Packet> ParsedList = new List<Packet>();
                    ParsedList.Clear();

                    

                    return ParsedList;
                }

                public static void Serializer(string path)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Packet.Store>));
                    StreamReader reader = new StreamReader(path);
                }
            }
        }
    }
}
