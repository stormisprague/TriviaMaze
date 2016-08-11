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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.trim = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.wall = new System.Windows.Forms.PictureBox();
            this.room_num_label = new System.Windows.Forms.Label();
            this.d1_label = new System.Windows.Forms.Label();
            this.d2_label = new System.Windows.Forms.Label();
            this.d3_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(87, 145);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 271);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open door";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(373, 145);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 271);
            this.button2.TabIndex = 1;
            this.button2.Text = "Open door";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(656, 145);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 271);
            this.button3.TabIndex = 2;
            this.button3.Text = "Open door";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // trim
            // 
            this.trim.Location = new System.Drawing.Point(-1, 321);
            this.trim.Name = "trim";
            this.trim.Size = new System.Drawing.Size(690, 17);
            this.trim.TabIndex = 3;
            this.trim.TabStop = false;
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.floor.Location = new System.Drawing.Point(-56, 335);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(761, 127);
            this.floor.TabIndex = 4;
            this.floor.TabStop = false;
            // 
            // wall
            // 
            this.wall.BackColor = System.Drawing.Color.LightGreen;
            this.wall.Location = new System.Drawing.Point(-1, 0);
            this.wall.Name = "wall";
            this.wall.Size = new System.Drawing.Size(690, 329);
            this.wall.TabIndex = 5;
            this.wall.TabStop = false;
            // 
            // room_num_label
            // 
            this.room_num_label.AutoSize = true;
            this.room_num_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_num_label.Location = new System.Drawing.Point(218, 43);
            this.room_num_label.Name = "room_num_label";
            this.room_num_label.Size = new System.Drawing.Size(280, 39);
            this.room_num_label.TabIndex = 6;
            this.room_num_label.Text = "ROOM NUMBER";
            // 
            // d1_label
            // 
            this.d1_label.AutoSize = true;
            this.d1_label.Location = new System.Drawing.Point(111, 350);
            this.d1_label.Name = "d1_label";
            this.d1_label.Size = new System.Drawing.Size(46, 17);
            this.d1_label.TabIndex = 7;
            this.d1_label.Text = "label1";
            // 
            // d2_label
            // 
            this.d2_label.AutoSize = true;
            this.d2_label.Location = new System.Drawing.Point(319, 350);
            this.d2_label.Name = "d2_label";
            this.d2_label.Size = new System.Drawing.Size(46, 17);
            this.d2_label.TabIndex = 8;
            this.d2_label.Text = "label1";
            // 
            // d3_label
            // 
            this.d3_label.AutoSize = true;
            this.d3_label.Location = new System.Drawing.Point(539, 350);
            this.d3_label.Name = "d3_label";
            this.d3_label.Size = new System.Drawing.Size(46, 17);
            this.d3_label.TabIndex = 9;
            this.d3_label.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 425);
            this.Controls.Add(this.d3_label);
            this.Controls.Add(this.d2_label);
            this.Controls.Add(this.d1_label);
            this.Controls.Add(this.room_num_label);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trim);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.wall);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Trivia Maze";
            ((System.ComponentModel.ISupportInitialize)(this.trim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox trim;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox wall;
        private System.Windows.Forms.Label room_num_label;
        private System.Windows.Forms.Label d1_label;
        private System.Windows.Forms.Label d2_label;
        private System.Windows.Forms.Label d3_label;
    }
}

