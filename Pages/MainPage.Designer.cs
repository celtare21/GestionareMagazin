
namespace GestionareMagazin.Pages
{
    partial class MainPage
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
            this.ProductsList = new System.Windows.Forms.ListView();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ModifyPersonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductsList
            // 
            this.ProductsList.CheckBoxes = true;
            this.ProductsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ProductsList.HideSelection = false;
            this.ProductsList.Location = new System.Drawing.Point(150, 50);
            this.ProductsList.Margin = new System.Windows.Forms.Padding(10);
            this.ProductsList.Name = "ProductsList";
            this.ProductsList.Size = new System.Drawing.Size(500, 196);
            this.ProductsList.TabIndex = 1;
            this.ProductsList.UseCompatibleStateImageBehavior = false;
            this.ProductsList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ProductsList_ItemChecked);
            // 
            // AddItemButton
            // 
            this.AddItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddItemButton.Location = new System.Drawing.Point(150, 297);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(119, 30);
            this.AddItemButton.TabIndex = 2;
            this.AddItemButton.Text = "Add new person";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Enabled = false;
            this.RemoveItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RemoveItemButton.Location = new System.Drawing.Point(344, 297);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(119, 30);
            this.RemoveItemButton.TabIndex = 3;
            this.RemoveItemButton.Text = "Remove person";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // ModifyPersonButton
            // 
            this.ModifyPersonButton.Enabled = false;
            this.ModifyPersonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ModifyPersonButton.Location = new System.Drawing.Point(531, 297);
            this.ModifyPersonButton.Name = "ModifyPersonButton";
            this.ModifyPersonButton.Size = new System.Drawing.Size(119, 30);
            this.ModifyPersonButton.TabIndex = 4;
            this.ModifyPersonButton.Text = "Modify person";
            this.ModifyPersonButton.UseVisualStyleBackColor = true;
            this.ModifyPersonButton.Click += new System.EventHandler(this.ModifyPersonButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 370);
            this.Controls.Add(this.ModifyPersonButton);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.ProductsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ProductsList;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button ModifyPersonButton;
    }
}