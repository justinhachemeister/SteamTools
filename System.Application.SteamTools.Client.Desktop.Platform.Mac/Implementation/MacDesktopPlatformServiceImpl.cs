﻿using System.Diagnostics;

namespace System.Application.Services.Implementation
{
    internal sealed class MacDesktopPlatformServiceImpl : IDesktopPlatformService
    {
        public void SetResizeMode(IntPtr hWnd, int value)
        {
        }

        public string GetCommandLineArgs(Process process)
        {
            return string.Empty;
        }
    }
}