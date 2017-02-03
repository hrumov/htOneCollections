using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace htOneCollections
{
    public class QueueClass : CollectionsClass
    {
        public Queue<int> myQueue;

        public QueueClass()
        {
            Queue<int> myQueue = new Queue<int>();
            for (int i = 1; i <= Int32.Parse(CollectionSettings.NumberOfElements); i++)
            {
                myQueue.Enqueue(i * 2);
            }
            this.myQueue = myQueue;
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
                    myQueue.Enqueue(897);
                    st.Stop();
                    this.addLastItemTime = st.Elapsed;
                    break;
                case "getFirstItemTime":
                    st.Start();
                    int a = myQueue.Peek();
                    st.Stop();
                    this.getFirstItemTime = st.Elapsed;
                    break;
                case "getLastItemTime":
                    break;
                case "delFirstItemTime":
                    st.Start();
                    myQueue.Dequeue();
                    st.Stop();
                    this.delFirstItemTime = st.Elapsed;
                    break;
                case "delLastItemTime":
                    break;
            }
        }
    }
}
