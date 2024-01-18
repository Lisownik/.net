
namespace FormsyPierwszyProjekt
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.php = new System.Windows.Forms.CheckBox();
            this.checkBoxcss = new System.Windows.Forms.CheckBox();
            this.DirectionOfFolder1 = new System.Windows.Forms.Button();
            this.textBoxofNewFolderName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxofDirection1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNazwa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxJs = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(12, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(910, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Stwórz Projekt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(644, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Projektant do szkoły";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // php
            // 
            this.php.AutoSize = true;
            this.php.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.php.Location = new System.Drawing.Point(52, 323);
            this.php.Name = "php";
            this.php.Padding = new System.Windows.Forms.Padding(10);
            this.php.Size = new System.Drawing.Size(102, 49);
            this.php.TabIndex = 4;
            this.php.Text = "PHP?";
            this.php.UseVisualStyleBackColor = true;
            // 
            // checkBoxcss
            // 
            this.checkBoxcss.AutoSize = true;
            this.checkBoxcss.Location = new System.Drawing.Point(242, 323);
            this.checkBoxcss.Name = "checkBoxcss";
            this.checkBoxcss.Size = new System.Drawing.Size(49, 17);
            this.checkBoxcss.TabIndex = 5;
            this.checkBoxcss.Text = "Css?";
            this.checkBoxcss.UseVisualStyleBackColor = true;
            this.checkBoxcss.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DirectionOfFolder1
            // 
            this.DirectionOfFolder1.Location = new System.Drawing.Point(308, 133);
            this.DirectionOfFolder1.Name = "DirectionOfFolder1";
            this.DirectionOfFolder1.Size = new System.Drawing.Size(139, 35);
            this.DirectionOfFolder1.TabIndex = 7;
            this.DirectionOfFolder1.Text = "...";
            this.DirectionOfFolder1.UseVisualStyleBackColor = true;
            this.DirectionOfFolder1.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxofNewFolderName
            // 
            this.textBoxofNewFolderName.Location = new System.Drawing.Point(95, 107);
            this.textBoxofNewFolderName.Name = "textBoxofNewFolderName";
            this.textBoxofNewFolderName.Size = new System.Drawing.Size(111, 20);
            this.textBoxofNewFolderName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(236, 9);
            this.label2.MinimumSize = new System.Drawing.Size(30, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tworzenie Foledru";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(621, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 61);
            this.button4.TabIndex = 9;
            this.button4.Text = "Utworzenie";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxofDirection1
            // 
            this.textBoxofDirection1.Location = new System.Drawing.Point(308, 107);
            this.textBoxofDirection1.Name = "textBoxofDirection1";
            this.textBoxofDirection1.Size = new System.Drawing.Size(139, 20);
            this.textBoxofDirection1.TabIndex = 10;
            this.textBoxofDirection1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nazwa Nowego Folderu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lokalizacja miejsca na folder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(236, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "Właściwości Plików";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.Location = new System.Drawing.Point(45, 297);
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.Size = new System.Drawing.Size(118, 20);
            this.textBoxNazwa.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(30, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nazwa pliku html";
            // 
            // checkBoxJs
            // 
            this.checkBoxJs.AutoSize = true;
            this.checkBoxJs.Location = new System.Drawing.Point(454, 323);
            this.checkBoxJs.Name = "checkBoxJs";
            this.checkBoxJs.Size = new System.Drawing.Size(42, 17);
            this.checkBoxJs.TabIndex = 16;
            this.checkBoxJs.Text = "Js?";
            this.checkBoxJs.UseVisualStyleBackColor = true;
            this.checkBoxJs.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 454);
            this.Controls.Add(this.checkBoxJs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNazwa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxofDirection1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DirectionOfFolder1);
            this.Controls.Add(this.textBoxofNewFolderName);
            this.Controls.Add(this.checkBoxcss);
            this.Controls.Add(this.php);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox php;
        private System.Windows.Forms.CheckBox checkBoxcss;
        private System.Windows.Forms.Button DirectionOfFolder1;
        private System.Windows.Forms.TextBox textBoxofNewFolderName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxofDirection1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNazwa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxJs;
    }
}

