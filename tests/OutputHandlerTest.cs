namespace tests;

[TestClass]
public class OutputHandlerTest : code.OutputHandler
{
    [TestMethod]
    public void Test1()
    {
        var lowPoints = new List<int> { 1, 2, 3 };
        int expected = 9;
        int actual = code.OutputHandler.sumCustomised(lowPoints);
    Assert.AreEqual(expected, actual);
    }


//     [TestMethod]
//     public void Test2()
//     {
//  CollectionAssert.AreEqual(expected, actual);
//     }

  
//         // sum
//     [TestMethod]
//     public void exampleFinalTest()
//     {

//         Assert.AreEqual(expected, actual);
//     }

//         [TestMethod]
//     public void outputTest()
//     {
       
//         Assert.AreEqual(expected, actual);
//     }
}
