namespace GEST_DE_STOCK.PL
{
    partial class ClientFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaShadowPanel2 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaImageButton2 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.AddButton = new Guna.UI.WinForms.GunaImageButton();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaShadowPanel2.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaShadowPanel2
            // 
            this.gunaShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.gunaShadowPanel2.Controls.Add(this.gunaImageButton2);
            this.gunaShadowPanel2.Controls.Add(this.gunaImageButton1);
            this.gunaShadowPanel2.Controls.Add(this.AddButton);
            this.gunaShadowPanel2.Location = new System.Drawing.Point(168, 3);
            this.gunaShadowPanel2.Name = "gunaShadowPanel2";
            this.gunaShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel2.Size = new System.Drawing.Size(141, 63);
            this.gunaShadowPanel2.TabIndex = 4;
            // 
            // gunaImageButton2
            // 
            this.gunaImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton2.Image")));
            this.gunaImageButton2.ImageSize = new System.Drawing.Size(35, 35);
            this.gunaImageButton2.Location = new System.Drawing.Point(97, 14);
            this.gunaImageButton2.Name = "gunaImageButton2";
            this.gunaImageButton2.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton2.OnHoverImage")));
            this.gunaImageButton2.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton2.Size = new System.Drawing.Size(36, 36);
            this.gunaImageButton2.TabIndex = 8;
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.Image")));
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(35, 35);
            this.gunaImageButton1.Location = new System.Drawing.Point(55, 14);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.OnHoverImage")));
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(36, 36);
            this.gunaImageButton1.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.AccessibleName = "Ajouter";
            this.AddButton.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageSize = new System.Drawing.Size(35, 35);
            this.AddButton.Location = new System.Drawing.Point(13, 14);
            this.AddButton.Name = "AddButton";
            this.AddButton.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("AddButton.OnHoverImage")));
            this.AddButton.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.AddButton.Size = new System.Drawing.Size(36, 36);
            this.AddButton.TabIndex = 6;
            this.AddButton.Tag = "Ajouter";
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.gunaShadowPanel1.Controls.Add(this.gunaComboBox1);
            this.gunaShadowPanel1.Controls.Add(this.gunaTextBox1);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(417, 3);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(524, 63);
            this.gunaShadowPanel1.TabIndex = 5;
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Items.AddRange(new object[] {
            "ID Client",
            "Nom Client",
            "Prénom Client",
            "N° Téléphone",
            "Email Client",
            "Adresse Client",
            "Ville Client"});
            this.gunaComboBox1.Location = new System.Drawing.Point(14, 16);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Size = new System.Drawing.Size(194, 26);
            this.gunaComboBox1.TabIndex = 7;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(227, 16);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(283, 26);
            this.gunaTextBox1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.idclient,
            this.nomclient,
            this.prenomclient,
            this.telephoneclient,
            this.emailclient,
            this.adresseclient,
            this.villeclient});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(201)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(1064, 480);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // select
            // 
            this.select.HeaderText = "Sélectionner";
            this.select.Name = "select";
            // 
            // idclient
            // 
            this.idclient.HeaderText = "ID Client";
            this.idclient.Name = "idclient";
            this.idclient.ReadOnly = true;
            // 
            // nomclient
            // 
            this.nomclient.HeaderText = "Nom Client";
            this.nomclient.Name = "nomclient";
            this.nomclient.ReadOnly = true;
            // 
            // prenomclient
            // 
            this.prenomclient.HeaderText = "Prénom Client";
            this.prenomclient.Name = "prenomclient";
            this.prenomclient.ReadOnly = true;
            // 
            // telephoneclient
            // 
            this.telephoneclient.HeaderText = "N° Téléphone";
            this.telephoneclient.Name = "telephoneclient";
            this.telephoneclient.ReadOnly = true;
            // 
            // emailclient
            // 
            this.emailclient.HeaderText = "Email Client";
            this.emailclient.Name = "emailclient";
            this.emailclient.ReadOnly = true;
            // 
            // adresseclient
            // 
            this.adresseclient.HeaderText = "Adresse Client";
            this.adresseclient.Name = "adresseclient";
            this.adresseclient.ReadOnly = true;
            // 
            // villeclient
            // 
            this.villeclient.HeaderText = "Ville Client";
            this.villeclient.Name = "villeclient";
            this.villeclient.ReadOnly = true;
            // 
            // ClientFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.gunaShadowPanel2);
            this.Name = "ClientFrm";
            this.Size = new System.Drawing.Size(1070, 570);
            this.Load += new System.EventHandler(this.ClientFrm_Load);
            this.gunaShadowPanel2.ResumeLayout(false);
            this.gunaShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel2;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton2;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private Guna.UI.WinForms.GunaImageButton AddButton;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeclient;
    }
}
