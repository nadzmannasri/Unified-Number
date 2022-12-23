namespace unifiednumber
{
    partial class UnifiedNumber
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
            this.Valuetextbox = new System.Windows.Forms.TextBox();
            this.chinesecharbutton = new System.Windows.Forms.RadioButton();
            this.arabiccharbutton = new System.Windows.Forms.RadioButton();
            this.thaicharbutton = new System.Windows.Forms.RadioButton();
            this.translatebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.romanButton = new System.Windows.Forms.RadioButton();
            this.enterbutton = new System.Windows.Forms.Button();
            this.valuelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MsgLabel = new System.Windows.Forms.Label();
            this.answerlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Valuetextbox
            // 
            this.Valuetextbox.Location = new System.Drawing.Point(209, 70);
            this.Valuetextbox.Margin = new System.Windows.Forms.Padding(2);
            this.Valuetextbox.Name = "Valuetextbox";
            this.Valuetextbox.Size = new System.Drawing.Size(104, 20);
            this.Valuetextbox.TabIndex = 0;
            this.Valuetextbox.Text = "Please Insert Value";
            // 
            // chinesecharbutton
            // 
            this.chinesecharbutton.AutoSize = true;
            this.chinesecharbutton.Location = new System.Drawing.Point(209, 186);
            this.chinesecharbutton.Margin = new System.Windows.Forms.Padding(2);
            this.chinesecharbutton.Name = "chinesecharbutton";
            this.chinesecharbutton.Size = new System.Drawing.Size(112, 17);
            this.chinesecharbutton.TabIndex = 1;
            this.chinesecharbutton.TabStop = true;
            this.chinesecharbutton.Text = "Chinese Character";
            this.chinesecharbutton.UseVisualStyleBackColor = true;
            // 
            // arabiccharbutton
            // 
            this.arabiccharbutton.AutoSize = true;
            this.arabiccharbutton.Location = new System.Drawing.Point(209, 207);
            this.arabiccharbutton.Margin = new System.Windows.Forms.Padding(2);
            this.arabiccharbutton.Name = "arabiccharbutton";
            this.arabiccharbutton.Size = new System.Drawing.Size(104, 17);
            this.arabiccharbutton.TabIndex = 2;
            this.arabiccharbutton.TabStop = true;
            this.arabiccharbutton.Text = "Arabic Character";
            this.arabiccharbutton.UseVisualStyleBackColor = true;
            // 
            // thaicharbutton
            // 
            this.thaicharbutton.AutoSize = true;
            this.thaicharbutton.Location = new System.Drawing.Point(209, 228);
            this.thaicharbutton.Margin = new System.Windows.Forms.Padding(2);
            this.thaicharbutton.Name = "thaicharbutton";
            this.thaicharbutton.Size = new System.Drawing.Size(95, 17);
            this.thaicharbutton.TabIndex = 3;
            this.thaicharbutton.TabStop = true;
            this.thaicharbutton.Text = "Thai Character";
            this.thaicharbutton.UseVisualStyleBackColor = true;
            // 
            // translatebutton
            // 
            this.translatebutton.Location = new System.Drawing.Point(209, 266);
            this.translatebutton.Margin = new System.Windows.Forms.Padding(2);
            this.translatebutton.Name = "translatebutton";
            this.translatebutton.Size = new System.Drawing.Size(75, 19);
            this.translatebutton.TabIndex = 4;
            this.translatebutton.Text = "Translate";
            this.translatebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.translatebutton.UseVisualStyleBackColor = true;
            this.translatebutton.Click += new System.EventHandler(this.translatebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unified Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // romanButton
            // 
            this.romanButton.AutoSize = true;
            this.romanButton.Location = new System.Drawing.Point(209, 247);
            this.romanButton.Name = "romanButton";
            this.romanButton.Size = new System.Drawing.Size(99, 17);
            this.romanButton.TabIndex = 7;
            this.romanButton.TabStop = true;
            this.romanButton.Text = "Roman Number";
            this.romanButton.UseVisualStyleBackColor = true;
            // 
            // enterbutton
            // 
            this.enterbutton.Location = new System.Drawing.Point(318, 68);
            this.enterbutton.Name = "enterbutton";
            this.enterbutton.Size = new System.Drawing.Size(75, 23);
            this.enterbutton.TabIndex = 8;
            this.enterbutton.Text = "Enter";
            this.enterbutton.UseVisualStyleBackColor = true;
            this.enterbutton.Click += new System.EventHandler(this.enterbutton_Click);
            // 
            // valuelabel
            // 
            this.valuelabel.AutoSize = true;
            this.valuelabel.Location = new System.Drawing.Point(400, 73);
            this.valuelabel.Name = "valuelabel";
            this.valuelabel.Size = new System.Drawing.Size(0, 13);
            this.valuelabel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(59, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "- Please choose language before clicking translate -";
            // 
            // MsgLabel
            // 
            this.MsgLabel.AutoSize = true;
            this.MsgLabel.Location = new System.Drawing.Point(209, 100);
            this.MsgLabel.Name = "MsgLabel";
            this.MsgLabel.Size = new System.Drawing.Size(53, 13);
            this.MsgLabel.TabIndex = 11;
            this.MsgLabel.Text = "Message:";
            // 
            // answerlabel
            // 
            this.answerlabel.AutoSize = true;
            this.answerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerlabel.Location = new System.Drawing.Point(209, 302);
            this.answerlabel.Name = "answerlabel";
            this.answerlabel.Size = new System.Drawing.Size(105, 31);
            this.answerlabel.TabIndex = 12;
            this.answerlabel.Text = "Answer";
            // 
            // UnifiedNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.answerlabel);
            this.Controls.Add(this.MsgLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valuelabel);
            this.Controls.Add(this.enterbutton);
            this.Controls.Add(this.romanButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.translatebutton);
            this.Controls.Add(this.thaicharbutton);
            this.Controls.Add(this.arabiccharbutton);
            this.Controls.Add(this.chinesecharbutton);
            this.Controls.Add(this.Valuetextbox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UnifiedNumber";
            this.Text = "UnifiedNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Valuetextbox;
        private System.Windows.Forms.RadioButton chinesecharbutton;
        private System.Windows.Forms.RadioButton arabiccharbutton;
        private System.Windows.Forms.RadioButton thaicharbutton;
        private System.Windows.Forms.Button translatebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton romanButton;
        private System.Windows.Forms.Button enterbutton;
        private System.Windows.Forms.Label valuelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MsgLabel;
        private System.Windows.Forms.Label answerlabel;
    }
}

