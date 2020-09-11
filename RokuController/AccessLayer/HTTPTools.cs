using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RokuAccess
{
    public class HTTPTools
    {
        public static string Get(string uri)
        {
            var result = "";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public static async Task<string> GetAsync(string uri)
        {
            var result = "";
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(uri);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                using (var response = (HttpWebResponse)await request.GetResponseAsync())
                using (var stream = response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    result = await reader.ReadToEndAsync();
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public static string Post(string uri, string data = "", string contentType = null, string method = "POST")
        {
            var result = "";
            try
            {
                byte[] dataBytes = Encoding.UTF8.GetBytes(data);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                request.ContentLength = dataBytes.Length;
                request.ContentType = contentType;
                request.Method = method;

                using (Stream requestBody = request.GetRequestStream())
                {
                    requestBody.Write(dataBytes, 0, dataBytes.Length);
                }

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public static async Task<string> PostAsync(string uri, string data = "", string contentType = null, string method = "POST")
        {
            var result = "";
            try
            {
                byte[] dataBytes = Encoding.UTF8.GetBytes(data);

                var request = (HttpWebRequest)WebRequest.Create(uri);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                request.ContentLength = dataBytes.Length;
                request.ContentType = contentType;
                request.Method = method;

                using (var requestBody = request.GetRequestStream())
                {
                    await requestBody.WriteAsync(dataBytes, 0, dataBytes.Length);
                }

                using (var response = (HttpWebResponse)await request.GetResponseAsync())
                using (var stream = response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    result = await reader.ReadToEndAsync();
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}
