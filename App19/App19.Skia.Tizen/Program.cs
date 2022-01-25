﻿using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace App19.Skia.Tizen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new App19.App(), args);
            host.Run();
        }
    }
}
