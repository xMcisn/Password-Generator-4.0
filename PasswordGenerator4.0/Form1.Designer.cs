namespace PasswordGenerator4._0
{
    partial class Form1
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonGenerateNew = new System.Windows.Forms.Button();
            this.labelWebsite = new System.Windows.Forms.Label();
            this.textBoxWebsite = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelGeneratedPassword = new System.Windows.Forms.Label();
            this.labelGeneratedPass = new System.Windows.Forms.Label();
            this.labelDesiredLength = new System.Windows.Forms.Label();
            this.textBoxDesiredPassLength = new System.Windows.Forms.TextBox();
            this.buttonSaveEntry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // buttonGenerateNew
            // 
            this.buttonGenerateNew.Location = new System.Drawing.Point(1148, 550);
            this.buttonGenerateNew.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateNew.Name = "buttonGenerateNew";
            this.buttonGenerateNew.Size = new System.Drawing.Size(155, 49);
            this.buttonGenerateNew.TabIndex = 2;
            this.buttonGenerateNew.Text = "Generate New";
            this.buttonGenerateNew.UseVisualStyleBackColor = true;
            this.buttonGenerateNew.Click += new System.EventHandler(this.buttonGenerateNew_Click);
            // 
            // labelWebsite
            // 
            this.labelWebsite.AutoSize = true;
            this.labelWebsite.Font = new System.Drawing.Font("HelveticaNeueLT Com 57 Cn", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWebsite.Location = new System.Drawing.Point(1181, 26);
            this.labelWebsite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWebsite.Name = "labelWebsite";
            this.labelWebsite.Size = new System.Drawing.Size(95, 28);
            this.labelWebsite.TabIndex = 3;
            this.labelWebsite.Text = "WEBSITE:";
            this.labelWebsite.Click += new System.EventHandler(this.labelWebsite_Click);
            // 
            // textBoxWebsite
            // 
            this.textBoxWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWebsite.Location = new System.Drawing.Point(972, 78);
            this.textBoxWebsite.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWebsite.Name = "textBoxWebsite";
            this.textBoxWebsite.Size = new System.Drawing.Size(502, 35);
            this.textBoxWebsite.TabIndex = 4;
            this.textBoxWebsite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxWebsite.TextChanged += new System.EventHandler(this.textBoxWebsite_TextChanged);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("HelveticaNeueLT Com 57 Cn", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(1192, 140);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(68, 28);
            this.labelLogin.TabIndex = 5;
            this.labelLogin.Text = "LOGIN:";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(972, 186);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(502, 35);
            this.textBoxLogin.TabIndex = 6;
            this.textBoxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("HelveticaNeueLT Com 57 Cn", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(1172, 386);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(115, 28);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "PASSWORD:";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // labelGeneratedPassword
            // 
            this.labelGeneratedPassword.AutoSize = true;
            this.labelGeneratedPassword.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGeneratedPassword.Location = new System.Drawing.Point(522, 374);
            this.labelGeneratedPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGeneratedPassword.Name = "labelGeneratedPassword";
            this.labelGeneratedPassword.Size = new System.Drawing.Size(0, 30);
            this.labelGeneratedPassword.TabIndex = 8;
            // 
            // labelGeneratedPass
            // 
            this.labelGeneratedPass.AutoSize = true;
            this.labelGeneratedPass.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGeneratedPass.Location = new System.Drawing.Point(967, 440);
            this.labelGeneratedPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGeneratedPass.Name = "labelGeneratedPass";
            this.labelGeneratedPass.Size = new System.Drawing.Size(68, 27);
            this.labelGeneratedPass.TabIndex = 9;
            this.labelGeneratedPass.Text = "NULL";
            this.labelGeneratedPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGeneratedPass.Click += new System.EventHandler(this.labelGeneratedPass_Click);
            // 
            // labelDesiredLength
            // 
            this.labelDesiredLength.AutoSize = true;
            this.labelDesiredLength.Font = new System.Drawing.Font("HelveticaNeueLT Com 57 Cn", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesiredLength.Location = new System.Drawing.Point(1106, 255);
            this.labelDesiredLength.Name = "labelDesiredLength";
            this.labelDesiredLength.Size = new System.Drawing.Size(274, 26);
            this.labelDesiredLength.TabIndex = 10;
            this.labelDesiredLength.Text = "DESIRED PASS LENGTH (10-64):";
            this.labelDesiredLength.Click += new System.EventHandler(this.labelDesiredLength_Click);
            // 
            // textBoxDesiredPassLength
            // 
            this.textBoxDesiredPassLength.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDesiredPassLength.Location = new System.Drawing.Point(1197, 304);
            this.textBoxDesiredPassLength.MaxLength = 2;
            this.textBoxDesiredPassLength.Name = "textBoxDesiredPassLength";
            this.textBoxDesiredPassLength.Size = new System.Drawing.Size(63, 40);
            this.textBoxDesiredPassLength.TabIndex = 11;
            this.textBoxDesiredPassLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDesiredPassLength.TextChanged += new System.EventHandler(this.textBoxDesiredPassLength_TextChanged);
            // 
            // buttonSaveEntry
            // 
            this.buttonSaveEntry.Location = new System.Drawing.Point(1148, 651);
            this.buttonSaveEntry.Name = "buttonSaveEntry";
            this.buttonSaveEntry.Size = new System.Drawing.Size(155, 45);
            this.buttonSaveEntry.TabIndex = 12;
            this.buttonSaveEntry.Text = "Save Entry";
            this.buttonSaveEntry.UseVisualStyleBackColor = true;
            this.buttonSaveEntry.Click += new System.EventHandler(this.buttonSaveEntry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2180, 974);
            this.Controls.Add(this.buttonSaveEntry);
            this.Controls.Add(this.textBoxDesiredPassLength);
            this.Controls.Add(this.labelDesiredLength);
            this.Controls.Add(this.labelGeneratedPass);
            this.Controls.Add(this.labelGeneratedPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxWebsite);
            this.Controls.Add(this.labelWebsite);
            this.Controls.Add(this.buttonGenerateNew);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonGenerateNew;
        private System.Windows.Forms.Label labelWebsite;
        private System.Windows.Forms.TextBox textBoxWebsite;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelGeneratedPassword;
        private System.Windows.Forms.Label labelGeneratedPass;
        private System.Windows.Forms.Label labelDesiredLength;
        private System.Windows.Forms.TextBox textBoxDesiredPassLength;
        private System.Windows.Forms.Button buttonSaveEntry;
    }
}

