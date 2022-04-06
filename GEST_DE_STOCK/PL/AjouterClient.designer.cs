namespace GEST_DE_STOCK.PL
{
    partial class AjouterClient
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
            this.labeltitre = new System.Windows.Forms.Label();
            this.nomclient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prenomclient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.telclient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emeilclient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adresseclient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.villeclient = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonactualiser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(9, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 2);
            this.panel1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(337, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 40);
            this.button2.TabIndex = 17;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labeltitre
            // 
            this.labeltitre.AutoSize = true;
            this.labeltitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitre.Location = new System.Drawing.Point(139, 35);
            this.labeltitre.Name = "labeltitre";
            this.labeltitre.Size = new System.Drawing.Size(180, 32);
            this.labeltitre.TabIndex = 32;
            this.labeltitre.Text = "Ajouter client";
            // 
            // nomclient
            // 
            this.nomclient.Location = new System.Drawing.Point(193, 135);
            this.nomclient.Multiline = true;
            this.nomclient.Name = "nomclient";
            this.nomclient.Size = new System.Drawing.Size(234, 26);
            this.nomclient.TabIndex = 36;
            this.nomclient.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nom_Client :";
            // 
            // prenomclient
            // 
            this.prenomclient.Location = new System.Drawing.Point(193, 184);
            this.prenomclient.Multiline = true;
            this.prenomclient.Name = "prenomclient";
            this.prenomclient.Size = new System.Drawing.Size(234, 26);
            this.prenomclient.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Prenom_Client :";
            // 
            // telclient
            // 
            this.telclient.Location = new System.Drawing.Point(193, 233);
            this.telclient.Multiline = true;
            this.telclient.Name = "telclient";
            this.telclient.Size = new System.Drawing.Size(234, 26);
            this.telclient.TabIndex = 40;
            this.telclient.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.telclient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Tel_Client :";
            // 
            // emeilclient
            // 
            this.emeilclient.Location = new System.Drawing.Point(193, 282);
            this.emeilclient.Multiline = true;
            this.emeilclient.Name = "emeilclient";
            this.emeilclient.Size = new System.Drawing.Size(234, 26);
            this.emeilclient.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Email_Client :";
            // 
            // adresseclient
            // 
            this.adresseclient.Location = new System.Drawing.Point(193, 331);
            this.adresseclient.Multiline = true;
            this.adresseclient.Name = "adresseclient";
            this.adresseclient.Size = new System.Drawing.Size(234, 54);
            this.adresseclient.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Adresse_Client :";
            // 
            // villeclient
            // 
            this.villeclient.Location = new System.Drawing.Point(193, 404);
            this.villeclient.Multiline = true;
            this.villeclient.Name = "villeclient";
            this.villeclient.Size = new System.Drawing.Size(234, 26);
            this.villeclient.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 45;
            this.label8.Text = "Ville :";
            // 
            // buttonactualiser
            // 
            this.buttonactualiser.Location = new System.Drawing.Point(9, 466);
            this.buttonactualiser.Name = "buttonactualiser";
            this.buttonactualiser.Size = new System.Drawing.Size(122, 40);
            this.buttonactualiser.TabIndex = 47;
            this.buttonactualiser.Text = "Actualiser";
            this.buttonactualiser.UseVisualStyleBackColor = true;
            this.buttonactualiser.Click += new System.EventHandler(this.button3_Click);
            // 
            // AjouterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 544);
            this.Controls.Add(this.buttonactualiser);
            this.Controls.Add(this.villeclient);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.adresseclient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.emeilclient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telclient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prenomclient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomclient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labeltitre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AjouterClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjouterClient";
            this.Load += new System.EventHandler(this.AjouterClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label labeltitre;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button buttonactualiser;
        public System.Windows.Forms.TextBox nomclient;
        public System.Windows.Forms.TextBox prenomclient;
        public System.Windows.Forms.TextBox telclient;
        public System.Windows.Forms.TextBox emeilclient;
        public System.Windows.Forms.TextBox adresseclient;
        public System.Windows.Forms.TextBox villeclient;
    }
}