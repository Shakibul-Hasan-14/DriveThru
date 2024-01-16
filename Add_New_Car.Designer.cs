
namespace DriveThru
{
    partial class Add_New_Car
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_New_Car));
            this.UpPic = new System.Windows.Forms.PictureBox();
            this.AddModel = new System.Windows.Forms.Label();
            this.AddModeltxt = new System.Windows.Forms.TextBox();
            this.AddCaptxt = new System.Windows.Forms.TextBox();
            this.AddCap = new System.Windows.Forms.Label();
            this.AddPlatetxt = new System.Windows.Forms.TextBox();
            this.AddPlate = new System.Windows.Forms.Label();
            this.btnAddBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.Messagelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpPic)).BeginInit();
            this.SuspendLayout();
            // 
            // UpPic
            // 
            this.UpPic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpPic.BackColor = System.Drawing.Color.Snow;
            this.UpPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UpPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpPic.Location = new System.Drawing.Point(74, 69);
            this.UpPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpPic.Name = "UpPic";
            this.UpPic.Size = new System.Drawing.Size(726, 435);
            this.UpPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpPic.TabIndex = 0;
            this.UpPic.TabStop = false;
            // 
            // AddModel
            // 
            this.AddModel.AutoSize = true;
            this.AddModel.BackColor = System.Drawing.Color.Transparent;
            this.AddModel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddModel.Location = new System.Drawing.Point(857, 69);
            this.AddModel.Name = "AddModel";
            this.AddModel.Size = new System.Drawing.Size(102, 22);
            this.AddModel.TabIndex = 1;
            this.AddModel.Text = "Car Model:";
            // 
            // AddModeltxt
            // 
            this.AddModeltxt.BackColor = System.Drawing.Color.MistyRose;
            this.AddModeltxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddModeltxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddModeltxt.Location = new System.Drawing.Point(852, 95);
            this.AddModeltxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddModeltxt.Name = "AddModeltxt";
            this.AddModeltxt.Size = new System.Drawing.Size(163, 30);
            this.AddModeltxt.TabIndex = 2;
            // 
            // AddCaptxt
            // 
            this.AddCaptxt.BackColor = System.Drawing.Color.MistyRose;
            this.AddCaptxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddCaptxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCaptxt.Location = new System.Drawing.Point(852, 371);
            this.AddCaptxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddCaptxt.Name = "AddCaptxt";
            this.AddCaptxt.Size = new System.Drawing.Size(163, 30);
            this.AddCaptxt.TabIndex = 4;
            // 
            // AddCap
            // 
            this.AddCap.AutoSize = true;
            this.AddCap.BackColor = System.Drawing.Color.Transparent;
            this.AddCap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCap.Location = new System.Drawing.Point(857, 345);
            this.AddCap.Name = "AddCap";
            this.AddCap.Size = new System.Drawing.Size(86, 22);
            this.AddCap.TabIndex = 3;
            this.AddCap.Text = "Capacity:";
            // 
            // AddPlatetxt
            // 
            this.AddPlatetxt.BackColor = System.Drawing.Color.MistyRose;
            this.AddPlatetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddPlatetxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPlatetxt.Location = new System.Drawing.Point(852, 239);
            this.AddPlatetxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddPlatetxt.Name = "AddPlatetxt";
            this.AddPlatetxt.Size = new System.Drawing.Size(163, 30);
            this.AddPlatetxt.TabIndex = 6;
            // 
            // AddPlate
            // 
            this.AddPlate.AutoSize = true;
            this.AddPlate.BackColor = System.Drawing.Color.Transparent;
            this.AddPlate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPlate.Location = new System.Drawing.Point(857, 213);
            this.AddPlate.Name = "AddPlate";
            this.AddPlate.Size = new System.Drawing.Size(124, 22);
            this.AddPlate.TabIndex = 5;
            this.AddPlate.Text = "Number Plate:";
            // 
            // btnAddBack
            // 
            this.btnAddBack.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddBack.FlatAppearance.BorderSize = 0;
            this.btnAddBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddBack.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBack.Image")));
            this.btnAddBack.Location = new System.Drawing.Point(3, 4);
            this.btnAddBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddBack.Name = "btnAddBack";
            this.btnAddBack.Size = new System.Drawing.Size(38, 38);
            this.btnAddBack.TabIndex = 10;
            this.btnAddBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddBack.UseVisualStyleBackColor = false;
            this.btnAddBack.Click += new System.EventHandler(this.btnAddBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.MistyRose;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(460, 600);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 40);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.AutoSize = true;
            this.btnUpload.BackColor = System.Drawing.Color.MistyRose;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(852, 470);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(163, 34);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.Text = "Upload Picture";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // OpenDialog
            // 
            this.OpenDialog.FileName = "OpenDialog";
            // 
            // Messagelbl
            // 
            this.Messagelbl.AutoSize = true;
            this.Messagelbl.BackColor = System.Drawing.Color.White;
            this.Messagelbl.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messagelbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Messagelbl.Location = new System.Drawing.Point(281, 265);
            this.Messagelbl.Name = "Messagelbl";
            this.Messagelbl.Size = new System.Drawing.Size(273, 37);
            this.Messagelbl.TabIndex = 13;
            this.Messagelbl.Text = "No Photo Uploaded";
            // 
            // Add_New_Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.Messagelbl);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAddBack);
            this.Controls.Add(this.AddPlatetxt);
            this.Controls.Add(this.AddPlate);
            this.Controls.Add(this.AddCaptxt);
            this.Controls.Add(this.AddCap);
            this.Controls.Add(this.AddModeltxt);
            this.Controls.Add(this.AddModel);
            this.Controls.Add(this.UpPic);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Add_New_Car";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Asset";
            this.Load += new System.EventHandler(this.Add_New_Car_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UpPic;
        private System.Windows.Forms.Label AddModel;
        private System.Windows.Forms.TextBox AddModeltxt;
        private System.Windows.Forms.TextBox AddCaptxt;
        private System.Windows.Forms.Label AddCap;
        private System.Windows.Forms.TextBox AddPlatetxt;
        private System.Windows.Forms.Label AddPlate;
        private System.Windows.Forms.Button btnAddBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog OpenDialog;
        private System.Windows.Forms.Label Messagelbl;
    }
}