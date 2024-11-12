
namespace Lab_Assignment_3___Coffee_Shop
{
    partial class frmEmployeeCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ltvItemTable = new System.Windows.Forms.ListView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.gboCategories = new System.Windows.Forms.GroupBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.cobCategories = new System.Windows.Forms.ComboBox();
            this.gpbRetailPrice = new System.Windows.Forms.GroupBox();
            this.lblRetailPrice = new System.Windows.Forms.Label();
            this.txtRetailPrice = new System.Windows.Forms.TextBox();
            this.gpbLongDescription = new System.Windows.Forms.GroupBox();
            this.lblLongDescription = new System.Windows.Forms.Label();
            this.txtLongDescription = new System.Windows.Forms.TextBox();
            this.gboMenu = new System.Windows.Forms.GroupBox();
            this.lblStore = new System.Windows.Forms.Label();
            this.gpbShortDescription = new System.Windows.Forms.GroupBox();
            this.lblShortDescription = new System.Windows.Forms.Label();
            this.txtShortDescription = new System.Windows.Forms.TextBox();
            this.gpbCostItem = new System.Windows.Forms.GroupBox();
            this.lblCostItem = new System.Windows.Forms.Label();
            this.txtCostItem = new System.Windows.Forms.TextBox();
            this.gpbImageItem = new System.Windows.Forms.GroupBox();
            this.lblImageItem = new System.Windows.Forms.Label();
            this.txtImageItem = new System.Windows.Forms.TextBox();
            this.lblFormDescription = new System.Windows.Forms.Label();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.gpbIoadImage = new System.Windows.Forms.GroupBox();
            this.btnStore = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            this.gboCategories.SuspendLayout();
            this.gpbRetailPrice.SuspendLayout();
            this.gpbLongDescription.SuspendLayout();
            this.gboMenu.SuspendLayout();
            this.gpbShortDescription.SuspendLayout();
            this.gpbCostItem.SuspendLayout();
            this.gpbImageItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.gpbIoadImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltvItemTable
            // 
            this.ltvItemTable.FullRowSelect = true;
            this.ltvItemTable.HideSelection = false;
            this.ltvItemTable.Location = new System.Drawing.Point(6, 19);
            this.ltvItemTable.Name = "ltvItemTable";
            this.ltvItemTable.Size = new System.Drawing.Size(323, 277);
            this.ltvItemTable.TabIndex = 0;
            this.ltvItemTable.UseCompatibleStateImageBehavior = false;
            this.ltvItemTable.SelectedIndexChanged += new System.EventHandler(this.ltvItemTable_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(448, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(534, 398);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 40);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(49, 398);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 40);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblError.Location = new System.Drawing.Point(221, 412);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(99, 13);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "(Error) Place Holder";
            this.lblError.Visible = false;
            // 
            // gboCategories
            // 
            this.gboCategories.Controls.Add(this.lblCategories);
            this.gboCategories.Controls.Add(this.cobCategories);
            this.gboCategories.Location = new System.Drawing.Point(12, 114);
            this.gboCategories.Name = "gboCategories";
            this.gboCategories.Size = new System.Drawing.Size(108, 100);
            this.gboCategories.TabIndex = 9;
            this.gboCategories.TabStop = false;
            this.gboCategories.Text = "Categories";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(-1, 34);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(105, 13);
            this.lblCategories.TabIndex = 14;
            this.lblCategories.Text = "Enter the categories:";
            // 
            // cobCategories
            // 
            this.cobCategories.FormattingEnabled = true;
            this.cobCategories.Location = new System.Drawing.Point(6, 73);
            this.cobCategories.Name = "cobCategories";
            this.cobCategories.Size = new System.Drawing.Size(100, 21);
            this.cobCategories.TabIndex = 0;
            // 
            // gpbRetailPrice
            // 
            this.gpbRetailPrice.Controls.Add(this.lblRetailPrice);
            this.gpbRetailPrice.Controls.Add(this.txtRetailPrice);
            this.gpbRetailPrice.Location = new System.Drawing.Point(124, 114);
            this.gpbRetailPrice.Name = "gpbRetailPrice";
            this.gpbRetailPrice.Size = new System.Drawing.Size(108, 100);
            this.gpbRetailPrice.TabIndex = 10;
            this.gpbRetailPrice.TabStop = false;
            this.gpbRetailPrice.Text = "Price";
            // 
            // lblRetailPrice
            // 
            this.lblRetailPrice.AutoSize = true;
            this.lblRetailPrice.Location = new System.Drawing.Point(-1, 34);
            this.lblRetailPrice.Name = "lblRetailPrice";
            this.lblRetailPrice.Size = new System.Drawing.Size(104, 13);
            this.lblRetailPrice.TabIndex = 13;
            this.lblRetailPrice.Text = "Enter the retail price:";
            // 
            // txtRetailPrice
            // 
            this.txtRetailPrice.Location = new System.Drawing.Point(2, 74);
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.Size = new System.Drawing.Size(100, 20);
            this.txtRetailPrice.TabIndex = 0;
            // 
            // gpbLongDescription
            // 
            this.gpbLongDescription.Controls.Add(this.lblLongDescription);
            this.gpbLongDescription.Controls.Add(this.txtLongDescription);
            this.gpbLongDescription.Location = new System.Drawing.Point(124, 220);
            this.gpbLongDescription.Name = "gpbLongDescription";
            this.gpbLongDescription.Size = new System.Drawing.Size(108, 100);
            this.gpbLongDescription.TabIndex = 11;
            this.gpbLongDescription.TabStop = false;
            this.gpbLongDescription.Text = "Long Description";
            // 
            // lblLongDescription
            // 
            this.lblLongDescription.AutoSize = true;
            this.lblLongDescription.Location = new System.Drawing.Point(-3, 47);
            this.lblLongDescription.Name = "lblLongDescription";
            this.lblLongDescription.Size = new System.Drawing.Size(112, 13);
            this.lblLongDescription.TabIndex = 14;
            this.lblLongDescription.Text = "Enter long description:";
            this.lblLongDescription.Click += new System.EventHandler(this.lblLongDescription_Click);
            // 
            // txtLongDescription
            // 
            this.txtLongDescription.Location = new System.Drawing.Point(2, 74);
            this.txtLongDescription.Multiline = true;
            this.txtLongDescription.Name = "txtLongDescription";
            this.txtLongDescription.Size = new System.Drawing.Size(100, 20);
            this.txtLongDescription.TabIndex = 1;
            // 
            // gboMenu
            // 
            this.gboMenu.Controls.Add(this.ltvItemTable);
            this.gboMenu.Location = new System.Drawing.Point(237, 12);
            this.gboMenu.Name = "gboMenu";
            this.gboMenu.Size = new System.Drawing.Size(335, 302);
            this.gboMenu.TabIndex = 14;
            this.gboMenu.TabStop = false;
            this.gboMenu.Text = "Menu";
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Location = new System.Drawing.Point(28, 381);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(464, 13);
            this.lblStore.TabIndex = 15;
            this.lblStore.Text = "Store after entering the items\' name, retail price, category, image, cost, short " +
    "and long description:";
            // 
            // gpbShortDescription
            // 
            this.gpbShortDescription.Controls.Add(this.lblShortDescription);
            this.gpbShortDescription.Controls.Add(this.txtShortDescription);
            this.gpbShortDescription.Location = new System.Drawing.Point(10, 220);
            this.gpbShortDescription.Name = "gpbShortDescription";
            this.gpbShortDescription.Size = new System.Drawing.Size(108, 100);
            this.gpbShortDescription.TabIndex = 15;
            this.gpbShortDescription.TabStop = false;
            this.gpbShortDescription.Text = "Short Description";
            // 
            // lblShortDescription
            // 
            this.lblShortDescription.AutoSize = true;
            this.lblShortDescription.Location = new System.Drawing.Point(-3, 47);
            this.lblShortDescription.Name = "lblShortDescription";
            this.lblShortDescription.Size = new System.Drawing.Size(115, 13);
            this.lblShortDescription.TabIndex = 14;
            this.lblShortDescription.Text = "Enter short description:";
            // 
            // txtShortDescription
            // 
            this.txtShortDescription.Location = new System.Drawing.Point(2, 74);
            this.txtShortDescription.Name = "txtShortDescription";
            this.txtShortDescription.Size = new System.Drawing.Size(100, 20);
            this.txtShortDescription.TabIndex = 1;
            // 
            // gpbCostItem
            // 
            this.gpbCostItem.Controls.Add(this.lblCostItem);
            this.gpbCostItem.Controls.Add(this.txtCostItem);
            this.gpbCostItem.Location = new System.Drawing.Point(123, 12);
            this.gpbCostItem.Name = "gpbCostItem";
            this.gpbCostItem.Size = new System.Drawing.Size(108, 100);
            this.gpbCostItem.TabIndex = 14;
            this.gpbCostItem.TabStop = false;
            this.gpbCostItem.Text = "Cost of Item";
            // 
            // lblCostItem
            // 
            this.lblCostItem.AutoSize = true;
            this.lblCostItem.Location = new System.Drawing.Point(6, 34);
            this.lblCostItem.Name = "lblCostItem";
            this.lblCostItem.Size = new System.Drawing.Size(98, 13);
            this.lblCostItem.TabIndex = 13;
            this.lblCostItem.Text = "Enter the item cost:";
            // 
            // txtCostItem
            // 
            this.txtCostItem.Location = new System.Drawing.Point(2, 74);
            this.txtCostItem.Name = "txtCostItem";
            this.txtCostItem.Size = new System.Drawing.Size(100, 20);
            this.txtCostItem.TabIndex = 0;
            // 
            // gpbImageItem
            // 
            this.gpbImageItem.Controls.Add(this.lblImageItem);
            this.gpbImageItem.Controls.Add(this.txtImageItem);
            this.gpbImageItem.Location = new System.Drawing.Point(12, 12);
            this.gpbImageItem.Name = "gpbImageItem";
            this.gpbImageItem.Size = new System.Drawing.Size(108, 100);
            this.gpbImageItem.TabIndex = 15;
            this.gpbImageItem.TabStop = false;
            this.gpbImageItem.Text = "Image of Item";
            // 
            // lblImageItem
            // 
            this.lblImageItem.AutoSize = true;
            this.lblImageItem.Location = new System.Drawing.Point(6, 34);
            this.lblImageItem.Name = "lblImageItem";
            this.lblImageItem.Size = new System.Drawing.Size(100, 13);
            this.lblImageItem.TabIndex = 13;
            this.lblImageItem.Text = "Enter image of item:";
            // 
            // txtImageItem
            // 
            this.txtImageItem.Location = new System.Drawing.Point(2, 74);
            this.txtImageItem.Name = "txtImageItem";
            this.txtImageItem.Size = new System.Drawing.Size(100, 20);
            this.txtImageItem.TabIndex = 0;
            // 
            // lblFormDescription
            // 
            this.lblFormDescription.AutoSize = true;
            this.lblFormDescription.Location = new System.Drawing.Point(237, 0);
            this.lblFormDescription.Name = "lblFormDescription";
            this.lblFormDescription.Size = new System.Drawing.Size(290, 13);
            this.lblFormDescription.TabIndex = 16;
            this.lblFormDescription.Text = "Allow the employee to create a menu of drinks and pastries: ";
            // 
            // pbxImage
            // 
            this.pbxImage.Location = new System.Drawing.Point(7, 19);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(165, 142);
            this.pbxImage.TabIndex = 17;
            this.pbxImage.TabStop = false;
            this.pbxImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gpbIoadImage
            // 
            this.gpbIoadImage.Controls.Add(this.pbxImage);
            this.gpbIoadImage.Location = new System.Drawing.Point(578, 12);
            this.gpbIoadImage.Name = "gpbIoadImage";
            this.gpbIoadImage.Size = new System.Drawing.Size(178, 167);
            this.gpbIoadImage.TabIndex = 18;
            this.gpbIoadImage.TabStop = false;
            this.gpbIoadImage.Text = "Image";
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(135, 397);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(80, 40);
            this.btnStore.TabIndex = 12;
            this.btnStore.Text = "Store";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(234, 317);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(347, 13);
            this.lblInformation.TabIndex = 19;
            this.lblInformation.Text = "This List view will only show items that\'s being create during this session.";
            // 
            // frmEmployeeCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.gpbIoadImage);
            this.Controls.Add(this.lblFormDescription);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.gpbImageItem);
            this.Controls.Add(this.gpbCostItem);
            this.Controls.Add(this.gpbShortDescription);
            this.Controls.Add(this.lblStore);
            this.Controls.Add(this.gboMenu);
            this.Controls.Add(this.gpbLongDescription);
            this.Controls.Add(this.gpbRetailPrice);
            this.Controls.Add(this.gboCategories);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnExit);
            this.Name = "frmEmployeeCreate";
            this.Text = "Create Menu";
            this.Load += new System.EventHandler(this.EmployeeCreate_Load);
            this.gboCategories.ResumeLayout(false);
            this.gboCategories.PerformLayout();
            this.gpbRetailPrice.ResumeLayout(false);
            this.gpbRetailPrice.PerformLayout();
            this.gpbLongDescription.ResumeLayout(false);
            this.gpbLongDescription.PerformLayout();
            this.gboMenu.ResumeLayout(false);
            this.gpbShortDescription.ResumeLayout(false);
            this.gpbShortDescription.PerformLayout();
            this.gpbCostItem.ResumeLayout(false);
            this.gpbCostItem.PerformLayout();
            this.gpbImageItem.ResumeLayout(false);
            this.gpbImageItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.gpbIoadImage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ltvItemTable;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.GroupBox gboCategories;
        private System.Windows.Forms.GroupBox gpbRetailPrice;
        private System.Windows.Forms.TextBox txtRetailPrice;
        private System.Windows.Forms.GroupBox gpbLongDescription;
        private System.Windows.Forms.TextBox txtLongDescription;
        private System.Windows.Forms.Label lblRetailPrice;
        private System.Windows.Forms.Label lblLongDescription;
        private System.Windows.Forms.GroupBox gboMenu;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.GroupBox gpbShortDescription;
        private System.Windows.Forms.Label lblShortDescription;
        private System.Windows.Forms.TextBox txtShortDescription;
        private System.Windows.Forms.GroupBox gpbCostItem;
        private System.Windows.Forms.Label lblCostItem;
        private System.Windows.Forms.TextBox txtCostItem;
        private System.Windows.Forms.GroupBox gpbImageItem;
        private System.Windows.Forms.Label lblImageItem;
        private System.Windows.Forms.TextBox txtImageItem;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.ComboBox cobCategories;
        private System.Windows.Forms.Label lblFormDescription;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.GroupBox gpbIoadImage;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Label lblInformation;
    }
}

