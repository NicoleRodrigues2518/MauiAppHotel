namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}
    private async void btSobre_Clicked(object sender, EventArgs e)
	{
    await Navigation.PushAsync(new Sobre());
    }
}