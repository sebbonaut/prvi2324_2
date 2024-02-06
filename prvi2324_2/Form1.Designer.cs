namespace prvi2324_2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewRacuni = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPrikazSvih = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDodajNaRacun = new System.Windows.Forms.Button();
            this.dataGridViewArtikli = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRacuni)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRacuni
            // 
            this.dataGridViewRacuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRacuni.BackgroundColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRacuni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRacuni.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRacuni.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewRacuni.Name = "dataGridViewRacuni";
            this.dataGridViewRacuni.RowHeadersWidth = 51;
            this.dataGridViewRacuni.RowTemplate.Height = 24;
            this.dataGridViewRacuni.Size = new System.Drawing.Size(658, 183);
            this.dataGridViewRacuni.TabIndex = 0;
            this.dataGridViewRacuni.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRacuni_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prikaz podataka o računima";
            // 
            // buttonPrikazSvih
            // 
            this.buttonPrikazSvih.Font = new System.Drawing.Font("Open Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrikazSvih.Location = new System.Drawing.Point(230, 250);
            this.buttonPrikazSvih.Name = "buttonPrikazSvih";
            this.buttonPrikazSvih.Size = new System.Drawing.Size(247, 48);
            this.buttonPrikazSvih.TabIndex = 2;
            this.buttonPrikazSvih.Text = "Prikaz svih";
            this.buttonPrikazSvih.UseVisualStyleBackColor = true;
            this.buttonPrikazSvih.Click += new System.EventHandler(this.buttonPrikazSvih_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDodajNaRacun);
            this.groupBox1.Controls.Add(this.dataGridViewArtikli);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 226);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o odabranom računu";
            // 
            // buttonDodajNaRacun
            // 
            this.buttonDodajNaRacun.Font = new System.Drawing.Font("Open Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodajNaRacun.Location = new System.Drawing.Point(485, 75);
            this.buttonDodajNaRacun.Name = "buttonDodajNaRacun";
            this.buttonDodajNaRacun.Size = new System.Drawing.Size(153, 106);
            this.buttonDodajNaRacun.TabIndex = 4;
            this.buttonDodajNaRacun.Text = "Dodaj na račun";
            this.buttonDodajNaRacun.UseVisualStyleBackColor = true;
            this.buttonDodajNaRacun.Click += new System.EventHandler(this.buttonDodajNaRacun_Click);
            // 
            // dataGridViewArtikli
            // 
            this.dataGridViewArtikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewArtikli.BackgroundColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArtikli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewArtikli.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewArtikli.Location = new System.Drawing.Point(16, 55);
            this.dataGridViewArtikli.Name = "dataGridViewArtikli";
            this.dataGridViewArtikli.RowHeadersWidth = 51;
            this.dataGridViewArtikli.RowTemplate.Height = 24;
            this.dataGridViewArtikli.Size = new System.Drawing.Size(448, 151);
            this.dataGridViewArtikli.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonPrikazSvih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewRacuni);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podaci o računima";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRacuni)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRacuni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPrikazSvih;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewArtikli;
        private System.Windows.Forms.Button buttonDodajNaRacun;
    }
}

