using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Text.Json;
using System.Globalization;
using System.Net.Http;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;

namespace TypingGameWpf
{
    /// <summary>
    /// スコアのセーブ及びロードを行う。
    /// </summary>
    public class Score
    {
        /// <summary>
        /// ユーザーID。
        /// </summary>
        public string? Id { get; set; }
        /// <summary>
        /// 初速（文章出題時から打つまでの時間）。
        /// </summary>
        public decimal Latency { get; set; }
        /// <summary>
        /// タイピングスコア。
        /// </summary>
        public double TypingScore { get; set; }
        /// <summary>
        /// タイピングのミス数。
        /// </summary>
        public int MissCount { get; set; }
        private static string serialize(Score score)
        {
            return JsonSerializer.Serialize(score);
        }
        /// <summary>
        /// タイピングのデータをセーブする。
        /// </summary>
        /// <param name="obj">セーブするデータ。</param>
        /// <returns>セーブが成功したかの判断。</returns>
        public static bool Save(Score obj)
        {
            try
            {
                var data = new Score()
                {
                    Latency = obj.Latency,
                    TypingScore = obj.TypingScore
                    //MissCount = obj.MissCount
                };
                string fileName = "test.json";
                string jsonString = serialize(data);
                File.WriteAllText(fileName, jsonString);
            }
            catch
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// タイピングのデータをロードする。
        /// </summary>
        /// <returns>ロードされたデータ。</returns>
        public static Score? Load()
        {
            try
            {
                string fileName = "test.json";
                string jsonString = File.ReadAllText(fileName);
                return JsonSerializer.Deserialize<Score>(jsonString)!;
            }
            catch
            {
                return null;
            }
        }

        public static void Post(Score obj)
        {
            var httpClient = new HttpClient();
            //var requestEndPoint = "https://ss1.xrea.com/shirasugohan0141.s239.xrea.com/save.php";
            var requestEndPoint = "http://shirasugohan0141.s239.xrea.com/save.php";
            var request = new HttpRequestMessage(HttpMethod.Get, requestEndPoint);
            //request.Headers.Add("Accept", "application/json");
            //request.Headers.Add("Accept-Charset", "utf-8");
            string reqBodyJson = serialize(obj);
            var content = new StringContent(reqBodyJson, Encoding.UTF8, @"application/json");
            request.Content = content;

            string resBodyStr;
            HttpStatusCode resStatusCoode = HttpStatusCode.NotFound;
            Task<HttpResponseMessage> response;
            try
            {
                response = httpClient.SendAsync(request);
                resBodyStr = response.Result.Content.ReadAsStringAsync().Result;
                resStatusCoode = response.Result.StatusCode;
            }
            catch (HttpRequestException e)
            {
                throw e;
            }

            if (!resStatusCoode.Equals(HttpStatusCode.OK))
            {
                throw new Exception();
            }
            if (string.IsNullOrEmpty(resBodyStr) || resBodyStr != "ok")
            {
                throw new Exception();
            }
        }
    }
}
