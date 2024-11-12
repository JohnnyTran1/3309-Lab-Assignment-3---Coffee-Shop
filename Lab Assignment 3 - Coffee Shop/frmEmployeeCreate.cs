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
// when create new items over time, it will create duplicates
namespace Lab_Assignment_3___Coffee_Shop
{
    public partial class frmEmployeeCreate : Form
    {
        //internal the Food class and list to give access to the other forms
        //global
        internal Food food;
        //new list that contains all items
        List<Food> menu = new List<Food>();
        string sourceDir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        public frmEmployeeCreate()
        {
            InitializeComponent();
        }

        private void EmployeeCreate_Load(object sednder, EventArgs e)
        {
            //populate the combo box
            cobCategories.Items.Add(foodCategory.coffee);
            cobCategories.Items.Add(foodCategory.others);
            cobCategories.Items.Add(foodCategory.pastry);
            cobCategories.Items.Add(foodCategory.seasonal);
            cobCategories.Items.Add(foodCategory.smoothies);
            cobCategories.Items.Add(foodCategory.snacks);
            cobCategories.Items.Add(foodCategory.tea);

            //populate the listview create items
            ltvItemTable.View = View.Details;
            ltvItemTable.Columns.Add("Category", 55);
            ltvItemTable.Columns.Add("Cost", 35);
            ltvItemTable.Columns.Add("Price", 40);
            ltvItemTable.Columns.Add("Short Description", 95);
            ltvItemTable.Columns.Add("Long Description", 95);

        }
        //clear all the textboxes and combo box
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCostItem.Text = "";
            txtImageItem.Text = "";
            txtLongDescription.Text = "";
            txtRetailPrice.Text = "";
            txtShortDescription.Text = "";

            cobCategories.SelectedIndex = -1;

            lblError.Text = "";
            lblError.Visible = false;
        }

        private void lblLongDescription_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //modal form
            //open the frmmenudisplay
            frmMenuDisplay menuDisplayForm = new frmMenuDisplay();
            menuDisplayForm.ShowDialog();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            //new food instance of the Food class
            Food food = new Food();

            if (CreateFood(food))
            {
                menu.Add(food);

                //Display the item's fields on the form list view
                ListViewItem item = new ListViewItem(food.Category.ToString());
                item.SubItems.Add(food.Cost.ToString());
                item.SubItems.Add(food.Price.ToString());
                item.SubItems.Add(food.ShortDescription);
                item.SubItems.Add(food.LongDescription);
                ltvItemTable.Items.Add(item);

                //find the textfile
                try
                {
                    //lab 4 demo reference textfile and loading it
                    FileStream file = new FileStream(Path.Combine(sourceDir, "TextFile1.txt"),FileMode.OpenOrCreate);

                    StreamWriter writer = new StreamWriter(file);

                    if(File.Exists(Path.Combine(sourceDir, "TextFile1.txt")))
                    {
                        file.Seek(0, SeekOrigin.End);

                        foreach (Food fooditem in menu)
                        {
                            writer.WriteLine(fooditem.Category.ToString() + ", " + fooditem.Cost.ToString() + ", " + fooditem.Price.ToString() + ", " + fooditem.ShortDescription.ToString() + ", " + fooditem.LongDescription.ToString() + ", " + fooditem.Image.ToString());
                        }
                        writer.Close();
                    }

                    else
                    {
                        foreach (Food fooditem in menu)
                        {
                            writer.WriteLine(fooditem.ToString());
                        }
                        writer.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Successfully added food to menu!");
            }
        }

        private bool CreateFood(Food currentFood)
        {
            try
            {
                switch (cobCategories.SelectedIndex)
                //switch case for the caategory for the selected
                //lecture - control structures powerpoint lecture
                {
                    case 0:
                        currentFood.Category = foodCategory.coffee;
                        break;
                    case 1:
                        currentFood.Category = foodCategory.others;
                        break;
                    case 2:
                        currentFood.Category = foodCategory.pastry;
                        break;
                    case 3:
                        currentFood.Category = foodCategory.seasonal;
                        break;
                    case 4:
                        currentFood.Category = foodCategory.smoothies;
                        break;
                    case 5:
                        currentFood.Category = foodCategory.snacks;
                        break;
                    case 6:
                        currentFood.Category = foodCategory.tea;
                        break;
                    default:
                        lblError.Text = "Please enter a category for item!";
                        lblError.Visible = true;
                        return false;
                }

                currentFood.Image = txtImageItem.Text.ToString();

                //cant create an item without cost being null or blank
                //keyword isnullorwhitespace
                //https://learn.microsoft.com/en-us/dotnet/api/system.string.isnullorwhitespace?view=net-7.0
                if (string.IsNullOrWhiteSpace(txtCostItem.Text))
                {
                    lblError.Text = "Please enter a number for cost!";
                    lblError.Visible = true;
                    return false;
                }

                //validated if the cost is a postive number
                double parsedCost;
                if (!Double.TryParse(txtCostItem.Text, out parsedCost))
                {
                    lblError.Text = "Please enter a postive number for cost!";
                    lblError.Visible = true;
                    return false;
                }
                currentFood.Cost = parsedCost;

                //cant create an item without price being null or blank
                if (string.IsNullOrWhiteSpace(txtRetailPrice.Text))
                {
                    lblError.Text = "Please enter a number for price!";
                    lblError.Visible = true;
                    return false;
                }

                //validated if the price is a postive number
                double parsedPrice;
                if (!Double.TryParse(txtRetailPrice.Text, out parsedPrice))
                {
                    lblError.Text = "Please enter a postive number for price!";
                    lblError.Visible = true;
                    return false;
                }
                currentFood.Price = parsedPrice;

                //cant create an item without short description being null or blank
                if (string.IsNullOrWhiteSpace(txtShortDescription.Text))
                {
                    lblError.Text = "Please enter a short description for item!";
                    lblError.Visible = true;
                    return false;
                }
                currentFood.ShortDescription = txtShortDescription.Text.ToString();

                //cant create an item without long description being null or blank
                if (string.IsNullOrWhiteSpace(txtLongDescription.Text))
                {
                    lblError.Text = "Please enter a long description for item!";
                    lblError.Visible = true;
                    return false;
                }
                currentFood.LongDescription = txtLongDescription.Text.ToString();
                
                return true;
            }
            catch (FormatException)
            {
                lblError.Text = "Incomplete field(s)!";
                lblError.Visible = true;
                return false;
            }
        }

        //when the user/employee select an item on the list view
        //selected item will have their image load into a control (picturebox)
        private void ltvItemTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltvItemTable.SelectedItems.Count > 0)
            {
                int selectedIndex = ltvItemTable.SelectedItems[0].Index;

                if (selectedIndex >= 0 && selectedIndex < menu.Count)
                {
                    Food selectedFood = menu[selectedIndex];

                    //sometimes, the employee image address wont load the image on form and it will causes a crash
                    //so a try catch will occured and will catch it with a default image
                    try
                    {
                        //lecture - windows forms, simple controls, and events lecture slide
                        //Size mode is a propery that "defines how the image appears (is scaled) inside of the picturebox"
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
