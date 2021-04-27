
namespace AddressBook.UI
{
    partial class ChangePhoneNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePhoneNumber));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBox = new System.Windows.Forms.TextBox();
            this.DeleteBox = new System.Windows.Forms.TextBox();
            this.OldNumberBox = new System.Windows.Forms.TextBox();
            this.NewNumberBox = new System.Windows.Forms.TextBox();
            this.AddPhone = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateNumberBtn = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 2;
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
            // AddBox
            // 
            this.AddBox.Location = new System.Drawing.Point(374, 173);
            this.AddBox.Name = "AddBox";
            this.AddBox.PlaceholderText = "Enter Phone Number to Add";
            this.AddBox.Size = new System.Drawing.Size(439, 37);
            this.AddBox.TabIndex = 14;
            // 
            // DeleteBox
            // 
            this.DeleteBox.Location = new System.Drawing.Point(374, 360);
            this.DeleteBox.Name = "DeleteBox";
            this.DeleteBox.PlaceholderText = "Enter Number to delete";
            this.DeleteBox.Size = new System.Drawing.Size(439, 37);
            this.DeleteBox.TabIndex = 15;
            // 
            // OldNumberBox
            // 
            this.OldNumberBox.Location = new System.Drawing.Point(108, 587);
            this.OldNumberBox.Name = "OldNumberBox";
            this.OldNumberBox.PlaceholderText = "Enter the Number to Update";
            this.OldNumberBox.Size = new System.Drawing.Size(439, 37);
            this.OldNumberBox.TabIndex = 16;
            // 
            // NewNumberBox
            // 
            this.NewNumberBox.Location = new System.Drawing.Point(655, 587);
            this.NewNumberBox.Name = "NewNumberBox";
            this.NewNumberBox.PlaceholderText = "Enter the New Number";
            this.NewNumberBox.Size = new System.Drawing.Size(439, 37);
            this.NewNumberBox.TabIndex = 17;
            // 
            // AddPhone
            // 
            this.AddPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.AddPhone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AddPhone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddPhone.ForeColor = System.Drawing.Color.White;
            this.AddPhone.Location = new System.Drawing.Point(437, 237);
            this.AddPhone.Name = "AddPhone";
            this.AddPhone.Size = new System.Drawing.Size(292, 46);
            this.AddPhone.TabIndex = 23;
            this.AddPhone.Text = "Add Phone Number";
            this.AddPhone.UseVisualStyleBackColor = false;
            this.AddPhone.Click += new System.EventHandler(this.AddPhone_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(437, 428);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(292, 46);
            this.DeleteButton.TabIndex = 24;
            this.DeleteButton.Text = "Delete Number";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateNumberBtn
            // 
            this.UpdateNumberBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.UpdateNumberBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.UpdateNumberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateNumberBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateNumberBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateNumberBtn.Location = new System.Drawing.Point(448, 650);
            this.UpdateNumberBtn.Name = "UpdateNumberBtn";
            this.UpdateNumberBtn.Size = new System.Drawing.Size(292, 46);
            this.UpdateNumberBtn.TabIndex = 25;
            this.UpdateNumberBtn.Text = "Update Number";
            this.UpdateNumberBtn.UseVisualStyleBackColor = false;
            this.UpdateNumberBtn.Click += new System.EventHandler(this.UpdateNumberBtn_Click);
            // 
            // ChangePhoneNumber
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 853);
            this.Controls.Add(this.UpdateNumberBtn);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddPhone);
            this.Controls.Add(this.NewNumberBox);
            this.Controls.Add(this.OldNumberBox);
            this.Controls.Add(this.DeleteBox);
            this.Controls.Add(this.AddBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePhoneNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPhoneNumber";
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
        private System.Windows.Forms.TextBox AddBox;
        private System.Windows.Forms.TextBox DeleteBox;
        private System.Windows.Forms.TextBox OldNumberBox;
        private System.Windows.Forms.TextBox NewNumberBox;
        private System.Windows.Forms.Button AddPhone;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateNumberBtn;
    }
}