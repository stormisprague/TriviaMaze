namespace TriviaMaze
{
    partial class Form2
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
            this.answer4 = new System.Windows.Forms.Button();
            this.answer2 = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.Label();
            this.answer3 = new System.Windows.Forms.Button();
            this.answer1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // answer4
            // 
            this.answer4.BackColor = System.Drawing.SystemColors.Control;
            this.answer4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.answer4.Font = new System.Drawing.Font("Raleway", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer4.Location = new System.Drawing.Point(13, 360);
            this.answer4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(645, 61);
            this.answer4.TabIndex = 0;
            this.answer4.UseVisualStyleBackColor = false;
            this.answer4.Click += new System.EventHandler(this.button1_Click);
            // 
            // answer2
            // 
            this.answer2.BackColor = System.Drawing.SystemColors.Control;
            this.answer2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.answer2.Font = new System.Drawing.Font("Raleway", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer2.Location = new System.Drawing.Point(13, 226);
            this.answer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(645, 59);
            this.answer2.TabIndex = 1;
            this.answer2.UseVisualStyleBackColor = false;
            this.answer2.Click += new System.EventHandler(this.button2_Click);
            // 
            // question
            // 
            this.question.BackColor = System.Drawing.Color.Transparent;
            this.question.Font = new System.Drawing.Font("Raleway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.Location = new System.Drawing.Point(13, 14);
            this.question.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(576, 65);
            this.question.TabIndex = 2;
            this.question.Text = "Hello";
            // 
            // answer3
            // 
            this.answer3.BackColor = System.Drawing.SystemColors.Control;
            this.answer3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.answer3.Font = new System.Drawing.Font("Raleway", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer3.Location = new System.Drawing.Point(13, 293);
            this.answer3.Margin = new System.Windows.Forms.Padding(4);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(645, 59);
            this.answer3.TabIndex = 3;
            this.answer3.UseVisualStyleBackColor = false;
            this.answer3.Click += new System.EventHandler(this.answer3_Click);
            // 
            // answer1
            // 
            this.answer1.BackColor = System.Drawing.SystemColors.Control;
            this.answer1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.answer1.Font = new System.Drawing.Font("Raleway", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer1.Location = new System.Drawing.Point(13, 159);
            this.answer1.Margin = new System.Windows.Forms.Padding(4);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(645, 59);
            this.answer1.TabIndex = 4;
            this.answer1.UseVisualStyleBackColor = false;
            this.answer1.Click += new System.EventHandler(this.answer1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 131);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.question);
            this.panel2.Location = new System.Drawing.Point(20, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 92);
            this.panel2.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(671, 436);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button answer4;
        private System.Windows.Forms.Button answer2;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Button answer3;
        private System.Windows.Forms.Button answer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}