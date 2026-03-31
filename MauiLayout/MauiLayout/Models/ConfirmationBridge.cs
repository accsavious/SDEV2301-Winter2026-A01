using System;
using System.Collections.Generic;
using System.Text;

namespace MauiLayout.Models
{
    internal class ConfirmationBridge
    {
        public static ConfirmationBridge Instance { get; }
            = new ConfirmationBridge();

        public event Action<bool> ConfirmationChanged;

        public void PublishResult(bool result) {
            ConfirmationChanged?.Invoke(result);
        }
    }
}
