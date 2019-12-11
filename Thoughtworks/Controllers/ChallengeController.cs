using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Thoughtworks.Models;

namespace Thoughtworks.Controllers
{
    public class ChallengeController : Controller
    {
        [HttpGet]
        public int StageOne()
        {
            string jsonResponse = null;
            int count = 0;
            var webRequest = System.Net.WebRequest.Create(" https://http-hunt.thoughtworks-labs.net/challenge/input");
            webRequest.Method = "GET";
            webRequest.ContentType = "application/json";
            webRequest.Headers.Add("userid", "0g6QIVoLy");

            using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                {
                    jsonResponse = sr.ReadToEnd();
                    var obj1 = JsonConvert.DeserializeObject<StageOne>(jsonResponse);
                    count = obj1.text.Length;
                }
            }

            var request = (HttpWebRequest)WebRequest.Create("https://http-hunt.thoughtworks-labs.net/challenge/output");
            request.Accept = "application/json"; //"application/xml";
            request.Method = "POST";
            request.Headers.Add("userid", "0g6QIVoLy");

            StageOneOut obj = new StageOneOut() { count = count};
            JavaScriptSerializer jss = new JavaScriptSerializer();
            // serialize into json string
            var myContent = jss.Serialize(obj);

            var data = Encoding.ASCII.GetBytes(myContent);

            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            try
            {
                var response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception ex)
            {
            }

            return count;
        }

        [HttpGet]
        public int StageTwo()
        {
            string jsonResponse = null;
            int count = 0;
            var webRequest = System.Net.WebRequest.Create(" https://http-hunt.thoughtworks-labs.net/challenge/input");
            webRequest.Method = "GET";
            webRequest.ContentType = "application/json";
            webRequest.Headers.Add("userid", "0g6QIVoLy");

            using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                {
                    jsonResponse = sr.ReadToEnd();
                    var obj1 = JsonConvert.DeserializeObject<StageOne>(jsonResponse);
                    var r = obj1.text.Split(' ');
                    count = r.Length;
                }
            }

            var request = (HttpWebRequest)WebRequest.Create("https://http-hunt.thoughtworks-labs.net/challenge/output");
            request.Accept = "application/json"; //"application/xml";
            request.Method = "POST";
            request.Headers.Add("userid", "0g6QIVoLy");

            StageTwoOut obj = new StageTwoOut() { wordCount = count };
            JavaScriptSerializer jss = new JavaScriptSerializer();
            // serialize into json string
            var myContent = jss.Serialize(obj);

            var data = Encoding.ASCII.GetBytes(myContent);

            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            try
            {
                var response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception ex)
            {
            }

            return count;
        }

        [HttpGet]
        public int StageThree()
        {
            string jsonResponse = null;
            int count = 0;
            var webRequest = System.Net.WebRequest.Create(" https://http-hunt.thoughtworks-labs.net/challenge/input");
            webRequest.Method = "GET";
            webRequest.ContentType = "application/json";
            webRequest.Headers.Add("userid", "0g6QIVoLy");

            using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                {
                    jsonResponse = sr.ReadToEnd();
                    var obj1 = JsonConvert.DeserializeObject<StageOne>(jsonResponse);
                    var r = obj1.text.Split(new char[] { '.', '?' }, StringSplitOptions.RemoveEmptyEntries);
                    count = r.Length;
                }
            }

            var request = (HttpWebRequest)WebRequest.Create("https://http-hunt.thoughtworks-labs.net/challenge/output");
            request.Accept = "application/json"; //"application/xml";
            request.Method = "POST";
            request.Headers.Add("userid", "0g6QIVoLy");

            StageThree obj = new StageThree() { sentenceCount = count };
            JavaScriptSerializer jss = new JavaScriptSerializer();
            // serialize into json string
            var myContent = jss.Serialize(obj);

            var data = Encoding.ASCII.GetBytes(myContent);

            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            try
            {
                var response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception ex)
            {
            }

            return count;
        }

        [HttpGet]
        public int StageFour()
        {
            string jsonResponse = null;
            int count = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            dic['a'] = 0;
            dic['e'] = 0;
            dic['i'] = 0;
            dic['o'] = 0;
            dic['u'] = 0;
            var webRequest = System.Net.WebRequest.Create(" https://http-hunt.thoughtworks-labs.net/challenge/input");
            webRequest.Method = "GET";
            webRequest.ContentType = "application/json";
            webRequest.Headers.Add("userid", "0g6QIVoLy");

            using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                {
                    jsonResponse = sr.ReadToEnd();
                    var obj1 = JsonConvert.DeserializeObject<StageOne>(jsonResponse);
                    foreach (char c in obj1.text)
                    {
                        if (c == 'a' || c == 'A')
                        {
                            dic['a']++;
                        }
                        else if (c == 'e' || c == 'E')
                        {
                            dic['e']++;
                        }
                        else if (c == 'i' || c == 'I')
                        {
                            dic['i']++;
                        }
                        else if (c == 'o' || c == 'O')
                        {
                            dic['o']++;
                        }
                        else if (c == 'u' || c == 'U')
                        {
                            dic['u']++;
                        }
                    }
                }
            }

            var request = (HttpWebRequest)WebRequest.Create("https://http-hunt.thoughtworks-labs.net/challenge/output");
            request.Accept = "application/json"; //"application/xml";
            request.Method = "POST";
            request.Headers.Add("userid", "0g6QIVoLy");

            StageThree obj = new StageThree() { sentenceCount = count };
            JavaScriptSerializer jss = new JavaScriptSerializer();
            // serialize into json string
            var myContent = JsonConvert.SerializeObject(dic);

            var data = Encoding.ASCII.GetBytes(myContent);

            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            try
            {
                var response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception ex)
            {
            }

            return count;
        }
    }
}