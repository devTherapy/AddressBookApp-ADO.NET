
namespace AddressBook.UI
{
    partial class ChangeAddress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeAddress));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ZipCodeBox = new System.Windows.Forms.TextBox();
            this.CountryBox = new System.Windows.Forms.TextBox();
            this.StateBox = new System.Windows.Forms.TextBox();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.StreetBox = new System.Windows.Forms.TextBox();
            this.AddAddressBtn = new System.Windows.Forms.Button();
            this.UpdateAddressBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 69);
            this.panel1.TabIndex = 3;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(995, 9);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(99, 46);
            this.BackButton.TabIndex = 22;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(147, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address Book";
            // 
            // ZipCodeBox
            // 
            this.ZipCodeBox.Location = new System.Drawing.Point(385, 415);
            this.ZipCodeBox.Name = "ZipCodeBox";
            this.ZipCodeBox.PlaceholderText = "Enter your Zip code";
            this.ZipCodeBox.Size = new System.Drawing.Size(439, 37);
            this.ZipCodeBox.TabIndex = 15;
            // 
            // CountryBox
            // 
            this.CountryBox.Location = new System.Drawing.Point(389, 341);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.PlaceholderText = "Enter your country";
            this.CountryBox.Size = new System.Drawing.Size(439, 37);
            this.CountryBox.TabIndex = 16;
            // 
            // StateBox
            // 
            this.StateBox.Location = new System.Drawing.Point(389, 270);
            this.StateBox.Name = "StateBox";
            this.StateBox.PlaceholderText = "Enter your state";
            this.StateBox.Size = new System.Drawing.Size(439, 37);
            this.StateBox.TabIndex = 17;
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(389, 197);
            this.CityBox.Name = "CityBox";
            this.CityBox.PlaceholderText = "Enter your city";
            this.CityBox.Size = new System.Drawing.Size(439, 37);
            this.CityBox.TabIndex = 18;
            // 
            // StreetBox
            // 
            this.StreetBox.Location = new System.Drawing.Point(389, 127);
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.PlaceholderText = "Enter your street";
            this.StreetBox.Size = new System.Drawing.Size(439, 37);
            this.StreetBox.TabIndex = 19;
            // 
            // AddAddressBtn
            // 
            this.AddAddressBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.AddAddressBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AddAddressBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddAddressBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddAddressBtn.ForeColor = System.Drawing.Color.White;
            this.AddAddressBtn.Location = new System.Drawing.Point(264, 507);
            this.AddAddressBtn.Name = "AddAddressBtn";
            this.AddAddressBtn.Size = new System.Drawing.Size(292, 46);
            this.AddAddressBtn.TabIndex = 26;
            this.AddAddressBtn.Text = "Add Address";
            this.AddAddressBtn.UseVisualStyleBackColor = false;
            this.AddAddressBtn.Click += new System.EventHandler(this.AddAddressBtn_Click);
            // 
            // UpdateAddressBtn
            // 
            this.UpdateAddressBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.UpdateAddressBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.UpdateAddressBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateAddressBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateAddressBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateAddressBtn.Location = new System.Drawing.Point(663, 507);
            this.UpdateAddressBtn.Name = "UpdateAddressBtn";
            this.UpdateAddressBtn.Size = new System.Drawing.Size(292, 46);
            this.UpdateAddressBtn.TabIndex = 27;
            this.UpdateAddressBtn.Text = "Update Address";
            this.UpdateAddressBtn.UseVisualStyleBackColor = false;
            this.UpdateAddressBtn.Click += new System.EventHandler(this.UpdateAddressBtn_Click);
            // 
            // ChangeAddress
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 853);
            this.Controls.Add(this.UpdateAddressBtn);
            this.Controls.Add(this.AddAddressBtn);
            this.Controls.Add(this.StreetBox);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.StateBox);
            this.Controls.Add(this.CountryBox);
            this.Controls.Add(this.ZipCodeBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeAddress";
            this.Load += new System.EventHandler(this.ChangeAddress_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ZipCodeBox;
        private System.Windows.Forms.TextBox CountryBox;
        private System.Windows.Forms.TextBox StateBox;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.TextBox StreetBox;
        private System.Windows.Forms.Button AddAddressBtn;
        private System.Windows.Forms.Button UpdateAddressBtn;
    }
}