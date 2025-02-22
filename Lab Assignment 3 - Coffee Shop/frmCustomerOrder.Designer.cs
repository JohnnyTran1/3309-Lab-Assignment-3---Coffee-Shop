﻿
namespace Lab_Assignment_3___Coffee_Shop
{
    partial class frmCustomerOrder
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
            this.gboTip = new System.Windows.Forms.GroupBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.gboOrder = new System.Windows.Forms.GroupBox();
            this.radPickUp = new System.Windows.Forms.RadioButton();
            this.radDelivery = new System.Windows.Forms.RadioButton();
            this.gboPersonalInformation = new System.Windows.Forms.GroupBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumberEnter = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddressEnter = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNameEnter = new System.Windows.Forms.TextBox();
            this.blOptional = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ltvMenu = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ltvSelectedItem = new System.Windows.Forms.ListView();
            this.gpbSelectedItem = new System.Windows.Forms.GroupBox();
            this.gpbMenu = new System.Windows.Forms.GroupBox();
            this.gpbDetail = new System.Windows.Forms.GroupBox();
            this.lblLong = new System.Windows.Forms.Label();
            this.lblShort = new System.Windows.Forms.Label();
            this.lblLongDescription = new System.Windows.Forms.Label();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.lblShortDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceDisplay = new System.Windows.Forms.Label();
            this.gboTip.SuspendLayout();
            this.gboOrder.SuspendLayout();
            this.gboPersonalInformation.SuspendLayout();
            this.gpbSelectedItem.SuspendLayout();
            this.gpbMenu.SuspendLayout();
            this.gpbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gboTip
            // 
            this.gboTip.Controls.Add(this.txtTip);
            this.gboTip.Controls.Add(this.lblTip);
            this.gboTip.Location = new System.Drawing.Point(11, 223);
            this.gboTip.Name = "gboTip";
            this.gboTip.Size = new System.Drawing.Size(200, 50);
            this.gboTip.TabIndex = 5;
            this.gboTip.TabStop = false;
            this.gboTip.Text = "Tip";
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(94, 14);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(100, 20);
            this.txtTip.TabIndex = 32;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(7, 21);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(66, 13);
            this.lblTip.TabIndex = 31;
            this.lblTip.Text = "Tip the staff:";
            // 
            // gboOrder
            // 
            this.gboOrder.Controls.Add(this.radPickUp);
            this.gboOrder.Controls.Add(this.radDelivery);
            this.gboOrder.Location = new System.Drawing.Point(12, 117);
            this.gboOrder.Name = "gboOrder";
            this.gboOrder.Size = new System.Drawing.Size(200, 100);
            this.gboOrder.TabIndex = 4;
            this.gboOrder.TabStop = false;
            this.gboOrder.Text = "Order";
            // 
            // radPickUp
            // 
            this.radPickUp.AutoSize = true;
            this.radPickUp.Location = new System.Drawing.Point(9, 54);
            this.radPickUp.Name = "radPickUp";
            this.radPickUp.Size = new System.Drawing.Size(63, 17);
            this.radPickUp.TabIndex = 1;
            this.radPickUp.TabStop = true;
            this.radPickUp.Text = "Pick Up";
            this.radPickUp.UseVisualStyleBackColor = true;
            // 
            // radDelivery
            // 
            this.radDelivery.AutoSize = true;
            this.radDelivery.Location = new System.Drawing.Point(9, 20);
            this.radDelivery.Name = "radDelivery";
            this.radDelivery.Size = new System.Drawing.Size(63, 17);
            this.radDelivery.TabIndex = 0;
            this.radDelivery.TabStop = true;
            this.radDelivery.Text = "Delivery";
            this.radDelivery.UseVisualStyleBackColor = true;
            // 
            // gboPersonalInformation
            // 
            this.gboPersonalInformation.Controls.Add(this.lblPhoneNumber);
            this.gboPersonalInformation.Controls.Add(this.txtPhoneNumberEnter);
            this.gboPersonalInformation.Controls.Add(this.lblAddress);
            this.gboPersonalInformation.Controls.Add(this.txtAddressEnter);
            this.gboPersonalInformation.Controls.Add(this.lblName);
            this.gboPersonalInformation.Controls.Add(this.txtNameEnter);
            this.gboPersonalInformation.Location = new System.Drawing.Point(11, 10);
            this.gboPersonalInformation.Name = "gboPersonalInformation";
            this.gboPersonalInformation.Size = new System.Drawing.Size(200, 100);
            this.gboPersonalInformation.TabIndex = 3;
            this.gboPersonalInformation.TabStop = false;
            this.gboPersonalInformation.Text = "Personal Information";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(7, 42);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // txtPhoneNumberEnter
            // 
            this.txtPhoneNumberEnter.Location = new System.Drawing.Point(94, 42);
            this.txtPhoneNumberEnter.Name = "txtPhoneNumberEnter";
            this.txtPhoneNumberEnter.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumberEnter.TabIndex = 12;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(7, 67);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddressEnter
            // 
            this.txtAddressEnter.Location = new System.Drawing.Point(94, 64);
            this.txtAddressEnter.Name = "txtAddressEnter";
            this.txtAddressEnter.Size = new System.Drawing.Size(100, 20);
            this.txtAddressEnter.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtNameEnter
            // 
            this.txtNameEnter.BackColor = System.Drawing.SystemColors.Window;
            this.txtNameEnter.Location = new System.Drawing.Point(94, 20);
            this.txtNameEnter.Name = "txtNameEnter";
            this.txtNameEnter.Size = new System.Drawing.Size(100, 20);
            this.txtNameEnter.TabIndex = 10;
            // 
            // blOptional
            // 
            this.blOptional.AutoSize = true;
            this.blOptional.Location = new System.Drawing.Point(18, 409);
            this.blOptional.Name = "blOptional";
            this.blOptional.Size = new System.Drawing.Size(209, 13);
            this.blOptional.TabIndex = 49;
            this.blOptional.Text = "Optional: Tip, Phone Number and Address!";
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(13, 386);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(290, 13);
            this.lblInstruction.TabIndex = 48;
            this.lblInstruction.Text = "Customer must select at least one item, name, order and qty.";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(217, 276);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(98, 13);
            this.lblError.TabIndex = 47;
            this.lblError.Text = "Error (place Holder)";
            this.lblError.Visible = false;
            this.lblError.Click += new System.EventHandler(this.lblError_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(129, 185);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(65, 20);
            this.txtQty.TabIndex = 46;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(100, 185);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(23, 13);
            this.lblQty.TabIndex = 45;
            this.lblQty.Text = "Qty";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(97, 332);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 40);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(178, 332);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 40);
            this.btnSubmit.TabIndex = 43;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(16, 332);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 40);
            this.btnExit.TabIndex = 50;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // ltvMenu
            // 
            this.ltvMenu.FullRowSelect = true;
            this.ltvMenu.HideSelection = false;
            this.ltvMenu.Location = new System.Drawing.Point(9, 13);
            this.ltvMenu.Name = "ltvMenu";
            this.ltvMenu.Size = new System.Drawing.Size(234, 163);
            this.ltvMenu.TabIndex = 51;
            this.ltvMenu.UseCompatibleStateImageBehavior = false;
            this.ltvMenu.SelectedIndexChanged += new System.EventHandler(this.ltvMenu_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(129, 215);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 40);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ltvSelectedItem
            // 
            this.ltvSelectedItem.HideSelection = false;
            this.ltvSelectedItem.Location = new System.Drawing.Point(18, 19);
            this.ltvSelectedItem.Name = "ltvSelectedItem";
            this.ltvSelectedItem.Size = new System.Drawing.Size(271, 164);
            this.ltvSelectedItem.TabIndex = 53;
            this.ltvSelectedItem.UseCompatibleStateImageBehavior = false;
            // 
            // gpbSelectedItem
            // 
            this.gpbSelectedItem.Controls.Add(this.ltvSelectedItem);
            this.gpbSelectedItem.Location = new System.Drawing.Point(791, 25);
            this.gpbSelectedItem.Name = "gpbSelectedItem";
            this.gpbSelectedItem.Size = new System.Drawing.Size(328, 205);
            this.gpbSelectedItem.TabIndex = 55;
            this.gpbSelectedItem.TabStop = false;
            this.gpbSelectedItem.Text = "Selected Item(s)";
            // 
            // gpbMenu
            // 
            this.gpbMenu.Controls.Add(this.ltvMenu);
            this.gpbMenu.Controls.Add(this.lblQty);
            this.gpbMenu.Controls.Add(this.btnAdd);
            this.gpbMenu.Controls.Add(this.txtQty);
            this.gpbMenu.Location = new System.Drawing.Point(218, 12);
            this.gpbMenu.Name = "gpbMenu";
            this.gpbMenu.Size = new System.Drawing.Size(249, 261);
            this.gpbMenu.TabIndex = 56;
            this.gpbMenu.TabStop = false;
            this.gpbMenu.Text = "Menu";
            // 
            // gpbDetail
            // 
            this.gpbDetail.Controls.Add(this.lblPrice);
            this.gpbDetail.Controls.Add(this.lblPriceDisplay);
            this.gpbDetail.Controls.Add(this.lblLong);
            this.gpbDetail.Controls.Add(this.lblShort);
            this.gpbDetail.Controls.Add(this.lblLongDescription);
            this.gpbDetail.Controls.Add(this.pbxImage);
            this.gpbDetail.Controls.Add(this.lblShortDescription);
            this.gpbDetail.Location = new System.Drawing.Point(485, 25);
            this.gpbDetail.Name = "gpbDetail";
            this.gpbDetail.Size = new System.Drawing.Size(281, 331);
            this.gpbDetail.TabIndex = 57;
            this.gpbDetail.TabStop = false;
            this.gpbDetail.Text = "Detail";
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Location = new System.Drawing.Point(6, 220);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(63, 13);
            this.lblLong.TabIndex = 19;
            this.lblLong.Text = "Description:";
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
            this.lblLongDescription.Location = new System.Drawing.Point(75, 220);
            this.lblLongDescription.Name = "lblLongDescription";
            this.lblLongDescription.Size = new System.Drawing.Size(200, 108);
            this.lblLongDescription.TabIndex = 17;
            this.lblLongDescription.Text = "Place Holder (long)";
            // 
            // pbxImage
            // 
            this.pbxImage.Location = new System.Drawing.Point(6, 20);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(269, 150);
            this.pbxImage.TabIndex = 16;
            this.pbxImage.TabStop = false;
            this.pbxImage.Click += new System.EventHandler(this.pbxImage_Click);
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
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(11, 198);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "Price:";
            // 
            // lblPriceDisplay
            // 
            this.lblPriceDisplay.AutoSize = true;
            this.lblPriceDisplay.Location = new System.Drawing.Point(47, 198);
            this.lblPriceDisplay.Name = "lblPriceDisplay";
            this.lblPriceDisplay.Size = new System.Drawing.Size(100, 13);
            this.lblPriceDisplay.TabIndex = 20;
            this.lblPriceDisplay.Text = "Place Holder( price)";
            // 
            // frmCustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 519);
            this.Controls.Add(this.gpbDetail);
            this.Controls.Add(this.gpbMenu);
            this.Controls.Add(this.gpbSelectedItem);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.blOptional);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gboTip);
            this.Controls.Add(this.gboOrder);
            this.Controls.Add(this.gboPersonalInformation);
            this.Name = "frmCustomerOrder";
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.gboTip.ResumeLayout(false);
            this.gboTip.PerformLayout();
            this.gboOrder.ResumeLayout(false);
            this.gboOrder.PerformLayout();
            this.gboPersonalInformation.ResumeLayout(false);
            this.gboPersonalInformation.PerformLayout();
            this.gpbSelectedItem.ResumeLayout(false);
            this.gpbMenu.ResumeLayout(false);
            this.gpbMenu.PerformLayout();
            this.gpbDetail.ResumeLayout(false);
            this.gpbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboTip;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.GroupBox gboOrder;
        private System.Windows.Forms.RadioButton radPickUp;
        private System.Windows.Forms.RadioButton radDelivery;
        private System.Windows.Forms.GroupBox gboPersonalInformation;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumberEnter;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddressEnter;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNameEnter;
        private System.Windows.Forms.Label blOptional;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView ltvMenu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView ltvSelectedItem;
        private System.Windows.Forms.GroupBox gpbSelectedItem;
        private System.Windows.Forms.GroupBox gpbMenu;
        private System.Windows.Forms.GroupBox gpbDetail;
        private System.Windows.Forms.Label lblLong;
        private System.Windows.Forms.Label lblShort;
        private System.Windows.Forms.Label lblLongDescription;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Label lblShortDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPriceDisplay;
    }
}