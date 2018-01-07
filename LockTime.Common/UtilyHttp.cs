using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using System.IO;

namespace LockTime.Common
{
    public   class UtilyHttp
    {
        public  static void Post(string url, object para)
        {
            HttpWebRequest request =(HttpWebRequest)WebRequest.Create(url);
            request.Method = "Post";
            request.ContentType = "application/json; charset=UTF-8";

            var paraString = JsonConvert.SerializeObject(para);

            Encoding encoding = Encoding.UTF8;
            byte[] postData = encoding.GetBytes(paraString);
            request.ContentLength = postData.Length;

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(postData, 0, postData.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            StreamReader streamReader = new StreamReader(responseStream, encoding);
            string retString = streamReader.ReadToEnd();
            streamReader.Close();
            responseStream.Close();

        }
    }
}
