using NUnit.Framework;
using System;
using System.Net;
using System.Net.Http;
using TesteFramework.Core;
using TesteFramework.Core.Exceptions;

namespace TesteFramework
{
    public class ClientContactResponseTranslatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ClientContactResponseTranslator_Success()
        {
            //Arrange
            Action action = () => { };
            var responseTranslator = new ClientContactResponseTranslator();
            HttpStatusCode actual, expected = HttpStatusCode.OK;

            //Act
            actual = responseTranslator.GetResponseFromAction(action).StatusCode;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void ClientContactResponseTranslator_Fail_NoAuth()
        {
            //Arrange
            Action action = () => { throw new NoAuthException(); };
            var responseTranslator = new ClientContactResponseTranslator();
            HttpStatusCode actual, expected = HttpStatusCode.Unauthorized;

            //Act
            actual = responseTranslator.GetResponseFromAction(action).StatusCode;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void ClientContactResponseTranslator_Fail_UnidentifiedCustomer()
        {
            //Arrange
            Action action = () => { throw new UnidentifiedCustomerException(); };
            var responseTranslator = new ClientContactResponseTranslator();
            HttpStatusCode actual, expected = HttpStatusCode.Forbidden;

            //Act
            actual = responseTranslator.GetResponseFromAction(action).StatusCode;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void ClientContactResponseTranslator_Fail_Generic()
        {
            //Arrange
            Action action = () => { throw new Exception(); };
            var responseTranslator = new ClientContactResponseTranslator();
            HttpStatusCode actual, expected = HttpStatusCode.InternalServerError;

            //Act
            actual = responseTranslator.GetResponseFromAction(action).StatusCode;

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}