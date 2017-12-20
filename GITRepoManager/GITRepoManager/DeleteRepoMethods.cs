using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITRepoManager
{
    public static class DeleteRepoMethods
    {
        public static void DeleteRepository()
        {
            MessageBox.Show("Deleting " + DeleteRepoData.Repository_Setting_Location);
        }
    }
}
