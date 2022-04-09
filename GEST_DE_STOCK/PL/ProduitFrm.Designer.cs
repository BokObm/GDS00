namespace GEST_DE_STOCK.PL
{
    partial class ProduitFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProduitFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaShadowPanel2 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaImageButton2 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.AddButton = new Guna.UI.WinForms.GunaImageButton();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.comborechercheproduit = new Guna.UI.WinForms.GunaComboBox();
            this.rechercheproduit = new Guna.UI.WinForms.GunaTextBox();
            this.dataGridViewproduit = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idvente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomproduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idemploye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaShadowPanel2.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewproduit)).BeginInit();
            this.SuspendLayout();
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
            this.gunaShadowPanel2.TabIndex = 2;
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
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.gunaShadowPanel1.Controls.Add(this.comborechercheproduit);
            this.gunaShadowPanel1.Controls.Add(this.rechercheproduit);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(556, 4);
            this.gunaShadowPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(699, 78);
            this.gunaShadowPanel1.TabIndex = 3;
            // 
            // comborechercheproduit
            // 
            this.comborechercheproduit.BackColor = System.Drawing.Color.Transparent;
            this.comborechercheproduit.BaseColor = System.Drawing.Color.White;
            this.comborechercheproduit.BorderColor = System.Drawing.Color.Silver;
            this.comborechercheproduit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comborechercheproduit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comborechercheproduit.FocusedColor = System.Drawing.Color.Empty;
            this.comborechercheproduit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comborechercheproduit.ForeColor = System.Drawing.Color.Black;
            this.comborechercheproduit.FormattingEnabled = true;
            this.comborechercheproduit.Items.AddRange(new object[] {
            "ID Produit",
            "Nom Produit",
            "Date Entrée",
            "Quantité",
            "Heure",
            "Prix"});
            this.comborechercheproduit.Location = new System.Drawing.Point(19, 20);
            this.comborechercheproduit.Margin = new System.Windows.Forms.Padding(4);
            this.comborechercheproduit.Name = "comborechercheproduit";
            this.comborechercheproduit.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comborechercheproduit.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comborechercheproduit.Size = new System.Drawing.Size(257, 31);
            this.comborechercheproduit.TabIndex = 7;
            // 
            // rechercheproduit
            // 
            this.rechercheproduit.BaseColor = System.Drawing.Color.White;
            this.rechercheproduit.BorderColor = System.Drawing.Color.Silver;
            this.rechercheproduit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rechercheproduit.FocusedBaseColor = System.Drawing.Color.White;
            this.rechercheproduit.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rechercheproduit.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.rechercheproduit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rechercheproduit.Location = new System.Drawing.Point(303, 20);
            this.rechercheproduit.Margin = new System.Windows.Forms.Padding(4);
            this.rechercheproduit.Name = "rechercheproduit";
            this.rechercheproduit.PasswordChar = '\0';
            this.rechercheproduit.SelectedText = "";
            this.rechercheproduit.Size = new System.Drawing.Size(377, 37);
            this.rechercheproduit.TabIndex = 7;
            this.rechercheproduit.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
            // 
            // dataGridViewproduit
            // 
            this.dataGridViewproduit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewproduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewproduit.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewproduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewproduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewproduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.idvente,
            this.nomproduit,
            this.idemploye,
            this.idclient,
            this.Prix});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(201)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewproduit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewproduit.EnableHeadersVisualStyles = false;
            this.dataGridViewproduit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.dataGridViewproduit.Location = new System.Drawing.Point(4, 107);
            this.dataGridViewproduit.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewproduit.Name = "dataGridViewproduit";
            this.dataGridViewproduit.RowHeadersWidth = 51;
            this.dataGridViewproduit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewproduit.Size = new System.Drawing.Size(1419, 591);
            this.dataGridViewproduit.TabIndex = 4;
            // 
            // select
            // 
            this.select.HeaderText = "Sélectionner";
            this.select.MinimumWidth = 6;
            this.select.Name = "select";
            // 
            // idvente
            // 
            this.idvente.HeaderText = "ID Produit";
            this.idvente.MinimumWidth = 6;
            this.idvente.Name = "idvente";
            this.idvente.ReadOnly = true;
            // 
            // nomproduit
            // 
            this.nomproduit.HeaderText = "Nom Produit";
            this.nomproduit.MinimumWidth = 6;
            this.nomproduit.Name = "nomproduit";
            this.nomproduit.ReadOnly = true;
            // 
            // idemploye
            // 
            this.idemploye.HeaderText = "Date Entrée";
            this.idemploye.MinimumWidth = 6;
            this.idemploye.Name = "idemploye";
            this.idemploye.ReadOnly = true;
            // 
            // idclient
            // 
            this.idclient.HeaderText = "Quantité";
            this.idclient.MinimumWidth = 6;
            this.idclient.Name = "idclient";
            this.idclient.ReadOnly = true;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.MinimumWidth = 6;
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            // 
            // ProduitFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewproduit);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.gunaShadowPanel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProduitFrm";
            this.Size = new System.Drawing.Size(1427, 702);
            this.Load += new System.EventHandler(this.ProduitFrm_Load);
            this.gunaShadowPanel2.ResumeLayout(false);
            this.gunaShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewproduit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel2;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton2;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private Guna.UI.WinForms.GunaImageButton AddButton;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaComboBox comborechercheproduit;
        private Guna.UI.WinForms.GunaTextBox rechercheproduit;
        private System.Windows.Forms.DataGridView dataGridViewproduit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomproduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn idemploye;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
    }
}
