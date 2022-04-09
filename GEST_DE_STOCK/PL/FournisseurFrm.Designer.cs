namespace GEST_DE_STOCK.PL
{
    partial class FournisseurFrm
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FournisseurFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.comborecherche = new Guna.UI.WinForms.GunaComboBox();
            this.recherchefournisseur = new Guna.UI.WinForms.GunaTextBox();
            this.gunaShadowPanel2 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaImageButton2 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.AddButton = new Guna.UI.WinForms.GunaImageButton();
            this.dataGridViewfourn = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idfournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomfournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailfournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressefournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaShadowPanel1.SuspendLayout();
            this.gunaShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfourn)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.gunaShadowPanel1.Controls.Add(this.comborecherche);
            this.gunaShadowPanel1.Controls.Add(this.recherchefournisseur);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(556, 4);
            this.gunaShadowPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(699, 78);
            this.gunaShadowPanel1.TabIndex = 6;
            // 
            // comborecherche
            // 
            this.comborecherche.BackColor = System.Drawing.Color.Transparent;
            this.comborecherche.BaseColor = System.Drawing.Color.White;
            this.comborecherche.BorderColor = System.Drawing.Color.Silver;
            this.comborecherche.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comborecherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comborecherche.FocusedColor = System.Drawing.Color.Empty;
            this.comborecherche.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comborecherche.ForeColor = System.Drawing.Color.Black;
            this.comborecherche.FormattingEnabled = true;
            this.comborecherche.Items.AddRange(new object[] {
            "ID Fournisseur",
            "Nom Fournisseur",
            "Email Fournisseur",
            "Adresse Fournisseur"});
            this.comborecherche.Location = new System.Drawing.Point(19, 20);
            this.comborecherche.Margin = new System.Windows.Forms.Padding(4);
            this.comborecherche.Name = "comborecherche";
            this.comborecherche.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comborecherche.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comborecherche.Size = new System.Drawing.Size(257, 31);
            this.comborecherche.TabIndex = 7;
            this.comborecherche.SelectedIndexChanged += new System.EventHandler(this.comborecherche_SelectedIndexChanged);
            // 
            // recherchefournisseur
            // 
            this.recherchefournisseur.BaseColor = System.Drawing.Color.White;
            this.recherchefournisseur.BorderColor = System.Drawing.Color.Silver;
            this.recherchefournisseur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.recherchefournisseur.FocusedBaseColor = System.Drawing.Color.White;
            this.recherchefournisseur.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.recherchefournisseur.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.recherchefournisseur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.recherchefournisseur.Location = new System.Drawing.Point(303, 20);
            this.recherchefournisseur.Margin = new System.Windows.Forms.Padding(4);
            this.recherchefournisseur.Name = "recherchefournisseur";
            this.recherchefournisseur.PasswordChar = '\0';
            this.recherchefournisseur.SelectedText = "";
            this.recherchefournisseur.Size = new System.Drawing.Size(377, 37);
            this.recherchefournisseur.TabIndex = 7;
            this.recherchefournisseur.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
            // 
            // gunaShadowPanel2
            // 
            this.gunaShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.gunaShadowPanel2.Controls.Add(this.gunaImageButton2);
            this.gunaShadowPanel2.Controls.Add(this.gunaImageButton1);
            this.gunaShadowPanel2.Controls.Add(this.AddButton);
            this.gunaShadowPanel2.Location = new System.Drawing.Point(224, 4);
            this.gunaShadowPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaShadowPanel2.Name = "gunaShadowPanel2";
            this.gunaShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel2.Size = new System.Drawing.Size(188, 78);
            this.gunaShadowPanel2.TabIndex = 7;
            // 
            // gunaImageButton2
            // 
            this.gunaImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton2.Image")));
            this.gunaImageButton2.ImageSize = new System.Drawing.Size(35, 35);
            this.gunaImageButton2.Location = new System.Drawing.Point(129, 17);
            this.gunaImageButton2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaImageButton2.Name = "gunaImageButton2";
            this.gunaImageButton2.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton2.OnHoverImage")));
            this.gunaImageButton2.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton2.Size = new System.Drawing.Size(48, 44);
            this.gunaImageButton2.TabIndex = 8;
            this.gunaImageButton2.Click += new System.EventHandler(this.gunaImageButton2_Click);
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.Image")));
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(35, 35);
            this.gunaImageButton1.Location = new System.Drawing.Point(73, 17);
            this.gunaImageButton1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.OnHoverImage")));
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(48, 44);
            this.gunaImageButton1.TabIndex = 7;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // AddButton
            // 
            this.AddButton.AccessibleName = "Ajouter";
            this.AddButton.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageSize = new System.Drawing.Size(35, 35);
            this.AddButton.Location = new System.Drawing.Point(17, 17);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("AddButton.OnHoverImage")));
            this.AddButton.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.AddButton.Size = new System.Drawing.Size(48, 44);
            this.AddButton.TabIndex = 6;
            this.AddButton.Tag = "Ajouter";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // dataGridViewfourn
            // 
            this.dataGridViewfourn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewfourn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewfourn.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewfourn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewfourn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewfourn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.idfournisseur,
            this.nomfournisseur,
            this.emailfournisseur,
            this.adressefournisseur});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(201)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewfourn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewfourn.EnableHeadersVisualStyles = false;
            this.dataGridViewfourn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.dataGridViewfourn.Location = new System.Drawing.Point(4, 107);
            this.dataGridViewfourn.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewfourn.Name = "dataGridViewfourn";
            this.dataGridViewfourn.RowHeadersWidth = 51;
            this.dataGridViewfourn.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewfourn.Size = new System.Drawing.Size(1419, 591);
            this.dataGridViewfourn.TabIndex = 8;
            // 
            // select
            // 
            this.select.HeaderText = "Sélectionner";
            this.select.MinimumWidth = 6;
            this.select.Name = "select";
            // 
            // idfournisseur
            // 
            this.idfournisseur.HeaderText = "ID Fournisseur";
            this.idfournisseur.MinimumWidth = 6;
            this.idfournisseur.Name = "idfournisseur";
            this.idfournisseur.ReadOnly = true;
            // 
            // nomfournisseur
            // 
            this.nomfournisseur.HeaderText = "Nom Fournisseur";
            this.nomfournisseur.MinimumWidth = 6;
            this.nomfournisseur.Name = "nomfournisseur";
            this.nomfournisseur.ReadOnly = true;
            // 
            // emailfournisseur
            // 
            this.emailfournisseur.HeaderText = "Email Fournisseur";
            this.emailfournisseur.MinimumWidth = 6;
            this.emailfournisseur.Name = "emailfournisseur";
            this.emailfournisseur.ReadOnly = true;
            // 
            // adressefournisseur
            // 
            this.adressefournisseur.HeaderText = "Adresse Fournisseur";
            this.adressefournisseur.MinimumWidth = 6;
            this.adressefournisseur.Name = "adressefournisseur";
            this.adressefournisseur.ReadOnly = true;
            // 
            // FournisseurFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewfourn);
            this.Controls.Add(this.gunaShadowPanel2);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FournisseurFrm";
            this.Size = new System.Drawing.Size(1427, 702);
            this.Load += new System.EventHandler(this.FournisseurFrm_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfourn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaComboBox comborecherche;
        private Guna.UI.WinForms.GunaTextBox recherchefournisseur;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel2;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton2;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private Guna.UI.WinForms.GunaImageButton AddButton;
        private System.Windows.Forms.DataGridView dataGridViewfourn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomfournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailfournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressefournisseur;
    }
}
