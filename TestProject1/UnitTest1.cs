using NUnit.Framework;
using System;
using UserRegistrationMSTesting;


namespace UserRegistrationTesting
{
    public class Tests
    {
        Validation validation;
        [SetUp]
        public void Setup()
        {
            validation = new Validation();
        }

        [Test]
        public void ValidFirst()
        {
            string expected = "First Name is Valid";
            string name = "Ankita";
            string result = validation.ValidFirstName(name);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void ValidLastName()
        {
            string expected = "Last Name is Valid";
            string name = "Ankita";
            string result = validation.ValidLastName(name);
            Assert.AreEqual(expected, result);
        }
    }
}