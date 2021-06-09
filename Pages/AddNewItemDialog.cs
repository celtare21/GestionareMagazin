using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionareMagazin.EF;

namespace GestionareMagazin.Pages
{
    public partial class AddNewItemDialog : Form
    {
        public AddNewItemDialog() =>
            InitializeComponent();

        private async void AddButton_Click(object sender, EventArgs e)
        {
            if (!CheckAllFields())
                return;

            await AddNewItemToDb().ConfigureAwait(false);
        }

        private bool CheckAllFields()
        {
            if (!string.IsNullOrWhiteSpace(NameBox.Text) &&
                !string.IsNullOrWhiteSpace(NumberBox.Text))
                return true;

            MessageBox.Show(@"Input all the fields!");

            return false;
        }

        private async Task AddNewItemToDb()
        {
            using (var ctx = new ContactsContext())
            {
                var item = new Person {Name = NameBox.Text, Number = NumberBox.Text};

                ctx.Persons.Add(item);
                await ctx.SaveChangesAsync();
            }

            Close();
        }
    }
}
