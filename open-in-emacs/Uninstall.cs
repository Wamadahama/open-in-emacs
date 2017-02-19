using Microsoft.Win32;
using System.Diagnostics;
using System;

namespace open_in_emacs
{
    class Uninstall
    {
        static void Main()
        {
            FileShellExtension.UnRegister("*", "OpenInEmacs");
        }
    }
}
