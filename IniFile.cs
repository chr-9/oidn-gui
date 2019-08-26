using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace OIDN
{
    public class IniFile
    {
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(
        string lpApplicationName,
        string lpKeyName,
        string lpDefault,
        StringBuilder lpReturnedstring,
        int nSize,
        string lpFileName);

        [DllImport("kernel32.dll")]
        private static extern int WritePrivateProfileString(
        string lpApplicationName,
        string lpKeyName,
        string lpstring,
        string lpFileName);

        string filePath;

        public IniFile(string filePath)
        {
            this.filePath = filePath;
        }

        public string this[string section, string key]
        {
            set
            {
                WritePrivateProfileString(section, key, value, filePath);
            }
            get
            {
                StringBuilder sb = new StringBuilder(256);
                GetPrivateProfileString(section, key, string.Empty, sb, sb.Capacity, filePath);
                return sb.ToString();
            }
        }

        public string GetValue(string section, string key, string defaultvalue)
        {
            StringBuilder sb = new StringBuilder(256);
            GetPrivateProfileString(section, key, defaultvalue, sb, sb.Capacity, filePath);
            return sb.ToString();
        }
    }
}