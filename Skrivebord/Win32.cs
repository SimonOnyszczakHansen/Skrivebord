using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;

namespace Skrivebord
{
    internal sealed class Win32
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int FuWinIni);
    }
}
