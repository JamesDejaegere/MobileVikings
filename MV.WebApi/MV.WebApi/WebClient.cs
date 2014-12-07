using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
using MV.WebApi.Interfaces;
using MV.WebApi.Enums;
using MV.WebApi.JsonObject;
using System.Threading.Tasks;

namespace MV.WebApi
{
    /// <summary>
    /// .Net Client for calling api methods for Mobile vikings
    /// </summary>
    public class WebClient : IMVWebApiClient
    {
        private const string _apiUrl = @"https://www.mobilevikings.be/api/2.0/";

        private const string _authenticate_oAuth = "oauth";
        private const string _authenticate_basic = "basic";

        private const string _usage = "usage";
        private const string _balance = "sim_balance";
        private const string _simList = "msisdn_list";
        private const string _price_plan = "price_plan_details";
        private const string _top_up_history = "top_up_hisory";
        private const string _points_stats = "points/stats";
        private const string _points_links = "points/links";
        private const string _points_referrals = "points/referrals";

        private const string _resultFormat = ".json";

        async public Task<List<Sim>> GetSimsAsync()
        {
            try
            {
                var response = await ReadResponseAsync(CreateRequest(ApiMethod.Sim_List));
                if (response != null)
                {
                    var sims = ConvertToSimList(response);
                    return sims;
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Reads the response of sending a api method
        /// </summary>
        /// <param name="request">httpRequest that will be sent</param>
        /// <returns>the response from the httpRequest</returns>
        async private Task<string> ReadResponseAsync(WebRequest request)
        {
            var content = new MemoryStream();
            using (WebResponse webResponse = await request.GetResponseAsync())
            {
                using (Stream responseStream = webResponse.GetResponseStream())
                {
                    await responseStream.CopyToAsync(content);
                }
            }
            if (content.Length >= 0)
            {
                return Encoding.Default.GetString(content.ToArray());
            }

            //byte[] result = null;
            //var stream = await request.GetRequestStreamAsync();
            //if (stream != null)
            //{
            //    await stream.ReadAsync(result, 0, (int)stream.Length);
            //}

            return null;
        }

        private List<Sim> ConvertToSimList(string response)
        {
            List<Sim> responseMessage = null;
            try
            {
                responseMessage = JsonConvert.DeserializeObject<List<Sim>>(response);
            }
            catch (Exception)
            {
                try
                {
                    //responseMessage = JsonConvert.DeserializeObject<ResponseErrorMessage>(response);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return responseMessage;
        }

        private HttpWebRequest CreateRequest(ApiMethod method)
        {
            try
            {
                var url = _apiUrl + _authenticate_basic + "/";
                switch (method)
                {
                    case ApiMethod.Sim_List:
                        url += _simList + _resultFormat + "?alias=1";
                        break;
                    case ApiMethod.Sim_Balance:
                        break;
                    case ApiMethod.Sim_Usage:
                        break;
                    case ApiMethod.Sim_PricePlan:
                        break;
                    case ApiMethod.TopUpHistory:
                        break;
                    case ApiMethod.SimCardInfo:
                        break;
                    case ApiMethod.VP_Stats:
                        break;
                    case ApiMethod.VP_Links:
                        break;
                    case ApiMethod.VP_Referals:
                        break;
                    default:
                        url += _simList;
                        break;
                }
                url += _resultFormat;
                HttpWebRequest request = WebRequest.Create(new Uri(url)) as HttpWebRequest;
                request.Method = "GET";
                request.ContentType = "application/json; charset=UTF-8";
                request.Accept = "application/json";
                request.Credentials = new NetworkCredential("jdejaegere", "J@mes@MV");
                return request;
            }
            catch (Exception ex)
            {
                throw new Exception("Fault in creating HttpRequest.", ex);
            }
        }

        public Sim_Balance GetSimBalance(string simId)
        {
            throw new NotImplementedException();
        }

        public List<Usage> GetSimUsage(string simId)
        {
            throw new NotImplementedException();
        }
    }
}
