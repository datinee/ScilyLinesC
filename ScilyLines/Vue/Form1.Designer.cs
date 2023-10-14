namespace Connecte
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
            this.listBoxSecteur = new System.Windows.Forms.ListBox();
            this.btn = new System.Windows.Forms.Button();
            this.listBoxLiaison = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxSecteur
            // 
            this.listBoxSecteur.FormattingEnabled = true;
            this.listBoxSecteur.ItemHeight = 16;
            this.listBoxSecteur.Location = new System.Drawing.Point(104, 6);
            this.listBoxSecteur.Name = "listBoxSecteur";
            this.listBoxSecteur.Size = new System.Drawing.Size(741, 356);
            this.listBoxSecteur.TabIndex = 23;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(401, 458);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(230, 64);
            this.btn.TabIndex = 24;
            this.btn.Text = "Valider";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // listBoxLiaison
            // 
            this.listBoxLiaison.FormattingEnabled = true;
            this.listBoxLiaison.ItemHeight = 16;
            this.listBoxLiaison.Location = new System.Drawing.Point(108, 32);
            this.listBoxLiaison.Name = "listBoxLiaison";
            this.listBoxLiaison.Size = new System.Drawing.Size(736, 324);
            this.listBoxLiaison.TabIndex = 25;
            this.listBoxLiaison.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 624);
            this.Controls.Add(this.listBoxLiaison);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.listBoxSecteur);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Gestion des secteurs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxSecteur;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ListBox listBoxLiaison;
    }
}

