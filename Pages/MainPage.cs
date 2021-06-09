using System;
using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionareMagazin.EF;

namespace GestionareMagazin.Pages
{
    public partial class MainPage : Form
    {
        private SynchronizationContext _synchronizationContext;

        public MainPage() =>
            InitializeComponent();

        private void MainPage_Load(object sender, EventArgs e)
        {
            _synchronizationContext = SynchronizationContext.Current;

            InitializeListView();

            ImportProductsFromDb();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            new AddNewItemDialog().ShowDialog();

            ImportProductsFromDb();
        }

        private async void RemoveItemButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new ContactsContext())
            {
                foreach (ListViewItem item in ProductsList.CheckedItems)
                {
                    if (!int.TryParse(item.SubItems[0].Text, out int id))
                        return;

                    var product = await ctx.Persons.FindAsync(id);

                    if (product == null)
                        return;

                    ctx.Persons.Remove(product);

                    await ctx.SaveChangesAsync();
                }
            }

            ImportProductsFromDb();
        }

        private void ModifyPersonButton_Click(object sender, EventArgs e)
        {
            if (ProductsList.CheckedItems.Count > 1)
            {
                MessageBox.Show(@"Please select a single person at a time to modify!");
                return;
            }

            new ModifyPersonPage(this, ProductsList.CheckedItems[0]).ShowDialog();
        }

        private void ProductsList_ItemChecked(object sender, ItemCheckedEventArgs e) =>
            RemoveItemButton.Enabled = ModifyPersonButton.Enabled = ProductsList.CheckedItems.Count > 0;

        private void InitializeListView()
        {
            ProductsList.View = View.Details;
            ProductsList.Columns.Add("Id", 50);
            ProductsList.Columns.Add("Name", 200);
            ProductsList.Columns.Add("Number", 200);
        }

        public void ImportProductsFromDb()
        {
            Task.Run(async () =>
            {
                _synchronizationContext.Post(_ => ProductsList.Items.Clear(), null);

                using (var ctx = new ContactsContext())
                {
                    var allProducts = await ctx.Persons.ToArrayAsync();

                    foreach (var product in allProducts)
                    {
                        var item = new ListViewItem { Text = product.Id.ToString() };

                        item.SubItems.Add(product.Name);
                        item.SubItems.Add(product.Number);

                        _synchronizationContext.Post(_ => ProductsList.Items.Add(item), null);
                    }
                }
            });
        }
    }
}
