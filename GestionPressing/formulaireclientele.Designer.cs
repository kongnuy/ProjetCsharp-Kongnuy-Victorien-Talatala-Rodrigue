namespace GestionPressing
{
    partial class formulaireclientele
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
            this.lblgestionclientele = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbquartier = new System.Windows.Forms.ComboBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.bttrier = new System.Windows.Forms.Button();
            this.cbnom = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gpdatagrid1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbajoutmodifsupprquit = new System.Windows.Forms.GroupBox();
            this.btquitter = new System.Windows.Forms.Button();
            this.btsupprimerclientele = new System.Windows.Forms.Button();
            this.btmodifierclientele = new System.Windows.Forms.Button();
            this.btajouterclientele = new System.Windows.Forms.Button();
            this.btclients = new System.Windows.Forms.Button();
            this.btvetements = new System.Windows.Forms.Button();
            this.btfactures = new System.Windows.Forms.Button();
            this.btdedomages = new System.Windows.Forms.Button();
            this.gpmodifierclient = new System.Windows.Forms.GroupBox();
            this.txtmle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtquartier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtidvet = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gpdatagrid1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbajoutmodifsupprquit.SuspendLayout();
            this.gpmodifierclient.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblgestionclientele
            // 
            this.lblgestionclientele.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblgestionclientele.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblgestionclientele.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgestionclientele.Location = new System.Drawing.Point(0, 0);
            this.lblgestionclientele.Name = "lblgestionclientele";
            this.lblgestionclientele.Size = new System.Drawing.Size(874, 54);
            this.lblgestionclientele.TabIndex = 0;
            this.lblgestionclientele.Text = "Service clientèle";
            this.lblgestionclientele.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtidvet);
            this.groupBox1.Controls.Add(this.cbquartier);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.bttrier);
            this.groupBox1.Controls.Add(this.cbnom);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(75, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trier par";
            // 
            // cbquartier
            // 
            this.cbquartier.FormattingEnabled = true;
            this.cbquartier.Location = new System.Drawing.Point(436, 43);
            this.cbquartier.Name = "cbquartier";
            this.cbquartier.Size = new System.Drawing.Size(129, 21);
            this.cbquartier.TabIndex = 9;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(436, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(59, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Quatier";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // bttrier
            // 
            this.bttrier.Location = new System.Drawing.Point(582, 34);
            this.bttrier.Name = "bttrier";
            this.bttrier.Size = new System.Drawing.Size(85, 29);
            this.bttrier.TabIndex = 7;
            this.bttrier.Text = "Trier";
            this.bttrier.UseVisualStyleBackColor = true;
            this.bttrier.Click += new System.EventHandler(this.bttrier_Click);
            // 
            // cbnom
            // 
            this.cbnom.FormattingEnabled = true;
            this.cbnom.Location = new System.Drawing.Point(301, 42);
            this.cbnom.Name = "cbnom";
            this.cbnom.Size = new System.Drawing.Size(124, 21);
            this.cbnom.TabIndex = 6;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(301, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nom";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(177, 47);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(101, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(48, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Au";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Du";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Date";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // gpdatagrid1
            // 
            this.gpdatagrid1.Controls.Add(this.dataGridView1);
            this.gpdatagrid1.Location = new System.Drawing.Point(75, 142);
            this.gpdatagrid1.Name = "gpdatagrid1";
            this.gpdatagrid1.Size = new System.Drawing.Size(571, 307);
            this.gpdatagrid1.TabIndex = 2;
            this.gpdatagrid1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(6, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 293);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gbajoutmodifsupprquit
            // 
            this.gbajoutmodifsupprquit.Controls.Add(this.btquitter);
            this.gbajoutmodifsupprquit.Controls.Add(this.btsupprimerclientele);
            this.gbajoutmodifsupprquit.Controls.Add(this.btmodifierclientele);
            this.gbajoutmodifsupprquit.Controls.Add(this.btajouterclientele);
            this.gbajoutmodifsupprquit.Location = new System.Drawing.Point(780, 142);
            this.gbajoutmodifsupprquit.Name = "gbajoutmodifsupprquit";
            this.gbajoutmodifsupprquit.Size = new System.Drawing.Size(85, 307);
            this.gbajoutmodifsupprquit.TabIndex = 3;
            this.gbajoutmodifsupprquit.TabStop = false;
            this.gbajoutmodifsupprquit.Enter += new System.EventHandler(this.gbajoutmodifsupprquit_Enter);
            // 
            // btquitter
            // 
            this.btquitter.Location = new System.Drawing.Point(7, 258);
            this.btquitter.Name = "btquitter";
            this.btquitter.Size = new System.Drawing.Size(71, 37);
            this.btquitter.TabIndex = 3;
            this.btquitter.Text = "Quitter";
            this.btquitter.UseVisualStyleBackColor = true;
            this.btquitter.Click += new System.EventHandler(this.btquitter_Click);
            // 
            // btsupprimerclientele
            // 
            this.btsupprimerclientele.Location = new System.Drawing.Point(6, 105);
            this.btsupprimerclientele.Name = "btsupprimerclientele";
            this.btsupprimerclientele.Size = new System.Drawing.Size(71, 37);
            this.btsupprimerclientele.TabIndex = 2;
            this.btsupprimerclientele.Text = "Supprimer";
            this.btsupprimerclientele.UseVisualStyleBackColor = true;
            this.btsupprimerclientele.Click += new System.EventHandler(this.btsupprimerclient_Click);
            // 
            // btmodifierclientele
            // 
            this.btmodifierclientele.Location = new System.Drawing.Point(6, 63);
            this.btmodifierclientele.Name = "btmodifierclientele";
            this.btmodifierclientele.Size = new System.Drawing.Size(71, 37);
            this.btmodifierclientele.TabIndex = 1;
            this.btmodifierclientele.Text = "Modifier";
            this.btmodifierclientele.UseVisualStyleBackColor = true;
            this.btmodifierclientele.Click += new System.EventHandler(this.btmodifierclient_Click);
            // 
            // btajouterclientele
            // 
            this.btajouterclientele.Location = new System.Drawing.Point(6, 16);
            this.btajouterclientele.Name = "btajouterclientele";
            this.btajouterclientele.Size = new System.Drawing.Size(71, 37);
            this.btajouterclientele.TabIndex = 0;
            this.btajouterclientele.Text = "Ajouter";
            this.btajouterclientele.UseVisualStyleBackColor = true;
            this.btajouterclientele.Click += new System.EventHandler(this.btajouterclient_Click);
            // 
            // btclients
            // 
            this.btclients.BackColor = System.Drawing.Color.Transparent;
            this.btclients.Location = new System.Drawing.Point(2, 56);
            this.btclients.Name = "btclients";
            this.btclients.Size = new System.Drawing.Size(73, 79);
            this.btclients.TabIndex = 4;
            this.btclients.Text = "Clients";
            this.btclients.UseVisualStyleBackColor = false;
            this.btclients.Click += new System.EventHandler(this.btclients_Click);
            // 
            // btvetements
            // 
            this.btvetements.BackColor = System.Drawing.Color.Transparent;
            this.btvetements.Location = new System.Drawing.Point(2, 131);
            this.btvetements.Name = "btvetements";
            this.btvetements.Size = new System.Drawing.Size(73, 82);
            this.btvetements.TabIndex = 5;
            this.btvetements.Text = "Vetements";
            this.btvetements.UseVisualStyleBackColor = false;
            this.btvetements.Click += new System.EventHandler(this.btvetements_Click);
            // 
            // btfactures
            // 
            this.btfactures.BackColor = System.Drawing.Color.Transparent;
            this.btfactures.Location = new System.Drawing.Point(2, 205);
            this.btfactures.Name = "btfactures";
            this.btfactures.Size = new System.Drawing.Size(73, 79);
            this.btfactures.TabIndex = 6;
            this.btfactures.Text = "Factures";
            this.btfactures.UseVisualStyleBackColor = false;
            this.btfactures.Click += new System.EventHandler(this.btfactures_Click);
            // 
            // btdedomages
            // 
            this.btdedomages.BackColor = System.Drawing.Color.Transparent;
            this.btdedomages.Location = new System.Drawing.Point(2, 281);
            this.btdedomages.Name = "btdedomages";
            this.btdedomages.Size = new System.Drawing.Size(73, 85);
            this.btdedomages.TabIndex = 7;
            this.btdedomages.Text = "Dedomages";
            this.btdedomages.UseVisualStyleBackColor = false;
            this.btdedomages.Click += new System.EventHandler(this.btdedomages_Click);
            // 
            // gpmodifierclient
            // 
            this.gpmodifierclient.Controls.Add(this.txtmle);
            this.gpmodifierclient.Controls.Add(this.label5);
            this.gpmodifierclient.Controls.Add(this.txtnom);
            this.gpmodifierclient.Controls.Add(this.label4);
            this.gpmodifierclient.Controls.Add(this.txtquartier);
            this.gpmodifierclient.Controls.Add(this.label3);
            this.gpmodifierclient.Controls.Add(this.label6);
            this.gpmodifierclient.Controls.Add(this.label7);
            this.gpmodifierclient.Controls.Add(this.txttel);
            this.gpmodifierclient.Controls.Add(this.txtprenom);
            this.gpmodifierclient.Enabled = false;
            this.gpmodifierclient.Location = new System.Drawing.Point(652, 142);
            this.gpmodifierclient.Name = "gpmodifierclient";
            this.gpmodifierclient.Size = new System.Drawing.Size(127, 307);
            this.gpmodifierclient.TabIndex = 25;
            this.gpmodifierclient.TabStop = false;
            // 
            // txtmle
            // 
            this.txtmle.Enabled = false;
            this.txtmle.Location = new System.Drawing.Point(7, 40);
            this.txtmle.Name = "txtmle";
            this.txtmle.Size = new System.Drawing.Size(114, 20);
            this.txtmle.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Matricule :";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(9, 93);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(113, 20);
            this.txtnom.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Quartier :";
            // 
            // txtquartier
            // 
            this.txtquartier.Location = new System.Drawing.Point(9, 277);
            this.txtquartier.Name = "txtquartier";
            this.txtquartier.Size = new System.Drawing.Size(112, 20);
            this.txtquartier.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Telephone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nom :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Prenom :";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(8, 222);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(113, 20);
            this.txttel.TabIndex = 18;
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(9, 154);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(112, 20);
            this.txtprenom.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(2, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 85);
            this.button1.TabIndex = 8;
            this.button1.Text = "Archives";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtidvet
            // 
            this.txtidvet.Location = new System.Drawing.Point(683, 42);
            this.txtidvet.Name = "txtidvet";
            this.txtidvet.Size = new System.Drawing.Size(113, 20);
            this.txtidvet.TabIndex = 17;
            // 
            // formulaireclientele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(874, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpmodifierclient);
            this.Controls.Add(this.btdedomages);
            this.Controls.Add(this.btfactures);
            this.Controls.Add(this.btvetements);
            this.Controls.Add(this.btclients);
            this.Controls.Add(this.gbajoutmodifsupprquit);
            this.Controls.Add(this.gpdatagrid1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblgestionclientele);
            this.Name = "formulaireclientele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formulaireclientele_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpdatagrid1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbajoutmodifsupprquit.ResumeLayout(false);
            this.gpmodifierclient.ResumeLayout(false);
            this.gpmodifierclient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblgestionclientele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttrier;
        private System.Windows.Forms.ComboBox cbnom;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox gpdatagrid1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbajoutmodifsupprquit;
        private System.Windows.Forms.Button btquitter;
        private System.Windows.Forms.Button btsupprimerclientele;
        private System.Windows.Forms.Button btmodifierclientele;
        private System.Windows.Forms.Button btajouterclientele;
        private System.Windows.Forms.ComboBox cbquartier;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btclients;
        private System.Windows.Forms.Button btvetements;
        private System.Windows.Forms.Button btfactures;
        private System.Windows.Forms.Button btdedomages;
        private System.Windows.Forms.GroupBox gpmodifierclient;
        private System.Windows.Forms.TextBox txtmle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtquartier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtidvet;
    }
}

