using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegisteration;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //validation for first Name
        [TestMethod]
        [DataRow("Ankit", "Ankit")]
        [DataRow("Ank", "Ank")]
        [DataRow("a", null)]
        [DataRow("Anki05", null)]

        public void ValidateFirstname(string a, string expected)
        {

            var actual = RegexSample.ValidatingFirstName(a);
            Assert.AreEqual(expected, actual);
        }
        //Validating for Last Name
        [TestMethod]
        [DataRow("Venkatesh", "Venkatesh")]
        [DataRow("Ve", null)]
        [DataRow("Venkat", "Venkat")]
        [DataRow("Venkat05", null)]
        public void ValidateUserLastname(string a, string expected)
        {
            var actual = RegexSample.ValidatingLastName(a);
            Assert.AreEqual(expected, actual);
        }
        //Validation for Email
        [TestMethod]
        [DataRow("abc@gmail.com", "abc@gmail.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc111@yahoo.com", "abc111@yahoo.com")]
        [DataRow("abc111@abc.com", "abc111@abc.com")]
        [DataRow("abc-100@abc.net", "abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
        [DataRow("abc@1.com", "abc@1.com")]
        [DataRow("abc@gmail.com.com", "abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com", "abc+100@gmail.com")]
        [DataRow("abc", null)]
        [DataRow("abc@.com.my", null)]
        [DataRow("abc123@.com", null)]
        [DataRow("abc123@.com.com", null)]
        [DataRow("abc()*@gmail.com", null)]
        [DataRow(".abc@abc.com", null)]
        [DataRow("abc@%*.com", null)]
        [DataRow("abc..2002@gmail.com", null)]
        [DataRow("abc.@gmail.com", null)]
        [DataRow("abc@abc@gmail.com", null)]
        [DataRow("abc@gmail.com.1a", null)]
        [DataRow("abc@gmail.com.aa.au", null)]

        public void ValidateUserEmail(string a, string expected)
        {
            var actual = RegexSample.ValidatingEmailId(a);
            Assert.AreEqual(expected, actual);
        }

        //Validation for Phone Number
        [TestMethod]
        [DataRow("1 1000987267", "1 1000987267")]
        [DataRow("91 9842905050", "91 9842905050")]
        [DataRow("100 9842905050", "100 9842905050")]
        [DataRow("919842905050", null)]
        [DataRow("919842905", null)]
        [DataRow("91 984290", null)]
        [DataRow("91 984290505000000", null)]
        public void ValidateUserPhoneNumber(string a, string expected)
        {
            var actual = RegexSample.ValidatingPhoneNum(a);
            Assert.AreEqual(expected, actual);
        }

        ////Validation for Password
        [TestMethod]
        [DataRow("Anki@123", "Anki@123")]
        [DataRow("Ank#it123", "Ank#lini123")]
        [DataRow("Ank@it1A ", "Ank@it1A")]
        [DataRow("@Ankit129", "@Ankit129")]
        [DataRow("Ank-it123", "Ank-it123")]
        [DataRow("ankit123)@1234", null)]
        [DataRow("Ank@it", null)]
        [DataRow("ank123", null)]
        [DataRow("ank@123", null)]
        [DataRow("@ank#12it", null)]
        [DataRow(")ankit12", null)]
        [DataRow(")ankIt12", null)]
        [DataRow("ank-it@12S", null)]
        [DataRow("anKI@s", null)]

        public void ValidateUserPassword(string a, string expected)
        {
            var actual = RegexSample.ValidatingPassWord(a);
            Assert.AreEqual(expected, actual);
        }



    }
}