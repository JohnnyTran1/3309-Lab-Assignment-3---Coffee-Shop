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

namespace Lab_Assignment_3___Coffee_Shop
{
    public partial class frmCustomerOrder : Form
    {
        //global 
        Customer customer;
        Food food;
        Order order;
        string sourceDir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        List<Food> loadedItems = new List<Food>();
        Dictionary<Food, int> itemSelected = new Dictionary<Food, int>();
        public frmCustomerOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            //setting up the columns in the list view called ltvmenu
            //we are loading the textfile1 from the method loadfooditemsfromfile
            //http://csharp.net-informations.com/gui/cs-listview.htm
            //https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-add-and-remove-items-with-the-windows-forms-listview-control?view=netframeworkdesktop-4.8
            ltvMenu.View = View.Details;
            ltvMenu.Columns.Add("Item", 100);
            ltvMenu.Columns.Add("Price", 50);
            ltvMenu.Columns.Add("Category", 75);

            //This is another list view but for the items that the user has added
            ltvSelectedItem.View = View.Details;
            ltvSelectedItem.Columns.Add("Item", 100);
            ltvSelectedItem.Columns.Add("Price", 100);
            ltvSelectedItem.Columns.Add("Qty", 50);

            //callin on the textfile1 on populate the list view
            List<Food> foodItems = LoadFoodItemsFromFile();

            PopulateMenuListView(foodItems);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //This is from the input invalid lecture slide
            //Cant let the user enter numbers, symbols and etcs, they need to put letters 
            //becauase names contains only letters
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNameEnter.Text, "^[a-zA-Z ]"))
            {
                lblError.Text = "Name only accept letters!";
                lblError.Visible = true;
                return;
            }

            //There is a link from the input invalid lecture slide to the mircsoft learn, this list regex and the types of input you can allows
            //@"^(\d{10}|)$" just validates if the input is a 10 digits number or is empty
            // Doesnt make sense to have a phone number that isnt 10 digits here and i dont want to force users to enter phone numbers
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPhoneNumberEnter.Text, @"^(\d{10}|)$"))
            {
                lblError.Text = "Phone number must be a positive 10 digits number or left blank!";
                lblError.Visible = true;
                return;
            }

            string name = txtNameEnter.Text;
            string phone = txtPhoneNumberEnter.Text;
            string address = txtAddressEnter.Text;
            customer = new Customer(name, phone, address);

            //This  is a ternary operator, rather than do a if else statement; you can do a line one
            //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
            string deliveryMethod = radDelivery.Checked ? "Delivery" : "Pickup";
            //string deliveryMethod;
            //if (radDelivery.Checked)
            //{
            //    deliveryMethod = "Delivery";
            //}
            //else
            //{
            //  deliveryMethod = "Pickup";
            //}

            //A both condition that requires at least one of the radio button to be checked
            if (!radDelivery.Checked && !radPickUp.Checked)
            {
                lblError.Text = "Please select a type of order!";
                lblError.Visible = true;
                return;
            }

            //tip
            double tipValue = 0;
            //another regex from the input validation lecture slide
            //basically a tip isnt a requirement to enter but you do need to need a number becayse tip is optainal
            //a user can just enter letters and symbol, first it wouldnt make sense
            //second the tip is added to the total bill so it will prob cause a crash
            //also there are no such thing as negative numbers in tips, the shop owner dont owned customer money
            if (string.IsNullOrWhiteSpace(txtTip.Text))
            {
                tipValue = 0;  
            }
            else if (!double.TryParse(txtTip.Text, out tipValue) || tipValue < 0)
            {
                lblError.Text = "Tip must be a positive number!";
                lblError.Visible = true;
                return;
            }
            string tip = tipValue.ToString();

            int qty;
            //qty is just how many we want for the items we selected
            if (!int.TryParse(txtQty.Text, out qty) || qty <= 0)
            {
                lblError.Text = "Please enter a postive number for qty.";
                lblError.Visible = true;
                return;
            }

            // new order 
            order = new Order(customer, deliveryMethod, tip, qty, food, itemSelected);

            //Create an instance of the form to open and use
            frmCustomerReceipt customerReceiptForm = new frmCustomerReceipt(order);
            customerReceiptForm.ShowDialog();// modal form

        }

        //Event handler for my lvtMenu
        private void ltvMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltvMenu.SelectedItems.Count > 0)
            {
                int selectedIndex = ltvMenu.SelectedItems[0].Index;

                if (selectedIndex >= 0 && selectedIndex < loadedItems.Count)
                {
                    //the select row of the listview will show more details of that item like description, image, and price
                    Food selectedFood = loadedItems[selectedIndex];
                    lblShortDescription.Text = selectedFood.ShortDescription;
                    lblLongDescription.Text = selectedFood.LongDescription;
                    lblPriceDisplay.Text = "$" + selectedFood.Price.ToString();
                    //it will try the image address but it cant load, it will catch it and load with a default image 
                    try
                    {
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

        //a method that load the textfile1.txt
        private List<Food> LoadFoodItemsFromFile()
        {
            //store all the information from the textfil1 in a string array
            string[] lines = File.ReadAllLines(Path.Combine(sourceDir, "TextFile1.txt"));

            foreach (string line in lines)
            {
                //encounter the comma will split the line/string
                string[] parts = line.Split(',');
                //trim will remove the spaces
                //ssetting every of the item fields
                //TA helped me with this during the lab
                Food foodItem = new Food()
                {
                    Category = (foodCategory)Enum.Parse(typeof(foodCategory), parts[0].Trim()),
                    Cost = double.Parse(parts[1].Trim()),
                    Price = double.Parse(parts[2].Trim()),
                    ShortDescription = parts[3].Trim(),
                    LongDescription = parts[4].Trim(),
                    Image = parts[5].Trim()
                };
                // added each of the fields of the item into the loadeditems list
                loadedItems.Add(foodItem);
            }

            return loadedItems;
        }

        //populate the list view from the list fooditem
        private void PopulateMenuListView(List<Food> foodItems)
        {
            ltvMenu.Items.Clear();
            foreach (Food foodItem in foodItems)
            {
                ListViewItem item = new ListViewItem(foodItem.ShortDescription);
                item.SubItems.Add(foodItem.Price.ToString());
                item.SubItems.Add(foodItem.Category.ToString());
                ltvMenu.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //the button requres a item in the listview to be selected
            if (ltvMenu.SelectedItems.Count == 0)
            {
                lblError.Text = ("Please select an item from the menu!");
                lblError.Visible = true;
                return;
            }

            //Also before hitting the add button, you need to add the qty of that item
            if (string.IsNullOrWhiteSpace(txtQty.Text) || !int.TryParse(txtQty.Text, out int qty) || qty <= 0)
            {
                lblError.Text = ("Please enter a valid positive quantity!");
                lblError.Visible = true;
                return;
            }
            //On the canvas assignment lab 3 one of the link, "C# ListView Control"
            //has example like 
            //"productName = listView1.SelectedItems[0].SubItems[0].Text;"
            //"price = listView1.SelectedItems[0].SubItems[1].Text;"
            //"quantity = listView1.SelectedItems[0].SubItems[2].Text;"
            //http://csharp.net-informations.com/gui/cs-listview.htm

            string selectedItemName = ltvMenu.SelectedItems[0].SubItems[0].Text;
            string selectedItemPrice = ltvMenu.SelectedItems[0].SubItems[1].Text;
            Food selectedItemFood = loadedItems[ltvMenu.SelectedItems[0].Index];

            //There is an issue of add an item that already has been added to the selected listview
            //so I doing a foreach if there is a match that it will just increase the quantity
            foreach (ListViewItem item in ltvSelectedItem.Items)
            {
                if (item.SubItems[0].Text == selectedItemName)
                {
                    //item (short description) is [0]
                    //price is [1]
                    //qty is [2]
                    int existingQty = int.Parse(item.SubItems[2].Text);
                    item.SubItems[2].Text = (existingQty + qty).ToString();

                    itemSelected[selectedItemFood] = existingQty + qty;

                    return;
                }
            }
            
            ListViewItem newItem = new ListViewItem(selectedItemName);
            newItem.SubItems.Add(selectedItemPrice);
            newItem.SubItems.Add(qty.ToString());
            ltvSelectedItem.Items.Add(newItem);
            //update the list of item and qty
            itemSelected.Add(selectedItemFood, qty);

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void pbxImage_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNameEnter.Text = "";
            txtAddressEnter.Text = "";
            txtPhoneNumberEnter.Text = "";

            txtQty.Text = "";

            txtTip.Text = "";

            radDelivery.Checked = false;
            radPickUp.Checked = false;

        }
    }
}
