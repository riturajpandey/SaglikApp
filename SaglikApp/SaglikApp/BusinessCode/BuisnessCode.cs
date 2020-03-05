using SaglikApp.Providers;
using System.Net.Http;

namespace SaglikApp.BusinessCode
{
    public class BuisnessCode : IBusinessCode
    {
        IApiProvider _apiProvider;
        public BuisnessCode(IApiProvider apiProvider)
        {
            //To initialize service providers...
            _apiProvider = apiProvider;
            HttpClientHandler handler = new HttpClientHandler();
        }

        #region Web Services

        #region Accounts Api
       
        #endregion

   
     

        #endregion
    }
}

