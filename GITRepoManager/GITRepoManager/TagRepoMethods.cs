using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITRepoManager
{
    public static class TagRepoMethods
    {
        public static RepoCell Find_Repo_Cell(object sender)
        {
            foreach (RepoCell rc in TagRepoData.All_Repos)
            {
                if (sender is Label)
                {
                    if (rc.RepoControl == sender as Label)
                    {
                        return rc;
                    }
                }

                else if (sender is string)
                {
                    if (rc.RepoName == sender as string)
                    {
                        return rc;
                    }
                }
            }

            return null;
        }

        public static bool Select_All_Repos()
        {
            try
            {
                foreach (RepoCell rc in TagRepoData.All_Repos)
                {
                    rc.Checked = true;
                }

                TagRepoData.Selected_Repos_Count = TagRepoData.All_Repos.Count;

                return true;
            }

            catch
            {
                return false;
            }
        }

        public static bool Deselect_All_Repos()
        {
            try
            {
                foreach (RepoCell rc in TagRepoData.All_Repos)
                {
                    rc.Checked = false;
                }

                TagRepoData.Selected_Repos_Count = 0;

                return true;
            }

            catch
            {
                return false;
            }
        }

        public static bool Toggle_Selection(object sender)
        {
            try
            {
                RepoCell tempCell = Find_Repo_Cell(sender);

                if (tempCell != null)
                {
                    if (tempCell.Checked)
                    {
                        tempCell.Checked = false;
                        TagRepoData.Selected_Repos_Count--;
                    }

                    else
                    {
                        tempCell.Checked = true;
                        TagRepoData.Selected_Repos_Count++;
                    }

                    return true;
                }

                return false;
            }

            catch
            {
                return false;
            }
        }

        public static bool Checked(object sender)
        {
            RepoCell tempCell = Find_Repo_Cell(sender);

            if (tempCell != null)
            {
                if (tempCell.Checked)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

            return false;
        }

        public static bool Populate_Selected_List()
        {
            TagRepoData.Selected_Repos.Clear();
            try
            {
                foreach (RepoCell rc in TagRepoData.All_Repos)
                {
                    if (rc.Checked)
                    {
                        TagRepoData.Selected_Repos.Add(rc);
                    }
                }


                return true;
            }

            catch
            {
                return false;
            }
        }
    }
}
