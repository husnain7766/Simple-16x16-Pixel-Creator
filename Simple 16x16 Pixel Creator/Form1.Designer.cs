using System.Windows.Forms;

namespace Simple_16x16_Pixel_Creator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.pixelColor = new System.Windows.Forms.Button();
            this.RotateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FlipButton = new System.Windows.Forms.Button();
            this.ShiftLeftButton = new System.Windows.Forms.Button();
            this.ShiftRightButton = new System.Windows.Forms.Button();
            this.ShiftUpButton = new System.Windows.Forms.Button();
            this.ShiftDownButton = new System.Windows.Forms.Button();
            this.ImageListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(75, 25);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(240, 20);
            this.FileName.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveButton.BackgroundImage")));
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Location = new System.Drawing.Point(340, 23);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(25, 25);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // pixelColor
            // 
            this.pixelColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pixelColor.ForeColor = System.Drawing.Color.Black;
            this.pixelColor.Location = new System.Drawing.Point(340, 81);
            this.pixelColor.Name = "pixelColor";
            this.pixelColor.Size = new System.Drawing.Size(25, 25);
            this.pixelColor.TabIndex = 3;
            this.pixelColor.UseVisualStyleBackColor = true;
            // 
            // RotateButton
            // 
            this.RotateButton.Location = new System.Drawing.Point(340, 116);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(25, 25);
            this.RotateButton.TabIndex = 4;
            this.RotateButton.Text = "R";
            this.RotateButton.UseVisualStyleBackColor = true;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(337, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pixel";
            // 
            // FlipButton
            // 
            this.FlipButton.Location = new System.Drawing.Point(340, 151);
            this.FlipButton.Name = "FlipButton";
            this.FlipButton.Size = new System.Drawing.Size(25, 25);
            this.FlipButton.TabIndex = 6;
            this.FlipButton.Text = "F";
            this.FlipButton.UseVisualStyleBackColor = true;
            this.FlipButton.Click += new System.EventHandler(this.FlipButton_Click);
            // 
            // ShiftLeftButton
            // 
            this.ShiftLeftButton.Location = new System.Drawing.Point(340, 185);
            this.ShiftLeftButton.Name = "ShiftLeftButton";
            this.ShiftLeftButton.Size = new System.Drawing.Size(25, 25);
            this.ShiftLeftButton.TabIndex = 7;
            this.ShiftLeftButton.Text = "<";
            this.ShiftLeftButton.UseVisualStyleBackColor = true;
            this.ShiftLeftButton.Click += new System.EventHandler(this.ShiftLeftButton_Click);
            // 
            // ShiftRightButton
            // 
            this.ShiftRightButton.Location = new System.Drawing.Point(340, 218);
            this.ShiftRightButton.Name = "ShiftRightButton";
            this.ShiftRightButton.Size = new System.Drawing.Size(25, 25);
            this.ShiftRightButton.TabIndex = 8;
            this.ShiftRightButton.Text = ">";
            this.ShiftRightButton.UseVisualStyleBackColor = true;
            this.ShiftRightButton.Click += new System.EventHandler(this.ShiftRightButton_Click);
            // 
            // ShiftUpButton
            // 
            this.ShiftUpButton.Location = new System.Drawing.Point(340, 249);
            this.ShiftUpButton.Name = "ShiftUpButton";
            this.ShiftUpButton.Size = new System.Drawing.Size(25, 25);
            this.ShiftUpButton.TabIndex = 9;
            this.ShiftUpButton.Text = "U";
            this.ShiftUpButton.UseVisualStyleBackColor = true;
            this.ShiftUpButton.Click += new System.EventHandler(this.ShiftUpButton_Click);
            // 
            // ShiftDownButton
            // 
            this.ShiftDownButton.Location = new System.Drawing.Point(340, 280);
            this.ShiftDownButton.Name = "ShiftDownButton";
            this.ShiftDownButton.Size = new System.Drawing.Size(25, 25);
            this.ShiftDownButton.TabIndex = 10;
            this.ShiftDownButton.Text = "D";
            this.ShiftDownButton.UseVisualStyleBackColor = true;
            this.ShiftDownButton.Click += new System.EventHandler(this.ShiftDownButton_Click);
            // 
            // ImageListView
            // 
            this.ImageListView.BackColor = System.Drawing.Color.Black;
            this.ImageListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ImageListView.ForeColor = System.Drawing.SystemColors.Info;
            this.ImageListView.GridLines = true;
            this.ImageListView.HideSelection = false;
            this.ImageListView.Location = new System.Drawing.Point(377, 23);
            this.ImageListView.Margin = new System.Windows.Forms.Padding(0);
            this.ImageListView.Name = "ImageListView";
            this.ImageListView.Size = new System.Drawing.Size(361, 633);
            this.ImageListView.TabIndex = 0;
            this.ImageListView.TileSize = new System.Drawing.Size(60, 60);
            this.ImageListView.UseCompatibleStateImageBehavior = false;
            this.ImageListView.View = System.Windows.Forms.View.Tile;
            this.ImageListView.SelectedIndexChanged += new System.EventHandler(this.ImageListView_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 668);
            this.Controls.Add(this.ImageListView);
            this.Controls.Add(this.ShiftDownButton);
            this.Controls.Add(this.ShiftUpButton);
            this.Controls.Add(this.ShiftRightButton);
            this.Controls.Add(this.ShiftLeftButton);
            this.Controls.Add(this.FlipButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RotateButton);
            this.Controls.Add(this.pixelColor);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pixel Art Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button[]colorGrid = new Button[256];
        private System.Windows.Forms.Button[,]image = new Button[16,16];
        private Label label1;
        private TextBox FileName;
        private Button SaveButton;
        private Button pixelColor;
        private Button RotateButton;
        private Label label2;
        private Button FlipButton;
        private Button ShiftLeftButton;
        private Button ShiftRightButton;
        private Button ShiftUpButton;
        private Button ShiftDownButton;
        private ListView ImageListView;
        private ColumnHeader columnHeader1;
    }
}

