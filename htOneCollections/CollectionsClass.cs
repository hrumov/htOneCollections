using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace htOneCollections
{
    public class CollectionsClass
    {
        public TimeSpan addFirstItemTime;
        public TimeSpan addLastItemTime;
        public TimeSpan getFirstItemTime;
        public TimeSpan getLastItemTime;
        public TimeSpan delFirstItemTime;
        public TimeSpan delLastItemTime;
        public string name;

        public static void Loging(CollectionsClass cc)
        {
            string[] lines = {
                    cc.name,
                    "addFirstItemTime   " + cc.addFirstItemTime + " s",
                    "addLastItemTime   " + cc.addLastItemTime + " s",
                    "getFirstItemTime   " + cc.getFirstItemTime + " s",
                    "getLastItemTime   " + cc.getLastItemTime + " s",
                    "delFirstItemTime   " + cc.delFirstItemTime + " s",
                    "delLastItemTime   " + cc.delLastItemTime + " s",
                    ""};
            File.AppendAllLines(CollectionSettings.LogFileAddress, lines);
        }
    }
}
