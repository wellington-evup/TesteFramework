using NUnit.Framework;
using System;
using TesteFramework.Core;
using TesteFramework.Core.Exceptions;

namespace TesteFramework
{
    public class BirthDateTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BirthDate_Success()
        {
            //Arrange
            var birthDate = new BirthDate();

            //Act
            Action action = () => birthDate.SetValue(new DateTime(1992, 03, 06));

            //Assert
            Assert.That(action, Throws.Nothing);
        }

        [Test]
        public void BirthDate_Fail_Pattern()
        {
            //Arrange
            var birthDate = new BirthDate();

            //Act
            Action action = () => birthDate.SetValue(new DateTime(1899, 12, 31));

            //Assert
            Assert.That(action, Throws.InstanceOf<PatternException>());
        }
    }
}