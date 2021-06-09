using System;
using System.Windows.Forms;
using GestionareMagazin.EF;

namespace GestionareMagazin.Pages
{
    public partial class ModifyPersonPage : Form
    {
        private readonly ListViewItem _person;
        private readonly MainPage _home;

        public ModifyPersonPage(MainPage home, ListViewItem person)
        {
            InitializeComponent();

            _home = home;
            _person = person;
        }

        private void ModifyPersonPage_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = _person.SubItems[1].Text;
            NumberTextBox.Text = _person.SubItems[2].Text;
        }

        private async void ModifyButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new ContactsContext())
            {
                if (!int.TryParse(_person.SubItems[0].Text, out var key))
                    return;

                var person = await ctx.Persons.FindAsync(key);

                if (person == null)
                {
                    Close();
                    return;
                }

                person.Name = NameTextBox.Text;
                person.Number = NumberTextBox.Text;

                await ctx.SaveChangesAsync();
            }

            _home.ImportProductsFromDb();

            Close();
        }
    }
}
