namespace My_Paint
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label thicknessLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.squareButton = new System.Windows.Forms.Button();
            this.houseButton = new System.Windows.Forms.Button();
            this.triangleButton = new System.Windows.Forms.Button();
            this.ellipsebox = new System.Windows.Forms.PictureBox();
            this.rubberSelectLabel = new System.Windows.Forms.Label();
            this.lineSelectLabel = new System.Windows.Forms.Label();
            this.thicknessDropdown = new System.Windows.Forms.ComboBox();
            this.penSelectLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rectanglebox = new System.Windows.Forms.PictureBox();
            this.default1 = new System.Windows.Forms.PictureBox();
            this.triangleTimer = new System.Windows.Forms.Timer(this.components);
            this.houseTimer = new System.Windows.Forms.Timer(this.components);
            this.squareTimer = new System.Windows.Forms.Timer(this.components);
            thicknessLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ellipsebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectanglebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.default1)).BeginInit();
            this.SuspendLayout();
            // 
            // thicknessLabel
            // 
            thicknessLabel.AutoSize = true;
            thicknessLabel.Location = new System.Drawing.Point(208, 5);
            thicknessLabel.Name = "thicknessLabel";
            thicknessLabel.Size = new System.Drawing.Size(56, 13);
            thicknessLabel.TabIndex = 8;
            thicknessLabel.Text = "Thickness";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.squareButton);
            this.panel1.Controls.Add(this.houseButton);
            this.panel1.Controls.Add(this.triangleButton);
            this.panel1.Controls.Add(this.ellipsebox);
            this.panel1.Controls.Add(this.rubberSelectLabel);
            this.panel1.Controls.Add(this.lineSelectLabel);
            this.panel1.Controls.Add(this.thicknessDropdown);
            this.panel1.Controls.Add(thicknessLabel);
            this.panel1.Controls.Add(this.penSelectLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rectanglebox);
            this.panel1.Controls.Add(this.default1);
            this.panel1.Location = new System.Drawing.Point(245, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 109);
            this.panel1.TabIndex = 0;
            // 
            // squareButton
            // 
            this.squareButton.Location = new System.Drawing.Point(536, 76);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(75, 23);
            this.squareButton.TabIndex = 15;
            this.squareButton.Text = "Square";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // houseButton
            // 
            this.houseButton.Location = new System.Drawing.Point(438, 76);
            this.houseButton.Name = "houseButton";
            this.houseButton.Size = new System.Drawing.Size(75, 23);
            this.houseButton.TabIndex = 14;
            this.houseButton.Text = "House";
            this.houseButton.UseVisualStyleBackColor = true;
            this.houseButton.Click += new System.EventHandler(this.houseButton_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.Location = new System.Drawing.Point(341, 76);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(75, 23);
            this.triangleButton.TabIndex = 13;
            this.triangleButton.Text = "Triangle";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
            // 
            // ellipsebox
            // 
            this.ellipsebox.BackgroundImage = global::My_Paint.Properties.Resources.Screenshot_2;
            this.ellipsebox.Location = new System.Drawing.Point(451, 3);
            this.ellipsebox.Name = "ellipsebox";
            this.ellipsebox.Size = new System.Drawing.Size(62, 40);
            this.ellipsebox.TabIndex = 12;
            this.ellipsebox.TabStop = false;
            this.ellipsebox.Click += new System.EventHandler(this.ellipsebox_Click);
            // 
            // rubberSelectLabel
            // 
            this.rubberSelectLabel.AutoSize = true;
            this.rubberSelectLabel.Location = new System.Drawing.Point(191, 86);
            this.rubberSelectLabel.Name = "rubberSelectLabel";
            this.rubberSelectLabel.Size = new System.Drawing.Size(42, 13);
            this.rubberSelectLabel.TabIndex = 11;
            this.rubberSelectLabel.Text = "Rubber";
            this.rubberSelectLabel.Click += new System.EventHandler(this.rubberSelectLabel_Click);
            // 
            // lineSelectLabel
            // 
            this.lineSelectLabel.AutoSize = true;
            this.lineSelectLabel.Location = new System.Drawing.Point(141, 86);
            this.lineSelectLabel.Name = "lineSelectLabel";
            this.lineSelectLabel.Size = new System.Drawing.Size(27, 13);
            this.lineSelectLabel.TabIndex = 10;
            this.lineSelectLabel.Text = "Line";
            this.lineSelectLabel.Click += new System.EventHandler(this.lineSelectLabel_Click);
            // 
            // thicknessDropdown
            // 
            this.thicknessDropdown.FormattingEnabled = true;
            this.thicknessDropdown.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.thicknessDropdown.Location = new System.Drawing.Point(176, 35);
            this.thicknessDropdown.Name = "thicknessDropdown";
            this.thicknessDropdown.Size = new System.Drawing.Size(121, 21);
            this.thicknessDropdown.TabIndex = 9;
            this.thicknessDropdown.SelectionChangeCommitted += new System.EventHandler(this.thicknessDropdown_SelectionChangeCommitted);
            // 
            // penSelectLabel
            // 
            this.penSelectLabel.AutoSize = true;
            this.penSelectLabel.Location = new System.Drawing.Point(82, 86);
            this.penSelectLabel.Name = "penSelectLabel";
            this.penSelectLabel.Size = new System.Drawing.Size(26, 13);
            this.penSelectLabel.TabIndex = 7;
            this.penSelectLabel.Text = "Pen";
            this.penSelectLabel.Click += new System.EventHandler(this.penSelectLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose color";
            // 
            // rectanglebox
            // 
            this.rectanglebox.BackColor = System.Drawing.Color.Black;
            this.rectanglebox.BackgroundImage = global::My_Paint.Properties.Resources.Screenshot_1;
            this.rectanglebox.Location = new System.Drawing.Point(358, 3);
            this.rectanglebox.Name = "rectanglebox";
            this.rectanglebox.Size = new System.Drawing.Size(58, 40);
            this.rectanglebox.TabIndex = 5;
            this.rectanglebox.TabStop = false;
            this.rectanglebox.Click += new System.EventHandler(this.rectanglebox_Click);
            // 
            // default1
            // 
            this.default1.BackColor = System.Drawing.Color.Black;
            this.default1.Location = new System.Drawing.Point(3, 21);
            this.default1.Name = "default1";
            this.default1.Size = new System.Drawing.Size(118, 47);
            this.default1.TabIndex = 0;
            this.default1.TabStop = false;
            this.default1.Click += new System.EventHandler(this.default1_Click);
            // 
            // triangleTimer
            // 
            this.triangleTimer.Interval = 1000;
            this.triangleTimer.Tick += new System.EventHandler(this.triangleTimer_Tick);
            // 
            // houseTimer
            // 
            this.houseTimer.Interval = 1000;
            this.houseTimer.Tick += new System.EventHandler(this.houseTimer_Tick);
            // 
            // squareTimer
            // 
            this.squareTimer.Interval = 1000;
            this.squareTimer.Tick += new System.EventHandler(this.squareTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ellipsebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectanglebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.default1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox default1;
        private System.Windows.Forms.PictureBox rectanglebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label penSelectLabel;
        private System.Windows.Forms.ComboBox thicknessDropdown;
        private System.Windows.Forms.Label lineSelectLabel;
        private System.Windows.Forms.Label rubberSelectLabel;
        private System.Windows.Forms.PictureBox ellipsebox;
        private System.Windows.Forms.Button triangleButton;
        private System.Windows.Forms.Timer triangleTimer;
        private System.Windows.Forms.Button houseButton;
        private System.Windows.Forms.Timer houseTimer;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Timer squareTimer;
    }
}

