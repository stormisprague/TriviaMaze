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
            this.SuspendLayout();
            // 
            // answer4
            // 
            this.answer4.Location = new System.Drawing.Point(490, 225);
            this.answer4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(151, 61);
            this.answer4.TabIndex = 0;
            this.answer4.UseVisualStyleBackColor = true;
            this.answer4.Click += new System.EventHandler(this.button1_Click);
            // 
            // answer2
            // 
            this.answer2.Location = new System.Drawing.Point(172, 225);
            this.answer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(151, 59);
            this.answer2.TabIndex = 1;
            this.answer2.UseVisualStyleBackColor = true;
            this.answer2.Click += new System.EventHandler(this.button2_Click);
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Location = new System.Drawing.Point(10, 63);
            this.question.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(0, 17);
            this.question.TabIndex = 2;
            // 
            // answer3
            // 
            this.answer3.Location = new System.Drawing.Point(331, 225);
            this.answer3.Margin = new System.Windows.Forms.Padding(4);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(151, 59);
            this.answer3.TabIndex = 3;
            this.answer3.UseVisualStyleBackColor = true;
            this.answer3.Click += new System.EventHandler(this.answer3_Click);
            // 
            // answer1
            // 
            this.answer1.Location = new System.Drawing.Point(13, 225);
            this.answer1.Margin = new System.Windows.Forms.Padding(4);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(151, 59);
            this.answer1.TabIndex = 4;
            this.answer1.UseVisualStyleBackColor = true;
            this.answer1.Click += new System.EventHandler(this.answer1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 315);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.question);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Answer the Question!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button answer4;
        private System.Windows.Forms.Button answer2;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Button answer3;
        private System.Windows.Forms.Button answer1;
    }
}