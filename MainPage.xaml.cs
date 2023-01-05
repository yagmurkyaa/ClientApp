

namespace ClientApp;

public partial class MainPage : ContentPage
{
    List<Client> Clients = new List<Client>();

    public MainPage()
    {
        InitializeComponent();
    }
    private void Add_Button_Clicked(object sender, EventArgs e)
    {

        Clients.Add(new Client(C_Name.Text, C_L_Name.Text, C_Tel.Text, C_Address.Text));

    }


    private void Show_Button_Clicked(object sender, EventArgs e)
    {
        List_View.ItemsSource = null;
        List_View.ItemsSource = Clients;
    }

}
