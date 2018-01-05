using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

/*
 * JSON Packet Format
 * 
 * {
    "Repository_Name" : "Test",
    "Last_Commit" : null,
    "Tags" :
    {
        "0" : "test",
        "1" : "test2",
        "2" : "test3",
        "3" : "test4",
        "4" : "test5",
        "5" : "test6",
        "6" : "test7",
        "7" : "test8",
        "8" : "test9",
        "9" : "test10",
        "10" : "test11",
        "11" : "test12"
    },
    "Status" : 0
}
 * 
 */

namespace GITRepoManager
{
    public class COM
    {
        public static string Repository_Name { get; set; }
        public static DateTime Last_Commit { get; set; }
        public static List<string> Notes { get; set; }
        public static Status_Type Status { get; set; }

        public enum Status_Type
        {
            Invalid = 0,
            New = 1,
            Development = 2,
            Production = 3
        }

        const string pattern = @"\s*""(\S*)""\s*:\s*""(\S*)"".*\s*";


        #region Deserialize

        /*
         *   ________________________________________________________________________________
         *   # Method:             Deserialize                                              #
         *   #                                                                              #
         *   # Usage:              Breaks a JSON packet into it's COM variables             #
         *   #                                                                              #
         *   # Parameters:         string - The json packet string                          #   
         *   #                                                                              #
         *   # Returns:            Boolean representing a failed or passed deserialization  #
         *   #                                                                              #
         *   # Last Date Modified: Josh                                                     #
         *   #                                                                              #
         *   # Last Modified By:   1/5/2018                                                 #
         *   #                                                                              #
         *   ________________________________________________________________________________
         */
            public static bool Deserialize(string json)
            {
                try
                {
                    var settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        MissingMemberHandling = MissingMemberHandling.Ignore
                    };

                    var jpacket = JsonConvert.DeserializeObject<dynamic>(json, settings);

                    Repository_Name = jpacket.Repository_Name.ToString();

                    if (jpacket.Last_Commit == null)
                    {
                        Last_Commit = DateTime.MinValue;
                    }

                    if(Status > Status_Type.Production || Status < Status_Type.Development)
                    {
                        Status = Status_Type.Invalid;
                    }

                    else
                    {
                        Status = (Status_Type)jpacket.Status;
                    }


                    Notes.Clear();
                    Notes = Get_Notes(jpacket.Tags.ToString());

                    return true;
                }

                catch (Exception ex)
                {
                    return false;
                }
            }

        #endregion


        #region Get Notes

        /*
         *   ________________________________________________________________________________
         *   # Method:             Get_Notes                                                #
         *   #                                                                              #
         *   # Usage:              Breaks the notes portion of a JSON packet into a list.   #
         *   #                                                                              #
         *   # Parameters:         string - The notes portion of the json packet string.    #   
         *   #                                                                              #
         *   # Returns:            A list of strings containing each note                   #
         *   #                                                                              #
         *   # Last Date Modified: 1/5/2018                                                 #
         *   #                                                                              #
         *   # Last Modified By:   Josh                                                     #
         *   #                                                                              #
         *   ________________________________________________________________________________
         */
            public static List<string> Get_Notes(string json)
            {
                List<string> result = new List<string>();

                json = json.Substring(1, json.Length - 2).Trim();

                Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);

                MatchCollection matches = rgx.Matches(json);

                if (matches.Count > 0)
                {
                    foreach (Match m in matches)
                    {
                        //string key = m.Groups[1].ToString();
                        string val = m.Groups[2].ToString();

                        result.Add(val);
                    }
                }

                return result;
            }

        #endregion


        #region Status Type To String

        /*
         *   ________________________________________________________________________________
         *   # Method:             Status_Type_ToString()                                   #
         *   #                                                                              #
         *   # Usage:              Creates a message based on the current status.           #
         *   #                                                                              #
         *   # Parameters:         None                                                     #   
         *   #                                                                              #
         *   # Returns:            A string containing a message.                           #
         *   #                                                                              #
         *   # Last Date Modified: 1/5/2018                                                 #
         *   #                                                                              #
         *   # Last Modified By:   Josh                                                     #
         *   #                                                                              #
         *   ________________________________________________________________________________
         */
            public string Status_Type_ToString()
            {
                switch(Status)
                {
                    case Status_Type.New:
                        return "New";

                    case Status_Type.Development:
                        return "Development";

                    case Status_Type.Production:
                        return "Production";

                    default:
                        return "Invalid";
                }
            }

        #endregion
    }
}
