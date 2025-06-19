﻿using System;
using Tomori.Framework;
using Tomori.Framework.Platform;

namespace SampleApp.Desktop;

internal class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        using (AppHost host = new DesktopAppHost("sample-app"))
        using (App app = new SampleApp())
            host.Run(app);
    }
}
