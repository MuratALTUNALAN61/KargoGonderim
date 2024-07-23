namespace kargo_il
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
            components = new System.ComponentModel.Container();
            comboBox1 = new ComboBox();
            bindingSource1 = new BindingSource(components);
            comboBox2 = new ComboBox();
            textBoxTc = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            radioButtonBireysel = new RadioButton();
            radioButtonKurumsal = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxAd = new TextBox();
            textBoxSoyad = new TextBox();
            textBoxKurumAd = new TextBox();
            textBoxMersis = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(103, 241);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.Leave += comboBox1_Leave;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(347, 241);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 5;
            comboBox2.Leave += comboBox2_Leave;
            // 
            // textBoxTc
            // 
            textBoxTc.Location = new Point(124, 153);
            textBoxTc.MaxLength = 11;
            textBoxTc.Name = "textBoxTc";
            textBoxTc.Size = new Size(100, 23);
            textBoxTc.TabIndex = 3;
            textBoxTc.KeyPress += textBoxTc_KeyPress;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // radioButtonBireysel
            // 
            radioButtonBireysel.AutoSize = true;
            radioButtonBireysel.Location = new Point(115, 42);
            radioButtonBireysel.Name = "radioButtonBireysel";
            radioButtonBireysel.Size = new Size(119, 19);
            radioButtonBireysel.TabIndex = 55;
            radioButtonBireysel.TabStop = true;
            radioButtonBireysel.Text = "Bireysel Gönderici";
            radioButtonBireysel.UseVisualStyleBackColor = true;
            radioButtonBireysel.CheckedChanged += radioButtonBireysel_CheckedChanged;
            // 
            // radioButtonKurumsal
            // 
            radioButtonKurumsal.AutoSize = true;
            radioButtonKurumsal.Location = new Point(478, 42);
            radioButtonKurumsal.Name = "radioButtonKurumsal";
            radioButtonKurumsal.Size = new Size(129, 19);
            radioButtonKurumsal.TabIndex = 56;
            radioButtonKurumsal.TabStop = true;
            radioButtonKurumsal.Text = "Kurumsal Gönderici";
            radioButtonKurumsal.UseVisualStyleBackColor = true;
            radioButtonKurumsal.CheckedChanged += radioButtonKurumsal_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 86);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 6;
            label1.Text = "Ad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 115);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 7;
            label2.Text = "Soyad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 156);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 8;
            label3.Text = "Tc :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(408, 70);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 9;
            label4.Text = "Kurum Adı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(408, 103);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 10;
            label5.Text = "Mersis No :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 241);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 11;
            label6.Text = "İl :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(288, 244);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 12;
            label7.Text = "İlçe :";
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(124, 78);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(100, 23);
            textBoxAd.TabIndex = 1;
            // 
            // textBoxSoyad
            // 
            textBoxSoyad.Location = new Point(124, 112);
            textBoxSoyad.Name = "textBoxSoyad";
            textBoxSoyad.Size = new Size(100, 23);
            textBoxSoyad.TabIndex = 2;
            // 
            // textBoxKurumAd
            // 
            textBoxKurumAd.Location = new Point(507, 67);
            textBoxKurumAd.Name = "textBoxKurumAd";
            textBoxKurumAd.Size = new Size(100, 23);
            textBoxKurumAd.TabIndex = 15;
            // 
            // textBoxMersis
            // 
            textBoxMersis.Location = new Point(507, 103);
            textBoxMersis.Name = "textBoxMersis";
            textBoxMersis.Size = new Size(100, 23);
            textBoxMersis.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxMersis);
            Controls.Add(textBoxKurumAd);
            Controls.Add(textBoxSoyad);
            Controls.Add(textBoxAd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(radioButtonKurumsal);
            Controls.Add(radioButtonBireysel);
            Controls.Add(textBoxTc);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private BindingSource bindingSource1;
        private DataGridView dataGridView1;
        private ComboBox comboBox2;
        private TextBox textBoxTc;
        private ErrorProvider errorProvider1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton radioButtonKurumsal;
        private RadioButton radioButtonBireysel;
        private TextBox textBoxMersis;
        private TextBox textBoxKurumAd;
        private TextBox textBoxSoyad;
        private TextBox textBoxAd;
    }
}