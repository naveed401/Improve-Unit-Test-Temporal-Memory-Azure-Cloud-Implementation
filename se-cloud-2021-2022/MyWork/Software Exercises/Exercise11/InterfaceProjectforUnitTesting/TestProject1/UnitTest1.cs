using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterfaceProjectforUnitTesting;
using Newtonsoft.Json;
using System.IO;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 class1 = new Class1();
            int expectedResult = class1.ThrowMeANumber(1);
            Assert.AreEqual(1, expectedResult);
        }
        [TestMethod]
        [TestCategory("Test for Class2")]
        public void TestMethodForClass2()
        {
            // Serialization
            Class2 class2 = new Class2();
            int expectedResult = class2.ThrowMeANumber(1);
            // //string class2Save = JsonConvert.SerializeObject(class2);
            //File.WriteAllText("save of class2 object", class2Save);

            // Deserialization
            //string readJson = File.ReadAllText("save of class2 object");
            // Class2 newClass2Object = JsonConvert.DeserializeObject<Class2>(readJson);
            Assert.AreEqual(2, expectedResult);
        }
    }
}
