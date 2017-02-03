using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace htOneCollections
{
    public class LinkedListClass : CollectionsClass
    {
        public LinkedList<int> myList;
        
        public LinkedListClass()
        {
            LinkedList<int> myList = new LinkedList<int>();
            for (int i = 1; i <= Int32.Parse(CollectionSettings.NumberOfElements); i++)
            {
                myList.AddLast(i * 2);
            }
            this.myList = myList;
        }

        public void GetTime(string operation)
        {
            Stopwatch st = new Stopwatch();
            switch (operation)
            {
                case "addFirstItemTime":
                    st.Start();
                    myList.AddFirst(897);
                    st.Stop();
                    this.addFirstItemTime = st.Elapsed;
                    break;
                case "addLastItemTime":
                    st.Start();
                    myList.AddLast(897);
                    st.Stop();
                    this.addLastItemTime = st.Elapsed;
                    break;
                case "getFirstItemTime":
                    st.Start();
                    int a = myList.ElementAt(0);
                    st.Stop();
                    this.getFirstItemTime = st.Elapsed;
                    break;
                case "getLastItemTime":
                    st.Start();
                    int b = myList.ElementAt(Int32.Parse(CollectionSettings.NumberOfElements));
                    st.Stop();
                    this.getLastItemTime = st.Elapsed;
                    break;
                case "delFirstItemTime":
                    st.Start();
                    myList.RemoveFirst();
                    st.Stop();
                    this.delFirstItemTime = st.Elapsed;
                    break;
                case "delLastItemTime":
                    st.Start();
                    myList.RemoveLast();
                    st.Stop();
                    this.delLastItemTime = st.Elapsed;
                    break;
            }
        }
    }
}
