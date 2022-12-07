namespace Test
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(45, 306);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(112, 34);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "print";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(325, 306);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(112, 34);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "clear";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(621, 306);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(112, 34);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "EXIT";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(199, 219);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(68, 25);
            this.label.TabIndex = 3;
            this.label.Text = "Result :";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(309, 219);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(59, 25);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "label2";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(271, 76);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(195, 31);
            this.txt.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Label label;
        private Label lblResult;
        private TextBox txt;
    }
}