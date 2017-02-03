using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace htOneCollections
{
    [TestFixture]
    public class TestClass
    {
        [TestCase]
        public void ListTest()
        {
            ListClass lc = new ListClass();

            lc.GetTime("addLastItemTime");
            lc.GetTime("getFirstItemTime");
            lc.GetTime("getLastItemTime");
            lc.GetTime("delFirstItemTime");
            lc.GetTime("delLastItemTime");
            lc.name = "List";
            CollectionsClass.Loging(lc);
        }

        [TestCase]
        public void LinkedListTest()
        {
            LinkedListClass llc = new LinkedListClass();

            llc.GetTime("addLastItemTime");
            llc.GetTime("getFirstItemTime");
            llc.GetTime("getLastItemTime");
            llc.GetTime("delFirstItemTime");
            llc.GetTime("delLastItemTime");
            llc.name = "LinkedList";
            CollectionsClass.Loging(llc);
        }

        [TestCase]
        public void DictionaryTest()
        {
            DictionaryClass dc = new DictionaryClass();

            dc.GetTime("addFirstItemTime");
            dc.GetTime("addLastItemTime");
            dc.GetTime("getFirstItemTime");
            dc.GetTime("getLastItemTime");
            dc.GetTime("delFirstItemTime");
            dc.GetTime("delLastItemTime");
            dc.name = "Dictionary";
            CollectionsClass.Loging(dc);
        }

        [TestCase]
        public void QueueTest()
        {
            QueueClass qc = new QueueClass();

            qc.GetTime("addFirstItemTime");
            qc.GetTime("addLastItemTime");
            qc.GetTime("getFirstItemTime");
            qc.GetTime("getLastItemTime");
            qc.GetTime("delFirstItemTime");
            qc.GetTime("delLastItemTime");
            qc.name = "Queue";
            CollectionsClass.Loging(qc);
        }

        [TestCase]
        public void StackTest()
        {
            StackClass sc = new StackClass();

            sc.GetTime("addFirstItemTime");
            sc.GetTime("addLastItemTime");
            sc.GetTime("getFirstItemTime");
            sc.GetTime("getLastItemTime");
            sc.GetTime("delFirstItemTime");
            sc.GetTime("delLastItemTime");
            sc.name = "Stack";
            CollectionsClass.Loging(sc);
        }

        [TestCase]
        public void SortedSetTest()
        {
            SortedSetClass ssc = new SortedSetClass();

            ssc.GetTime("addFirstItemTime");
            ssc.GetTime("addLastItemTime");
            ssc.GetTime("getFirstItemTime");
            ssc.GetTime("getLastItemTime");
            ssc.GetTime("delFirstItemTime");
            ssc.GetTime("delLastItemTime");
            ssc.name = "SortedSet";
            CollectionsClass.Loging(ssc);
        }

        [TestCase]
        public void SortedDictionaryTest()
        {
            SortedDictionaryClass sdc = new SortedDictionaryClass();

            sdc.GetTime("addFirstItemTime");
            sdc.GetTime("addLastItemTime");
            sdc.GetTime("getFirstItemTime");
            sdc.GetTime("getLastItemTime");
            sdc.GetTime("delFirstItemTime");
            sdc.GetTime("delLastItemTime");
            sdc.name = "Sorteddictionary";
            CollectionsClass.Loging(sdc);
        }
    }
}
