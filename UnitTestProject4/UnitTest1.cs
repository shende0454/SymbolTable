using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SymTab;

namespace UnitTestProject4
{
    [TestClass]
    public class UnitTest1
    {

        //[TestMethod]
        //public void T001_createSymbolTable()
        //{
        //    SimpleST<string, int> st = new SimpleST<string, int>();
        //    Assert.AreEqual(0, st.Size());
        //}
        //// end T001_createSymbolTable()



        //[TestMethod]
        //public void T002_put()
        //{
        //    SimpleST<string, int> creditsPerClass = new SimpleST<string, int>();
        //    int nCredits = 4;
        //    string theClass = "cs242";
        //    creditsPerClass.Put(theClass, nCredits);
        //    Assert.AreEqual(1, creditsPerClass.Size());
        //}
        //// end T002_put()


        //[TestMethod]
        //public void T003_get()
        //{
        //    SimpleST<string, int> creditsPerClass = new SimpleST<string, int>();
        //    int nCredits = 4;
        //    string theClass = "cs242";
        //    creditsPerClass.Put(theClass, nCredits);
        //    Assert.AreEqual(nCredits, creditsPerClass.Get(theClass));
        //}
        //// end T003_get()


        //[TestMethod]
        //public void T004_delete()
        //{
        //    SimpleST<string, int> creditsPerClass = new SimpleST<string, int>();
        //    int nCredits = 4;
        //    string theClass = "cs242";
        //    creditsPerClass.Put(theClass, nCredits);
        //    creditsPerClass.Delete(theClass);
        //    Assert.AreEqual(0, creditsPerClass.Size());
        //}
        //// end T004_delete()


        // [TestMethod]
        //public void T005_contains()
        //{
        //    SimpleST<string, int> creditsPerClass = new SimpleST<string, int>();
        //    int cs242Credits = 4;
        //    string theClass = "cs242";
        //    creditsPerClass.Put(theClass, cs242Credits);
        //    string anotherClass = "cs350";
        //    int cs350Credits = 3;
        //    creditsPerClass.Put(anotherClass, cs350Credits);
        //    Assert.IsTrue(creditsPerClass.Contains(theClass));
        //    creditsPerClass.Delete(theClass);
        //    Assert.IsFalse(creditsPerClass.Contains(theClass));
        //}
        //// end T005_contains()


        //[TestMethod]
        //public void T006_isEmpty()
        //{
        //    SimpleST<string, int> creditsPerClass = new SimpleST<string, int>();
        //    int cs242Credits = 4;
        //    string theClass = "cs242";
        //    creditsPerClass.Put(theClass, cs242Credits);
        //    string anotherClass = "cs350";
        //    int cs350Credits = 3;
        //    creditsPerClass.Put(anotherClass, cs350Credits);
        //    Assert.IsTrue(creditsPerClass.Contains(theClass));
        //    creditsPerClass.Delete(theClass);
        //    creditsPerClass.Delete(anotherClass);
        //    Assert.IsTrue(creditsPerClass.IsEmpty());
        //}
        //// end T006_isEmpty()


        //[TestMethod]
        //public void T007_max()
        //{
        //    SimpleST<string, int> creditsPerClass = new SimpleST<string, int>();
        //    int cs242Credits = 4;
        //    string theClass = "cs242";
        //    creditsPerClass.Put(theClass, cs242Credits);
        //    string anotherClass = "cs350";
        //    int cs350Credits = 3;
        //    creditsPerClass.Put(anotherClass, cs350Credits);
        //    string maxKey = creditsPerClass.Max();
        //    Assert.AreEqual(anotherClass, maxKey);
        //}
        //// end T007_max()

        //[TestMethod]
        //public void T008_min()
        //{
        //    SimpleST<string, int> creditsPerClass = new SimpleST<string, int>();
        //    int cs242Credits = 4;
        //    string theClass = "cs242";
        //    creditsPerClass.Put(theClass, cs242Credits);
        //    string anotherClass = "cs350";
        //    int cs350Credits = 3;
        //    creditsPerClass.Put(anotherClass, cs350Credits);
        //    string minKey = creditsPerClass.Min();
        //    Assert.AreEqual(theClass, minKey);
        //}
        //// end T008_min()


        [TestMethod]
        public void T009_floor()
        {
            SimpleST<string, int> creditsPerClass = new SimpleST<string, int>();
            int cs242Credits = 4;
            string theClass = "cs242";
            creditsPerClass.Put(theClass, cs242Credits);
            string anotherClass = "cs350";
            int cs350Credits = 3;
            creditsPerClass.Put(anotherClass, cs350Credits);
            Assert.AreEqual(theClass, creditsPerClass.Floor(theClass));
            Assert.AreEqual(theClass, creditsPerClass.Floor("cs243"));

        }
        //// end T009_floor()


        //[TestMethod]
        //public void T010_ceiling()
        //{
        //    SimpleST<string, int> creditsPerClass = new SimpleST<string, int>();
        //    int cs242Credits = 4;
        //    string theClass = "cs242";
        //    creditsPerClass.Put(theClass, cs242Credits);
        //    string anotherClass = "cs350";
        //    int cs350Credits = 3;
        //    creditsPerClass.Put(anotherClass, cs350Credits);
        //    Assert.AreEqual(theClass, creditsPerClass.Ceiling(theClass));
        //    Assert.AreEqual(anotherClass, creditsPerClass.Ceiling("cs243"));
        //}
        //// end T010_ceiling()


        //[TestMethod]
        //public void T011_rank()
        //{
        //    SimpleST<string, int> creditsPerClass = new SimpleST<string, int>();
        //    int cs242Credits = 4;

        //    string aThirdClass = "cs452";
        //    int cs452Credits = 3;
        //    creditsPerClass.Put(aThirdClass, cs452Credits);

        //    string theClass = "cs242";
        //    creditsPerClass.Put(theClass, cs242Credits);
        //    string anotherClass = "cs350";
        //    int cs350Credits = 3;
        //    creditsPerClass.Put(anotherClass, cs350Credits);

        //    Assert.AreEqual(0, creditsPerClass.Rank(theClass));
        //    Assert.AreEqual(1, creditsPerClass.Rank(anotherClass));
        //    Assert.AreEqual(2, creditsPerClass.Rank(aThirdClass));
        //}
        //// end T011_rank()


        //[TestMethod]
        //public void T012_select()
        //{
        //    SimpleST<string, int> creditsPerClass = new SimpleST<string, int>();
        //    int cs242Credits = 4;

        //    string aThirdClass = "cs452";
        //    int cs452Credits = 3;
        //    creditsPerClass.Put(aThirdClass, cs452Credits);

        //    string theClass = "cs242";
        //    creditsPerClass.Put(theClass, cs242Credits);
        //    string anotherClass = "cs350";
        //    int cs350Credits = 3;
        //    creditsPerClass.Put(anotherClass, cs350Credits);

        //    Assert.AreEqual(theClass, creditsPerClass.SelectWithRankOf(0));
        //    Assert.AreEqual(anotherClass, creditsPerClass.SelectWithRankOf(1));
        //    Assert.AreEqual(aThirdClass, creditsPerClass.SelectWithRankOf(2));
        //}
        //// end T012_select()


        //[TestMethod]
        //public void T013_deleteMin()
        //{
        //    SimpleST<string, int> creditsPerClass = new SimpleST<string, int>();
        //    int cs242Credits = 4;

        //    string aThirdClass = "cs452";
        //    int cs452Credits = 3;
        //    creditsPerClass.Put(aThirdClass, cs452Credits);

        //    string theClass = "cs242";
        //    creditsPerClass.Put(theClass, cs242Credits);
        //    string anotherClass = "cs350";
        //    int cs350Credits = 3;
        //    creditsPerClass.Put(anotherClass, cs350Credits);

        //    creditsPerClass.DeleteMin();

        //    Assert.IsFalse(creditsPerClass.Contains(theClass));
        //    Assert.IsTrue(creditsPerClass.Contains(anotherClass));
        //    Assert.IsTrue(creditsPerClass.Contains(aThirdClass));
        //}
        //// end T013_deleteMin()


        //[TestMethod]
        //public void T014_deleteMax()
        //{
        //    SimpleST<string, int> creditsPerClass = new SimpleST<string, int>();
        //    int cs242Credits = 4;

        //    string aThirdClass = "cs452";
        //    int cs452Credits = 3;
        //    creditsPerClass.Put(aThirdClass, cs452Credits);

        //    string theClass = "cs242";
        //    creditsPerClass.Put(theClass, cs242Credits);
        //    string anotherClass = "cs350";
        //    int cs350Credits = 3;
        //    creditsPerClass.Put(anotherClass, cs350Credits);

        //    creditsPerClass.DeleteMax();

        //    Assert.IsTrue(creditsPerClass.Contains(theClass));
        //    Assert.IsTrue(creditsPerClass.Contains(anotherClass));
        //    Assert.IsFalse(creditsPerClass.Contains(aThirdClass));
        //}
        //// end T014_deleteMax()


    }
    //[TestClass]
    //public class BinarySearchSTTest
    //{
    //    public void T1_rankTest()
    //    {
    //        BinarySearchST<string,int> table = new BinarySearchST<string,int>();
    //        Assert.AreEqual(0, table.Rank("cs242"));
    //    }
        // end T1_rankTest()
  //  }
}
