namespace UIControl
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TopPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.closebt = new Bunifu.Framework.UI.BunifuImageButton();
            this.maxbt = new Bunifu.Framework.UI.BunifuImageButton();
            this.minbt = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DisconnectedLabel = new System.Windows.Forms.Label();
            this.ConnectedLabel = new System.Windows.Forms.Label();
            this.DisconnectedImage = new System.Windows.Forms.PictureBox();
            this.ConnectedImage = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CloseSPBt = new Bunifu.Framework.UI.BunifuImageButton();
            this.OpenSPBt = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BaudrateBox = new System.Windows.Forms.ComboBox();
            this.PortNameBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox4 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox5 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btRight4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btLeft4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btRight3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btLeft3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btRight1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btLeft1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btRight2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btLeft2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label6 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closebt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxbt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minbt)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisconnectedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectedImage)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseSPBt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenSPBt)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btRight4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btLeft4)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btRight3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btLeft3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btRight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btLeft1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btRight2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btLeft2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.TopPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // TopPanel
            // 
            this.TopPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopPanel.BackgroundImage")));
            this.TopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopPanel.Controls.Add(this.closebt);
            this.TopPanel.Controls.Add(this.maxbt);
            this.TopPanel.Controls.Add(this.minbt);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.TopPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.TopPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(84)))), ((int)(((byte)(111)))));
            this.TopPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(249)))), ((int)(((byte)(115)))));
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Quality = 10;
            this.TopPanel.Size = new System.Drawing.Size(1001, 47);
            this.TopPanel.TabIndex = 10;
            this.TopPanel.DoubleClick += new System.EventHandler(this.TopPanel_DoubleClick);
            // 
            // closebt
            // 
            this.closebt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebt.BackColor = System.Drawing.Color.Transparent;
            this.closebt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebt.Image = global::UIControl.Properties.Resources.Close_Window_50px;
            this.closebt.ImageActive = null;
            this.closebt.Location = new System.Drawing.Point(970, 7);
            this.closebt.Name = "closebt";
            this.closebt.Size = new System.Drawing.Size(25, 25);
            this.closebt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closebt.TabIndex = 9;
            this.closebt.TabStop = false;
            this.closebt.Zoom = 10;
            this.closebt.Click += new System.EventHandler(this.closebt_Click);
            // 
            // maxbt
            // 
            this.maxbt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxbt.BackColor = System.Drawing.Color.Transparent;
            this.maxbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maxbt.Image = global::UIControl.Properties.Resources.Maximize_Window_50px;
            this.maxbt.ImageActive = null;
            this.maxbt.Location = new System.Drawing.Point(939, 7);
            this.maxbt.Name = "maxbt";
            this.maxbt.Size = new System.Drawing.Size(25, 25);
            this.maxbt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maxbt.TabIndex = 8;
            this.maxbt.TabStop = false;
            this.maxbt.Zoom = 10;
            this.maxbt.Click += new System.EventHandler(this.maxbt_Click);
            // 
            // minbt
            // 
            this.minbt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minbt.BackColor = System.Drawing.Color.Transparent;
            this.minbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minbt.Image = global::UIControl.Properties.Resources.Minimize_Window_50px;
            this.minbt.ImageActive = null;
            this.minbt.Location = new System.Drawing.Point(908, 7);
            this.minbt.Name = "minbt";
            this.minbt.Size = new System.Drawing.Size(25, 25);
            this.minbt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minbt.TabIndex = 7;
            this.minbt.TabStop = false;
            this.minbt.Zoom = 10;
            this.minbt.Click += new System.EventHandler(this.minbt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ailerons", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(5)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "asdfasdfasdfasdfasdf";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bunifuMetroTextbox4);
            this.panel1.Controls.Add(this.bunifuMetroTextbox5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 201);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.DisconnectedLabel);
            this.panel2.Controls.Add(this.ConnectedLabel);
            this.panel2.Controls.Add(this.DisconnectedImage);
            this.panel2.Controls.Add(this.ConnectedImage);
            this.panel2.Location = new System.Drawing.Point(154, 47);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 130);
            this.panel2.TabIndex = 16;
            // 
            // DisconnectedLabel
            // 
            this.DisconnectedLabel.AutoSize = true;
            this.DisconnectedLabel.BackColor = System.Drawing.Color.Transparent;
            this.DisconnectedLabel.Font = new System.Drawing.Font("Makhina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectedLabel.ForeColor = System.Drawing.Color.Black;
            this.DisconnectedLabel.Location = new System.Drawing.Point(41, 102);
            this.DisconnectedLabel.Name = "DisconnectedLabel";
            this.DisconnectedLabel.Size = new System.Drawing.Size(138, 19);
            this.DisconnectedLabel.TabIndex = 10;
            this.DisconnectedLabel.Text = "DISCONNECTED";
            // 
            // ConnectedLabel
            // 
            this.ConnectedLabel.AutoSize = true;
            this.ConnectedLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConnectedLabel.Font = new System.Drawing.Font("Makhina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectedLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.ConnectedLabel.Location = new System.Drawing.Point(53, 102);
            this.ConnectedLabel.Name = "ConnectedLabel";
            this.ConnectedLabel.Size = new System.Drawing.Size(109, 19);
            this.ConnectedLabel.TabIndex = 10;
            this.ConnectedLabel.Text = "CONNECTED";
            // 
            // DisconnectedImage
            // 
            this.DisconnectedImage.BackColor = System.Drawing.Color.Transparent;
            this.DisconnectedImage.Image = global::UIControl.Properties.Resources.disconnected;
            this.DisconnectedImage.Location = new System.Drawing.Point(0, 1);
            this.DisconnectedImage.Name = "DisconnectedImage";
            this.DisconnectedImage.Size = new System.Drawing.Size(215, 90);
            this.DisconnectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DisconnectedImage.TabIndex = 1;
            this.DisconnectedImage.TabStop = false;
            // 
            // ConnectedImage
            // 
            this.ConnectedImage.Image = global::UIControl.Properties.Resources.connected;
            this.ConnectedImage.Location = new System.Drawing.Point(0, 0);
            this.ConnectedImage.Name = "ConnectedImage";
            this.ConnectedImage.Size = new System.Drawing.Size(215, 90);
            this.ConnectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ConnectedImage.TabIndex = 1;
            this.ConnectedImage.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.CloseSPBt);
            this.panel3.Controls.Add(this.OpenSPBt);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.BaudrateBox);
            this.panel3.Controls.Add(this.PortNameBox);
            this.panel3.Location = new System.Drawing.Point(447, 47);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 130);
            this.panel3.TabIndex = 17;
            // 
            // CloseSPBt
            // 
            this.CloseSPBt.BackColor = System.Drawing.Color.Transparent;
            this.CloseSPBt.Image = global::UIControl.Properties.Resources.Stop_100px;
            this.CloseSPBt.ImageActive = null;
            this.CloseSPBt.Location = new System.Drawing.Point(87, 86);
            this.CloseSPBt.Name = "CloseSPBt";
            this.CloseSPBt.Size = new System.Drawing.Size(35, 35);
            this.CloseSPBt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseSPBt.TabIndex = 1;
            this.CloseSPBt.TabStop = false;
            this.CloseSPBt.Zoom = 10;
            this.CloseSPBt.Click += new System.EventHandler(this.CloseSPBt_Click);
            // 
            // OpenSPBt
            // 
            this.OpenSPBt.BackColor = System.Drawing.Color.Transparent;
            this.OpenSPBt.Image = global::UIControl.Properties.Resources.Play_100px1;
            this.OpenSPBt.ImageActive = null;
            this.OpenSPBt.Location = new System.Drawing.Point(31, 86);
            this.OpenSPBt.Name = "OpenSPBt";
            this.OpenSPBt.Size = new System.Drawing.Size(34, 34);
            this.OpenSPBt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenSPBt.TabIndex = 1;
            this.OpenSPBt.TabStop = false;
            this.OpenSPBt.Zoom = 10;
            this.OpenSPBt.Click += new System.EventHandler(this.OpenSPBt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Makhina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Baudrate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Makhina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Port Name";
            // 
            // BaudrateBox
            // 
            this.BaudrateBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaudrateBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(9)))), ((int)(((byte)(42)))));
            this.BaudrateBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BaudrateBox.Font = new System.Drawing.Font("Aqua Grotesque", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudrateBox.ForeColor = System.Drawing.Color.White;
            this.BaudrateBox.FormattingEnabled = true;
            this.BaudrateBox.Location = new System.Drawing.Point(159, 47);
            this.BaudrateBox.Name = "BaudrateBox";
            this.BaudrateBox.Size = new System.Drawing.Size(229, 29);
            this.BaudrateBox.TabIndex = 2;
            // 
            // PortNameBox
            // 
            this.PortNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(9)))), ((int)(((byte)(42)))));
            this.PortNameBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PortNameBox.Font = new System.Drawing.Font("Aqua Grotesque", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortNameBox.ForeColor = System.Drawing.Color.White;
            this.PortNameBox.FormattingEnabled = true;
            this.PortNameBox.Location = new System.Drawing.Point(159, 13);
            this.PortNameBox.Name = "PortNameBox";
            this.PortNameBox.Size = new System.Drawing.Size(229, 29);
            this.PortNameBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ailerons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(207, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "CONNECTION";
            // 
            // bunifuMetroTextbox4
            // 
            this.bunifuMetroTextbox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuMetroTextbox4.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(9)))), ((int)(((byte)(42)))));
            this.bunifuMetroTextbox4.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(9)))), ((int)(((byte)(42)))));
            this.bunifuMetroTextbox4.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(9)))), ((int)(((byte)(42)))));
            this.bunifuMetroTextbox4.BorderThickness = 2;
            this.bunifuMetroTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMetroTextbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox4.isPassword = false;
            this.bunifuMetroTextbox4.Location = new System.Drawing.Point(427, 22);
            this.bunifuMetroTextbox4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox4.Name = "bunifuMetroTextbox4";
            this.bunifuMetroTextbox4.Size = new System.Drawing.Size(458, 164);
            this.bunifuMetroTextbox4.TabIndex = 19;
            this.bunifuMetroTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox5
            // 
            this.bunifuMetroTextbox5.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(9)))), ((int)(((byte)(42)))));
            this.bunifuMetroTextbox5.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(9)))), ((int)(((byte)(42)))));
            this.bunifuMetroTextbox5.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(9)))), ((int)(((byte)(42)))));
            this.bunifuMetroTextbox5.BorderThickness = 2;
            this.bunifuMetroTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMetroTextbox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox5.isPassword = false;
            this.bunifuMetroTextbox5.Location = new System.Drawing.Point(100, 22);
            this.bunifuMetroTextbox5.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox5.Name = "bunifuMetroTextbox5";
            this.bunifuMetroTextbox5.Size = new System.Drawing.Size(319, 164);
            this.bunifuMetroTextbox5.TabIndex = 20;
            this.bunifuMetroTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel7, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 248);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1001, 330);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btRight4);
            this.panel7.Controls.Add(this.btLeft4);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(753, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(245, 324);
            this.panel7.TabIndex = 3;
            // 
            // btRight4
            // 
            this.btRight4.BackColor = System.Drawing.Color.Transparent;
            this.btRight4.Image = global::UIControl.Properties.Resources.Chevron_Right_64px;
            this.btRight4.ImageActive = null;
            this.btRight4.Location = new System.Drawing.Point(129, 132);
            this.btRight4.Name = "btRight4";
            this.btRight4.Size = new System.Drawing.Size(60, 60);
            this.btRight4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btRight4.TabIndex = 21;
            this.btRight4.TabStop = false;
            this.btRight4.Zoom = 10;
            this.btRight4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btRight4_MouseDown);
            this.btRight4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btRight4_MouseUp);
            // 
            // btLeft4
            // 
            this.btLeft4.BackColor = System.Drawing.Color.Transparent;
            this.btLeft4.Image = global::UIControl.Properties.Resources.Chevron_Left_64px;
            this.btLeft4.ImageActive = null;
            this.btLeft4.Location = new System.Drawing.Point(56, 132);
            this.btLeft4.Name = "btLeft4";
            this.btLeft4.Size = new System.Drawing.Size(60, 60);
            this.btLeft4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btLeft4.TabIndex = 22;
            this.btLeft4.TabStop = false;
            this.btLeft4.Zoom = 10;
            this.btLeft4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btLeft4_MouseDown);
            this.btLeft4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btLeft4_MouseUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Ailerons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(93, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "MOTOR 4";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btRight3);
            this.panel6.Controls.Add(this.btLeft3);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(503, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(244, 324);
            this.panel6.TabIndex = 2;
            // 
            // btRight3
            // 
            this.btRight3.BackColor = System.Drawing.Color.Transparent;
            this.btRight3.Image = global::UIControl.Properties.Resources.Chevron_Right_64px;
            this.btRight3.ImageActive = null;
            this.btRight3.Location = new System.Drawing.Point(129, 132);
            this.btRight3.Name = "btRight3";
            this.btRight3.Size = new System.Drawing.Size(60, 60);
            this.btRight3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btRight3.TabIndex = 21;
            this.btRight3.TabStop = false;
            this.btRight3.Zoom = 10;
            this.btRight3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btRight3_MouseDown);
            this.btRight3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btRight3_MouseUp);
            // 
            // btLeft3
            // 
            this.btLeft3.BackColor = System.Drawing.Color.Transparent;
            this.btLeft3.Image = global::UIControl.Properties.Resources.Chevron_Left_64px;
            this.btLeft3.ImageActive = null;
            this.btLeft3.Location = new System.Drawing.Point(56, 132);
            this.btLeft3.Name = "btLeft3";
            this.btLeft3.Size = new System.Drawing.Size(60, 60);
            this.btLeft3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btLeft3.TabIndex = 22;
            this.btLeft3.TabStop = false;
            this.btLeft3.Zoom = 10;
            this.btLeft3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btLeft3_MouseDown);
            this.btLeft3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btLeft3_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Ailerons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(78, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "MOTOR 3";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btRight1);
            this.panel5.Controls.Add(this.btLeft1);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(244, 324);
            this.panel5.TabIndex = 1;
            // 
            // btRight1
            // 
            this.btRight1.BackColor = System.Drawing.Color.Transparent;
            this.btRight1.Image = global::UIControl.Properties.Resources.Chevron_Right_64px;
            this.btRight1.ImageActive = null;
            this.btRight1.Location = new System.Drawing.Point(126, 130);
            this.btRight1.Name = "btRight1";
            this.btRight1.Size = new System.Drawing.Size(60, 60);
            this.btRight1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btRight1.TabIndex = 20;
            this.btRight1.TabStop = false;
            this.btRight1.Zoom = 10;
            this.btRight1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btRight1_MouseDown);
            this.btRight1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btRight1_MouseUp);
            // 
            // btLeft1
            // 
            this.btLeft1.BackColor = System.Drawing.Color.Transparent;
            this.btLeft1.Image = global::UIControl.Properties.Resources.Chevron_Left_64px;
            this.btLeft1.ImageActive = null;
            this.btLeft1.Location = new System.Drawing.Point(53, 130);
            this.btLeft1.Name = "btLeft1";
            this.btLeft1.Size = new System.Drawing.Size(60, 60);
            this.btLeft1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btLeft1.TabIndex = 20;
            this.btLeft1.TabStop = false;
            this.btLeft1.Zoom = 10;
            this.btLeft1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btLeft1_MouseDown);
            this.btLeft1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btLeft1_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ailerons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(78, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "MOTOR 1";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btRight2);
            this.panel4.Controls.Add(this.btLeft2);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(253, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(244, 324);
            this.panel4.TabIndex = 0;
            // 
            // btRight2
            // 
            this.btRight2.BackColor = System.Drawing.Color.Transparent;
            this.btRight2.Image = global::UIControl.Properties.Resources.Chevron_Right_64px;
            this.btRight2.ImageActive = null;
            this.btRight2.Location = new System.Drawing.Point(129, 132);
            this.btRight2.Name = "btRight2";
            this.btRight2.Size = new System.Drawing.Size(60, 60);
            this.btRight2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btRight2.TabIndex = 21;
            this.btRight2.TabStop = false;
            this.btRight2.Zoom = 10;
            this.btRight2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btRight2_MouseDown);
            this.btRight2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btRight2_MouseUp);
            // 
            // btLeft2
            // 
            this.btLeft2.BackColor = System.Drawing.Color.Transparent;
            this.btLeft2.Image = global::UIControl.Properties.Resources.Chevron_Left_64px;
            this.btLeft2.ImageActive = null;
            this.btLeft2.Location = new System.Drawing.Point(56, 132);
            this.btLeft2.Name = "btLeft2";
            this.btLeft2.Size = new System.Drawing.Size(60, 60);
            this.btLeft2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btLeft2.TabIndex = 22;
            this.btLeft2.TabStop = false;
            this.btLeft2.Zoom = 10;
            this.btLeft2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btLeft2_MouseDown);
            this.btLeft2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btLeft2_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ailerons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(79, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "MOTOR 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 578);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closebt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxbt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minbt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisconnectedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectedImage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseSPBt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenSPBt)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btRight4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btLeft4)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btRight3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btLeft3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btRight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btLeft1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btRight2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btLeft2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel TopPanel;
        private Bunifu.Framework.UI.BunifuImageButton closebt;
        private Bunifu.Framework.UI.BunifuImageButton maxbt;
        private Bunifu.Framework.UI.BunifuImageButton minbt;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.PictureBox DisconnectedImage;
        public System.Windows.Forms.PictureBox ConnectedImage;
        public System.Windows.Forms.Label DisconnectedLabel;
        public System.Windows.Forms.Label ConnectedLabel;
        private System.Windows.Forms.Panel panel3;
        public Bunifu.Framework.UI.BunifuImageButton CloseSPBt;
        public Bunifu.Framework.UI.BunifuImageButton OpenSPBt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox BaudrateBox;
        public System.Windows.Forms.ComboBox PortNameBox;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox4;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        public Bunifu.Framework.UI.BunifuImageButton btRight1;
        public Bunifu.Framework.UI.BunifuImageButton btLeft1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        public Bunifu.Framework.UI.BunifuImageButton btRight4;
        public Bunifu.Framework.UI.BunifuImageButton btLeft4;
        public Bunifu.Framework.UI.BunifuImageButton btRight3;
        public Bunifu.Framework.UI.BunifuImageButton btLeft3;
        public Bunifu.Framework.UI.BunifuImageButton btRight2;
        public Bunifu.Framework.UI.BunifuImageButton btLeft2;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

