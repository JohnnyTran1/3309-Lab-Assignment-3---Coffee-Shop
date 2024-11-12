
namespace Lab_Assignment_3___Coffee_Shop
{
    partial class frmMenuDisplay
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
            this.lblError = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.gpbFilter = new System.Windows.Forms.GroupBox();
            this.cobCategories = new System.Windows.Forms.ComboBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.gpbDetail = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblLong = new System.Windows.Forms.Label();
            this.lblPriceDisplay = new System.Windows.Forms.Label();
            this.lblShort = new System.Windows.Forms.Label();
            this.lblLongDescription = new System.Windows.Forms.Label();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.lblShortDescription = new System.Windows.Forms.Label();
            this.gpbMenu = new System.Windows.Forms.GroupBox();
            this.ltvMenu = new System.Windows.Forms.ListView();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblCostDisplay = new System.Windows.Forms.Label();
            this.gpbFilter.SuspendLayout();
            this.gpbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.gpbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(246, 313);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(99, 13);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "(Error) Place Holder";
            this.lblError.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(335, 329);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 40);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(421, 329);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(80, 40);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.Text = "Start an order!";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(249, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 40);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(53, 296);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(80, 40);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // gpbFilter
            // 
            this.gpbFilter.Controls.Add(this.cobCategories);
            this.gpbFilter.Controls.Add(this.lblCategories);
            this.gpbFilter.Location = new System.Drawing.Point(2, 38);
            this.gpbFilter.Name = "gpbFilter";
            this.gpbFilter.Size = new System.Drawing.Size(200, 252);
            this.gpbFilter.TabIndex = 14;
            this.gpbFilter.TabStop = false;
            this.gpbFilter.Text = "Filter";
            // 
            // cobCategories
            // 
            this.cobCategories.FormattingEnabled = true;
            this.cobCategories.Location = new System.Drawing.Point(6, 36);
            this.cobCategories.Name = "cobCategories";
            this.cobCategories.Size = new System.Drawing.Size(121, 21);
            this.cobCategories.TabIndex = 5;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(6, 19);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(57, 13);
            this.lblCategories.TabIndex = 2;
            this.lblCategories.Text = "Categories";
            // 
            // gpbDetail
            // 
            this.gpbDetail.Controls.Add(this.lblCost);
            this.gpbDetail.Controls.Add(this.lblCostDisplay);
            this.gpbDetail.Controls.Add(this.lblPrice);
            this.gpbDetail.Controls.Add(this.lblLong);
            this.gpbDetail.Controls.Add(this.lblPriceDisplay);
            this.gpbDetail.Controls.Add(this.lblShort);
            this.gpbDetail.Controls.Add(this.lblLongDescription);
            this.gpbDetail.Controls.Add(this.pbxImage);
            this.gpbDetail.Controls.Add(this.lblShortDescription);
            this.gpbDetail.Location = new System.Drawing.Point(507, 38);
            this.gpbDetail.Name = "gpbDetail";
            this.gpbDetail.Size = new System.Drawing.Size(281, 360);
            this.gpbDetail.TabIndex = 15;
            this.gpbDetail.TabStop = false;
            this.gpbDetail.Text = "Detail";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(11, 197);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 23;
            this.lblPrice.Text = "Price:";
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Location = new System.Drawing.Point(6, 245);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(63, 13);
            this.lblLong.TabIndex = 19;
            this.lblLong.Text = "Description:";
            // 
            // lblPriceDisplay
            // 
            this.lblPriceDisplay.AutoSize = true;
            this.lblPriceDisplay.Location = new System.Drawing.Point(47, 197);
            this.lblPriceDisplay.Name = "lblPriceDisplay";
            this.lblPriceDisplay.Size = new System.Drawing.Size(100, 13);
            this.lblPriceDisplay.TabIndex = 22;
            this.lblPriceDisplay.Text = "Place Holder( price)";
            // 
            // lblShort
            // 
            this.lblShort.AutoSize = true;
            this.lblShort.Location = new System.Drawing.Point(11, 173);
            this.lblShort.Name = "lblShort";
            this.lblShort.Size = new System.Drawing.Size(30, 13);
            this.lblShort.TabIndex = 18;
            this.lblShort.Text = "Item:";
            // 
            // lblLongDescription
            // 
            this.lblLongDescription.Location = new System.Drawing.Point(75, 245);
            this.lblLongDescription.Name = "lblLongDescription";
            this.lblLongDescription.Size = new System.Drawing.Size(200, 108);
            this.lblLongDescription.TabIndex = 17;
            this.lblLongDescription.Text = "Place Holder (long)";
            this.lblLongDescription.Click += new System.EventHandler(this.lblLongDescription_Click);
            // 
            // pbxImage
            // 
            this.pbxImage.Location = new System.Drawing.Point(6, 20);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(269, 150);
            this.pbxImage.TabIndex = 16;
            this.pbxImage.TabStop = false;
            // 
            // lblShortDescription
            // 
            this.lblShortDescription.AutoSize = true;
            this.lblShortDescription.Location = new System.Drawing.Point(47, 173);
            this.lblShortDescription.Name = "lblShortDescription";
            this.lblShortDescription.Size = new System.Drawing.Size(100, 13);
            this.lblShortDescription.TabIndex = 16;
            this.lblShortDescription.Text = "Place Holder( short)";
            // 
            // gpbMenu
            // 
            this.gpbMenu.Controls.Add(this.ltvMenu);
            this.gpbMenu.Location = new System.Drawing.Point(208, 38);
            this.gpbMenu.Name = "gpbMenu";
            this.gpbMenu.Size = new System.Drawing.Size(293, 258);
            this.gpbMenu.TabIndex = 15;
            this.gpbMenu.TabStop = false;
            this.gpbMenu.Text = "Menu";
            // 
            // ltvMenu
            // 
            this.ltvMenu.FullRowSelect = true;
            this.ltvMenu.HideSelection = false;
            this.ltvMenu.Location = new System.Drawing.Point(6, 19);
            this.ltvMenu.Name = "ltvMenu";
            this.ltvMenu.Size = new System.Drawing.Size(281, 233);
            this.ltvMenu.TabIndex = 16;
            this.ltvMenu.UseCompatibleStateImageBehavior = false;
            this.ltvMenu.SelectedIndexChanged += new System.EventHandler(this.ltvMenuDisplay_SelectedIndexChanged);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(11, 223);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(31, 13);
            this.lblCost.TabIndex = 25;
            this.lblCost.Text = "Cost:";
            // 
            // lblCostDisplay
            // 
            this.lblCostDisplay.AutoSize = true;
            this.lblCostDisplay.Location = new System.Drawing.Point(47, 223);
            this.lblCostDisplay.Name = "lblCostDisplay";
            this.lblCostDisplay.Size = new System.Drawing.Size(95, 13);
            this.lblCostDisplay.TabIndex = 24;
            this.lblCostDisplay.Text = "Place Holder(Cost)";
            // 
            // frmMenuDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbDetail);
            this.Controls.Add(this.gpbMenu);
            this.Controls.Add(this.gpbFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnExit);
            this.Name = "frmMenuDisplay";
            this.Text = "frmMenuDisplay";
            this.Load += new System.EventHandler(this.frmMenuDisplay_Load);
            this.gpbFilter.ResumeLayout(false);
            this.gpbFilter.PerformLayout();
            this.gpbDetail.ResumeLayout(false);
            this.gpbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.gpbMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.GroupBox gpbFilter;
        private System.Windows.Forms.GroupBox gpbDetail;
        private System.Windows.Forms.GroupBox gpbMenu;
        private System.Windows.Forms.ListView ltvMenu;
        private System.Windows.Forms.ComboBox cobCategories;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Label lblShortDescription;
        private System.Windows.Forms.Label lblLongDescription;
        private System.Windows.Forms.Label lblLong;
        private System.Windows.Forms.Label lblShort;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPriceDisplay;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblCostDisplay;
    }
}