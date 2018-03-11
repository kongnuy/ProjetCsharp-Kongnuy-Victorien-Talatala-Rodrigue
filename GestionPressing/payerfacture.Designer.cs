namespace GestionPressing
{
    partial class payerfacture
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
            this.montanttotal = new System.Windows.Forms.Label();
            this.lblmontant = new System.Windows.Forms.Label();
            this.lblmontantpayer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblmention = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtmontant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btregler = new System.Windows.Forms.Button();
            this.btenregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblgestionclientele
            // 
            this.lblgestionclientele.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblgestionclientele.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblgestionclientele.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgestionclientele.Location = new System.Drawing.Point(0, 0);
            this.lblgestionclientele.Name = "lblgestionclientele";
            this.lblgestionclientele.Size = new System.Drawing.Size(305, 57);
            this.lblgestionclientele.TabIndex = 26;
            this.lblgestionclientele.Text = "Payer la facture";
            this.lblgestionclientele.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // montanttotal
            // 
            this.montanttotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.montanttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montanttotal.Location = new System.Drawing.Point(155, 89);
            this.montanttotal.Name = "montanttotal";
            this.montanttotal.Size = new System.Drawing.Size(110, 27);
            this.montanttotal.TabIndex = 36;
            this.montanttotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblmontant
            // 
            this.lblmontant.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmontant.Location = new System.Drawing.Point(38, 91);
            this.lblmontant.Name = "lblmontant";
            this.lblmontant.Size = new System.Drawing.Size(111, 24);
            this.lblmontant.TabIndex = 35;
            this.lblmontant.Text = "Montant de la facture :";
            this.lblmontant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblmontantpayer
            // 
            this.lblmontantpayer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmontantpayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmontantpayer.Location = new System.Drawing.Point(155, 128);
            this.lblmontantpayer.Name = "lblmontantpayer";
            this.lblmontantpayer.Size = new System.Drawing.Size(110, 27);
            this.lblmontantpayer.TabIndex = 38;
            this.lblmontantpayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(38, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 37;
            this.label5.Text = "Montant payé :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblmention
            // 
            this.lblmention.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmention.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmention.Location = new System.Drawing.Point(155, 169);
            this.lblmention.Name = "lblmention";
            this.lblmention.Size = new System.Drawing.Size(110, 27);
            this.lblmention.TabIndex = 44;
            this.lblmention.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(38, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 24);
            this.label12.TabIndex = 43;
            this.label12.Text = "Reste à payer :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtmontant
            // 
            this.txtmontant.Location = new System.Drawing.Point(155, 212);
            this.txtmontant.Name = "txtmontant";
            this.txtmontant.Size = new System.Drawing.Size(110, 20);
            this.txtmontant.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(38, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "entrer le montant :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btregler
            // 
            this.btregler.Location = new System.Drawing.Point(164, 257);
            this.btregler.Name = "btregler";
            this.btregler.Size = new System.Drawing.Size(101, 34);
            this.btregler.TabIndex = 48;
            this.btregler.Text = "Regler";
            this.btregler.UseVisualStyleBackColor = true;
            this.btregler.Click += new System.EventHandler(this.btimprimer_Click);
            // 
            // btenregistrer
            // 
            this.btenregistrer.Location = new System.Drawing.Point(41, 257);
            this.btenregistrer.Name = "btenregistrer";
            this.btenregistrer.Size = new System.Drawing.Size(95, 34);
            this.btenregistrer.TabIndex = 47;
            this.btenregistrer.Text = "Annuller";
            this.btenregistrer.UseVisualStyleBackColor = true;
            // 
            // payerfacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 315);
            this.Controls.Add(this.btregler);
            this.Controls.Add(this.btenregistrer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmontant);
            this.Controls.Add(this.lblmention);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblmontantpayer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.montanttotal);
            this.Controls.Add(this.lblmontant);
            this.Controls.Add(this.lblgestionclientele);
            this.Name = "payerfacture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.payerfacture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgestionclientele;
        private System.Windows.Forms.Label montanttotal;
        private System.Windows.Forms.Label lblmontant;
        private System.Windows.Forms.Label lblmontantpayer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblmention;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtmontant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btregler;
        private System.Windows.Forms.Button btenregistrer;
    }
}