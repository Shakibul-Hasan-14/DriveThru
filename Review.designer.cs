
namespace DriveThru
{
    partial class repiss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(repiss));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.desBox = new System.Windows.Forms.TextBox();
            this.repback = new System.Windows.Forms.Button();
            this.repSub = new System.Windows.Forms.Button();
            this.DBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(452, 97);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // desBox
            // 
            this.desBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.desBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desBox.ForeColor = System.Drawing.Color.Maroon;
            this.desBox.Location = new System.Drawing.Point(180, 357);
            this.desBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.desBox.Multiline = true;
            this.desBox.Name = "desBox";
            this.desBox.Size = new System.Drawing.Size(712, 106);
            this.desBox.TabIndex = 3;
            this.desBox.TextChanged += new System.EventHandler(this.desBox_TextChanged);
            // 
            // repback
            // 
            this.repback.BackColor = System.Drawing.Color.Transparent;
            this.repback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.repback.FlatAppearance.BorderSize = 0;
            this.repback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.repback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.repback.Image = ((System.Drawing.Image)(resources.GetObject("repback.Image")));
            this.repback.Location = new System.Drawing.Point(3, 4);
            this.repback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.repback.Name = "repback";
            this.repback.Size = new System.Drawing.Size(38, 38);
            this.repback.TabIndex = 18;
            this.repback.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.repback.UseVisualStyleBackColor = false;
            this.repback.Click += new System.EventHandler(this.repback_Click_1);
            // 
            // repSub
            // 
            this.repSub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.repSub.AutoSize = true;
            this.repSub.BackColor = System.Drawing.Color.MistyRose;
            this.repSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.repSub.FlatAppearance.BorderSize = 0;
            this.repSub.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.repSub.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.repSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repSub.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repSub.ForeColor = System.Drawing.Color.Maroon;
            this.repSub.Location = new System.Drawing.Point(410, 533);
            this.repSub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.repSub.Name = "repSub";
            this.repSub.Size = new System.Drawing.Size(250, 40);
            this.repSub.TabIndex = 19;
            this.repSub.Text = "Submit";
            this.repSub.UseVisualStyleBackColor = false;
            this.repSub.Click += new System.EventHandler(this.repSub_Click);
            // 
            // DBox
            // 
            this.DBox.AutoSize = true;
            this.DBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBox.ForeColor = System.Drawing.Color.White;
            this.DBox.Location = new System.Drawing.Point(176, 331);
            this.DBox.Name = "DBox";
            this.DBox.Size = new System.Drawing.Size(146, 22);
            this.DBox.TabIndex = 20;
            this.DBox.Text = "Description Box:";
            // 
            // repiss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.DBox);
            this.Controls.Add(this.repSub);
            this.Controls.Add(this.repback);
            this.Controls.Add(this.desBox);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "repiss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review";
            this.Load += new System.EventHandler(this.repiss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox desBox;
        private System.Windows.Forms.Button repback;
        private System.Windows.Forms.Button repSub;
        private System.Windows.Forms.Label DBox;
    }
}

