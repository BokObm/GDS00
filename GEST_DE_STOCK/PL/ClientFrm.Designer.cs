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
            this.combochercheclient = new Guna.UI.WinForms.GunaComboBox();
            this.rechercheclient = new Guna.UI.WinForms.GunaTextBox();
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
            this.gunaShadowPanel2.Location = new System.Drawing.Point(224, 4);
            this.gunaShadowPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaShadowPanel2.Name = "gunaShadowPanel2";
            this.gunaShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel2.Size = new System.Drawing.Size(188, 78);
            this.gunaShadowPanel2.TabIndex = 4;
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
            this.gunaShadowPanel1.Controls.Add(this.combochercheclient);
            this.gunaShadowPanel1.Controls.Add(this.rechercheclient);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(556, 4);
            this.gunaShadowPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(699, 78);
            this.gunaShadowPanel1.TabIndex = 5;
            // 
            // combochercheclient
            // 
            this.combochercheclient.BackColor = System.Drawing.Color.Transparent;
            this.combochercheclient.BaseColor = System.Drawing.Color.White;
            this.combochercheclient.BorderColor = System.Drawing.Color.Silver;
            this.combochercheclient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combochercheclient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combochercheclient.FocusedColor = System.Drawing.Color.Empty;
            this.combochercheclient.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combochercheclient.ForeColor = System.Drawing.Color.Black;
            this.combochercheclient.FormattingEnabled = true;
            this.combochercheclient.Items.AddRange(new object[] {
            "ID Client",
            "Nom Client",
            "Prénom Client",
            "N° Téléphone",
            "Email Client",
            "Adresse Client",
            "Ville Client"});
            this.combochercheclient.Location = new System.Drawing.Point(19, 20);
            this.combochercheclient.Margin = new System.Windows.Forms.Padding(4);
            this.combochercheclient.Name = "combochercheclient";
            this.combochercheclient.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.combochercheclient.OnHoverItemForeColor = System.Drawing.Color.White;
            this.combochercheclient.Size = new System.Drawing.Size(257, 31);
            this.combochercheclient.TabIndex = 7;
            this.combochercheclient.SelectedIndexChanged += new System.EventHandler(this.combochercheclient_SelectedIndexChanged);
            // 
            // rechercheclient
            // 
            this.rechercheclient.BaseColor = System.Drawing.Color.White;
            this.rechercheclient.BorderColor = System.Drawing.Color.Silver;
            this.rechercheclient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rechercheclient.FocusedBaseColor = System.Drawing.Color.White;
            this.rechercheclient.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rechercheclient.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.rechercheclient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rechercheclient.Location = new System.Drawing.Point(303, 20);
            this.rechercheclient.Margin = new System.Windows.Forms.Padding(4);
            this.rechercheclient.Name = "rechercheclient";
            this.rechercheclient.PasswordChar = '\0';
            this.rechercheclient.SelectedText = "";
            this.rechercheclient.Size = new System.Drawing.Size(377, 37);
            this.rechercheclient.TabIndex = 7;
            this.rechercheclient.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
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
            this.dataGridView1.Location = new System.Drawing.Point(4, 107);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(1419, 591);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // select
            // 
            this.select.HeaderText = "Sélectionner";
            this.select.MinimumWidth = 6;
            this.select.Name = "select";
            // 
            // idclient
            // 
            this.idclient.HeaderText = "ID Client";
            this.idclient.MinimumWidth = 6;
            this.idclient.Name = "idclient";
            this.idclient.ReadOnly = true;
            // 
            // nomclient
            // 
            this.nomclient.HeaderText = "Nom Client";
            this.nomclient.MinimumWidth = 6;
            this.nomclient.Name = "nomclient";
            this.nomclient.ReadOnly = true;
            // 
            // prenomclient
            // 
            this.prenomclient.HeaderText = "Prénom Client";
            this.prenomclient.MinimumWidth = 6;
            this.prenomclient.Name = "prenomclient";
            this.prenomclient.ReadOnly = true;
            // 
            // telephoneclient
            // 
            this.telephoneclient.HeaderText = "N° Téléphone";
            this.telephoneclient.MinimumWidth = 6;
            this.telephoneclient.Name = "telephoneclient";
            this.telephoneclient.ReadOnly = true;
            // 
            // emailclient
            // 
            this.emailclient.HeaderText = "Email Client";
            this.emailclient.MinimumWidth = 6;
            this.emailclient.Name = "emailclient";
            this.emailclient.ReadOnly = true;
            // 
            // adresseclient
            // 
            this.adresseclient.HeaderText = "Adresse Client";
            this.adresseclient.MinimumWidth = 6;
            this.adresseclient.Name = "adresseclient";
            this.adresseclient.ReadOnly = true;
            // 
            // villeclient
            // 
            this.villeclient.HeaderText = "Ville Client";
            this.villeclient.MinimumWidth = 6;
            this.villeclient.Name = "villeclient";
            this.villeclient.ReadOnly = true;
            // 
            // ClientFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.gunaShadowPanel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientFrm";
            this.Size = new System.Drawing.Size(1427, 702);
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
        private Guna.UI.WinForms.GunaComboBox combochercheclient;
        private Guna.UI.WinForms.GunaTextBox rechercheclient;
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
