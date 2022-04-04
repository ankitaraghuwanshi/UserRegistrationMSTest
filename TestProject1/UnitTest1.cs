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
        [Test]
        public void ValidEmail()
        {
            string expected = "Email is Valid";
            string result = null;
            string email = "bittanraghu@gmail.com";
            try
            {
                result = validation.ValidEmail(email);
            }
            catch (Exception)
            {
                Assert.AreEqual(expected, result);
            }
        }
        [Test]
        public void ValidPhone()
        {
            string expected = "Phone number is Valid";
            string result = null;
            try
            {
                string phone = "1234567890";
                result = validation.ValidPhoneNumber(phone);
            }
            catch (Exception)
            {
                Assert.AreEqual(expected, result);
            }
        }
        [Test]
        public void ValidPassWord()
        {
            string result = null;
            string expected = "Password should contain atleast eight characters";
            try
            {
                string password = "passwords";
                result = validation.ValidPasswordEightChars(password);
            }
            catch (Exception)
            {
                Assert.AreEqual(expected, result);
            }
        }
        public void ValidPassWord_2()
        {
            string result = null;
            string expected = "Password should contain atleast eight characters";
            try
            {
                string password = "passwords";
                result = validation.ValidPasswordEightChars(password);
            }
            catch (Exception)
            {
                Assert.AreEqual(expected, result);
            }
        }
    }
}         
