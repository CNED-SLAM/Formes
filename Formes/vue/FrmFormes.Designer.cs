
namespace Formes.vue
{
    partial class FrmFormes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpForme = new System.Windows.Forms.GroupBox();
            this.TxtValeur = new System.Windows.Forms.TextBox();
            this.LblValeur = new System.Windows.Forms.Label();
            this.RdbSphere = new System.Windows.Forms.RadioButton();
            this.RdbCube = new System.Windows.Forms.RadioButton();
            this.RdbCercle = new System.Windows.Forms.RadioButton();
            this.RdbCarre = new System.Windows.Forms.RadioButton();
            this.grpMesures = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtVolume = new System.Windows.Forms.TextBox();
            this.TxtAire = new System.Windows.Forms.TextBox();
            this.TxtPerimetre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpForme.SuspendLayout();
            this.grpMesures.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpForme
            // 
            this.grpForme.Controls.Add(this.TxtValeur);
            this.grpForme.Controls.Add(this.LblValeur);
            this.grpForme.Controls.Add(this.RdbSphere);
            this.grpForme.Controls.Add(this.RdbCube);
            this.grpForme.Controls.Add(this.RdbCercle);
            this.grpForme.Controls.Add(this.RdbCarre);
            this.grpForme.Location = new System.Drawing.Point(12, 12);
            this.grpForme.Name = "grpForme";
            this.grpForme.Size = new System.Drawing.Size(254, 79);
            this.grpForme.TabIndex = 0;
            this.grpForme.TabStop = false;
            this.grpForme.Text = "forme";
            // 
            // TxtValeur
            // 
            this.TxtValeur.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtValeur.Location = new System.Drawing.Point(70, 47);
            this.TxtValeur.Name = "TxtValeur";
            this.TxtValeur.Size = new System.Drawing.Size(127, 22);
            this.TxtValeur.TabIndex = 0;
            this.TxtValeur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtValeur.TextChanged += new System.EventHandler(this.TxtValeur_TextChanged);
            // 
            // LblValeur
            // 
            this.LblValeur.AutoSize = true;
            this.LblValeur.Location = new System.Drawing.Point(6, 49);
            this.LblValeur.Name = "LblValeur";
            this.LblValeur.Size = new System.Drawing.Size(30, 15);
            this.LblValeur.TabIndex = 4;
            this.LblValeur.Text = "côté";
            // 
            // RdbSphere
            // 
            this.RdbSphere.AutoSize = true;
            this.RdbSphere.Location = new System.Drawing.Point(187, 22);
            this.RdbSphere.Name = "RdbSphere";
            this.RdbSphere.Size = new System.Drawing.Size(60, 19);
            this.RdbSphere.TabIndex = 3;
            this.RdbSphere.Text = "shpere";
            this.RdbSphere.UseVisualStyleBackColor = true;
            this.RdbSphere.CheckedChanged += new System.EventHandler(this.RdbSphere_CheckedChanged);
            // 
            // RdbCube
            // 
            this.RdbCube.AutoSize = true;
            this.RdbCube.Location = new System.Drawing.Point(68, 22);
            this.RdbCube.Name = "RdbCube";
            this.RdbCube.Size = new System.Drawing.Size(51, 19);
            this.RdbCube.TabIndex = 2;
            this.RdbCube.Text = "cube";
            this.RdbCube.UseVisualStyleBackColor = true;
            this.RdbCube.CheckedChanged += new System.EventHandler(this.RdbCube_CheckedChanged);
            // 
            // RdbCercle
            // 
            this.RdbCercle.AutoSize = true;
            this.RdbCercle.Location = new System.Drawing.Point(125, 22);
            this.RdbCercle.Name = "RdbCercle";
            this.RdbCercle.Size = new System.Drawing.Size(56, 19);
            this.RdbCercle.TabIndex = 1;
            this.RdbCercle.Text = "cercle";
            this.RdbCercle.UseVisualStyleBackColor = true;
            this.RdbCercle.CheckedChanged += new System.EventHandler(this.RdbCercle_CheckedChanged);
            // 
            // RdbCarre
            // 
            this.RdbCarre.AutoSize = true;
            this.RdbCarre.Checked = true;
            this.RdbCarre.Location = new System.Drawing.Point(6, 22);
            this.RdbCarre.Name = "RdbCarre";
            this.RdbCarre.Size = new System.Drawing.Size(51, 19);
            this.RdbCarre.TabIndex = 0;
            this.RdbCarre.TabStop = true;
            this.RdbCarre.Text = "carré";
            this.RdbCarre.UseVisualStyleBackColor = true;
            this.RdbCarre.CheckedChanged += new System.EventHandler(this.RdbCarre_CheckedChanged);
            // 
            // grpMesures
            // 
            this.grpMesures.Controls.Add(this.label3);
            this.grpMesures.Controls.Add(this.TxtVolume);
            this.grpMesures.Controls.Add(this.TxtAire);
            this.grpMesures.Controls.Add(this.TxtPerimetre);
            this.grpMesures.Controls.Add(this.label2);
            this.grpMesures.Controls.Add(this.label1);
            this.grpMesures.Location = new System.Drawing.Point(12, 97);
            this.grpMesures.Name = "grpMesures";
            this.grpMesures.Size = new System.Drawing.Size(254, 103);
            this.grpMesures.TabIndex = 2;
            this.grpMesures.TabStop = false;
            this.grpMesures.Text = "mesures";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "volume";
            // 
            // TxtVolume
            // 
            this.TxtVolume.Enabled = false;
            this.TxtVolume.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtVolume.Location = new System.Drawing.Point(70, 72);
            this.TxtVolume.Name = "TxtVolume";
            this.TxtVolume.Size = new System.Drawing.Size(127, 22);
            this.TxtVolume.TabIndex = 4;
            this.TxtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtAire
            // 
            this.TxtAire.Enabled = false;
            this.TxtAire.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAire.Location = new System.Drawing.Point(70, 44);
            this.TxtAire.Name = "TxtAire";
            this.TxtAire.Size = new System.Drawing.Size(127, 22);
            this.TxtAire.TabIndex = 3;
            this.TxtAire.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtPerimetre
            // 
            this.TxtPerimetre.Enabled = false;
            this.TxtPerimetre.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPerimetre.Location = new System.Drawing.Point(70, 16);
            this.TxtPerimetre.Name = "TxtPerimetre";
            this.TxtPerimetre.Size = new System.Drawing.Size(127, 22);
            this.TxtPerimetre.TabIndex = 2;
            this.TxtPerimetre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "aire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "périmètre";
            // 
            // FrmFormes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 209);
            this.Controls.Add(this.grpMesures);
            this.Controls.Add(this.grpForme);
            this.Name = "FrmFormes";
            this.Text = "Formes";
            this.grpForme.ResumeLayout(false);
            this.grpForme.PerformLayout();
            this.grpMesures.ResumeLayout(false);
            this.grpMesures.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpForme;
        private System.Windows.Forms.RadioButton RdbSphere;
        private System.Windows.Forms.RadioButton RdbCube;
        private System.Windows.Forms.RadioButton RdbCercle;
        private System.Windows.Forms.RadioButton RdbCarre;
        private System.Windows.Forms.TextBox TxtValeur;
        private System.Windows.Forms.GroupBox grpMesures;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtVolume;
        private System.Windows.Forms.TextBox TxtAire;
        private System.Windows.Forms.TextBox TxtPerimetre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblValeur;
    }
}

