using System;
using System.Collections.Generic;
using System.Text;

namespace MauiLayout.Models
{
    internal class ColorBridge
    {
        public static ColorBridge Instance { get; }
            = new ColorBridge();

        public event Action? ColorChanged;

        public void ResetColors()
        {
            ColorChanged?.Invoke();
        }
    }
}
