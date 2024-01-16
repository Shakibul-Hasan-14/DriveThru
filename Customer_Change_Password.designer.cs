
namespace DriveThru
{
    partial class Customer_Change_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Change_Password));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ccpback = new System.Windows.Forms.Button();
            this.ccpSub = new System.Windows.Forms.Button();
            this.ccpnewPassword = new System.Windows.Forms.TextBox();
            this.ccpuserName = new System.Windows.Forms.TextBox();
            this.ccpSA = new System.Windows.Forms.TextBox();
            this.ccpSQ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(398, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ccpback
            // 
            this.ccpback.BackColor = System.Drawing.Color.Transparent;
            this.ccpback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ccpback.FlatAppearance.BorderSize = 0;
            this.ccpback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ccpback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ccpback.Image = ((System.Drawing.Image)(resources.GetObject("ccpback.Image")));
            this.ccpback.Location = new System.Drawing.Point(3, 3);
            this.ccpback.Name = "ccpback";
            this.ccpback.Size = new System.Drawing.Size(34, 32);
            this.ccpback.TabIndex = 18;
            this.ccpback.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ccpback.UseVisualStyleBackColor = false;
            this.ccpback.Click += new System.EventHandler(this.ccpback_Click_1);
            // 
            // ccpSub
            // 
            this.ccpSub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ccpSub.AutoSize = true;
            this.ccpSub.BackColor = System.Drawing.Color.MistyRose;
            this.ccpSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ccpSub.FlatAppearance.BorderSize = 0;
            this.ccpSub.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.ccpSub.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.ccpSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ccpSub.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccpSub.ForeColor = System.Drawing.Color.Black;
            this.ccpSub.Location = new System.Drawing.Point(398, 594);
            this.ccpSub.Name = "ccpSub";
            this.ccpSub.Size = new System.Drawing.Size(282, 38);
            this.ccpSub.TabIndex = 71;
            this.ccpSub.Text = "Change Password";
            this.ccpSub.UseVisualStyleBackColor = false;
            this.ccpSub.Visible = false;
            this.ccpSub.Click += new System.EventHandler(this.ccpSub_Click_1);
            // 
            // ccpnewPassword
            // 
            this.ccpnewPassword.BackColor = System.Drawing.Color.MistyRose;
            this.ccpnewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ccpnewPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccpnewPassword.Location = new System.Drawing.Point(343, 542);
            this.ccpnewPassword.Name = "ccpnewPassword";
            this.ccpnewPassword.Size = new System.Drawing.Size(390, 30);
            this.ccpnewPassword.TabIndex = 70;
            this.ccpnewPassword.UseSystemPasswordChar = true;
            this.ccpnewPassword.Visible = false;
            // 
            // ccpuserName
            // 
            this.ccpuserName.BackColor = System.Drawing.Color.MistyRose;
            this.ccpuserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ccpuserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccpuserName.Location = new System.Drawing.Point(343, 339);
            this.ccpuserName.Name = "ccpuserName";
            this.ccpuserName.Size = new System.Drawing.Size(390, 30);
            this.ccpuserName.TabIndex = 69;
            this.ccpuserName.TextChanged += new System.EventHandler(this.ccpuserName_TextChanged);
            // 
            // ccpSA
            // 
            this.ccpSA.BackColor = System.Drawing.Color.MistyRose;
            this.ccpSA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ccpSA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccpSA.Location = new System.Drawing.Point(343, 472);
            this.ccpSA.Name = "ccpSA";
            this.ccpSA.Size = new System.Drawing.Size(390, 30);
            this.ccpSA.TabIndex = 68;
            this.ccpSA.Visible = false;
            this.ccpSA.TextChanged += new System.EventHandler(this.ccpsurveyQuestion_TextChanged);
            // 
            // ccpSQ
            // 
            this.ccpSQ.BackColor = System.Drawing.Color.MistyRose;
            this.ccpSQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ccpSQ.Enabled = false;
            this.ccpSQ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccpSQ.Location = new System.Drawing.Point(343, 410);
            this.ccpSQ.Name = "ccpSQ";
            this.ccpSQ.Size = new System.Drawing.Size(390, 30);
            this.ccpSQ.TabIndex = 72;
            this.ccpSQ.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(339, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 73;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(339, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 22);
            this.label2.TabIndex = 74;
            this.label2.Text = "Selected Security Question:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(339, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 75;
            this.label3.Text = "Answer:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(339, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 22);
            this.label4.TabIndex = 76;
            this.label4.Text = "New Password:";
            this.label4.Visible = false;
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheck.AutoSize = true;
            this.btnCheck.BackColor = System.Drawing.Color.MistyRose;
            this.btnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.Black;
            this.btnCheck.Location = new System.Drawing.Point(398, 438);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(282, 38);
            this.btnCheck.TabIndex = 77;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Customer_Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ccpSQ);
            this.Controls.Add(this.ccpSub);
            this.Controls.Add(this.ccpnewPassword);
            this.Controls.Add(this.ccpuserName);
            this.Controls.Add(this.ccpSA);
            this.Controls.Add(this.ccpback);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer_Change_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ccpback;
        private System.Windows.Forms.Button ccpSub;
        private System.Windows.Forms.TextBox ccpnewPassword;
        private System.Windows.Forms.TextBox ccpuserName;
        private System.Windows.Forms.TextBox ccpSA;
        private System.Windows.Forms.TextBox ccpSQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCheck;
    }
}

