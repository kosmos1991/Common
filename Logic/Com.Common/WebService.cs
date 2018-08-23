using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Com.Common
{
    /// <summary>
    /// 远程获取数据
    /// </summary>
    public class WebService
    {
        /// <summary>
        /// 远程获取数据（POST）
        /// </summary>
        /// <param name="param"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static dynamic HttpPost(Dictionary<string, string> dic, string url)
        {
            var param = JsonConvert.SerializeObject(dic);
            //转换输入参数的编码类型，获取bytep[]数组 
            byte[] byteArray = Encoding.UTF8.GetBytes(param);
            //初始化新的webRequst
            //1． 创建httpWebRequest对象
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(new Uri(url));
            //2． 初始化HttpWebRequest对象
            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";
            webRequest.ContentLength = byteArray.Length;
            Stream newStream = webRequest.GetRequestStream();
            newStream.Write(byteArray, 0, byteArray.Length);
            newStream.Close();
            //4． 读取服务器的返回信息
            HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string srend = sr.ReadToEnd();
            sr.Close();
            response.Close();
            return srend;
        }

        /// <summary>
        /// 远程获取数据（POST）
        /// </summary>
        /// <param name="param"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static dynamic HttpPost<T>(Dictionary<string, string> dic, string url)
        {
            var param = JsonConvert.SerializeObject(dic);

            //转换输入参数的编码类型，获取bytep[]数组 
            byte[] byteArray = Encoding.UTF8.GetBytes(param);
            //初始化新的webRequst
            //1． 创建httpWebRequest对象
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(new Uri(url));
            //2． 初始化HttpWebRequest对象
            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";
            webRequest.ContentLength = byteArray.Length;
            Stream newStream = webRequest.GetRequestStream();
            newStream.Write(byteArray, 0, byteArray.Length);
            newStream.Close();
            //4． 读取服务器的返回信息
            HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string srend = sr.ReadToEnd();
            sr.Close();
            response.Close();
            var res = JsonConvert.DeserializeObject<T>(srend);
            return res;
        }

        public static dynamic HttpGet(Dictionary<string, string> dic, string url)
        {
            var param = "";
            foreach (var item in dic)
            {
                if (!string.IsNullOrEmpty(param))
                    param += "&";

                param += item.Key + "=" + item.Value;
            }
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + (param == "" ? "" : "?") + param);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }

        public static dynamic HttpGet<T>(Dictionary<string, string> dic, string url)
        {
            var param = "";
            foreach (var item in dic)
            {
                if (!string.IsNullOrEmpty(param))
                    param += "&";

                param += item.Key + "=" + item.Value;
            }
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + (param == "" ? "" : "?") + param);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            var res = JsonConvert.DeserializeObject<T>(retString);
            return res;
        }
    }
}