using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace htOneCollections
{
    public class SortedDictionaryClass : CollectionsClass
    {
        public SortedDictionary<int, int> myDict;

        public SortedDictionaryClass()
        {
            SortedDictionary<int, int> myDict = new SortedDictionary<int, int>();
            for (int i = 1; i <= Int32.Parse(CollectionSettings.NumberOfElements); i++)
            {
                myDict.Add(i, i * 2);
            }
            this.myDict = myDict;
        }

        public void GetTime(string operation)
        {
            Stopwatch st = new Stopwatch();
            switch (operation)
            {
                case "addFirstItemTime":
                    st.Start();
                    myDict.Add(0, 897);
                    st.Stop();
                    this.addFirstItemTime = st.Elapsed;
                    break;
                case "addLastItemTime":
                    st.Start();
                    int k = Int32.Parse(CollectionSettings.NumberOfElements) + 1;
                    myDict.Add(k, 897);
                    st.Stop();
                    this.addLastItemTime = st.Elapsed;
                    break;
                case "getFirstItemTime":
                    st.Start();
                    int a = myDict[0];
                    st.Stop();
                    this.getFirstItemTime = st.Elapsed;
                    break;
                case "getLastItemTime":
                    st.Start();
                    int b = myDict[Int32.Parse(CollectionSettings.NumberOfElements) + 1];
                    st.Stop();
                    this.getLastItemTime = st.Elapsed;
                    break;
                case "delFirstItemTime":
                    st.Start();
                    myDict.Remove(0);
                    st.Stop();
                    this.delFirstItemTime = st.Elapsed;
                    break;
                case "delLastItemTime":
                    st.Start();
                    myDict.Remove(Int32.Parse(CollectionSettings.NumberOfElements));
                    st.Stop();
                    this.delLastItemTime = st.Elapsed;
                    break;
            }
        }
    }
}
