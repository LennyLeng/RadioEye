using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace CSHttpBaseLayer
{
    class HttpBaseLayer
    {
        public static string Get(string strURL, string strUserAgent)
        {
            try
            {
                CookieContainer container = new CookieContainer();
                string strResult = "";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);
                request.UserAgent = strUserAgent;
                request.ContentType = "text/html";
                request.Method = "GET";
                request.CookieContainer = container;

                HttpWebResponse response = null;
                StreamReader sr = null;
                response = (HttpWebResponse)request.GetResponse();
                sr = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8"));
                strResult = sr.ReadToEnd();
                return strResult;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string Post(string strURL, string strArgs, string strUserAgent)
        {
            try
            {
                byte[] bs = Encoding.UTF8.GetBytes(strArgs);

                CookieContainer container = new CookieContainer();
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);

                if (strURL.StartsWith("https", StringComparison.OrdinalIgnoreCase))
                {
                    ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                    request.ProtocolVersion = HttpVersion.Version10;  
                }

                request.Method = "POST";
                request.UserAgent = strUserAgent;
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = strArgs.Length;
                request.CookieContainer = container;
   

                Stream requestStream = request.GetRequestStream();
                requestStream.Write(bs, 0, bs.Length);
                requestStream.Close();

                HttpWebResponse response = null;
                StreamReader reader = null;
                response = (HttpWebResponse)request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8"));
                return reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true; //总是接受  
        }  
    }
}
