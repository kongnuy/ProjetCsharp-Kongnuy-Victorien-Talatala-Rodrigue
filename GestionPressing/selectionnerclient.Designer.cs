namespace GestionPressing
{
    partial class selectionnerclient
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btselectionner = new System.Windows.Forms.Button();
            this.btannuller = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.lblgestionclientele.Size = new System.Drawing.Size(763, 54);
            this.lblgestionclientele.TabIndex = 2;
            this.lblgestionclientele.Text = "Choisir un client";
            this.lblgestionclientele.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(609, 308);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dataGridView1_CellStateChanged);
            // 
            // btselectionner
            // 
            this.btselectionner.Location = new System.Drawing.Point(357, 399);
            this.btselectionner.Name = "btselectionner";
            this.btselectionner.Size = new System.Drawing.Size(105, 29);
            this.btselectionner.TabIndex = 26;
            this.btselectionner.Text = "Selectionner";
            this.btselectionner.UseVisualStyleBackColor = true;
            this.btselectionner.Click += new System.EventHandler(this.btselectionner_Click);
            // 
            // btannuller
            // 
            this.btannuller.Location = new System.Drawing.Point(201, 399);
            this.btannuller.Name = "btannuller";
            this.btannuller.Size = new System.Drawing.Size(105, 29);
            this.btannuller.TabIndex = 25;
            this.btannuller.Text = "Annuller";
            this.btannuller.UseVisualStyleBackColor = true;
            this.btannuller.Click += new System.EventHandler(this.btannuller_Click);
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
            this.gpmodifierclient.Location = new System.Drawing.Point(627, 72);
            this.gpmodifierclient.Name = "gpmodifierclient";
            this.gpmodifierclient.Size = new System.Drawing.Size(127, 315);
            this.gpmodifierclient.TabIndex = 27;
            this.gpmodifierclient.TabStop = false;
            // 
            // txtmle
            // 
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
            // selectionnerclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 442);
            this.Controls.Add(this.gpmodifierclient);
            this.Controls.Add(this.btselectionner);
            this.Controls.Add(this.btannuller);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblgestionclientele);
            this.Name = "selectionnerclient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.selectionnerclient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpmodifierclient.ResumeLayout(false);
            this.gpmodifierclient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblgestionclientele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btselectionner;
        private System.Windows.Forms.Button btannuller;
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
    }
}