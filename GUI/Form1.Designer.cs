namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbVoiture = new System.Windows.Forms.RadioButton();
            this.rbMoto = new System.Windows.Forms.RadioButton();
            this.lstAutos = new System.Windows.Forms.ListBox();
            this.Immat = new System.Windows.Forms.Label();
            this.Annee = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnCaracterestiques = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.lblImmat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbVoiture
            // 
            this.rbVoiture.AutoSize = true;
            this.rbVoiture.Location = new System.Drawing.Point(28, 36);
            this.rbVoiture.Name = "rbVoiture";
            this.rbVoiture.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbVoiture.Size = new System.Drawing.Size(70, 20);
            this.rbVoiture.TabIndex = 0;
            this.rbVoiture.TabStop = true;
            this.rbVoiture.Text = "Voiture";
            this.rbVoiture.UseVisualStyleBackColor = true;
            // 
            // rbMoto
            // 
            this.rbMoto.AutoSize = true;
            this.rbMoto.Location = new System.Drawing.Point(137, 36);
            this.rbMoto.Name = "rbMoto";
            this.rbMoto.Size = new System.Drawing.Size(58, 20);
            this.rbMoto.TabIndex = 1;
            this.rbMoto.TabStop = true;
            this.rbMoto.Text = "Moto";
            this.rbMoto.UseVisualStyleBackColor = true;
            // 
            // lstAutos
            // 
            this.lstAutos.FormattingEnabled = true;
            this.lstAutos.ItemHeight = 16;
            this.lstAutos.Location = new System.Drawing.Point(28, 92);
            this.lstAutos.Name = "lstAutos";
            this.lstAutos.Size = new System.Drawing.Size(200, 196);
            this.lstAutos.TabIndex = 2;
            this.lstAutos.SelectedIndexChanged += new System.EventHandler(this.lstAutos_SelectedIndexChanged);
            // 
            // Immat
            // 
            this.Immat.AutoSize = true;
            this.Immat.Location = new System.Drawing.Point(401, 110);
            this.Immat.Name = "Immat";
            this.Immat.Size = new System.Drawing.Size(96, 16);
            this.Immat.TabIndex = 4;
            this.Immat.Text = "Immatriculation";
            // 
            // Annee
            // 
            this.Annee.AutoSize = true;
            this.Annee.Location = new System.Drawing.Point(401, 165);
            this.Annee.Name = "Annee";
            this.Annee.Size = new System.Drawing.Size(46, 16);
            this.Annee.TabIndex = 5;
            this.Annee.Text = "Annee";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(28, 324);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnCaracterestiques
            // 
            this.btnCaracterestiques.Location = new System.Drawing.Point(472, 314);
            this.btnCaracterestiques.Name = "btnCaracterestiques";
            this.btnCaracterestiques.Size = new System.Drawing.Size(147, 23);
            this.btnCaracterestiques.TabIndex = 7;
            this.btnCaracterestiques.Text = "Caractéristiques";
            this.btnCaracterestiques.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(146, 324);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(82, 23);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(401, 215);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(39, 16);
            this.Type.TabIndex = 9;
            this.Type.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mon Garage";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(585, 215);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 16);
            this.lblType.TabIndex = 13;
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Location = new System.Drawing.Point(585, 165);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(0, 16);
            this.lblAnnee.TabIndex = 12;
            // 
            // lblImmat
            // 
            this.lblImmat.AutoSize = true;
            this.lblImmat.Location = new System.Drawing.Point(585, 110);
            this.lblImmat.Name = "lblImmat";
            this.lblImmat.Size = new System.Drawing.Size(0, 16);
            this.lblImmat.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAnnee);
            this.Controls.Add(this.lblImmat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnCaracterestiques);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.Annee);
            this.Controls.Add(this.Immat);
            this.Controls.Add(this.lstAutos);
            this.Controls.Add(this.rbMoto);
            this.Controls.Add(this.rbVoiture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbVoiture;
        private System.Windows.Forms.RadioButton rbMoto;
        private System.Windows.Forms.ListBox lstAutos;
        private System.Windows.Forms.Label Immat;
        private System.Windows.Forms.Label Annee;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnCaracterestiques;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.Label lblImmat;
    }
}

