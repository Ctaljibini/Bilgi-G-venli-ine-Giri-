namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.encrypt = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.decrypt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Messge:  ";
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(191, 135);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(75, 23);
            this.encrypt.TabIndex = 1;
            this.encrypt.Text = "encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(98, 32);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(196, 33);
            this.inputBox.TabIndex = 2;
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(110, 135);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(75, 23);
            this.decrypt.TabIndex = 1;
            this.decrypt.Text = "decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Key: ";
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(98, 71);
            this.keyBox.Multiline = true;
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(196, 33);
            this.keyBox.TabIndex = 2;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(300, 32);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(275, 268);
            this.output.TabIndex = 3;
            this.output.Text = "";
            this.output.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(191, 110);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(103, 110);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton1";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 312);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(603, 351);
            this.MinimumSize = new System.Drawing.Size(603, 351);
            this.Name = "Form1";
            this.Text = "Vigenere Cipher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

