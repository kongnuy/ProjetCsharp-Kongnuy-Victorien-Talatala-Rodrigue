namespace GestionPressing
{
    partial class formulairevetement
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
            this.dtdatedispovetement = new System.Windows.Forms.DateTimePicker();
            this.dtdatedepotvetement = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpinfovetement = new System.Windows.Forms.GroupBox();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.cbtypevetement = new System.Windows.Forms.ComboBox();
            this.rdexistanttype = new System.Windows.Forms.RadioButton();
            this.rdnouveautype = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtquantitevetement = new System.Windows.Forms.TextBox();
            this.txttypevetement = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpulavage = new System.Windows.Forms.TextBox();
            this.txtputraitementtype = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpinfoclient = new System.Windows.Forms.GroupBox();
            this.txtmle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rdclientexistant = new System.Windows.Forms.RadioButton();
            this.rdclientnouveau = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtquartier = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btannuller = new System.Windows.Forms.Button();
            this.btenregistrer = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtdateeffretrait = new System.Windows.Forms.DateTimePicker();
            this.txtficherepassage = new System.Windows.Forms.Label();
            this.txtfichelavage = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtcompartiment = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btcreerfacture = new System.Windows.Forms.Button();
            this.gpinfovetement.SuspendLayout();
            this.gpinfoclient.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblgestionclientele
            // 
            this.lblgestionclientele.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblgestionclientele.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblgestionclientele.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgestionclientele.Location = new System.Drawing.Point(0, 0);
            this.lblgestionclientele.Name = "lblgestionclientele";
            this.lblgestionclientele.Size = new System.Drawing.Size(717, 54);
            this.lblgestionclientele.TabIndex = 1;
            this.lblgestionclientele.Text = "Enregistrer les vetements";
            this.lblgestionclientele.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtdatedispovetement
            // 
            this.dtdatedispovetement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdatedispovetement.Location = new System.Drawing.Point(9, 89);
            this.dtdatedispovetement.Name = "dtdatedispovetement";
            this.dtdatedispovetement.Size = new System.Drawing.Size(125, 20);
            this.dtdatedispovetement.TabIndex = 4;
            // 
            // dtdatedepotvetement
            // 
            this.dtdatedepotvetement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdatedepotvetement.Location = new System.Drawing.Point(6, 35);
            this.dtdatedepotvetement.Name = "dtdatedepotvetement";
            this.dtdatedepotvetement.Size = new System.Drawing.Size(128, 20);
            this.dtdatedepotvetement.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date de disponibilite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date de depot";
            // 
            // gpinfovetement
            // 
            this.gpinfovetement.Controls.Add(this.txtcod);
            this.gpinfovetement.Controls.Add(this.cbtypevetement);
            this.gpinfovetement.Controls.Add(this.rdexistanttype);
            this.gpinfovetement.Controls.Add(this.rdnouveautype);
            this.gpinfovetement.Controls.Add(this.label10);
            this.gpinfovetement.Controls.Add(this.txtquantitevetement);
            this.gpinfovetement.Controls.Add(this.txttypevetement);
            this.gpinfovetement.Controls.Add(this.label5);
            this.gpinfovetement.Controls.Add(this.label4);
            this.gpinfovetement.Controls.Add(this.txtpulavage);
            this.gpinfovetement.Controls.Add(this.txtputraitementtype);
            this.gpinfovetement.Controls.Add(this.label3);
            this.gpinfovetement.Location = new System.Drawing.Point(289, 71);
            this.gpinfovetement.Name = "gpinfovetement";
            this.gpinfovetement.Size = new System.Drawing.Size(259, 210);
            this.gpinfovetement.TabIndex = 8;
            this.gpinfovetement.TabStop = false;
            this.gpinfovetement.Text = "Information sur  le vetement";
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(174, 54);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(53, 20);
            this.txtcod.TabIndex = 28;
            this.txtcod.TextChanged += new System.EventHandler(this.txtcod_TextChanged);
            // 
            // cbtypevetement
            // 
            this.cbtypevetement.FormattingEnabled = true;
            this.cbtypevetement.Location = new System.Drawing.Point(4, 74);
            this.cbtypevetement.Name = "cbtypevetement";
            this.cbtypevetement.Size = new System.Drawing.Size(223, 21);
            this.cbtypevetement.TabIndex = 27;
            this.cbtypevetement.SelectedIndexChanged += new System.EventHandler(this.cbtypevetement_SelectedIndexChanged);
            // 
            // rdexistanttype
            // 
            this.rdexistanttype.AutoSize = true;
            this.rdexistanttype.Location = new System.Drawing.Point(4, 30);
            this.rdexistanttype.Name = "rdexistanttype";
            this.rdexistanttype.Size = new System.Drawing.Size(88, 17);
            this.rdexistanttype.TabIndex = 25;
            this.rdexistanttype.TabStop = true;
            this.rdexistanttype.Text = "Type existant";
            this.rdexistanttype.UseVisualStyleBackColor = true;
            this.rdexistanttype.CheckedChanged += new System.EventHandler(this.rdexistanttype_CheckedChanged);
            // 
            // rdnouveautype
            // 
            this.rdnouveautype.AutoSize = true;
            this.rdnouveautype.Location = new System.Drawing.Point(135, 30);
            this.rdnouveautype.Name = "rdnouveautype";
            this.rdnouveautype.Size = new System.Drawing.Size(92, 17);
            this.rdnouveautype.TabIndex = 24;
            this.rdnouveautype.TabStop = true;
            this.rdnouveautype.Text = "Nouveau type";
            this.rdnouveautype.UseVisualStyleBackColor = true;
            this.rdnouveautype.CheckedChanged += new System.EventHandler(this.rdnouveautype_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(121, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Quantite :";
            // 
            // txtquantitevetement
            // 
            this.txtquantitevetement.Location = new System.Drawing.Point(122, 180);
            this.txtquantitevetement.Name = "txtquantitevetement";
            this.txtquantitevetement.Size = new System.Drawing.Size(105, 20);
            this.txtquantitevetement.TabIndex = 22;
            // 
            // txttypevetement
            // 
            this.txttypevetement.Location = new System.Drawing.Point(6, 74);
            this.txttypevetement.Name = "txttypevetement";
            this.txttypevetement.Size = new System.Drawing.Size(218, 20);
            this.txttypevetement.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "PU de traitement :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "PU de lavage :";
            // 
            // txtpulavage
            // 
            this.txtpulavage.Location = new System.Drawing.Point(5, 180);
            this.txtpulavage.Name = "txtpulavage";
            this.txtpulavage.Size = new System.Drawing.Size(111, 20);
            this.txtpulavage.TabIndex = 10;
            // 
            // txtputraitementtype
            // 
            this.txtputraitementtype.Location = new System.Drawing.Point(6, 127);
            this.txtputraitementtype.Name = "txtputraitementtype";
            this.txtputraitementtype.Size = new System.Drawing.Size(218, 20);
            this.txtputraitementtype.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type :";
            // 
            // gpinfoclient
            // 
            this.gpinfoclient.Controls.Add(this.txtmle);
            this.gpinfoclient.Controls.Add(this.label11);
            this.gpinfoclient.Controls.Add(this.rdclientexistant);
            this.gpinfoclient.Controls.Add(this.rdclientnouveau);
            this.gpinfoclient.Controls.Add(this.label9);
            this.gpinfoclient.Controls.Add(this.txtquartier);
            this.gpinfoclient.Controls.Add(this.txtnom);
            this.gpinfoclient.Controls.Add(this.label6);
            this.gpinfoclient.Controls.Add(this.label7);
            this.gpinfoclient.Controls.Add(this.txttel);
            this.gpinfoclient.Controls.Add(this.txtprenom);
            this.gpinfoclient.Controls.Add(this.label8);
            this.gpinfoclient.Location = new System.Drawing.Point(27, 75);
            this.gpinfoclient.Name = "gpinfoclient";
            this.gpinfoclient.Size = new System.Drawing.Size(256, 210);
            this.gpinfoclient.TabIndex = 9;
            this.gpinfoclient.TabStop = false;
            this.gpinfoclient.Text = "Information du client";
            // 
            // txtmle
            // 
            this.txtmle.Location = new System.Drawing.Point(10, 73);
            this.txtmle.Name = "txtmle";
            this.txtmle.Size = new System.Drawing.Size(232, 20);
            this.txtmle.TabIndex = 29;
            this.txtmle.TextChanged += new System.EventHandler(this.txtmle_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Matricule :";
            // 
            // rdclientexistant
            // 
            this.rdclientexistant.AutoSize = true;
            this.rdclientexistant.Location = new System.Drawing.Point(8, 30);
            this.rdclientexistant.Name = "rdclientexistant";
            this.rdclientexistant.Size = new System.Drawing.Size(90, 17);
            this.rdclientexistant.TabIndex = 27;
            this.rdclientexistant.TabStop = true;
            this.rdclientexistant.Text = "Client existant";
            this.rdclientexistant.UseVisualStyleBackColor = true;
            this.rdclientexistant.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rdclientnouveau
            // 
            this.rdclientnouveau.AutoSize = true;
            this.rdclientnouveau.Location = new System.Drawing.Point(139, 30);
            this.rdclientnouveau.Name = "rdclientnouveau";
            this.rdclientnouveau.Size = new System.Drawing.Size(97, 17);
            this.rdclientnouveau.TabIndex = 26;
            this.rdclientnouveau.TabStop = true;
            this.rdclientnouveau.Text = "Nouveau client";
            this.rdclientnouveau.UseVisualStyleBackColor = true;
            this.rdclientnouveau.CheckedChanged += new System.EventHandler(this.rdclientnouveau_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(118, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Quartier :";
            // 
            // txtquartier
            // 
            this.txtquartier.Location = new System.Drawing.Point(121, 180);
            this.txtquartier.Name = "txtquartier";
            this.txtquartier.Size = new System.Drawing.Size(121, 20);
            this.txtquartier.TabIndex = 20;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(10, 127);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(105, 20);
            this.txtnom.TabIndex = 19;
            this.txtnom.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Prenom :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Telephone :";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(10, 180);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(105, 20);
            this.txttel.TabIndex = 16;
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(121, 127);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(121, 20);
            this.txtprenom.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nom :";
            // 
            // btannuller
            // 
            this.btannuller.Location = new System.Drawing.Point(133, 431);
            this.btannuller.Name = "btannuller";
            this.btannuller.Size = new System.Drawing.Size(105, 29);
            this.btannuller.TabIndex = 23;
            this.btannuller.Text = "Annuller";
            this.btannuller.UseVisualStyleBackColor = true;
            this.btannuller.Click += new System.EventHandler(this.button3_Click);
            // 
            // btenregistrer
            // 
            this.btenregistrer.Location = new System.Drawing.Point(279, 431);
            this.btenregistrer.Name = "btenregistrer";
            this.btenregistrer.Size = new System.Drawing.Size(105, 29);
            this.btenregistrer.TabIndex = 24;
            this.btenregistrer.Text = "Enregistrer";
            this.btenregistrer.UseVisualStyleBackColor = true;
            this.btenregistrer.Click += new System.EventHandler(this.btenregistrer_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.dtdateeffretrait);
            this.groupBox3.Controls.Add(this.txtficherepassage);
            this.groupBox3.Controls.Add(this.txtfichelavage);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtcompartiment);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dtdatedepotvetement);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtdatedispovetement);
            this.groupBox3.Location = new System.Drawing.Point(554, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 340);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Date effective de retrait :";
            // 
            // dtdateeffretrait
            // 
            this.dtdateeffretrait.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdateeffretrait.Location = new System.Drawing.Point(10, 137);
            this.dtdateeffretrait.Name = "dtdateeffretrait";
            this.dtdateeffretrait.Size = new System.Drawing.Size(124, 20);
            this.dtdateeffretrait.TabIndex = 49;
            // 
            // txtficherepassage
            // 
            this.txtficherepassage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtficherepassage.Location = new System.Drawing.Point(6, 300);
            this.txtficherepassage.Name = "txtficherepassage";
            this.txtficherepassage.Size = new System.Drawing.Size(128, 23);
            this.txtficherepassage.TabIndex = 46;
            this.txtficherepassage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtfichelavage
            // 
            this.txtfichelavage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtfichelavage.Location = new System.Drawing.Point(7, 240);
            this.txtfichelavage.Name = "txtfichelavage";
            this.txtfichelavage.Size = new System.Drawing.Size(127, 25);
            this.txtfichelavage.TabIndex = 45;
            this.txtfichelavage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 274);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "Fiche de repassage :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Fiche de lavage";
            // 
            // txtcompartiment
            // 
            this.txtcompartiment.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtcompartiment.Location = new System.Drawing.Point(7, 189);
            this.txtcompartiment.Name = "txtcompartiment";
            this.txtcompartiment.Size = new System.Drawing.Size(127, 21);
            this.txtcompartiment.TabIndex = 41;
            this.txtcompartiment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Compartiment :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 124);
            this.dataGridView1.TabIndex = 0;
            // 
            // btcreerfacture
            // 
            this.btcreerfacture.Location = new System.Drawing.Point(443, 431);
            this.btcreerfacture.Name = "btcreerfacture";
            this.btcreerfacture.Size = new System.Drawing.Size(105, 29);
            this.btcreerfacture.TabIndex = 27;
            this.btcreerfacture.Text = "Creer la facture";
            this.btcreerfacture.UseVisualStyleBackColor = true;
            this.btcreerfacture.Click += new System.EventHandler(this.btcreerfacture_Click);
            // 
            // formulairevetement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 472);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btcreerfacture);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btenregistrer);
            this.Controls.Add(this.btannuller);
            this.Controls.Add(this.gpinfoclient);
            this.Controls.Add(this.gpinfovetement);
            this.Controls.Add(this.lblgestionclientele);
            this.Name = "formulairevetement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formulairevetement_Load);
            this.gpinfovetement.ResumeLayout(false);
            this.gpinfovetement.PerformLayout();
            this.gpinfoclient.ResumeLayout(false);
            this.gpinfoclient.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblgestionclientele;
        private System.Windows.Forms.DateTimePicker dtdatedispovetement;
        private System.Windows.Forms.DateTimePicker dtdatedepotvetement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpinfovetement;
        private System.Windows.Forms.GroupBox gpinfoclient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpulavage;
        private System.Windows.Forms.TextBox txtputraitementtype;
        private System.Windows.Forms.TextBox txttypevetement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtquartier;
        private System.Windows.Forms.Button btannuller;
        private System.Windows.Forms.Button btenregistrer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtquantitevetement;
        private System.Windows.Forms.ComboBox cbtypevetement;
        private System.Windows.Forms.RadioButton rdexistanttype;
        private System.Windows.Forms.RadioButton rdnouveautype;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rdclientexistant;
        private System.Windows.Forms.RadioButton rdclientnouveau;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label txtcompartiment;
        private System.Windows.Forms.Label txtficherepassage;
        private System.Windows.Forms.Label txtfichelavage;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        internal System.Windows.Forms.TextBox txtmle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtdateeffretrait;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btcreerfacture;
        private System.Windows.Forms.TextBox txtcod;
    }
}