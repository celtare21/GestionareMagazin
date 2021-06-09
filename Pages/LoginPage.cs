using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionareMagazin.EF;

namespace GestionareMagazin.Pages
{
    public partial class LoginPage : Form
    {
        public LoginPage() =>
            InitializeComponent();

        private async void LoginButton_Click(object sender, System.EventArgs e)
        {
            if (!AreFieldValid())
                return;

            if (!await AccountExists())
                return;

            Hide();
            new MainPage().Show();
        }

        private bool AreFieldValid()
        {
            LoginButton.Enabled = false;

            try
            {
                if (!string.IsNullOrWhiteSpace(UsernameText.Text) && !string.IsNullOrWhiteSpace(PasswordBox.Text))
                    return true;

                MessageBox.Show(@"Input your username and password!");
                return false;
            }
            finally
            {
                LoginButton.Enabled = true;
            }
        }

        private async Task<bool> AccountExists()
        {
            LoginButton.Enabled = false;

            try
            {
                using (var ctx = new ContactsContext())
                {
                    if (await ctx.Users.AnyAsync(user =>
                        user.Name == UsernameText.Text && user.Password == PasswordBox.Text))
                        return true;

                    MessageBox.Show(@"User not found!");
                    return false;
                }
            }
            finally
            {
                LoginButton.Enabled = true;
            }
        }
    }
}
