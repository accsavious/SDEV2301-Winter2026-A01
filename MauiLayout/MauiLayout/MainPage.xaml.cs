using MauiLayout.Models;

namespace MauiLayout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnClicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlertAsync(
                "Confirm Action",
                "Do you want to continue?",
                "Yes",
                "No");

            ConfirmationBridge.Instance.PublishResult(answer);
        }
    }
}
