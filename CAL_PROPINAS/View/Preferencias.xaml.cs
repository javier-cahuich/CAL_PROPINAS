namespace CAL_PROPINAS.View;

public partial class Preferencias : ContentPage
{
	public Preferencias()
	{
		InitializeComponent();
	}
	private void OnCounterClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new PagePreferences());
	}
}