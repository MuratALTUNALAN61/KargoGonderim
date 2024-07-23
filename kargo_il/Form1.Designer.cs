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
            lblAd = new Label();
            lblSoyad = new Label();
            lblTc = new Label();
            lblKurum = new Label();
            lblMersis = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxAd = new TextBox();
            textBoxSoyad = new TextBox();
            textBoxKurumAd = new TextBox();
            textBoxMersis = new TextBox();
            btnKaydet = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(63, 118);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.Leave += comboBox1_Leave;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(245, 118);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(100, 23);
            comboBox2.TabIndex = 5;
            comboBox2.Leave += comboBox2_Leave;
            // 
            // textBoxTc
            // 
            textBoxTc.Location = new Point(63, 75);
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
            radioButtonBireysel.Location = new Point(12, 12);
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
            radioButtonKurumsal.Location = new Point(169, 12);
            radioButtonKurumsal.Name = "radioButtonKurumsal";
            radioButtonKurumsal.Size = new Size(129, 19);
            radioButtonKurumsal.TabIndex = 56;
            radioButtonKurumsal.TabStop = true;
            radioButtonKurumsal.Text = "Kurumsal Gönderici";
            radioButtonKurumsal.UseVisualStyleBackColor = true;
            radioButtonKurumsal.CheckedChanged += radioButtonKurumsal_CheckedChanged;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(12, 34);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 15);
            lblAd.TabIndex = 6;
            lblAd.Text = "Ad :";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(12, 57);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(45, 15);
            lblSoyad.TabIndex = 7;
            lblSoyad.Text = "Soyad :";
            // 
            // lblTc
            // 
            lblTc.AutoSize = true;
            lblTc.Location = new Point(12, 78);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(24, 15);
            lblTc.TabIndex = 8;
            lblTc.Text = "Tc :";
            // 
            // lblKurum
            // 
            lblKurum.AutoSize = true;
            lblKurum.Location = new Point(169, 34);
            lblKurum.Name = "lblKurum";
            lblKurum.Size = new Size(70, 15);
            lblKurum.TabIndex = 9;
            lblKurum.Text = "Kurum Adı :";
            // 
            // lblMersis
            // 
            lblMersis.AutoSize = true;
            lblMersis.Location = new Point(169, 57);
            lblMersis.Name = "lblMersis";
            lblMersis.Size = new Size(66, 15);
            lblMersis.TabIndex = 10;
            lblMersis.Text = "Mersis No :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 121);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 11;
            label6.Text = "İl :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(169, 121);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 12;
            label7.Text = "İlçe :";
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(63, 31);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(100, 23);
            textBoxAd.TabIndex = 1;
            // 
            // textBoxSoyad
            // 
            textBoxSoyad.Location = new Point(63, 54);
            textBoxSoyad.Name = "textBoxSoyad";
            textBoxSoyad.Size = new Size(100, 23);
            textBoxSoyad.TabIndex = 2;
            // 
            // textBoxKurumAd
            // 
            textBoxKurumAd.Location = new Point(245, 31);
            textBoxKurumAd.Name = "textBoxKurumAd";
            textBoxKurumAd.Size = new Size(100, 23);
            textBoxKurumAd.TabIndex = 15;
            // 
            // textBoxMersis
            // 
            textBoxMersis.Location = new Point(245, 54);
            textBoxMersis.Name = "textBoxMersis";
            textBoxMersis.Size = new Size(100, 23);
            textBoxMersis.TabIndex = 16;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(160, 208);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 57;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKaydet);
            Controls.Add(textBoxMersis);
            Controls.Add(textBoxKurumAd);
            Controls.Add(textBoxSoyad);
            Controls.Add(textBoxAd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblMersis);
            Controls.Add(lblKurum);
            Controls.Add(lblTc);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
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
        private Label lblMersis;
        private Label lblKurum;
        private Label lblTc;
        private Label lblSoyad;
        private Label lblAd;
        private RadioButton radioButtonKurumsal;
        private RadioButton radioButtonBireysel;
        private TextBox textBoxMersis;
        private TextBox textBoxKurumAd;
        private TextBox textBoxSoyad;
        private TextBox textBoxAd;
        private Button btnKaydet;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
    }
}