using MetaCopy.Components;

namespace MetaCopy
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            GlacialComponents.Controls.GLColumn glColumn4 = new GlacialComponents.Controls.GLColumn();
            GlacialComponents.Controls.GLColumn glColumn5 = new GlacialComponents.Controls.GLColumn();
            GlacialComponents.Controls.GLColumn glColumn1 = new GlacialComponents.Controls.GLColumn();
            MetaCopy.Components.CustomLabel customLabel1;
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpenPath = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelStat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.TextBox();
            this.glacialList = new GlacialComponents.Controls.GlacialList();
            this.panel2 = new System.Windows.Forms.Panel();
            this.glacialListPath = new GlacialComponents.Controls.GlacialList();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customButton4 = new MetaCopy.Components.CustomButton();
            this.btnRem = new MetaCopy.Components.CustomButton();
            this.btnRemAll = new MetaCopy.Components.CustomButton();
            this.btnAddDestPath = new MetaCopy.Components.CustomButton();
            this.button5 = new MetaCopy.Components.CustomButton();
            this.button4 = new MetaCopy.Components.CustomButton();
            this.button3 = new MetaCopy.Components.CustomButton();
            this.button2 = new MetaCopy.Components.CustomButton();
            this.button1 = new MetaCopy.Components.CustomButton();
            label1 = new System.Windows.Forms.Label();
            customLabel1 = new MetaCopy.Components.CustomLabel();
            this.panelTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(59)))));
            label1.Location = new System.Drawing.Point(48, 66);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(97, 20);
            label1.TabIndex = 2;
            label1.Text = "Watch Folder";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(59)))));
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Controls.Add(customLabel1);
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(640, 32);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(606, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 26);
            this.btnClose.TabIndex = 19;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.closeApp);
            // 
            // btnOpenPath
            // 
            this.btnOpenPath.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOpenPath.FlatAppearance.BorderSize = 0;
            this.btnOpenPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.btnOpenPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOpenPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPath.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenPath.Image")));
            this.btnOpenPath.Location = new System.Drawing.Point(560, 62);
            this.btnOpenPath.Name = "btnOpenPath";
            this.btnOpenPath.Size = new System.Drawing.Size(26, 26);
            this.btnOpenPath.TabIndex = 3;
            this.btnOpenPath.UseVisualStyleBackColor = false;
            this.btnOpenPath.Click += new System.EventHandler(this.openFolder);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.checkBox1.Location = new System.Drawing.Point(501, 692);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 21);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Cut Mode";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelStat
            // 
            this.labelStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.labelStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.labelStat.Location = new System.Drawing.Point(52, 720);
            this.labelStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStat.Name = "labelStat";
            this.labelStat.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.labelStat.Size = new System.Drawing.Size(534, 22);
            this.labelStat.TabIndex = 18;
            this.labelStat.Text = "Meh...";
            this.labelStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.pathLabel);
            this.panel1.Location = new System.Drawing.Point(151, 60);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(403, 32);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.onPaint);
            this.panel1.Resize += new System.EventHandler(this.onPanelResize);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.button6.Location = new System.Drawing.Point(375, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(23, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.clearWatchPath);
            // 
            // pathLabel
            // 
            this.pathLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.pathLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pathLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.pathLabel.Location = new System.Drawing.Point(8, 7);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.ReadOnly = true;
            this.pathLabel.Size = new System.Drawing.Size(361, 18);
            this.pathLabel.TabIndex = 0;
            this.pathLabel.TabStop = false;
            this.pathLabel.Text = "add a watch folder";
            this.pathLabel.WordWrap = false;
            // 
            // glacialList
            // 
            this.glacialList.AllowColumnResize = true;
            this.glacialList.AllowDrop = true;
            this.glacialList.AllowMultiselect = true;
            this.glacialList.AlternateBackground = System.Drawing.Color.DarkGreen;
            this.glacialList.AlternatingColors = false;
            this.glacialList.AutoHeight = true;
            this.glacialList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.glacialList.BackgroundStretchToFit = true;
            glColumn4.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.None;
            glColumn4.CheckBoxes = true;
            glColumn4.ImageIndex = -1;
            glColumn4.Name = "filename";
            glColumn4.NumericSort = false;
            glColumn4.Text = "  Name";
            glColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn4.Width = 140;
            glColumn5.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.None;
            glColumn5.CheckBoxes = false;
            glColumn5.ImageIndex = -1;
            glColumn5.Name = "path";
            glColumn5.NumericSort = false;
            glColumn5.Text = "  Path";
            glColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn5.Width = 370;
            this.glacialList.Columns.AddRange(new GlacialComponents.Controls.GLColumn[] {
            glColumn4,
            glColumn5});
            this.glacialList.ControlStyle = GlacialComponents.Controls.GLControlStyles.SuperFlat;
            this.glacialList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glacialList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.glacialList.FullRowSelect = false;
            this.glacialList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.glacialList.GridLines = GlacialComponents.Controls.GLGridLines.gridVertical;
            this.glacialList.GridLineStyle = GlacialComponents.Controls.GLGridLineStyles.gridSolid;
            this.glacialList.GridTypes = GlacialComponents.Controls.GLGridTypes.gridOnExists;
            this.glacialList.HeaderHeight = 24;
            this.glacialList.HeaderVisible = true;
            this.glacialList.HeaderWordWrap = false;
            this.glacialList.HotColumnTracking = false;
            this.glacialList.HotItemTracking = true;
            this.glacialList.HotTrackingColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.glacialList.HoverEvents = false;
            this.glacialList.HoverTime = 1;
            this.glacialList.ImageList = null;
            this.glacialList.ItemHeight = 17;
            this.glacialList.ItemWordWrap = false;
            this.glacialList.Location = new System.Drawing.Point(2, 2);
            this.glacialList.Name = "glacialList";
            this.glacialList.Selectable = true;
            this.glacialList.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.glacialList.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.glacialList.ShowBorder = false;
            this.glacialList.ShowFocusRect = false;
            this.glacialList.Size = new System.Drawing.Size(530, 256);
            this.glacialList.SortType = GlacialComponents.Controls.SortTypes.InsertionSort;
            this.glacialList.SuperFlatHeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.glacialList.TabIndex = 4;
            this.glacialList.Text = "glacialList1";
            this.glacialList.ItemChangedEvent += new GlacialComponents.Controls.ChangedEventHandler(this.glacialList_ItemChangedEvent);
            this.glacialList.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.glacialList.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.glacialList);
            this.panel2.Location = new System.Drawing.Point(52, 114);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(534, 260);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.onPaint);
            this.panel2.Resize += new System.EventHandler(this.onPanelResize);
            // 
            // glacialListPath
            // 
            this.glacialListPath.AllowColumnResize = true;
            this.glacialListPath.AllowDrop = true;
            this.glacialListPath.AllowMultiselect = true;
            this.glacialListPath.AlternateBackground = System.Drawing.Color.DarkGreen;
            this.glacialListPath.AlternatingColors = false;
            this.glacialListPath.AutoHeight = true;
            this.glacialListPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.glacialListPath.BackgroundStretchToFit = true;
            glColumn1.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.None;
            glColumn1.CheckBoxes = true;
            glColumn1.ImageIndex = -1;
            glColumn1.Name = "filename";
            glColumn1.NumericSort = false;
            glColumn1.Text = "  Destination Path";
            glColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn1.Width = 530;
            this.glacialListPath.Columns.AddRange(new GlacialComponents.Controls.GLColumn[] {
            glColumn1});
            this.glacialListPath.ControlStyle = GlacialComponents.Controls.GLControlStyles.SuperFlat;
            this.glacialListPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glacialListPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.glacialListPath.FullRowSelect = true;
            this.glacialListPath.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.glacialListPath.GridLines = GlacialComponents.Controls.GLGridLines.gridVertical;
            this.glacialListPath.GridLineStyle = GlacialComponents.Controls.GLGridLineStyles.gridNone;
            this.glacialListPath.GridTypes = GlacialComponents.Controls.GLGridTypes.gridOnExists;
            this.glacialListPath.HeaderHeight = 24;
            this.glacialListPath.HeaderVisible = true;
            this.glacialListPath.HeaderWordWrap = false;
            this.glacialListPath.HotColumnTracking = false;
            this.glacialListPath.HotItemTracking = true;
            this.glacialListPath.HotTrackingColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.glacialListPath.HoverEvents = false;
            this.glacialListPath.HoverTime = 1;
            this.glacialListPath.ImageList = null;
            this.glacialListPath.ItemHeight = 17;
            this.glacialListPath.ItemWordWrap = false;
            this.glacialListPath.Location = new System.Drawing.Point(2, 2);
            this.glacialListPath.Name = "glacialListPath";
            this.glacialListPath.Selectable = true;
            this.glacialListPath.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.glacialListPath.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.glacialListPath.ShowBorder = false;
            this.glacialListPath.ShowFocusRect = false;
            this.glacialListPath.Size = new System.Drawing.Size(530, 156);
            this.glacialListPath.SortType = GlacialComponents.Controls.SortTypes.InsertionSort;
            this.glacialListPath.SuperFlatHeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.glacialListPath.TabIndex = 4;
            this.glacialListPath.Text = "glacialListPath";
            this.glacialListPath.ItemChangedEvent += new GlacialComponents.Controls.ChangedEventHandler(this.glacialListPath_ItemChangedEvent);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.panel3.Controls.Add(this.glacialListPath);
            this.panel3.Location = new System.Drawing.Point(52, 436);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(534, 160);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.onPaint);
            this.panel3.Resize += new System.EventHandler(this.onPanelResize);
            // 
            // customButton4
            // 
            this.customButton4.backColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.customButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.customButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.customButton4.FlatAppearance.BorderSize = 0;
            this.customButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(59)))));
            this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton4.foreColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.customButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(59)))));
            this.customButton4.Location = new System.Drawing.Point(52, 647);
            this.customButton4.Name = "customButton4";
            this.customButton4.onPressBackColour = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(59)))));
            this.customButton4.onPressForeColour = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.customButton4.Size = new System.Drawing.Size(534, 39);
            this.customButton4.TabIndex = 15;
            this.customButton4.Text = "COPY";
            this.customButton4.UseVisualStyleBackColor = false;
            // 
            // btnRem
            // 
            this.btnRem.backColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.btnRem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.btnRem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRem.FlatAppearance.BorderSize = 0;
            this.btnRem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRem.foreColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.btnRem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.btnRem.Location = new System.Drawing.Point(391, 605);
            this.btnRem.Name = "btnRem";
            this.btnRem.onPressBackColour = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnRem.onPressForeColour = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.btnRem.Size = new System.Drawing.Size(93, 32);
            this.btnRem.TabIndex = 14;
            this.btnRem.Text = "Remove";
            this.btnRem.UseVisualStyleBackColor = false;
            this.btnRem.Click += new System.EventHandler(this.onPathButton);
            // 
            // btnRemAll
            // 
            this.btnRemAll.backColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.btnRemAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.btnRemAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemAll.FlatAppearance.BorderSize = 0;
            this.btnRemAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemAll.foreColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.btnRemAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.btnRemAll.Location = new System.Drawing.Point(490, 605);
            this.btnRemAll.Name = "btnRemAll";
            this.btnRemAll.onPressBackColour = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnRemAll.onPressForeColour = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.btnRemAll.Size = new System.Drawing.Size(96, 32);
            this.btnRemAll.TabIndex = 13;
            this.btnRemAll.Text = "Remove All";
            this.btnRemAll.UseVisualStyleBackColor = false;
            this.btnRemAll.Click += new System.EventHandler(this.onPathButton);
            // 
            // btnAddDestPath
            // 
            this.btnAddDestPath.backColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.btnAddDestPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.btnAddDestPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddDestPath.FlatAppearance.BorderSize = 0;
            this.btnAddDestPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(59)))));
            this.btnAddDestPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDestPath.foreColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnAddDestPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnAddDestPath.Location = new System.Drawing.Point(52, 605);
            this.btnAddDestPath.Name = "btnAddDestPath";
            this.btnAddDestPath.onPressBackColour = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(59)))));
            this.btnAddDestPath.onPressForeColour = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnAddDestPath.Size = new System.Drawing.Size(333, 32);
            this.btnAddDestPath.TabIndex = 12;
            this.btnAddDestPath.Text = "Add Path";
            this.btnAddDestPath.UseVisualStyleBackColor = false;
            this.btnAddDestPath.Click += new System.EventHandler(this.openFolder);
            // 
            // button5
            // 
            this.button5.backColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.foreColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.button5.Location = new System.Drawing.Point(388, 383);
            this.button5.Name = "button5";
            this.button5.onPressBackColour = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.button5.onPressForeColour = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.button5.Size = new System.Drawing.Size(96, 32);
            this.button5.TabIndex = 10;
            this.button5.Text = "Remove";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.onButtonClick);
            // 
            // button4
            // 
            this.button4.backColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.foreColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.button4.Location = new System.Drawing.Point(490, 383);
            this.button4.Name = "button4";
            this.button4.onPressBackColour = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.button4.onPressForeColour = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.button4.Size = new System.Drawing.Size(96, 32);
            this.button4.TabIndex = 9;
            this.button4.Text = "Remove All";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.onButtonClick);
            // 
            // button3
            // 
            this.button3.backColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(59)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.foreColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.button3.Location = new System.Drawing.Point(286, 383);
            this.button3.Name = "button3";
            this.button3.onPressBackColour = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(59)))));
            this.button3.onPressForeColour = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.button3.Size = new System.Drawing.Size(96, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.onButtonClick);
            // 
            // button2
            // 
            this.button2.backColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(59)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.foreColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.button2.Location = new System.Drawing.Point(184, 383);
            this.button2.Name = "button2";
            this.button2.onPressBackColour = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(59)))));
            this.button2.onPressForeColour = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.button2.Size = new System.Drawing.Size(96, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Invert";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.onButtonClick);
            // 
            // button1
            // 
            this.button1.backColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(59)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.foreColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.button1.Location = new System.Drawing.Point(52, 383);
            this.button1.Name = "button1";
            this.button1.onPressBackColour = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(59)))));
            this.button1.onPressForeColour = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.button1.Size = new System.Drawing.Size(126, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Select All";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.onButtonClick);
            // 
            // customLabel1
            // 
            customLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            customLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            customLabel1.Location = new System.Drawing.Point(0, 0);
            customLabel1.Name = "customLabel1";
            customLabel1.Size = new System.Drawing.Size(120, 32);
            customLabel1.TabIndex = 0;
            customLabel1.Text = "METACOPY";
            customLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            customLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(638, 768);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelStat);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.customButton4);
            this.Controls.Add(this.btnRem);
            this.Controls.Add(this.btnRemAll);
            this.Controls.Add(this.btnAddDestPath);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpenPath);
            this.Controls.Add(label1);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 770);
            this.MinimumSize = new System.Drawing.Size(640, 770);
            this.Name = "Form1";
            this.panelTitle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button btnOpenPath;
        private GlacialComponents.Controls.GlacialList glacialList;
        private CustomButton button1;
        private CustomButton button2;
        private CustomButton button3;
        private CustomButton button4;
        private CustomButton button5;
        private GlacialComponents.Controls.GlacialList glacialListPath;
        private CustomButton btnAddDestPath;
        private CustomButton btnRem;
        private CustomButton btnRemAll;
        private CustomButton customButton4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelStat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox pathLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button6;
    }
}

