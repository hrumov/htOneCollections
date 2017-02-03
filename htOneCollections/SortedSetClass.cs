using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace htOneCollections
{
    public class SortedSetClass : CollectionsClass
    {
        public SortedSet<int> mySSet;

        public SortedSetClass()
        {
            SortedSet<int> mySSet = new SortedSet<int>();
            for (int i = 1; i <= Int32.Parse(CollectionSettings.NumberOfElements); i++)
            {
                mySSet.Add(i * 2);
            }
            this.mySSet = mySSet;
        }

        public void GetTime(string operation)
        {
            Stopwatch st = new Stopwatch();
            switch (operation)
            {
                case "addFirstItemTime":
                    break;
                case "addLastItemTime":
                    st.Start();
                    int k = Int32.Parse(CollectionSettings.NumberOfElements) + 1;
                    mySSet.Add(897);
                    st.Stop();
                    this.addLastItemTime = st.Elapsed;
                    break;
                case "getFirstItemTime":
                    st.Start();
                    int a = mySSet.First<int>();
                    st.Stop();
                    this.getFirstItemTime = st.Elapsed;
                    break;
                case "getLastItemTime":
                    st.Start();
                    int b = mySSet.Last<int>();
                    st.Stop();
                    this.getLastItemTime = st.Elapsed;
                    break;
                case "delFirstItemTime":
                    st.Start();
                    mySSet.Remove(0);
                    st.Stop();
                    this.delFirstItemTime = st.Elapsed;
                    break;
                case "delLastItemTime":
                    st.Start();
                    mySSet.Remove(Int32.Parse(CollectionSettings.NumberOfElements));
                    st.Stop();
                    this.delLastItemTime = st.Elapsed;
                    break;
            }
        }
    }
}
