namespace TallerLayouts;

public partial class FlexPage : ContentPage
{
	public FlexPage()
	{
		InitializeComponent();
	}
    private async void OnImageTapped(object sender, EventArgs e)
    {
        // Redirige al AbsolutePage
        await Navigation.PushAsync(new AbsolutePage());
    }

}