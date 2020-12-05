using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Base.Common.Helpers
{
    /// <summary>
    /// Helps with HttpClient Static Instance for API call
    /// </summary>
    public class HttpClientHelper
    {
        #region Static Variables

        // The web API client static Instance
        public static HttpClient WebApiClient = new HttpClient();

        #endregion

        #region Constructor        
        static HttpClientHelper()
        {
            WebApiClient.BaseAddress = new Uri("http://localhost:61652/api/");
            WebApiClient.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));
        }

        #endregion    
    }
}
