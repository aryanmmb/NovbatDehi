﻿using System.Runtime.InteropServices;
using System.Text;

namespace NovbatDehi.Class
{
    public class IniFile
    {
        public string Path;

        public IniFile(string path)
        {
            Path = path;
        }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
            string key, string def, StringBuilder retVal,
            int size, string filePath);

        public void IniWriteValue(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, this.Path);
        }

        public string IniReadValue(string section, string key)
        {
            var temp = new StringBuilder(255);
            GetPrivateProfileString(section, key, "", temp, 255, this.Path);
            return temp.ToString();
        }
    }
}