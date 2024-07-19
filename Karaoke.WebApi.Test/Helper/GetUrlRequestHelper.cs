
using Karaoke.Domain.Enums;
using System.ComponentModel;

namespace Karaoke.WebApi.Test.Helper
{
    public static class GetUrlRequestHelper
    {
        public static Boolean IsValidUrl(string url)
        {
            string[] urlDividida = url.Split("?");

            if(urlDividida.Count() < 2)
            {
                return false;
            }

            string[] bodyUrl = urlDividida[1].Split("&");

            
            if (bodyUrl.Count() < 3)
            {
                return false;
            }

            foreach(string bu in bodyUrl)
            {
                if(bu.Split("=").Count() < 2)
                {
                    return false;
                }
            }

            List<string> endpoints = GetEndPointList();

            foreach (string endpoint in endpoints) 
            {
                if (urlDividida[0].Contains(endpoint))
                {
                    return true;
                }
            }

            return false;
        }

        private static List<string> GetEndPointList() 
        {
            List<string> endpoints = new List<string>();

            foreach(var att in Enum.GetValues(typeof(Youtube)))
            {
                endpoints.Add(att.ToString());
            }

            return endpoints;
        }
    }
}
