namespace TallerLayouts;

public partial class GridPage : ContentPage
{
	public GridPage()
	{
		InitializeComponent();
	}
    private async void GoToStackLayout(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StackPage());
    }
}