

using CommunityToolkit.Maui.Core;

namespace camera_maui.Views;

public partial class CameraView : ContentPage
{
	public CameraView()
	{
		InitializeComponent();
	}

    private void cameraView_MediaCaptured(object sender, CommunityToolkit.Maui.Core.MediaCapturedEventArgs e)
    {

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var resultImage = await cameraView.CaptureImage(CancellationToken.None);


    }

    private void cameraView_Loaded(object sender, EventArgs e)
    {
        
    }
}