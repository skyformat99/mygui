﻿using System;
using System.Runtime.InteropServices;

namespace MyGUI.Sharp
{
    public class PointerManager
    {

        #region Instance

        private static PointerManager mInstance = new PointerManager();

        public static PointerManager Instance
        {
            get { return mInstance; }
        }

        #endregion

        #region Visible

        [DllImport("MyGUI_Export", CallingConvention = CallingConvention.StdCall)]
        private static extern void ExportPointerManager_SetVisible([MarshalAs(UnmanagedType.U1)]bool _value);
        [DllImport("MyGUI_Export", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ExportPointerManager_GetVisible();

        public bool Visible
        {
            get { return ExportPointerManager_GetVisible(); }
            set { ExportPointerManager_SetVisible(value); }
        }

        #endregion

    }
}
