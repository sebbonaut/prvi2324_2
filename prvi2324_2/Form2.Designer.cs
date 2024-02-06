namespace prvi2324_2
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownCijena = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownPopust = new System.Windows.Forms.NumericUpDown();
            this.gumbDodaj = new System.Windows.Forms.Button();
            this.labelaUpozorenje = new System.Windows.Forms.Label();
            this.gumbOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCijena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopust)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv artikla:";
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNaziv.Location = new System.Drawing.Point(223, 22);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(299, 38);
            this.textBoxNaziv.TabIndex = 1;
            this.textBoxNaziv.TextChanged += new System.EventHandler(this.textBoxNaziv_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cijena artikla:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Popust:";
            // 
            // numericUpDownCijena
            // 
            this.numericUpDownCijena.DecimalPlaces = 2;
            this.numericUpDownCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCijena.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownCijena.Location = new System.Drawing.Point(223, 124);
            this.numericUpDownCijena.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCijena.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownCijena.Name = "numericUpDownCijena";
            this.numericUpDownCijena.Size = new System.Drawing.Size(98, 38);
            this.numericUpDownCijena.TabIndex = 4;
            this.numericUpDownCijena.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "EUR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(327, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "%";
            // 
            // numericUpDownPopust
            // 
            this.numericUpDownPopust.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPopust.Location = new System.Drawing.Point(223, 178);
            this.numericUpDownPopust.Name = "numericUpDownPopust";
            this.numericUpDownPopust.Size = new System.Drawing.Size(98, 38);
            this.numericUpDownPopust.TabIndex = 7;
            // 
            // gumbDodaj
            // 
            this.gumbDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gumbDodaj.Location = new System.Drawing.Point(87, 252);
            this.gumbDodaj.Name = "gumbDodaj";
            this.gumbDodaj.Size = new System.Drawing.Size(148, 46);
            this.gumbDodaj.TabIndex = 8;
            this.gumbDodaj.Text = "Dodaj";
            this.gumbDodaj.UseVisualStyleBackColor = true;
            this.gumbDodaj.Click += new System.EventHandler(this.gumbDodaj_Click);
            // 
            // labelaUpozorenje
            // 
            this.labelaUpozorenje.AutoSize = true;
            this.labelaUpozorenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaUpozorenje.ForeColor = System.Drawing.Color.Red;
            this.labelaUpozorenje.Location = new System.Drawing.Point(82, 76);
            this.labelaUpozorenje.Name = "labelaUpozorenje";
            this.labelaUpozorenje.Size = new System.Drawing.Size(424, 25);
            this.labelaUpozorenje.TabIndex = 9;
            this.labelaUpozorenje.Text = "Naziv mora sadržavati bar jedan ne-blank znak!";
            // 
            // gumbOdustani
            // 
            this.gumbOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gumbOdustani.Location = new System.Drawing.Point(333, 252);
            this.gumbOdustani.Name = "gumbOdustani";
            this.gumbOdustani.Size = new System.Drawing.Size(148, 46);
            this.gumbOdustani.TabIndex = 10;
            this.gumbOdustani.Text = "Odustani";
            this.gumbOdustani.UseVisualStyleBackColor = true;
            this.gumbOdustani.Click += new System.EventHandler(this.gumbOdustani_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 323);
            this.Controls.Add(this.gumbOdustani);
            this.Controls.Add(this.labelaUpozorenje);
            this.Controls.Add(this.gumbDodaj);
            this.Controls.Add(this.numericUpDownPopust);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownCijena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Dodavanje artikla";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCijena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownCijena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownPopust;
        private System.Windows.Forms.Button gumbDodaj;
        private System.Windows.Forms.Label labelaUpozorenje;
        private System.Windows.Forms.Button gumbOdustani;
    }
}