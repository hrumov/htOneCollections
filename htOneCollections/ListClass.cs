using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace htOneCollections
{
    public class ListClass : CollectionsClass
    {
        public List<int> myList;

        public ListClass()
        {
            List<int> myList = new List<int>();
            for (int i = 0; i < Int32.Parse(CollectionSettings.NumberOfElements); i++)
            {
                myList.Add(i * 2);
            }
            this.myList = myList;
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
                    myList.Add(897);
                    st.Stop();
                    this.addLastItemTime = st.Elapsed;
                    break;
                case "getFirstItemTime":
                    st.Start();
                    int a = myList[0];
                    st.Stop();
                    this.getFirstItemTime = st.Elapsed;
                    break;
                case "getLastItemTime":
                    st.Start();
                    int b = myList[(Int32.Parse(CollectionSettings.NumberOfElements)) - 1];
                    st.Stop();
                    this.getLastItemTime = st.Elapsed;
                    break;
                case "delFirstItemTime":
                    st.Start();
                    myList.RemoveAt(0);
                    st.Stop();
                    this.delFirstItemTime = st.Elapsed;
                    break;
                case "delLastItemTime":
                    st.Start();
                    myList.RemoveAt((Int32.Parse(CollectionSettings.NumberOfElements)) - 1);
                    st.Stop();
                    this.delLastItemTime = st.Elapsed;
                    break;
            }
        }
    }
}
