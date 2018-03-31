using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using LinguaLeo.Interfaces;

namespace LinguaLeo.Api
{
    class API : IAPI
    {
        protected string API_URL = "http://api.lingualeo.com/";

        private string Email;
        private string Password;
        CookieContainer cookie = null;

        public API(string Email, string Password)
        {
            this.Email = Email;
            this.Password = Password;
        }

        public string Auth()
        {
            string urlParams = "email=" + this.Email
                            + "&password=" + this.Password;
            return Process(urlParams, "api/login", "POST");
        }

        public string isAuthorized()
        {
            return Process(null, "isauthorized", "POST");
        }

        public string AddWord(string word, string tword)
        {

            string urlParams = word != null ? "word=" + word : throw new System.ArgumentNullException();
            urlParams += tword != null ? "&tword=" + tword : "";

            return Process(urlParams, "addWord", "POST");
        }

        public string AddWords(List<Word> words)
        {
            if (words == null)
                throw new System.ArgumentNullException();
            string urlParams = "";
            for (int i = 0; i < words.Count; i++)
            {
                urlParams += "words[" + (i + 1).ToString() + "][word]=" + words[i].word + "&";
                if (words[i].word != null)
                    urlParams += "words[" + (i + 1).ToString() + "][tword]=" + words[i].tword;
                urlParams += "&";
            }
            return Process(urlParams, "addWords", "POST");
        }

        public string Translates(string word)
        {
            string urlParams = "word=" + word;
            return Process(urlParams, "getTranslates", "POST");
        }

        

        private string Process(string urlParams, string apiPath, string Method)
        {
            byte[] data = GetBytes(urlParams);
            HttpWebRequest req = GetWebRequest(apiPath, Method, data.Length);
            SendRequest(req.GetRequestStream(), data);
            if (cookie == null)
                cookie = req.CookieContainer;
            return GetResponse(req.GetResponse().GetResponseStream());
        }

        private HttpWebRequest GetWebRequest(string URL, string Method, int postDataLength)
        {
            HttpWebRequest request = HttpWebRequest.CreateHttp(API_URL + URL);
            request.Method = Method;
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = postDataLength;
            request.CookieContainer = new CookieContainer();
            if (cookie != null)
                request.CookieContainer = cookie;
            return request;
        }

        private void SendRequest(Stream request, byte[] data)
        {
            if (request != null && data != null)
                request.Write(data, 0, data.Length);
            request.Close();
        }

        private string GetResponse(Stream responce)
        {
            return responce != null ? new StreamReader(responce).ReadToEnd() : null;
        }

        private byte[] GetBytes(string data)
        {
            return data != null ? Encoding.UTF8.GetBytes(data) : new byte[0];
        }
    }
}

/*
    isAuth:"/isauthorized",
    login:"/api/login",
    addWordToDict:"/addword",
    addWordToDictMultiple:"/addwords",
    translate:"/translate.php",
    getTranslations:"/gettranslates",
 */


/*  You can find all api paths in LinguaLeo extention config.js file.
 *  Some examples are in server.js file.
 *  My path:
        C:\Users\*****\AppData\Local\Google\Chrome\User Data\Default\Extensions\nglbhlefjhcjockellmeclkcijildjhi\2.0.3.3_0\lingualeo\js\
*/
