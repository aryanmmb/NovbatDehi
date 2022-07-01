using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Media;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NovbatDehi.Class
{
    public enum BeepType
    {
        Error,
        Ok
    }

    public static class General
    {
        public static bool InternetConected()
        {
            bool result;
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                {
                    result = true;
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public static string CurentPath()
        {
            return Environment.CurrentDirectory;
        }

        public static void DeleteFile(string fileFullName)
        {
            try
            {
                if (File.Exists(fileFullName)) File.Delete(fileFullName);
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
            }
        }

        public static int RandomNumber(int min, int max)
        {
            return new Random().Next(min, max);
        }

        public static byte[] BitmapToByteArray(Bitmap bitmap)
        {
            BitmapData bmpdata = null;
            try
            {
                bmpdata = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly,
                    bitmap.PixelFormat);
                var numbytes = bmpdata.Stride * bitmap.Height;
                var bytedata = new byte[numbytes];
                var ptr = bmpdata.Scan0;
                Marshal.Copy(ptr, bytedata, 0, numbytes);
                return bytedata;
            }
            finally
            {
                if (bmpdata != null)
                    bitmap.UnlockBits(bmpdata);
            }
        }

        public static string FindDayOfWeek(DateTime dateTime)
        {
            try
            {
                var result = "شنبه";
                var dayofW = new PersianCalendar().GetDayOfWeek(dateTime);
                switch (dayofW)
                {
                    case DayOfWeek.Saturday:
                        result = "شنبه";
                        break;

                    case DayOfWeek.Sunday:
                        result = "یکشنبه";
                        break;

                    case DayOfWeek.Monday:
                        result = "دوشنبه";
                        break;

                    case DayOfWeek.Tuesday:
                        result = "سه شنبه";
                        break;

                    case DayOfWeek.Wednesday:
                        result = "چهارشنبه";
                        break;

                    case DayOfWeek.Thursday:
                        result = "پنجشنبه";
                        break;

                    case DayOfWeek.Friday:
                        result = "جمعه";
                        break;
                }

                return result;
            }
            catch
            {
                return "";
            }
        }

        public static byte[] ImageToStream(Image image)
        {
            var stream = new MemoryStream();
            try
            {
                var myimage = image;
                myimage.Save(stream, ImageFormat.Jpeg);
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
            }

            return stream.ToArray();
        }

        public static DataTable Convert_To_DataTable<T>(List<T> iList)
        {
            var dataTable = new DataTable();
            var propertyDescriptorCollection =
                TypeDescriptor.GetProperties(typeof(T));
            for (var i = 0; i < propertyDescriptorCollection.Count; i++)
            {
                var propertyDescriptor = propertyDescriptorCollection[i];
                var type = propertyDescriptor.PropertyType;
                if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                    type = Nullable.GetUnderlyingType(type);
                if (type != null)
                    dataTable.Columns.Add(propertyDescriptor.Name, type);
            }

            var values = new object[propertyDescriptorCollection.Count];
            foreach (var iListItem in iList)
            {
                for (var i = 0; i < values.Length; i++) values[i] = propertyDescriptorCollection[i].GetValue(iListItem);
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

        public static void PlayBeepSound(BeepType beepType)
        {
            try
            {
                var path = Application.StartupPath;
                var beep = beepType == BeepType.Error ? @"\Sound\Error.wav" : @"\Sound\OK.wav";
                if (File.Exists(path + beep))
                {
                    var simpleSound = new SoundPlayer(path + beep);
                    simpleSound.Play();
                }
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
            }
        }
    }

    public enum MsgBoxType
    {
        Warning,
        Error,
        Information,
        Confrim
    }

    public enum MsgBoxButtonType
    {
        Ok,
        Yesno
    }

    public static class StringExtensions
    {
        public static int ToInt(this string s)
        {
            var returnInt = 0;
            try
            {
                if (string.IsNullOrEmpty(s))
                    return 0;
                s = s.Replace(",", "");
                returnInt = int.Parse(s);
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
            }

            return returnInt;
        }

        public static double ToDouble(this string s)
        {
            double returnInt = 0;
            try
            {
                if (string.IsNullOrEmpty(s))
                    return 0;
                s = s.Replace(",", "");
                returnInt = double.Parse(s);
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
            }

            return returnInt;
        }

        public static decimal ToDecimal(this string s)
        {
            decimal returndecimal = 0;
            try
            {
                if (string.IsNullOrEmpty(s))
                    return 0;
                s = s.Replace(",", "");
                returndecimal = decimal.Parse(s);
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
            }

            return returndecimal;
        }

        public static bool ToBool(this string s)
        {
            var res = false;
            try
            {
                res = bool.Parse(s);
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
            }

            return res;
        }

        public static DateTime ToDate(this string s)
        {
            var res = DateTime.Now;
            try
            {
                res = Convert.ToDateTime(s, new CultureInfo("fa-IR"));
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
            }

            return res;
        }

        public static string ToBithDate(this string s, bool isPersianDate = false, string patern = "MM/dd")
        {
            var res = DateTime.Now;
            try
            {
                res = isPersianDate ? DateTime.Parse(s) : Convert.ToDateTime(s, new CultureInfo("fa-IR"));
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
            }

            return res.ToString(patern);
        }

        public static object ToStringDot(this string s)
        {
            var returnstr = "...";
            try
            {
                if (string.IsNullOrEmpty(s))
                    return returnstr;
                returnstr = s;
            }
            catch (Exception exception)
            {
                Console.Write(exception.Message);
            }

            return returnstr;
        }
    }
}