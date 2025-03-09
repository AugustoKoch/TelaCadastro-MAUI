namespace MeuPrimeiroAppMaui;

public partial class Cadastro : ContentPage
{
	public Cadastro()
	{
		InitializeComponent();
	}

    private void Cadastrar_Clicked(object sender, EventArgs e)
    {
		var nome = NomeCompleto.Text;

        DisplayAlert("Cadastro", String.Format("Usuário {0}, foi cadastrado com sucesso!", nome), "OK");
    }
}