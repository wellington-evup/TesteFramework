using System;
using System.Net.Http;

namespace TesteFramework.Core
{
    public interface IClientContactResponseTranslator
    {
        HttpResponseMessage GetResponseFromAction(Action action);
    }
}