namespace UnifiedNumber
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
            this.Value = new System.Windows.Forms.TextBox();
            this.chinesecharbutton = new System.Windows.Forms.RadioButton();
            this.arabiccharbutton = new System.Windows.Forms.RadioButton();
            this.thaicharbutton = new System.Windows.Forms.RadioButton();
            this.translatebutton = new System.Windows.Forms.Button();
            this.AnswertextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(279, 86);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(137, 22);
            this.Value.TabIndex = 0;
            this.Value.Text = "Please Insert Value";
            // 
            // chinesecharbutton
            // 
            this.chinesecharbutton.AutoSize = true;
            this.chinesecharbutton.Location = new System.Drawing.Point(279, 115);
            this.chinesecharbutton.Name = "chinesecharbutton";
            this.chinesecharbutton.Size = new System.Drawing.Size(138, 20);
            this.chinesecharbutton.TabIndex = 1;
            this.chinesecharbutton.TabStop = true;
            this.chinesecharbutton.Text = "Chinese Character";
            this.chinesecharbutton.UseVisualStyleBackColor = true;
            // 
            // arabiccharbutton
            // 
            this.arabiccharbutton.AutoSize = true;
            this.arabiccharbutton.Location = new System.Drawing.Point(279, 142);
            this.arabiccharbutton.Name = "arabiccharbutton";
            this.arabiccharbutton.Size = new System.Drawing.Size(128, 20);
            this.arabiccharbutton.TabIndex = 2;
            this.arabiccharbutton.TabStop = true;
            this.arabiccharbutton.Text = "Arabic Character";
            this.arabiccharbutton.UseVisualStyleBackColor = true;
            // 
            // thaicharbutton
            // 
            this.thaicharbutton.AutoSize = true;
            this.thaicharbutton.Location = new System.Drawing.Point(279, 169);
            this.thaicharbutton.Name = "thaicharbutton";
            this.thaicharbutton.Size = new System.Drawing.Size(116, 20);
            this.thaicharbutton.TabIndex = 3;
            this.thaicharbutton.TabStop = true;
            this.thaicharbutton.Text = "Thai Character";
            this.thaicharbutton.UseVisualStyleBackColor = true;
            // 
            // translatebutton
            // 
            this.translatebutton.Location = new System.Drawing.Point(279, 196);
            this.translatebutton.Name = "translatebutton";
            this.translatebutton.Size = new System.Drawing.Size(100, 23);
            this.translatebutton.TabIndex = 4;
            this.translatebutton.Text = "Translate";
            this.translatebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.translatebutton.UseVisualStyleBackColor = true;
            // 
            // AnswertextBox
            // 
            this.AnswertextBox.Location = new System.Drawing.Point(228, 248);
            this.AnswertextBox.Name = "AnswertextBox";
            this.AnswertextBox.Size = new System.Drawing.Size(229, 22);
            this.AnswertextBox.TabIndex = 5;
            this.AnswertextBox.Text = "Answer";
            this.AnswertextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unified Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnswertextBox);
            this.Controls.Add(this.translatebutton);
            this.Controls.Add(this.thaicharbutton);
            this.Controls.Add(this.arabiccharbutton);
            this.Controls.Add(this.chinesecharbutton);
            this.Controls.Add(this.Value);
            this.Name = "Form1";
            this.Text = "UnifiedNumber";
 
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.RadioButton chinesecharbutton;
        private System.Windows.Forms.RadioButton arabiccharbutton;
        private System.Windows.Forms.RadioButton thaicharbutton;
        private System.Windows.Forms.Button translatebutton;
        private System.Windows.Forms.TextBox AnswertextBox;
        private System.Windows.Forms.Label label1;
    }
}

