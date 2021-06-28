using NUnit.Framework;
using System;
using TesteFramework.Core;
using TesteFramework.Core.Exceptions;

namespace TesteFramework
{
    public class CPFTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CPF_Success()
        {
            //Arrange
            var cpf = new CPF();

            //Act
            Action action = () => cpf.SetValue("398.742.758-20");

            //Assert
            Assert.That(action, Throws.Nothing);
        }

        [Test]
        public void CPF_Fail_Regex()
        {
            //Arrange
            var cpf = new CPF();

            //Act
            Action action = () => cpf.SetValue("398.742.758-2X");

            //Assert
            Assert.That(action, Throws.InstanceOf<RegexException>());
        }

        [Test]
        public void CPF_Fail_Pattern()
        {
            //Arrange
            var cpf = new CPF();

            //Act
            Action action = () => cpf.SetValue("398.742.758-21");

            //Assert
            Assert.That(action, Throws.InstanceOf<PatternException>());
        }
    }
}