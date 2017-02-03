using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace htOneCollections
{
    public class StackClass : CollectionsClass
    {
        public Stack<int> myStack;

        public StackClass()
        {
            Stack<int> myStack = new Stack<int>();
            for (int i = 1; i <= Int32.Parse(CollectionSettings.NumberOfElements); i++)
            {
                myStack.Push(i * 2);
            }
            this.myStack = myStack;
        }

        public void GetTime(string operation)
        {
            Stopwatch st = new Stopwatch();
            switch (operation)
            {
                case "addFirstItemTime":
                    st.Start();
                    myStack.Push(897);
                    st.Stop();
                    this.addFirstItemTime = st.Elapsed;
                    break;
                case "addLastItemTime":
                    
                    break;
                case "getFirstItemTime":
                    break;
                case "getLastItemTime":
                    st.Start();
                    int b = myStack.Peek();
                    st.Stop();
                    this.getLastItemTime = st.Elapsed;
                    break;
                case "delFirstItemTime":
                    break;
                case "delLastItemTime":
                    st.Start();
                    myStack.Pop();
                    st.Stop();
                    this.delLastItemTime = st.Elapsed;
                    break;
            }
        }
    }
}
