﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace CyberCAT.Forms
{
    // https://stackoverflow.com/a/3795159
    public static class KnownFolderPathHelper
    {
        public static Guid SavedGames = new Guid("{4C5C32FF-BB9D-43B0-B5B4-2D72E54EAAA4}");

        public static string GetSavedGamesPath()
        {
            if (Environment.OSVersion.Version.Major < 6) throw new NotSupportedException();
            IntPtr pathPtr = IntPtr.Zero;
            try
            {
                SHGetKnownFolderPath(ref SavedGames, 0, IntPtr.Zero, out pathPtr);
                return Marshal.PtrToStringUni(pathPtr);
            }
            finally
            {
                Marshal.FreeCoTaskMem(pathPtr);
            }
        }

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        private static extern int SHGetKnownFolderPath(ref Guid id, int flags, IntPtr token, out IntPtr path);
    }
}
