namespace TriviaMaze
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
            this.wall = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.WinOrLose = new System.Windows.Forms.Label();
            this.door3 = new System.Windows.Forms.PictureBox();
            this.door2 = new System.Windows.Forms.PictureBox();
            this.door1 = new System.Windows.Forms.PictureBox();
            this.log1 = new System.Windows.Forms.PictureBox();
            this.log2 = new System.Windows.Forms.PictureBox();
            this.log3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.wall)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.door3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log3)).BeginInit();
            this.SuspendLayout();
            // 
            // wall
            // 
            this.wall.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.wall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wall.BackgroundImage")));
            this.wall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wall.Location = new System.Drawing.Point(0, 0);
            this.wall.Name = "wall";
            this.wall.Size = new System.Drawing.Size(601, 603);
            this.wall.TabIndex = 5;
            this.wall.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.WinOrLose);
            this.panel1.Location = new System.Drawing.Point(598, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 428);
            this.panel1.TabIndex = 10;
            this.panel1.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Raleway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(362, 278);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(183, 51);
            this.button5.TabIndex = 2;
            this.button5.Text = "Quit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Raleway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(131, 278);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 51);
            this.button4.TabIndex = 1;
            this.button4.Text = "Play Again";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // WinOrLose
            // 
            this.WinOrLose.BackColor = System.Drawing.Color.Transparent;
            this.WinOrLose.Font = new System.Drawing.Font("Raleway", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinOrLose.Location = new System.Drawing.Point(90, 116);
            this.WinOrLose.Name = "WinOrLose";
            this.WinOrLose.Size = new System.Drawing.Size(486, 60);
            this.WinOrLose.TabIndex = 0;
            this.WinOrLose.Text = "You won!";
            this.WinOrLose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // door3
            // 
            this.door3.BackColor = System.Drawing.Color.Transparent;
            this.door3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door3.Image = ((System.Drawing.Image)(resources.GetObject("door3.Image")));
            this.door3.Location = new System.Drawing.Point(400, 169);
            this.door3.Name = "door3";
            this.door3.Size = new System.Drawing.Size(201, 212);
            this.door3.TabIndex = 4;
            this.door3.TabStop = false;
            this.door3.Click += new System.EventHandler(this.door3_Click);
            // 
            // door2
            // 
            this.door2.BackColor = System.Drawing.Color.Transparent;
            this.door2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door2.Image = ((System.Drawing.Image)(resources.GetObject("door2.Image")));
            this.door2.Location = new System.Drawing.Point(193, 0);
            this.door2.Name = "door2";
            this.door2.Size = new System.Drawing.Size(201, 197);
            this.door2.TabIndex = 11;
            this.door2.TabStop = false;
            this.door2.Click += new System.EventHandler(this.door2_Click);
            // 
            // door1
            // 
            this.door1.BackColor = System.Drawing.Color.Transparent;
            this.door1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door1.Image = ((System.Drawing.Image)(resources.GetObject("door1.Image")));
            this.door1.Location = new System.Drawing.Point(0, 182);
            this.door1.Name = "door1";
            this.door1.Size = new System.Drawing.Size(201, 197);
            this.door1.TabIndex = 12;
            this.door1.TabStop = false;
            this.door1.Click += new System.EventHandler(this.door1_Click);
            // 
            // log1
            // 
            this.log1.BackColor = System.Drawing.Color.Transparent;
            this.log1.Image = ((System.Drawing.Image)(resources.GetObject("log1.Image")));
            this.log1.InitialImage = ((System.Drawing.Image)(resources.GetObject("log1.InitialImage")));
            this.log1.Location = new System.Drawing.Point(39, 260);
            this.log1.Name = "log1";
            this.log1.Size = new System.Drawing.Size(143, 100);
            this.log1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.log1.TabIndex = 13;
            this.log1.TabStop = false;
            // 
            // log2
            // 
            this.log2.BackColor = System.Drawing.Color.Transparent;
            this.log2.Image = ((System.Drawing.Image)(resources.GetObject("log2.Image")));
            this.log2.InitialImage = ((System.Drawing.Image)(resources.GetObject("log2.InitialImage")));
            this.log2.Location = new System.Drawing.Point(240, 55);
            this.log2.Name = "log2";
            this.log2.Size = new System.Drawing.Size(143, 100);
            this.log2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.log2.TabIndex = 14;
            this.log2.TabStop = false;
            // 
            // log3
            // 
            this.log3.BackColor = System.Drawing.Color.Transparent;
            this.log3.Image = ((System.Drawing.Image)(resources.GetObject("log3.Image")));
            this.log3.InitialImage = ((System.Drawing.Image)(resources.GetObject("log3.InitialImage")));
            this.log3.Location = new System.Drawing.Point(419, 269);
            this.log3.Name = "log3";
            this.log3.Size = new System.Drawing.Size(143, 100);
            this.log3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.log3.TabIndex = 15;
            this.log3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(601, 603);
            this.Controls.Add(this.log3);
            this.Controls.Add(this.log2);
            this.Controls.Add(this.log1);
            this.Controls.Add(this.door1);
            this.Controls.Add(this.door2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.door3);
            this.Controls.Add(this.wall);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Trivia Maze";
            ((System.ComponentModel.ISupportInitialize)(this.wall)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.door3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox wall;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label WinOrLose;
        private System.Windows.Forms.PictureBox door3;
        private System.Windows.Forms.PictureBox door2;
        private System.Windows.Forms.PictureBox door1;
        private System.Windows.Forms.PictureBox log1;
        private System.Windows.Forms.PictureBox log2;
        private System.Windows.Forms.PictureBox log3;
    }
}

