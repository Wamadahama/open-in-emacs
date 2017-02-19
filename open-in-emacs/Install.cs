using Microsoft.Win32;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace open_in_emacs
{
    class Install
    {
        static void Main(string[] args) {
            string Command = string.Format("\"C:\\Program Files\\emacs\\bin\\runemacs.exe\" \"%1\"");
            FileShellExtension.Register("*", "OpenInEmacs", "Open in Emacs", Command);
        }

    }
}
