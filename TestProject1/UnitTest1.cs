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
            string name = "Sankalp";
            string result = validation.ValidFirstName(name);
            Assert.AreEqual(expected, result);
        }
    }
}