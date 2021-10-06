
namespace AddSub
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Subbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.ResulttextBox = new System.Windows.Forms.TextBox();
            this.Num2textBox = new System.Windows.Forms.TextBox();
            this.Num1TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Subbutton
            // 
            this.Subbutton.Location = new System.Drawing.Point(319, 93);
            this.Subbutton.Name = "Subbutton";
            this.Subbutton.Size = new System.Drawing.Size(94, 29);
            this.Subbutton.TabIndex = 0;
            this.Subbutton.Text = "Sub";
            this.Subbutton.UseVisualStyleBackColor = true;
            this.Subbutton.Click += new System.EventHandler(this.Subbutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(319, 160);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(94, 29);
            this.Addbutton.TabIndex = 1;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // ResulttextBox
            // 
            this.ResulttextBox.Location = new System.Drawing.Point(504, 126);
            this.ResulttextBox.Name = "ResulttextBox";
            this.ResulttextBox.Size = new System.Drawing.Size(125, 27);
            this.ResulttextBox.TabIndex = 2;
            // 
            // Num2textBox
            // 
            this.Num2textBox.Location = new System.Drawing.Point(100, 201);
            this.Num2textBox.Name = "Num2textBox";
            this.Num2textBox.Size = new System.Drawing.Size(125, 27);
            this.Num2textBox.TabIndex = 3;
            // 
            // Num1TextBox
            // 
            this.Num1TextBox.Location = new System.Drawing.Point(100, 65);
            this.Num1TextBox.Name = "Num1TextBox";
            this.Num1TextBox.Size = new System.Drawing.Size(125, 27);
            this.Num1TextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Num1TextBox);
            this.Controls.Add(this.Num2textBox);
            this.Controls.Add(this.ResulttextBox);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Subbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Subbutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.TextBox ResulttextBox;
        private System.Windows.Forms.TextBox Num2textBox;
        private System.Windows.Forms.TextBox Num1TextBox;
    }
}

