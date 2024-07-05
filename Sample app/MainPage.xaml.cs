
namespace Sample_app
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnLoginClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            string validUsername = "Niya_George";
            string validPassword = "Pass@123";
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                if (username == validUsername && password == validPassword)
                {
                    
                    Navigation.PushAsync(new Page2());
                }
                else
                {
                    
                    DisplayAlert("Error","Invalid username or password.","OK");
                } }
            else
            {
                
                DisplayAlert("Error","Username and password are required.","OK");
            }
        }
    }
}
