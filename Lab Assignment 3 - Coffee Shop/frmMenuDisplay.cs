using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//problem 
// need to create more filters
//my combo box cobCategory will filter the list view but makes our selectitem in the listview unusable because we can select anything anymore there our picturebox, short description, long description are worthless


namespace Lab_Assignment_3___Coffee_Shop
{
    public partial class frmMenuDisplay : Form
    {
        string sourceDir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        List<Food> displayMenu = new List<Food>();
        public frmMenuDisplay()
        {
            InitializeComponent();
        }
        private void LoadItemsFromFile()
        {
            try
            {
                //read the information from the textfile1
                string[] lines = File.ReadAllLines(Path.Combine(sourceDir, "TextFile1.txt"));
                //extract field and trim (remove extra spaces) and populate hte list view
                //trim() is from the string lecture slide
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    Food foodItem = new Food()
                    {
                        Category = (foodCategory)Enum.Parse(typeof(foodCategory), parts[0].Trim()),
                        Cost = double.Parse(parts[1].Trim()),
                        Price = double.Parse(parts[2].Trim()),
                        ShortDescription = parts[3].Trim(),
                        LongDescription = parts[4].Trim(),
                        Image = parts[5].Trim()
                    };

                    displayMenu.Add(foodItem);

                    ListViewItem item = new ListViewItem(foodItem.ShortDescription);
                    item.SubItems.Add(foodItem.Price.ToString());
                    item.SubItems.Add(foodItem.Cost.ToString());
                    item.SubItems.Add(foodItem.Category.ToString());
                    ltvMenu.Items.Add(item);
                }
            }//catch if cant find the text file and show message box 
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items: " + ex.Message);
            }
        }

        //user selected a row/item in the listview and it display the short & long description, cost, price in labels and image in picture box for that item
        private void ltvMenuDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltvMenu.SelectedItems.Count > 0)
            {
                int selectedIndex = ltvMenu.SelectedItems[0].Index;

                if (selectedIndex >= 0 && selectedIndex < displayMenu.Count)
                {
                    Food selectedFood = displayMenu[selectedIndex];
                    lblShortDescription.Text = selectedFood.ShortDescription;
                    lblPriceDisplay.Text = "$" + selectedFood.Price.ToString();
                    lblCostDisplay.Text = "$" + selectedFood.Cost.ToString();
                    lblLongDescription.Text = selectedFood.LongDescription;
                    try
                    {
                        //lecute slide (windows forms, simple contrpls and events)
                        //"SizeMode property defines how the image appears (is scaled) inside of the PictureBox"
                        pbxImage.SizeMode = PictureBoxSizeMode.Zoom;
                        pbxImage.Load(selectedFood.Image);
                    }
                    catch
                    {
                        pbxImage.SizeMode = PictureBoxSizeMode.Zoom;
                        pbxImage.Load("https://cdn.dribbble.com/users/1012566/screenshots/4187820/media/985748436085f06bb2bd63686ff491a5.jpg");
                    }
                }
            }
        }

        private void frmMenuDisplay_Load(object sender, EventArgs e)
        {
            //automatic populate the list  columns 
            ltvMenu.View = View.Details;
            ltvMenu.Columns.Add("Item", 100);
            ltvMenu.Columns.Add("Price", 50);
            ltvMenu.Columns.Add("Cost", 50);
            ltvMenu.Columns.Add("Category", 75);

            //autommatic populate the combox box selection
            cobCategories.Items.Add("coffee");
            cobCategories.Items.Add("others");
            cobCategories.Items.Add("pastry");
            cobCategories.Items.Add("seasonal");
            cobCategories.Items.Add("smoothies");
            cobCategories.Items.Add("snacks");
            cobCategories.Items.Add("tea");
            //autommatic load the textfile1
            LoadItemsFromFile();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmCustomerOrder customerOrderForm = new frmCustomerOrder();
            customerOrderForm.ShowDialog();
        }

        private void lblLongDescription_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        //filters the list view to display only items of the selected category
        private void FilterListView()
        {
            //remove all the items in the listview
            ltvMenu.Items.Clear();

            string selectedCategory = cobCategories.SelectedItem.ToString();

            List<Food> filteredFoods = new List<Food>();
            foreach (Food food in displayMenu)
            {
                //stringcomparison (string lecture slide)
                if (food.Category.ToString().Equals(selectedCategory, StringComparison.OrdinalIgnoreCase))
                {
                    filteredFoods.Add(food);
                }
            }
            
            foreach (Food foodItem in filteredFoods)
            {
                ListViewItem item = new ListViewItem(foodItem.ShortDescription);
                item.SubItems.Add(foodItem.Price.ToString());
                item.SubItems.Add(foodItem.Cost.ToString());
                item.SubItems.Add(foodItem.Category.ToString());
                ltvMenu.Items.Add(item);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // if the button of filter is click after a category is selected, it called this method
            FilterListView();
        }
    }
}