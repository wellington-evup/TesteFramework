using NUnit.Framework;
using System;
using TesteFramework.Core;
using TesteFramework.Core.Exceptions;

namespace TesteFramework
{
    public class ClientContactValidatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ClientContactValidator_Success()
        {
            //Arrange
            var cliente = new Client();
            var emailAddress = new EmailAddress(); emailAddress.SetValue("wellington@teste.com.br");
            var validator = new ClientContactValidator();

            //Act
            Action action = () => validator.Validate(cliente, emailAddress);

            //Assert
            Assert.That(action, Throws.Nothing);
        }

        [Test]
        public void ClientContactValidator_Fail_Pattern()
        {
            //Arrange
            var cliente = new Client();
            var emailAddress = new EmailAddress(); emailAddress.SetValue("wellington@teste.com");
            var validator = new ClientContactValidator();

            //Act
            Action action = () => validator.Validate(cliente, emailAddress);

            //Assert
            Assert.That(action, Throws.InstanceOf<ForeignException>());
        }
    }
}