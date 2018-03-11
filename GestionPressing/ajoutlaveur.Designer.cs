namespace GestionPressing
{
    partial class ajoutlaveur
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
            this.btenregistrerclient = new System.Windows.Forms.Button();
            this.btannullerajout = new System.Windows.Forms.Button();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblajouterclient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btenregistrerclient
            // 
            this.btenregistrerclient.Location = new System.Drawing.Point(231, 243);
            this.btenregistrerclient.Name = "btenregistrerclient";
            this.btenregistrerclient.Size = new System.Drawing.Size(94, 29);
            this.btenregistrerclient.TabIndex = 21;
            this.btenregistrerclient.Text = "Enregistrer";
            this.btenregistrerclient.UseVisualStyleBackColor = true;
            // 
            // btannullerajout
            // 
            this.btannullerajout.Location = new System.Drawing.Point(118, 242);
            this.btannullerajout.Name = "btannullerajout";
            this.btannullerajout.Size = new System.Drawing.Size(87, 30);
            this.btannullerajout.TabIndex = 20;
            this.btannullerajout.Text = "Annuller";
            this.btannullerajout.UseVisualStyleBackColor = true;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(191, 183);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(134, 20);
            this.txttel.TabIndex = 18;
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(191, 128);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(134, 20);
            this.txtprenom.TabIndex = 17;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(191, 74);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(134, 20);
            this.txtnom.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Telephone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Prenom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nom :";
            // 
            // lblajouterclient
            // 
            this.lblajouterclient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblajouterclient.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblajouterclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblajouterclient.Location = new System.Drawing.Point(0, 0);
            this.lblajouterclient.Name = "lblajouterclient";
            this.lblajouterclient.Size = new System.Drawing.Size(420, 29);
            this.lblajouterclient.TabIndex = 11;
            this.lblajouterclient.Text = "Ajouter un laveur";
            this.lblajouterclient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ajoutlaveur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 296);
            this.Controls.Add(this.btenregistrerclient);
            this.Controls.Add(this.btannullerajout);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblajouterclient);
            this.Name = "ajoutlaveur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btenregistrerclient;
        private System.Windows.Forms.Button btannullerajout;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblajouterclient;
    }
}