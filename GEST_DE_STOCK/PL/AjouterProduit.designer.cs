namespace GEST_DE_STOCK.PL

{
    partial class AjouterProduit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labeltitrepro = new System.Windows.Forms.Label();
            this.idproduit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nomproduit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qteproduit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prixproduit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateproduit = new System.Windows.Forms.DateTimePicker();
            this.buttonactualiserpro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(9, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 2);
            this.panel1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(337, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 40);
            this.button2.TabIndex = 19;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 40);
            this.button1.TabIndex = 18;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labeltitrepro
            // 
            this.labeltitrepro.AutoSize = true;
            this.labeltitrepro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitrepro.Location = new System.Drawing.Point(125, 39);
            this.labeltitrepro.Name = "labeltitrepro";
            this.labeltitrepro.Size = new System.Drawing.Size(200, 32);
            this.labeltitrepro.TabIndex = 33;
            this.labeltitrepro.Text = "Ajouter produit";
            this.labeltitrepro.Click += new System.EventHandler(this.label7_Click);
            // 
            // idproduit
            // 
            this.idproduit.Location = new System.Drawing.Point(193, 134);
            this.idproduit.Multiline = true;
            this.idproduit.Name = "idproduit";
            this.idproduit.Size = new System.Drawing.Size(234, 26);
            this.idproduit.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "ID_Produit :";
            // 
            // nomproduit
            // 
            this.nomproduit.Location = new System.Drawing.Point(193, 183);
            this.nomproduit.Multiline = true;
            this.nomproduit.Name = "nomproduit";
            this.nomproduit.Size = new System.Drawing.Size(234, 26);
            this.nomproduit.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nom_Produit :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Date-Entrée-Stock:";
            // 
            // qteproduit
            // 
            this.qteproduit.Location = new System.Drawing.Point(193, 281);
            this.qteproduit.Multiline = true;
            this.qteproduit.Name = "qteproduit";
            this.qteproduit.Size = new System.Drawing.Size(234, 26);
            this.qteproduit.TabIndex = 42;
            this.qteproduit.TextChanged += new System.EventHandler(this.qteproduit_TextChanged);
            this.qteproduit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Qte_Produit :";
            // 
            // prixproduit
            // 
            this.prixproduit.Location = new System.Drawing.Point(193, 330);
            this.prixproduit.Multiline = true;
            this.prixproduit.Name = "prixproduit";
            this.prixproduit.Size = new System.Drawing.Size(234, 26);
            this.prixproduit.TabIndex = 44;
            this.prixproduit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "Prix_Produit :";
            // 
            // dateproduit
            // 
            this.dateproduit.Location = new System.Drawing.Point(193, 234);
            this.dateproduit.Name = "dateproduit";
            this.dateproduit.Size = new System.Drawing.Size(234, 22);
            this.dateproduit.TabIndex = 45;
            // 
            // buttonactualiserpro
            // 
            this.buttonactualiserpro.Location = new System.Drawing.Point(9, 451);
            this.buttonactualiserpro.Name = "buttonactualiserpro";
            this.buttonactualiserpro.Size = new System.Drawing.Size(122, 40);
            this.buttonactualiserpro.TabIndex = 46;
            this.buttonactualiserpro.Text = "Actualiser";
            this.buttonactualiserpro.UseVisualStyleBackColor = true;
            this.buttonactualiserpro.Click += new System.EventHandler(this.button3_Click);
            // 
            // AjouterProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 516);
            this.Controls.Add(this.buttonactualiserpro);
            this.Controls.Add(this.dateproduit);
            this.Controls.Add(this.prixproduit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.qteproduit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomproduit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idproduit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labeltitrepro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AjouterProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjouterProduit";
            this.Load += new System.EventHandler(this.AjouterProduit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label labeltitrepro;
        public System.Windows.Forms.TextBox idproduit;
        public System.Windows.Forms.TextBox nomproduit;
        public System.Windows.Forms.TextBox qteproduit;
        public System.Windows.Forms.TextBox prixproduit;
        public System.Windows.Forms.DateTimePicker dateproduit;
        public System.Windows.Forms.Button buttonactualiserpro;
    }
}