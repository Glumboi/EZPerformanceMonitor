using Octokit;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace EZPerformanceMonitor.Core
{
    internal class VersionControl
    {
        public async Task<bool> CheckGitHubNewerVersion()
        {
            //Get all releases from GitHub
            //Source: https://octokitnet.readthedocs.io/en/latest/getting-started/
            var client = new GitHubClient(new ProductHeaderValue("EZPCPM"));
            var releases = await client.Repository.Release.GetAll("Glumboi", "EZPerformanceMonitor");

            //Setup the versions
            var latestGitHubVersion = new Version(releases[0].TagName);
            var Reference = typeof(Form1).Assembly;
            var Version = Reference.GetName().Version;
            var localVersion = new Version(Version.ToString()); //Replace this with your local version. 
            //Only tested with numeric values.

            //Compare the Versions
            //Source: https://stackoverflow.com/questions/7568147/compare-version-numbers-without-using-split-function
            var versionComparison = localVersion.CompareTo(latestGitHubVersion);
            if (versionComparison < 0)
            {
                /*var dialogResult = MessageBox.Show(
                    $"You got an outdated version of EZAC installed would you like to update?\nCurrent installed version: {localVersion}\nNewest version: {latestGitHubVersion}",
                    "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);*/
             
                return true;
                /*if (dialogResult == DialogResult.Yes)
                {
                    Debug.WriteLine("Outdated");
                    Process.Start("https://github.com/Glumboi/EZAutoclicker/releases");
                }
                else if (dialogResult == DialogResult.No)
                {
                }*/
                //The version on GitHub is more up to date than this local release.
            }
            else if (versionComparison > 0)
            {
                Program.debugConsole.Info($"The local version of the app is higher than the version on github github (local version: {localVersion})");
                //This local version is greater than the release version on GitHub.
                return false;
            }
            else
            {
                Program.debugConsole.Info("The versions of the app is equal to the gtihub version");
                //This local Version and the Version on GitHub are equal.
                return false;
            }
        }

    }
}
