namespace GEST_DE_STOCK.PL
{
    partial class MenuFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuFrm));
            this.ListeShadowPanel = new Guna.UI.WinForms.GunaShadowPanel();
            this.Time = new Guna.UI.WinForms.GunaLabel();
            this.Date = new Guna.UI.WinForms.GunaLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.InsidePanel = new Guna.UI.WinForms.GunaPanel();
            this.EnTete = new Guna.UI.WinForms.GunaGradientPanel();
            this.FournisseursButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.VenteButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ClientsButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.LivraisonButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.CommandeButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.FournisseursButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ProduitsButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ClientButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.LivraisonButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ProductsButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.CommandeButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.VenteButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ListeShadowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListeShadowPanel
            // 
            this.ListeShadowPanel.BackColor = System.Drawing.Color.Transparent;
            this.ListeShadowPanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.ListeShadowPanel.Controls.Add(this.FournisseursButton2);
            this.ListeShadowPanel.Controls.Add(this.VenteButton2);
            this.ListeShadowPanel.Controls.Add(this.ClientsButton2);
            this.ListeShadowPanel.Controls.Add(this.Time);
            this.ListeShadowPanel.Controls.Add(this.LivraisonButton2);
            this.ListeShadowPanel.Controls.Add(this.Date);
            this.ListeShadowPanel.Controls.Add(this.CommandeButton2);
            this.ListeShadowPanel.Controls.Add(this.FournisseursButton);
            this.ListeShadowPanel.Controls.Add(this.ProduitsButton2);
            this.ListeShadowPanel.Controls.Add(this.ClientButton);
            this.ListeShadowPanel.Controls.Add(this.LivraisonButton);
            this.ListeShadowPanel.Controls.Add(this.ProductsButton);
            this.ListeShadowPanel.Controls.Add(this.CommandeButton);
            this.ListeShadowPanel.Controls.Add(this.VenteButton);
            this.ListeShadowPanel.Location = new System.Drawing.Point(-4, -9);
            this.ListeShadowPanel.Name = "ListeShadowPanel";
            this.ListeShadowPanel.ShadowColor = System.Drawing.Color.Black;
            this.ListeShadowPanel.ShadowDepth = 75;
            this.ListeShadowPanel.ShadowStyle = Guna.UI.WinForms.ShadowMode.ForwardDiagonal;
            this.ListeShadowPanel.Size = new System.Drawing.Size(180, 698);
            this.ListeShadowPanel.TabIndex = 1;
            this.ListeShadowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaShadowPanel1_Paint);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.Transparent;
            this.Time.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.White;
            this.Time.Location = new System.Drawing.Point(52, 47);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(48, 18);
            this.Time.TabIndex = 5;
            this.Time.Text = "Time";
            this.Time.Click += new System.EventHandler(this.Time_Click);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.BackColor = System.Drawing.Color.Transparent;
            this.Date.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.White;
            this.Date.Location = new System.Drawing.Point(25, 18);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(54, 22);
            this.Date.TabIndex = 4;
            this.Date.Text = "Date";
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // InsidePanel
            // 
            this.InsidePanel.Location = new System.Drawing.Point(182, 37);
            this.InsidePanel.Name = "InsidePanel";
            this.InsidePanel.Size = new System.Drawing.Size(1070, 570);
            this.InsidePanel.TabIndex = 4;
            this.InsidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InsidePanel_Paint);
            // 
            // EnTete
            // 
            this.EnTete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EnTete.BackgroundImage")));
            this.EnTete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EnTete.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.EnTete.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.EnTete.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.EnTete.GradientColor4 = System.Drawing.Color.White;
            this.EnTete.Location = new System.Drawing.Point(170, 0);
            this.EnTete.Name = "EnTete";
            this.EnTete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EnTete.Size = new System.Drawing.Size(1100, 31);
            this.EnTete.TabIndex = 3;
            this.EnTete.Text = "gunaGradientPanel1";
            this.EnTete.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaGradientPanel1_Paint);
            // 
            // FournisseursButton2
            // 
            this.FournisseursButton2.Animated = true;
            this.FournisseursButton2.AnimationHoverSpeed = 0.07F;
            this.FournisseursButton2.AnimationSpeed = 0.03F;
            this.FournisseursButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.FournisseursButton2.BorderColor = System.Drawing.Color.Black;
            this.FournisseursButton2.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(147)))), ((int)(((byte)(177)))));
            this.FournisseursButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.FournisseursButton2.CheckedForeColor = System.Drawing.Color.White;
            this.FournisseursButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("FournisseursButton2.CheckedImage")));
            this.FournisseursButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.FournisseursButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FournisseursButton2.FocusedColor = System.Drawing.Color.Empty;
            this.FournisseursButton2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FournisseursButton2.ForeColor = System.Drawing.Color.White;
            this.FournisseursButton2.Image = ((System.Drawing.Image)(resources.GetObject("FournisseursButton2.Image")));
            this.FournisseursButton2.ImageSize = new System.Drawing.Size(33, 33);
            this.FournisseursButton2.LineColor = System.Drawing.Color.White;
            this.FournisseursButton2.LineLeft = 4;
            this.FournisseursButton2.Location = new System.Drawing.Point(3, 506);
            this.FournisseursButton2.Name = "FournisseursButton2";
            this.FournisseursButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.FournisseursButton2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.FournisseursButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.FournisseursButton2.OnHoverImage = null;
            this.FournisseursButton2.OnHoverLineColor = System.Drawing.Color.White;
            this.FournisseursButton2.OnPressedColor = System.Drawing.Color.Transparent;
            this.FournisseursButton2.Size = new System.Drawing.Size(170, 42);
            this.FournisseursButton2.TabIndex = 13;
            this.FournisseursButton2.Text = "Fournisseurs";
            // 
            // VenteButton2
            // 
            this.VenteButton2.Animated = true;
            this.VenteButton2.AnimationHoverSpeed = 0.07F;
            this.VenteButton2.AnimationSpeed = 0.03F;
            this.VenteButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.VenteButton2.BorderColor = System.Drawing.Color.Black;
            this.VenteButton2.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(147)))), ((int)(((byte)(177)))));
            this.VenteButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.VenteButton2.CheckedForeColor = System.Drawing.Color.White;
            this.VenteButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("VenteButton2.CheckedImage")));
            this.VenteButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.VenteButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.VenteButton2.FocusedColor = System.Drawing.Color.Empty;
            this.VenteButton2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenteButton2.ForeColor = System.Drawing.Color.White;
            this.VenteButton2.Image = global::GEST_DE_STOCK.Properties.Resources.vente;
            this.VenteButton2.ImageSize = new System.Drawing.Size(33, 33);
            this.VenteButton2.LineColor = System.Drawing.Color.White;
            this.VenteButton2.LineLeft = 4;
            this.VenteButton2.Location = new System.Drawing.Point(3, 120);
            this.VenteButton2.Name = "VenteButton2";
            this.VenteButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.VenteButton2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.VenteButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.VenteButton2.OnHoverImage = null;
            this.VenteButton2.OnHoverLineColor = System.Drawing.Color.White;
            this.VenteButton2.OnPressedColor = System.Drawing.Color.Transparent;
            this.VenteButton2.Size = new System.Drawing.Size(170, 42);
            this.VenteButton2.TabIndex = 10;
            this.VenteButton2.Text = "Ventes";
            this.VenteButton2.Click += new System.EventHandler(this.VenteButton2_Click);
            // 
            // ClientsButton2
            // 
            this.ClientsButton2.Animated = true;
            this.ClientsButton2.AnimationHoverSpeed = 0.07F;
            this.ClientsButton2.AnimationSpeed = 0.03F;
            this.ClientsButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.ClientsButton2.BorderColor = System.Drawing.Color.Black;
            this.ClientsButton2.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(147)))), ((int)(((byte)(177)))));
            this.ClientsButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.ClientsButton2.CheckedForeColor = System.Drawing.Color.White;
            this.ClientsButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ClientsButton2.CheckedImage")));
            this.ClientsButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ClientsButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ClientsButton2.FocusedColor = System.Drawing.Color.Empty;
            this.ClientsButton2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsButton2.ForeColor = System.Drawing.Color.White;
            this.ClientsButton2.Image = ((System.Drawing.Image)(resources.GetObject("ClientsButton2.Image")));
            this.ClientsButton2.ImageSize = new System.Drawing.Size(33, 33);
            this.ClientsButton2.LineColor = System.Drawing.Color.White;
            this.ClientsButton2.LineLeft = 4;
            this.ClientsButton2.Location = new System.Drawing.Point(3, 430);
            this.ClientsButton2.Name = "ClientsButton2";
            this.ClientsButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.ClientsButton2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.ClientsButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.ClientsButton2.OnHoverImage = null;
            this.ClientsButton2.OnHoverLineColor = System.Drawing.Color.White;
            this.ClientsButton2.OnPressedColor = System.Drawing.Color.Transparent;
            this.ClientsButton2.Size = new System.Drawing.Size(170, 42);
            this.ClientsButton2.TabIndex = 12;
            this.ClientsButton2.Text = "Clients";
            // 
            // LivraisonButton2
            // 
            this.LivraisonButton2.Animated = true;
            this.LivraisonButton2.AnimationHoverSpeed = 0.07F;
            this.LivraisonButton2.AnimationSpeed = 0.03F;
            this.LivraisonButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.LivraisonButton2.BorderColor = System.Drawing.Color.Black;
            this.LivraisonButton2.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(147)))), ((int)(((byte)(177)))));
            this.LivraisonButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.LivraisonButton2.CheckedForeColor = System.Drawing.Color.White;
            this.LivraisonButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("LivraisonButton2.CheckedImage")));
            this.LivraisonButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.LivraisonButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LivraisonButton2.FocusedColor = System.Drawing.Color.Empty;
            this.LivraisonButton2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivraisonButton2.ForeColor = System.Drawing.Color.White;
            this.LivraisonButton2.Image = ((System.Drawing.Image)(resources.GetObject("LivraisonButton2.Image")));
            this.LivraisonButton2.ImageSize = new System.Drawing.Size(33, 33);
            this.LivraisonButton2.LineColor = System.Drawing.Color.White;
            this.LivraisonButton2.LineLeft = 4;
            this.LivraisonButton2.Location = new System.Drawing.Point(3, 354);
            this.LivraisonButton2.Name = "LivraisonButton2";
            this.LivraisonButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.LivraisonButton2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.LivraisonButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.LivraisonButton2.OnHoverImage = null;
            this.LivraisonButton2.OnHoverLineColor = System.Drawing.Color.White;
            this.LivraisonButton2.OnPressedColor = System.Drawing.Color.Transparent;
            this.LivraisonButton2.Size = new System.Drawing.Size(170, 42);
            this.LivraisonButton2.TabIndex = 11;
            this.LivraisonButton2.Text = "Livraisons";
            this.LivraisonButton2.Click += new System.EventHandler(this.LivraisonButton2_Click);
            // 
            // CommandeButton2
            // 
            this.CommandeButton2.Animated = true;
            this.CommandeButton2.AnimationHoverSpeed = 0.07F;
            this.CommandeButton2.AnimationSpeed = 0.03F;
            this.CommandeButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.CommandeButton2.BorderColor = System.Drawing.Color.Black;
            this.CommandeButton2.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(147)))), ((int)(((byte)(177)))));
            this.CommandeButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.CommandeButton2.CheckedForeColor = System.Drawing.Color.White;
            this.CommandeButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("CommandeButton2.CheckedImage")));
            this.CommandeButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CommandeButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CommandeButton2.FocusedColor = System.Drawing.Color.Empty;
            this.CommandeButton2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandeButton2.ForeColor = System.Drawing.Color.White;
            this.CommandeButton2.Image = ((System.Drawing.Image)(resources.GetObject("CommandeButton2.Image")));
            this.CommandeButton2.ImageSize = new System.Drawing.Size(33, 33);
            this.CommandeButton2.LineColor = System.Drawing.Color.White;
            this.CommandeButton2.LineLeft = 4;
            this.CommandeButton2.Location = new System.Drawing.Point(3, 272);
            this.CommandeButton2.Name = "CommandeButton2";
            this.CommandeButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.CommandeButton2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.CommandeButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.CommandeButton2.OnHoverImage = null;
            this.CommandeButton2.OnHoverLineColor = System.Drawing.Color.White;
            this.CommandeButton2.OnPressedColor = System.Drawing.Color.Transparent;
            this.CommandeButton2.Size = new System.Drawing.Size(170, 42);
            this.CommandeButton2.TabIndex = 11;
            this.CommandeButton2.Text = "Commandes";
            this.CommandeButton2.Click += new System.EventHandler(this.CommandeButton2_Click);
            // 
            // FournisseursButton
            // 
            this.FournisseursButton.Animated = true;
            this.FournisseursButton.AnimationHoverSpeed = 0.07F;
            this.FournisseursButton.AnimationSpeed = 0.03F;
            this.FournisseursButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.FournisseursButton.BorderColor = System.Drawing.Color.Black;
            this.FournisseursButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(147)))), ((int)(((byte)(177)))));
            this.FournisseursButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.FournisseursButton.CheckedForeColor = System.Drawing.Color.White;
            this.FournisseursButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("FournisseursButton.CheckedImage")));
            this.FournisseursButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.FournisseursButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FournisseursButton.FocusedColor = System.Drawing.Color.Empty;
            this.FournisseursButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FournisseursButton.ForeColor = System.Drawing.Color.White;
            this.FournisseursButton.Image = ((System.Drawing.Image)(resources.GetObject("FournisseursButton.Image")));
            this.FournisseursButton.ImageSize = new System.Drawing.Size(33, 33);
            this.FournisseursButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.FournisseursButton.LineLeft = 4;
            this.FournisseursButton.Location = new System.Drawing.Point(3, 506);
            this.FournisseursButton.Name = "FournisseursButton";
            this.FournisseursButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.FournisseursButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.FournisseursButton.OnHoverForeColor = System.Drawing.Color.White;
            this.FournisseursButton.OnHoverImage = null;
            this.FournisseursButton.OnHoverLineColor = System.Drawing.Color.White;
            this.FournisseursButton.OnPressedColor = System.Drawing.Color.Transparent;
            this.FournisseursButton.OnPressedDepth = 0;
            this.FournisseursButton.Size = new System.Drawing.Size(170, 42);
            this.FournisseursButton.TabIndex = 6;
            this.FournisseursButton.Text = "Fournisseurs";
            this.FournisseursButton.Click += new System.EventHandler(this.FournisseursButton_Click);
            // 
            // ProduitsButton2
            // 
            this.ProduitsButton2.Animated = true;
            this.ProduitsButton2.AnimationHoverSpeed = 0.07F;
            this.ProduitsButton2.AnimationSpeed = 0.03F;
            this.ProduitsButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.ProduitsButton2.BorderColor = System.Drawing.Color.Black;
            this.ProduitsButton2.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(147)))), ((int)(((byte)(177)))));
            this.ProduitsButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.ProduitsButton2.CheckedForeColor = System.Drawing.Color.White;
            this.ProduitsButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ProduitsButton2.CheckedImage")));
            this.ProduitsButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ProduitsButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ProduitsButton2.FocusedColor = System.Drawing.Color.Empty;
            this.ProduitsButton2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProduitsButton2.ForeColor = System.Drawing.Color.White;
            this.ProduitsButton2.Image = global::GEST_DE_STOCK.Properties.Resources.open_box;
            this.ProduitsButton2.ImageSize = new System.Drawing.Size(33, 33);
            this.ProduitsButton2.LineColor = System.Drawing.Color.White;
            this.ProduitsButton2.LineLeft = 4;
            this.ProduitsButton2.Location = new System.Drawing.Point(3, 196);
            this.ProduitsButton2.Name = "ProduitsButton2";
            this.ProduitsButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.ProduitsButton2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.ProduitsButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.ProduitsButton2.OnHoverImage = null;
            this.ProduitsButton2.OnHoverLineColor = System.Drawing.Color.White;
            this.ProduitsButton2.OnPressedColor = System.Drawing.Color.Transparent;
            this.ProduitsButton2.Size = new System.Drawing.Size(170, 42);
            this.ProduitsButton2.TabIndex = 11;
            this.ProduitsButton2.Text = "Produits";
            this.ProduitsButton2.Click += new System.EventHandler(this.ProduitsButton2_Click);
            // 
            // ClientButton
            // 
            this.ClientButton.Animated = true;
            this.ClientButton.AnimationHoverSpeed = 0.07F;
            this.ClientButton.AnimationSpeed = 0.03F;
            this.ClientButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.ClientButton.BorderColor = System.Drawing.Color.Black;
            this.ClientButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(147)))), ((int)(((byte)(177)))));
            this.ClientButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.ClientButton.CheckedForeColor = System.Drawing.Color.White;
            this.ClientButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ClientButton.CheckedImage")));
            this.ClientButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ClientButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ClientButton.FocusedColor = System.Drawing.Color.Empty;
            this.ClientButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientButton.ForeColor = System.Drawing.Color.White;
            this.ClientButton.Image = ((System.Drawing.Image)(resources.GetObject("ClientButton.Image")));
            this.ClientButton.ImageSize = new System.Drawing.Size(33, 33);
            this.ClientButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.ClientButton.LineLeft = 4;
            this.ClientButton.Location = new System.Drawing.Point(3, 430);
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.ClientButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.ClientButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ClientButton.OnHoverImage = null;
            this.ClientButton.OnHoverLineColor = System.Drawing.Color.White;
            this.ClientButton.OnPressedColor = System.Drawing.Color.Transparent;
            this.ClientButton.OnPressedDepth = 0;
            this.ClientButton.Size = new System.Drawing.Size(170, 42);
            this.ClientButton.TabIndex = 9;
            this.ClientButton.Text = "Clients";
            this.ClientButton.Click += new System.EventHandler(this.ClientButton_Click);
            // 
            // LivraisonButton
            // 
            this.LivraisonButton.Animated = true;
            this.LivraisonButton.AnimationHoverSpeed = 0.07F;
            this.LivraisonButton.AnimationSpeed = 0.03F;
            this.LivraisonButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.LivraisonButton.BorderColor = System.Drawing.Color.Black;
            this.LivraisonButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(147)))), ((int)(((byte)(177)))));
            this.LivraisonButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.LivraisonButton.CheckedForeColor = System.Drawing.Color.White;
            this.LivraisonButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("LivraisonButton.CheckedImage")));
            this.LivraisonButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.LivraisonButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LivraisonButton.FocusedColor = System.Drawing.Color.Empty;
            this.LivraisonButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivraisonButton.ForeColor = System.Drawing.Color.White;
            this.LivraisonButton.Image = ((System.Drawing.Image)(resources.GetObject("LivraisonButton.Image")));
            this.LivraisonButton.ImageSize = new System.Drawing.Size(33, 33);
            this.LivraisonButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.LivraisonButton.LineLeft = 4;
            this.LivraisonButton.Location = new System.Drawing.Point(3, 354);
            this.LivraisonButton.Name = "LivraisonButton";
            this.LivraisonButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.LivraisonButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.LivraisonButton.OnHoverForeColor = System.Drawing.Color.White;
            this.LivraisonButton.OnHoverImage = null;
            this.LivraisonButton.OnHoverLineColor = System.Drawing.Color.White;
            this.LivraisonButton.OnPressedColor = System.Drawing.Color.Transparent;
            this.LivraisonButton.OnPressedDepth = 0;
            this.LivraisonButton.Size = new System.Drawing.Size(170, 42);
            this.LivraisonButton.TabIndex = 6;
            this.LivraisonButton.Text = "Livraisons";
            this.LivraisonButton.Click += new System.EventHandler(this.LivraisonButton_Click);
            // 
            // ProductsButton
            // 
            this.ProductsButton.Animated = true;
            this.ProductsButton.AnimationHoverSpeed = 0.07F;
            this.ProductsButton.AnimationSpeed = 0.03F;
            this.ProductsButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.ProductsButton.BorderColor = System.Drawing.Color.Black;
            this.ProductsButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(147)))), ((int)(((byte)(177)))));
            this.ProductsButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.ProductsButton.CheckedForeColor = System.Drawing.Color.White;
            this.ProductsButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ProductsButton.CheckedImage")));
            this.ProductsButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ProductsButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ProductsButton.FocusedColor = System.Drawing.Color.Empty;
            this.ProductsButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsButton.ForeColor = System.Drawing.Color.White;
            this.ProductsButton.Image = global::GEST_DE_STOCK.Properties.Resources.open_box;
            this.ProductsButton.ImageSize = new System.Drawing.Size(33, 33);
            this.ProductsButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.ProductsButton.LineLeft = 4;
            this.ProductsButton.Location = new System.Drawing.Point(3, 196);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.ProductsButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.ProductsButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ProductsButton.OnHoverImage = null;
            this.ProductsButton.OnHoverLineColor = System.Drawing.Color.White;
            this.ProductsButton.OnPressedColor = System.Drawing.Color.Transparent;
            this.ProductsButton.OnPressedDepth = 0;
            this.ProductsButton.Size = new System.Drawing.Size(170, 42);
            this.ProductsButton.TabIndex = 8;
            this.ProductsButton.Text = "Produits";
            this.ProductsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // CommandeButton
            // 
            this.CommandeButton.Animated = true;
            this.CommandeButton.AnimationHoverSpeed = 0.07F;
            this.CommandeButton.AnimationSpeed = 0.03F;
            this.CommandeButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.CommandeButton.BorderColor = System.Drawing.Color.Black;
            this.CommandeButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(147)))), ((int)(((byte)(177)))));
            this.CommandeButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.CommandeButton.CheckedForeColor = System.Drawing.Color.White;
            this.CommandeButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("CommandeButton.CheckedImage")));
            this.CommandeButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CommandeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CommandeButton.FocusedColor = System.Drawing.Color.Empty;
            this.CommandeButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandeButton.ForeColor = System.Drawing.Color.White;
            this.CommandeButton.Image = ((System.Drawing.Image)(resources.GetObject("CommandeButton.Image")));
            this.CommandeButton.ImageSize = new System.Drawing.Size(33, 33);
            this.CommandeButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.CommandeButton.LineLeft = 4;
            this.CommandeButton.Location = new System.Drawing.Point(3, 272);
            this.CommandeButton.Name = "CommandeButton";
            this.CommandeButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.CommandeButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.CommandeButton.OnHoverForeColor = System.Drawing.Color.White;
            this.CommandeButton.OnHoverImage = null;
            this.CommandeButton.OnHoverLineColor = System.Drawing.Color.White;
            this.CommandeButton.OnPressedColor = System.Drawing.Color.Transparent;
            this.CommandeButton.OnPressedDepth = 0;
            this.CommandeButton.Size = new System.Drawing.Size(170, 42);
            this.CommandeButton.TabIndex = 5;
            this.CommandeButton.Text = "Commandes";
            this.CommandeButton.Click += new System.EventHandler(this.CommandeButton_Click);
            // 
            // VenteButton
            // 
            this.VenteButton.Animated = true;
            this.VenteButton.AnimationHoverSpeed = 0.07F;
            this.VenteButton.AnimationSpeed = 0.03F;
            this.VenteButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.VenteButton.BorderColor = System.Drawing.Color.Black;
            this.VenteButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(147)))), ((int)(((byte)(177)))));
            this.VenteButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.VenteButton.CheckedForeColor = System.Drawing.Color.White;
            this.VenteButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("VenteButton.CheckedImage")));
            this.VenteButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.VenteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.VenteButton.FocusedColor = System.Drawing.Color.Empty;
            this.VenteButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenteButton.ForeColor = System.Drawing.Color.White;
            this.VenteButton.Image = global::GEST_DE_STOCK.Properties.Resources.vente;
            this.VenteButton.ImageSize = new System.Drawing.Size(33, 33);
            this.VenteButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.VenteButton.LineLeft = 4;
            this.VenteButton.Location = new System.Drawing.Point(3, 120);
            this.VenteButton.Name = "VenteButton";
            this.VenteButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.VenteButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.VenteButton.OnHoverForeColor = System.Drawing.Color.White;
            this.VenteButton.OnHoverImage = null;
            this.VenteButton.OnHoverLineColor = System.Drawing.Color.White;
            this.VenteButton.OnPressedColor = System.Drawing.Color.Transparent;
            this.VenteButton.OnPressedDepth = 0;
            this.VenteButton.Size = new System.Drawing.Size(170, 42);
            this.VenteButton.TabIndex = 3;
            this.VenteButton.Text = "Ventes";
            this.VenteButton.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // MenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 611);
            this.Controls.Add(this.InsidePanel);
            this.Controls.Add(this.EnTete);
            this.Controls.Add(this.ListeShadowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuFrm";
            this.Text = "Gestion de Stock";
            this.Load += new System.EventHandler(this.MenuFrm_Load);
            this.ListeShadowPanel.ResumeLayout(false);
            this.ListeShadowPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel ListeShadowPanel;
        private Guna.UI.WinForms.GunaAdvenceButton VenteButton;
        private Guna.UI.WinForms.GunaAdvenceButton ProductsButton;
        private Guna.UI.WinForms.GunaAdvenceButton CommandeButton;
        private Guna.UI.WinForms.GunaAdvenceButton FournisseursButton;
        private Guna.UI.WinForms.GunaAdvenceButton ClientButton;
        private Guna.UI.WinForms.GunaAdvenceButton LivraisonButton;
        private Guna.UI.WinForms.GunaGradientPanel EnTete;
        private Guna.UI.WinForms.GunaLabel Date;
        private Guna.UI.WinForms.GunaLabel Time;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaPanel InsidePanel;
        private Guna.UI.WinForms.GunaAdvenceButton VenteButton2;
        private Guna.UI.WinForms.GunaAdvenceButton FournisseursButton2;
        private Guna.UI.WinForms.GunaAdvenceButton ClientsButton2;
        private Guna.UI.WinForms.GunaAdvenceButton LivraisonButton2;
        private Guna.UI.WinForms.GunaAdvenceButton CommandeButton2;
        private Guna.UI.WinForms.GunaAdvenceButton ProduitsButton2;
    }
}