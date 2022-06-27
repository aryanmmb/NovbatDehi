using BarcodeScaner_V2;
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
using BarcodeScaner_V2.Class;

public enum BeepType { Error, Ok }
public static class General
{
    public static string IniSetingFilename = "setting.ini";
    public static bool InternetConected()
    {
        bool result;
        try
        {
            using (var client = new WebClient())
            using (client.OpenRead("http://google.com/generate_204"))
                result = true;
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
            if (File.Exists(fileFullName))
            {
                File.Delete(fileFullName);
                //Logger.AddLog(" DeleteFile Filename:" + fileFullName + "   Time:" + DateTime.Now, LogType.Success);
            }
        }
        catch (Exception exception)
        {
            //Logger.AddLog("Error DeleteFile Filename:" + fileFullName + " exception:" + exception.Message + "   Time:" + DateTime.Now, LogType.Error);
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
            bmpdata = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, bitmap.PixelFormat);
            int numbytes = bmpdata.Stride * bitmap.Height;
            byte[] bytedata = new byte[numbytes];
            IntPtr ptr = bmpdata.Scan0;
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
            string result = "شنبه";
            var DayofW = new PersianCalendar().GetDayOfWeek(dateTime);
            switch (DayofW)
            {
                case DayOfWeek.Saturday: result = "شنبه"; break;
                case DayOfWeek.Sunday: result = "یکشنبه"; break;
                case DayOfWeek.Monday: result = "دوشنبه"; break;
                case DayOfWeek.Tuesday: result = "سه شنبه"; break;
                case DayOfWeek.Wednesday: result = "چهارشنبه"; break;
                case DayOfWeek.Thursday: result = "پنجشنبه"; break;
                case DayOfWeek.Friday: result = "جمعه"; break;
            }
            return result;
        }
        catch
        {
            return "";
        }
    }
    public static byte[] ImageToStream(Image _image)
    {
        MemoryStream stream = new MemoryStream();
        try
        {
            Image image = _image;
            image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
        catch
        {
        }
        return stream.ToArray();
    }
    public static DataTable Convert_To_DataTable<T>(List<T> iList)
    {
        DataTable dataTable = new DataTable();
        PropertyDescriptorCollection propertyDescriptorCollection =
            TypeDescriptor.GetProperties(typeof(T));
        for (int i = 0; i < propertyDescriptorCollection.Count; i++)
        {
            PropertyDescriptor propertyDescriptor = propertyDescriptorCollection[i];
            Type type = propertyDescriptor.PropertyType;
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                type = Nullable.GetUnderlyingType(type);
            dataTable.Columns.Add(propertyDescriptor.Name, type);
        }
        object[] values = new object[propertyDescriptorCollection.Count];
        foreach (T iListItem in iList)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = propertyDescriptorCollection[i].GetValue(iListItem);
            }
            dataTable.Rows.Add(values);
        }
        return dataTable;
    }
    public static void playBeepSound(BeepType beepType)
    {
        try
        {
            string path = Application.StartupPath;
            string beep = (beepType == BeepType.Error ? @"\Sound\Error.wav" : @"\Sound\OK.wav");
            if (File.Exists(path + beep))
            {
                SoundPlayer simpleSound = new SoundPlayer(path + beep);
                simpleSound.Play();
            }
        }
        catch
        {
        }
    }
}
public enum MsgBoxType
{
    Warning, Error, Information, Confrim
}
public enum MsgBoxButtonType
{
    OK, YESNO
}

public static class StringExtensions
{
    public static Int32 ToInt(this string s)
    {
        Int32 returnInt = 0;
        try
        {
            if (s == null || s == "")
                return 0;
            s = s.Replace(",", "");
            returnInt = Int32.Parse(s);
        }
        catch
        {
            //Nothing
        }
        return returnInt;
    }
    public static double ToDouble(this string s)
    {
        double returnInt = 0;
        try
        {
            if (s == null || s == "")
                return 0;
            s = s.Replace(",", "");
            returnInt = double.Parse(s);
        }
        catch
        {
            //Nothing
        }
        return returnInt;
    }
    public static decimal ToDecimal(this string s)
    {
        decimal returndecimal = 0;
        try
        {
            if (s == null || s == "")
                return 0;
            s = s.Replace(",", "");
            returndecimal = decimal.Parse(s);
        }
        catch
        {
            //Nothing
        }
        return returndecimal;
    }
    public static bool ToBool(this string s)
    {
        bool res = false;
        try
        {
            res = bool.Parse(s);
        }
        catch
        {
            //Nothing
        }
        return res;
    }
    //public static DateTime ToDate(  string s)
    //{
    //    DateTime res = DateTime.Now;
    //    try
    //    {
    //        res = DateTime.Parse(s);
    //    }
    //    catch
    //    {
    //        //Nothing
    //    }
    //    return res;
    //}
    public static DateTime ToDate(this string s)
    {
        DateTime res = DateTime.Now;
        try
        {
            res = Convert.ToDateTime(s, new CultureInfo("fa-IR"));
        }
        catch
        {
            //Nothing
        }
        return res;
    }
    public static string ToBithDate(this string s, bool IsPersianDate = false, string Patern = "MM/dd")
    {
        DateTime res = DateTime.Now;
        try
        {
            res = IsPersianDate ? DateTime.Parse(s) : Convert.ToDateTime(s, new CultureInfo("fa-IR"));
        }
        catch
        {
            //Nothing
        }
        return res.ToString(Patern);
    }

    public static object ToStringDot(this string s)
    {
        string returnstr = "...";
        try
        {
            if (s == null || s == "")
                return returnstr;
            returnstr = s.ToString();
        }
        catch
        {
            //Nothing
        }
        return returnstr;
    }
}