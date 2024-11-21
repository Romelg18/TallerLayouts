namespace TallerLayouts;

public partial class AbsolutePage : ContentPage
{
	public AbsolutePage()
	{
		InitializeComponent();
	}
    private async void GoToGridLayout(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GridPage());
    }

}