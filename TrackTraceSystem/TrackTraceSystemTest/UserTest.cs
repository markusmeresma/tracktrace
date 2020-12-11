/*
 * Author: Markus Meresma
 * Date last modified: 10.12.2020
 * Description of the role of the class:
 * This is a unit test which tests phone nr validation methods in User class
 */

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrackTraceSystem.business;

namespace TrackTraceSystemTest
{
    [TestClass]
    public class UserTest
    {
        /*
         * Test methods for phone nr validation
         */

        [TestMethod]
        public void TestIsValidUKPhoneNr()
        {
            //Arrange
            string UKMobilePhoneNr = "+447222555555";
            bool expected = true;

            //Act
            bool actual = User.IsValidUKPhoneNr(UKMobilePhoneNr);

            //Assert
            Assert.AreEqual(expected, actual, "Mobile phone nr not validated correctly");
        }

        [TestMethod]
        public void TestIsUniquePhoneNr()
        {
            //Arrange
            string mobilePhoneNr_1 = "+447222555555";
            string mobilePhoneNr_2 = "+447123456789";
            bool expected = true;
            User testUser = new User(mobilePhoneNr_1);

            //Act
            bool actual = User.IsUniquePhoneNr(mobilePhoneNr_2);

            //Assert
            Assert.AreEqual(expected, actual, "Phone nr uniqueness not validated correctly");        
        }
    }
}
