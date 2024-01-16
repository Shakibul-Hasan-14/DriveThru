
namespace DriveThru
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.Logo3 = new System.Windows.Forms.PictureBox();
            this.Logo2 = new System.Windows.Forms.PictureBox();
            this.C_Back_Button = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.Button();
            this.Available = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo2)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo3
            // 
            this.Logo3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo3.BackColor = System.Drawing.Color.Transparent;
            this.Logo3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Logo3.Image = ((System.Drawing.Image)(resources.GetObject("Logo3.Image")));
            this.Logo3.Location = new System.Drawing.Point(770, 366);
            this.Logo3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Logo3.Name = "Logo3";
            this.Logo3.Size = new System.Drawing.Size(183, 162);
            this.Logo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo3.TabIndex = 67;
            this.Logo3.TabStop = false;
            this.Logo3.Click += new System.EventHandler(this.Logo3_Click);
            // 
            // Logo2
            // 
            this.Logo2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo2.BackColor = System.Drawing.Color.Transparent;
            this.Logo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Logo2.Image = ((System.Drawing.Image)(resources.GetObject("Logo2.Image")));
            this.Logo2.Location = new System.Drawing.Point(770, 100);
            this.Logo2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Logo2.Name = "Logo2";
            this.Logo2.Size = new System.Drawing.Size(183, 162);
            this.Logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo2.TabIndex = 65;
            this.Logo2.TabStop = false;
            // 
            // C_Back_Button
            // 
            this.C_Back_Button.BackColor = System.Drawing.Color.Transparent;
            this.C_Back_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.C_Back_Button.FlatAppearance.BorderSize = 0;
            this.C_Back_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.C_Back_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.C_Back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C_Back_Button.ForeColor = System.Drawing.Color.Transparent;
            this.C_Back_Button.Image = ((System.Drawing.Image)(resources.GetObject("C_Back_Button.Image")));
            this.C_Back_Button.Location = new System.Drawing.Point(4, 6);
            this.C_Back_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.C_Back_Button.Name = "C_Back_Button";
            this.C_Back_Button.Size = new System.Drawing.Size(38, 38);
            this.C_Back_Button.TabIndex = 64;
            this.C_Back_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.C_Back_Button.UseVisualStyleBackColor = false;
            this.C_Back_Button.Click += new System.EventHandler(this.C_Back_Button_Click);
            // 
            // Report
            // 
            this.Report.BackColor = System.Drawing.Color.MistyRose;
            this.Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Report.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report.ForeColor = System.Drawing.Color.Black;
            this.Report.Location = new System.Drawing.Point(736, 536);
            this.Report.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(250, 39);
            this.Report.TabIndex = 63;
            this.Report.Text = "Review";
            this.Report.UseVisualStyleBackColor = false;
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // Available
            // 
            this.Available.BackColor = System.Drawing.Color.MistyRose;
            this.Available.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Available.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Available.ForeColor = System.Drawing.Color.Black;
            this.Available.Location = new System.Drawing.Point(736, 270);
            this.Available.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Available.Name = "Available";
            this.Available.Size = new System.Drawing.Size(250, 39);
            this.Available.TabIndex = 60;
            this.Available.Text = "Available For Rent";
            this.Available.UseVisualStyleBackColor = false;
            this.Available.Click += new System.EventHandler(this.Available_Click);
            // 
            // txtBox
            // 
            this.txtBox.BackColor = System.Drawing.Color.RosyBrown;
            this.txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox.ForeColor = System.Drawing.Color.Maroon;
            this.txtBox.Location = new System.Drawing.Point(88, 137);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.ReadOnly = true;
            this.txtBox.Size = new System.Drawing.Size(588, 399);
            this.txtBox.TabIndex = 68;
            this.txtBox.TabStop = false;
            this.txtBox.Text = "Information:";
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.Logo3);
            this.Controls.Add(this.Logo2);
            this.Controls.Add(this.C_Back_Button);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.Available);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Logo3;
        private System.Windows.Forms.PictureBox Logo2;
        private System.Windows.Forms.Button C_Back_Button;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.Button Available;
        private System.Windows.Forms.TextBox txtBox;
    }
}