using Microsoft.Win32;
using System.Diagnostics;
using System;

namespace open_in_emacs
{
    public static class FileShellExtension
    {
        public static void Register(string FileType, string ShellKeyName, string ContextMenuText, string ContextMenuCommand)
        {
            string RegistryPath = String.Format(@"{0}\shell\{1}", FileType, ShellKeyName);

            using (RegistryKey Key = Registry.ClassesRoot.CreateSubKey(RegistryPath))
            {
                Key.SetValue(null, ContextMenuText);
            }

            using (RegistryKey Key = Registry.ClassesRoot.CreateSubKey(string.Format(@"{0}\command", RegistryPath)))
            {
                Key.SetValue(null, ContextMenuCommand);
            }
        }


        public static void UnRegister(string FileType, string ShellKeyName)
        {
            Debug.Assert(!string.IsNullOrEmpty(FileType) && (!string.IsNullOrEmpty(ShellKeyName)));
            string RegPath = string.Format(@"{0}\shell\{1}", FileType, ShellKeyName);
            Registry.ClassesRoot.DeleteSubKeyTree(RegPath);
        }
    }
}
