using Lesson35Demo.Models;

namespace Lesson35Demo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnTapMeClicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlertAsync(
                "Confirm Action",
                "Do you want to continue?",
                "Yes",
                "No");

            // Send the result into the shared bridge
            ConfirmationBridge.Instance.PublishResult(answer);
        }
        private async void OnResetColorClicked(object sender, EventArgs e)
        {
            ColorBridge.Instance.ResetColors();
        }
    }
}
