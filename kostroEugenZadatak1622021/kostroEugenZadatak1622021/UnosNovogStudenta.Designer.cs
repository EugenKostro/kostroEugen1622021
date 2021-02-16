namespace kostroEugenZadatak1622021
{
    partial class UnosNovogStudenta
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
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonSnimi = new System.Windows.Forms.Button();
            this.buttonOtkazi = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.labelSmjer = new System.Windows.Forms.Label();
            this.labelBrojIndeksa = new System.Windows.Forms.Label();
            this.labelDatumnRodjenja = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(55, 55);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(172, 20);
            this.textBoxIme.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(55, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(389, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 20);
            this.textBox3.TabIndex = 2;
            // 
            // buttonSnimi
            // 
            this.buttonSnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSnimi.Location = new System.Drawing.Point(55, 282);
            this.buttonSnimi.Name = "buttonSnimi";
            this.buttonSnimi.Size = new System.Drawing.Size(146, 45);
            this.buttonSnimi.TabIndex = 3;
            this.buttonSnimi.Text = "Snimi";
            this.buttonSnimi.UseVisualStyleBackColor = true;
            this.buttonSnimi.Click += new System.EventHandler(this.ButtonSnimi_Click);
            // 
            // buttonOtkazi
            // 
            this.buttonOtkazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonOtkazi.Location = new System.Drawing.Point(550, 282);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(146, 45);
            this.buttonOtkazi.TabIndex = 4;
            this.buttonOtkazi.Text = "Otkazi";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Programer",
            "Sistem administrator",
            "Mrezni administrator"});
            this.comboBox1.Location = new System.Drawing.Point(55, 180);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(389, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 23);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(55, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime:";
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPrezime.Location = new System.Drawing.Point(58, 95);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(63, 17);
            this.labelPrezime.TabIndex = 8;
            this.labelPrezime.Text = "Prezime:";
            // 
            // labelSmjer
            // 
            this.labelSmjer.AutoSize = true;
            this.labelSmjer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSmjer.Location = new System.Drawing.Point(58, 161);
            this.labelSmjer.Name = "labelSmjer";
            this.labelSmjer.Size = new System.Drawing.Size(44, 17);
            this.labelSmjer.TabIndex = 9;
            this.labelSmjer.Text = "Smjer";
            // 
            // labelBrojIndeksa
            // 
            this.labelBrojIndeksa.AutoSize = true;
            this.labelBrojIndeksa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelBrojIndeksa.Location = new System.Drawing.Point(389, 35);
            this.labelBrojIndeksa.Name = "labelBrojIndeksa";
            this.labelBrojIndeksa.Size = new System.Drawing.Size(90, 17);
            this.labelBrojIndeksa.TabIndex = 10;
            this.labelBrojIndeksa.Text = "Broj indeksa:";
            // 
            // labelDatumnRodjenja
            // 
            this.labelDatumnRodjenja.AutoSize = true;
            this.labelDatumnRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDatumnRodjenja.Location = new System.Drawing.Point(389, 94);
            this.labelDatumnRodjenja.Name = "labelDatumnRodjenja";
            this.labelDatumnRodjenja.Size = new System.Drawing.Size(104, 17);
            this.labelDatumnRodjenja.TabIndex = 11;
            this.labelDatumnRodjenja.Text = "Datum rodjenja";
            // 
            // UnosNovogStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(759, 399);
            this.Controls.Add(this.labelDatumnRodjenja);
            this.Controls.Add(this.labelBrojIndeksa);
            this.Controls.Add(this.labelSmjer);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonOtkazi);
            this.Controls.Add(this.buttonSnimi);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxIme);
            this.Name = "UnosNovogStudenta";
            this.Text = "UnosNovogStudenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonSnimi;
        private System.Windows.Forms.Button buttonOtkazi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.Label labelSmjer;
        private System.Windows.Forms.Label labelBrojIndeksa;
        private System.Windows.Forms.Label labelDatumnRodjenja;
    }
}