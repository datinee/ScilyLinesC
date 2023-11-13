namespace Connecte
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
            this.listBoxLiaison = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbMajDuree = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaj = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSup = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtbIdSecteur = new System.Windows.Forms.TextBox();
            this.txtbPortA = new System.Windows.Forms.TextBox();
            this.txtbPortD = new System.Windows.Forms.TextBox();
            this.txtbDuree = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIns = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxLiaison
            // 
            this.listBoxLiaison.FormattingEnabled = true;
            this.listBoxLiaison.ItemHeight = 16;
            this.listBoxLiaison.Location = new System.Drawing.Point(90, 54);
            this.listBoxLiaison.Name = "listBoxLiaison";
            this.listBoxLiaison.Size = new System.Drawing.Size(493, 116);
            this.listBoxLiaison.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMaj);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtbMajDuree);
            this.groupBox1.Location = new System.Drawing.Point(56, 333);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mise à jour";
            // 
            // txtbMajDuree
            // 
            this.txtbMajDuree.Location = new System.Drawing.Point(85, 33);
            this.txtbMajDuree.Name = "txtbMajDuree";
            this.txtbMajDuree.Size = new System.Drawing.Size(100, 22);
            this.txtbMajDuree.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Durée";
            // 
            // btnMaj
            // 
            this.btnMaj.Location = new System.Drawing.Point(60, 71);
            this.btnMaj.Name = "btnMaj";
            this.btnMaj.Size = new System.Drawing.Size(75, 23);
            this.btnMaj.TabIndex = 2;
            this.btnMaj.Text = "MAJ";
            this.btnMaj.UseVisualStyleBackColor = true;
            this.btnMaj.Click += new System.EventHandler(this.btnMaj_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSup);
            this.groupBox2.Location = new System.Drawing.Point(301, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Suppression";
            // 
            // btnSup
            // 
            this.btnSup.Location = new System.Drawing.Point(57, 43);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(83, 23);
            this.btnSup.TabIndex = 0;
            this.btnSup.Text = "Supprimer";
            this.btnSup.UseVisualStyleBackColor = true;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnIns);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtbDuree);
            this.groupBox3.Controls.Add(this.txtbPortD);
            this.groupBox3.Controls.Add(this.txtbPortA);
            this.groupBox3.Controls.Add(this.txtbIdSecteur);
            this.groupBox3.Location = new System.Drawing.Point(529, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 184);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insertion";
            // 
            // txtbIdSecteur
            // 
            this.txtbIdSecteur.Location = new System.Drawing.Point(105, 23);
            this.txtbIdSecteur.Name = "txtbIdSecteur";
            this.txtbIdSecteur.ReadOnly = true;
            this.txtbIdSecteur.Size = new System.Drawing.Size(100, 22);
            this.txtbIdSecteur.TabIndex = 0;
            // 
            // txtbPortA
            // 
            this.txtbPortA.Location = new System.Drawing.Point(105, 79);
            this.txtbPortA.Name = "txtbPortA";
            this.txtbPortA.Size = new System.Drawing.Size(100, 22);
            this.txtbPortA.TabIndex = 1;
            // 
            // txtbPortD
            // 
            this.txtbPortD.Location = new System.Drawing.Point(105, 51);
            this.txtbPortD.Name = "txtbPortD";
            this.txtbPortD.Size = new System.Drawing.Size(100, 22);
            this.txtbPortD.TabIndex = 2;
            // 
            // txtbDuree
            // 
            this.txtbDuree.Location = new System.Drawing.Point(105, 111);
            this.txtbDuree.Name = "txtbDuree";
            this.txtbDuree.Size = new System.Drawing.Size(100, 22);
            this.txtbDuree.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "idSecteur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "idPortDepart";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "idPortArrivee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "duree";
            // 
            // btnIns
            // 
            this.btnIns.Location = new System.Drawing.Point(90, 148);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(75, 23);
            this.btnIns.TabIndex = 8;
            this.btnIns.Text = "Insérer";
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxLiaison);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLiaison;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbMajDuree;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtbDuree;
        private System.Windows.Forms.TextBox txtbPortD;
        private System.Windows.Forms.TextBox txtbPortA;
        private System.Windows.Forms.TextBox txtbIdSecteur;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}