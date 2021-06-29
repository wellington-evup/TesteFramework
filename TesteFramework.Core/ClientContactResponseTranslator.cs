using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using TesteFramework.Core.Exceptions;

namespace TesteFramework.Core
{
    public class ClientContactResponseTranslator : IClientContactResponseTranslator
    {
        public HttpResponseMessage GetResponseFromAction(Action action)
        {
            try
            {
                action.Invoke();

                return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            }
            catch (EmailAddressInUseException)
            {
                var response = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
                response.Content = null; //something
                return response;
            }
            catch (NoAuthException)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
            }
            catch (UnidentifiedCustomerException)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden);
            }
            catch (Exception)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
            }
        }
    }
}
