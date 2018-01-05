using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace GITRepoManager
{
    public static class Storage
    {
        public enum Type
        {
            INVALID = -1,
            LOCAL_ONLY = 0,
            LOCAL_BACKUP = 1,
            NETWORK = 2
        }
    }
}
