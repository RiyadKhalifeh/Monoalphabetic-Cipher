namespace خوارزمية_الأبجدية_الأحادية
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPlan = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCipher = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonDecipher = new System.Windows.Forms.Button();
            this.textBoxCipher = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxDecipher = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPlan);
            this.groupBox1.Location = new System.Drawing.Point(1, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(525, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "النص الأصلي";
            // 
            // textBoxPlan
            // 
            this.textBoxPlan.Location = new System.Drawing.Point(11, 14);
            this.textBoxPlan.Multiline = true;
            this.textBoxPlan.Name = "textBoxPlan";
            this.textBoxPlan.Size = new System.Drawing.Size(420, 104);
            this.textBoxPlan.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCipher);
            this.groupBox2.Controls.Add(this.textBoxKey);
            this.groupBox2.Location = new System.Drawing.Point(1, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(525, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جدول التشفير";
            // 
            // buttonCipher
            // 
            this.buttonCipher.Location = new System.Drawing.Point(439, 23);
            this.buttonCipher.Name = "buttonCipher";
            this.buttonCipher.Size = new System.Drawing.Size(75, 35);
            this.buttonCipher.TabIndex = 1;
            this.buttonCipher.Text = "تشفير";
            this.buttonCipher.UseVisualStyleBackColor = true;
            this.buttonCipher.Click += new System.EventHandler(this.buttonCipher_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(11, 32);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(420, 24);
            this.textBoxKey.TabIndex = 0;
            this.textBoxKey.TextChanged += new System.EventHandler(this.textBoxKey_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDecipher);
            this.groupBox3.Controls.Add(this.textBoxCipher);
            this.groupBox3.Location = new System.Drawing.Point(1, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(525, 124);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "النص المشفر";
            // 
            // buttonDecipher
            // 
            this.buttonDecipher.Enabled = false;
            this.buttonDecipher.Location = new System.Drawing.Point(439, 46);
            this.buttonDecipher.Name = "buttonDecipher";
            this.buttonDecipher.Size = new System.Drawing.Size(75, 46);
            this.buttonDecipher.TabIndex = 2;
            this.buttonDecipher.Text = "فك التشفير";
            this.buttonDecipher.UseVisualStyleBackColor = true;
            this.buttonDecipher.Click += new System.EventHandler(this.buttonDecipher_Click);
            // 
            // textBoxCipher
            // 
            this.textBoxCipher.Location = new System.Drawing.Point(11, 14);
            this.textBoxCipher.Multiline = true;
            this.textBoxCipher.Name = "textBoxCipher";
            this.textBoxCipher.Size = new System.Drawing.Size(420, 104);
            this.textBoxCipher.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonClear);
            this.groupBox4.Controls.Add(this.textBoxDecipher);
            this.groupBox4.Location = new System.Drawing.Point(1, 403);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(525, 146);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "النص مفكوك التشفير";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(439, 55);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 35);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "مسح";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxDecipher
            // 
            this.textBoxDecipher.Location = new System.Drawing.Point(11, 23);
            this.textBoxDecipher.Multiline = true;
            this.textBoxDecipher.Name = "textBoxDecipher";
            this.textBoxDecipher.Size = new System.Drawing.Size(420, 104);
            this.textBoxDecipher.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 590);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الأبجدية الأحادية";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPlan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCipher;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonDecipher;
        private System.Windows.Forms.TextBox textBoxCipher;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxDecipher;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

