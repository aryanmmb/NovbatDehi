using NovbatDehi.Class;
using System;
using System.IO;

namespace BarcodeScaner_V2.Class
{
    public static class IniWork
    {
        public static string ReadData(string filename, string section, string keyname)
        {
            try
            {
                var basePath = Environment.CurrentDirectory;
                if (!Directory.Exists(basePath)) Directory.CreateDirectory(basePath);

                var ini = new IniFile(basePath + "\\" + filename);
                var keyValue = ini.IniReadValue(section, keyname);
                return keyValue;
            }
            catch
            {
                return "";
            }
        }

        public static bool WriteData(string filename, string section, string keyname, string value)
        {
            try
            {
                var basePath = Environment.CurrentDirectory;
                if (!Directory.Exists(basePath)) Directory.CreateDirectory(basePath);
                var ini = new IniFile(basePath + "\\" + filename);
                ini.IniWriteValue(section, keyname, value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        internal static void ReadData(object iniSetingFilename, string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}