using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;


namespace SDVBackup
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //Set up paths
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string startPath = appDataPath + "\\StardewValley";
            string zipPath = appDataPath + "\\stardew_backup\\";




            //create backup dir if it doesn't exist already
            System.IO.Directory.CreateDirectory(zipPath);

            //create the backup
            ZipFile.CreateFromDirectory(startPath, zipPath + DateTime.Now.ToString("MM-dd-yyyy_HH-mm-ss") + ".zip");

            Console.WriteLine("All Done!");

            
        }

    }


}
