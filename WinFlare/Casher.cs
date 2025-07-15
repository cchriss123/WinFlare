using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFlare
{
    internal class Casher
    {
        public static List<string> CashLocations()
        {
            List<string> cash = new List<string>();
            cash.Add("C:");
            cash.Add("D:");


            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady && drive.DriveType == DriveType.Fixed)
                {
                    cash.Add(drive.Name);
                }
            }

            return cash;





        }

    }


}