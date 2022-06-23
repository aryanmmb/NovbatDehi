using System;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Serialization.Json;


namespace BarcodeScaner_V2.Class
{
    public static class WebHelper
    {
        public static async Task<bool> SendFile(string fileName, string username, string uploadlink)
        {
            try
            {
                using (var fileStream = File.Open(fileName, FileMode.Open))
                {
                    var client = new RestClient(uploadlink);
                    var request = new RestRequest(Method.POST);
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        await fileStream.CopyToAsync(memoryStream);
                        request.AddFile("file", memoryStream.ToArray(), fileName);
                        request.AddParameter("user", username);
                        request.AlwaysMultipartFormData = true;
                        var response = await client.ExecuteAsync(request);
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            //Logger.AddLog(
                            //    "WebHelper.SendFile file:" + fileName + " sended to server Success:" + uploadlink +
                            //    " user Id:" + username, LogType.Success);
                            return true;
                        }
                        //Logger.AddLog(
                        //    "WebHelper.SendFile file:" + fileName + " sended to server Fail:" + uploadlink +
                        //    " user Id:" + username, LogType.Success);
                    }
                }
                return false;
            }
            catch (Exception exception)
            {
                //Logger.AddLog(
                //    "error WebHelper.SendFile file:" + fileName + " sended to server:" + uploadlink +
                //    " user Id:" + username + " Error Message:" + exception.Message, LogType.Error);
                return false;
            }
        }
        /// <summary>
        /// تابع دانلود فایل های آپدیت از سرور
        /// </summary>
        /// <param name="path">مسیر برای کپی فایل های دانلود شده</param>
        /// <param name="username">نام کاربری برای ارسال به سرور</param>
        /// <param name="downloadlink">لینک سرویس دهنده </param>
        /// <param name="accessToken">رمز توکین</param>
        /// <returns>مقدار برگشتی اگر صحیح باشد یعنی یک فایل دانلود شده اگر نباشد یعنی آپدیتی موجود نیست </returns>
        public static async Task<bool> DownloadFile(string path, string username, string downloadlink, string accessToken = "")
        {
            RestClient client = new RestClient(downloadlink);
            client.ClearHandlers();
            client.AddHandler("*", () => { return new JsonDeserializer(); });
            RestRequest request = new RestRequest(Method.GET);
            ///برای اعتبار سنجی در آینده
            request.AddParameter("userid", username);
            // request.AddParameter("Authorization", string.Format("Bearer " + accessToken),
            //ParameterType.HttpHeader);
            IRestResponse response = await client.ExecuteTaskAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // خواندن بایت های فایل از وبسرویس
                byte[] fileBytes = response.RawBytes;
                var headervalue = response.Headers.FirstOrDefault(x => x.Name == "Content-Disposition")?.Value;
                string contentDispositionString = Convert.ToString(headervalue);
                ContentDisposition contentDisposition = new ContentDisposition(contentDispositionString);
                string fileName = contentDisposition.FileName;
                string extention = Path.GetExtension(fileName);
                //ساخت فایل در مسیر که به تابع پاس داده میشود و نام گزاری بر اساس تاریخ و ساعت جاری سیستم
                File.WriteAllBytes(path + "\\Update" + DateTime.Now.ToString("yyyMMdd_hhmmss") + extention, fileBytes);
                return true;
            }
            return false;
        }
    }
}
