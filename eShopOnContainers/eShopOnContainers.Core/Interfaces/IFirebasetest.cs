using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.Interfaces
{
    public interface IFirebasetest
    {
        Task<string> DoLoginWithEP(string E,string P);
        Task<string> DoRegisterWithEP(string E, string P);
    }
}
