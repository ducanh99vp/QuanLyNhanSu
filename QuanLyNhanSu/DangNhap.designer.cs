namespace Qlks
{
    partial class DangNhap
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
            this.bt_thoat = new System.Windows.Forms.Button();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.bt_dn = new System.Windows.Forms.Button();
            this.bt_username = new System.Windows.Forms.Button();
            this.bt_password = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Location = new System.Drawing.Point(333, 0);
            this.bt_thoat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(37, 31);
            this.bt_thoat.TabIndex = 1;
            this.bt_thoat.Text = "X";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // txt_tk
            // 
            this.txt_tk.Location = new System.Drawing.Point(113, 191);
            this.txt_tk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(212, 20);
            this.txt_tk.TabIndex = 0;
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(113, 221);
            this.txt_mk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.PasswordChar = '0';
            this.txt_mk.Size = new System.Drawing.Size(212, 20);
            this.txt_mk.TabIndex = 1;
            // 
            // bt_dn
            // 
            this.bt_dn.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_dn.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dn.ForeColor = System.Drawing.Color.White;
            this.bt_dn.Location = new System.Drawing.Point(136, 257);
            this.bt_dn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bt_dn.Name = "bt_dn";
            this.bt_dn.Size = new System.Drawing.Size(103, 35);
            this.bt_dn.TabIndex = 2;
            this.bt_dn.Text = "LOGIN";
            this.bt_dn.UseVisualStyleBackColor = false;
            this.bt_dn.Click += new System.EventHandler(this.bt_dn_Click);
            // 
            // bt_username
            // 
            this.bt_username.BackColor = System.Drawing.Color.DimGray;
            this.bt_username.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_username.ForeColor = System.Drawing.Color.White;
            this.bt_username.Location = new System.Drawing.Point(33, 188);
            this.bt_username.Name = "bt_username";
            this.bt_username.Size = new System.Drawing.Size(75, 23);
            this.bt_username.TabIndex = 3;
            this.bt_username.Text = "Username";
            this.bt_username.UseVisualStyleBackColor = false;
            // 
            // bt_password
            // 
            this.bt_password.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_password.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_password.ForeColor = System.Drawing.Color.White;
            this.bt_password.Location = new System.Drawing.Point(33, 220);
            this.bt_password.Name = "bt_password";
            this.bt_password.Size = new System.Drawing.Size(75, 21);
            this.bt_password.TabIndex = 4;
            this.bt_password.Text = "Password";
            this.bt_password.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Qlks.Properties.Resources.loginIcon;
            this.pictureBox1.Location = new System.Drawing.Point(139, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 81);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // DangNhap
            // 
            this.AcceptButton = this.bt_dn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Qlks.Properties.Resources.Beautiful_Background_Wallpaper_Copy2;
            this.ClientSize = new System.Drawing.Size(365, 336);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_password);
            this.Controls.Add(this.bt_username);
            this.Controls.Add(this.bt_dn);
            this.Controls.Add(this.txt_mk);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.bt_thoat);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(500, 0);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.Button bt_dn;
        private System.Windows.Forms.Button bt_username;
        private System.Windows.Forms.Button bt_password;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}