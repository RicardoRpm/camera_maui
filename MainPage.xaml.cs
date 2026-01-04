using camera_maui.Views;

namespace camera_maui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void CallCamera_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CameraView());
        }
    }
}
