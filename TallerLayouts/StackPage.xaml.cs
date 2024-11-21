namespace TallerLayouts;

public partial class StackPage : ContentPage
{
	public StackPage()
	{
		InitializeComponent();
	}
    private async void GoToFlexLayout(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FlexPage());
    }
}