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
            MetaCopy.Components.CustomLabel customLabel1;
            GlacialComponents.Controls.GLColumn glColumn1 = new GlacialComponents.Controls.GLColumn();
            GlacialComponents.Controls.GLColumn glColumn2 = new GlacialComponents.Controls.GLColumn();
            MetaCopy.Components.BorderedPanel borderedPanel3;
            GlacialComponents.Controls.GLColumn glColumn3 = new GlacialComponents.Controls.GLColumn();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnOpenPath = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelStat = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.customButton4 = new MetaCopy.Components.CustomButton();
            this.customButton2 = new MetaCopy.Components.CustomButton();
            this.customButton3 = new MetaCopy.Components.CustomButton();
            this.customButton1 = new MetaCopy.Components.CustomButton();
            this.button5 = new MetaCopy.Components.CustomButton();
            this.button4 = new MetaCopy.Components.CustomButton();
            this.button3 = new MetaCopy.Components.CustomButton();
            this.button2 = new MetaCopy.Components.CustomButton();
            this.button1 = new MetaCopy.Components.CustomButton();
            this.borderedPanel1 = new MetaCopy.Components.BorderedPanel();
            this.borderedPanel2 = new MetaCopy.Components.BorderedPanel();
            this.glacialList = new GlacialComponents.Controls.GlacialList();
            this.glacialListPath = new GlacialComponents.Controls.GlacialList();
            label1 = new System.Windows.Forms.Label();
            customLabel1 = new MetaCopy.Components.CustomLabel();
            borderedPanel3 = new MetaCopy.Components.BorderedPanel();
            this.panelTitle.SuspendLayout();
            this.borderedPanel2.SuspendLayout();
            borderedPanel3.SuspendLayout();
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
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.checkBox1.Location = new System.Drawing.Point(501, 692);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 20);
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
            // customButton4
            // 
            this.customButton4.backColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.customButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.customButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.customButton4.FlatAppearance.BorderSize = 0;
            this.customButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(59)))));
            this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton4.foreColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.customButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(59)))));
            this.customButton4.Location = new System.Drawing.Point(52, 647);
            this.customButton4.Name = "customButton4";
            this.customButton4.onPressBackColour = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(59)))));
            this.customButton4.onPressForeColour = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.customButton4.Size = new System.Drawing.Size(534, 39);
            this.customButton4.TabIndex = 15;
            this.customButton4.Text = "Copy";
            this.customButton4.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            this.customButton2.backColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.customButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.foreColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.customButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.customButton2.Location = new System.Drawing.Point(391, 605);
            this.customButton2.Name = "customButton2";
            this.customButton2.onPressBackColour = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.customButton2.onPressForeColour = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.customButton2.Size = new System.Drawing.Size(93, 32);
            this.customButton2.TabIndex = 14;
            this.customButton2.Text = "Remove";
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // customButton3
            // 
            this.customButton3.backColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.customButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.customButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.foreColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.customButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.customButton3.Location = new System.Drawing.Point(490, 605);
            this.customButton3.Name = "customButton3";
            this.customButton3.onPressBackColour = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.customButton3.onPressForeColour = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.customButton3.Size = new System.Drawing.Size(96, 32);
            this.customButton3.TabIndex = 13;
            this.customButton3.Text = "Remove All";
            this.customButton3.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            this.customButton1.backColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.customButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(59)))));
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.foreColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.customButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.customButton1.Location = new System.Drawing.Point(52, 605);
            this.customButton1.Name = "customButton1";
            this.customButton1.onPressBackColour = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(59)))));
            this.customButton1.onPressForeColour = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.customButton1.Size = new System.Drawing.Size(333, 32);
            this.customButton1.TabIndex = 12;
            this.customButton1.Text = "Add Path";
            this.customButton1.UseVisualStyleBackColor = false;
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
            // borderedPanel1
            // 
            this.borderedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.borderedPanel1.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.borderedPanel1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.borderedPanel1.Location = new System.Drawing.Point(151, 60);
            this.borderedPanel1.Name = "borderedPanel1";
            this.borderedPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.borderedPanel1.Size = new System.Drawing.Size(403, 32);
            this.borderedPanel1.TabIndex = 1;
            // 
            // borderedPanel2
            // 
            this.borderedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.borderedPanel2.Controls.Add(this.glacialList);
            this.borderedPanel2.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.borderedPanel2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.borderedPanel2.Location = new System.Drawing.Point(52, 114);
            this.borderedPanel2.Name = "borderedPanel2";
            this.borderedPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.borderedPanel2.Size = new System.Drawing.Size(534, 260);
            this.borderedPanel2.TabIndex = 5;
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
            glColumn1.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.None;
            glColumn1.CheckBoxes = true;
            glColumn1.ImageIndex = -1;
            glColumn1.Name = "filename";
            glColumn1.NumericSort = false;
            glColumn1.Text = "  Name";
            glColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn1.Width = 140;
            glColumn2.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.None;
            glColumn2.CheckBoxes = false;
            glColumn2.ImageIndex = -1;
            glColumn2.Name = "path";
            glColumn2.NumericSort = false;
            glColumn2.Text = "  Path";
            glColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn2.Width = 385;
            this.glacialList.Columns.AddRange(new GlacialComponents.Controls.GLColumn[] {
            glColumn1,
            glColumn2});
            this.glacialList.ControlStyle = GlacialComponents.Controls.GLControlStyles.SuperFlat;
            this.glacialList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.glacialList.FullRowSelect = true;
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
            this.glacialList.Location = new System.Drawing.Point(4, 4);
            this.glacialList.Name = "glacialList";
            this.glacialList.Selectable = true;
            this.glacialList.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.glacialList.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.glacialList.ShowBorder = false;
            this.glacialList.ShowFocusRect = false;
            this.glacialList.Size = new System.Drawing.Size(526, 259);
            this.glacialList.SortType = GlacialComponents.Controls.SortTypes.InsertionSort;
            this.glacialList.SuperFlatHeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.glacialList.TabIndex = 4;
            this.glacialList.Text = "glacialList1";
            this.glacialList.ItemChangedEvent += new GlacialComponents.Controls.ChangedEventHandler(this.glacialList_ItemChangedEvent);
            this.glacialList.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.glacialList.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.glacialList.MouseEnter += new System.EventHandler(this.onEnter);
            // 
            // borderedPanel3
            // 
            borderedPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            borderedPanel3.Controls.Add(this.glacialListPath);
            borderedPanel3.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            borderedPanel3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            borderedPanel3.Location = new System.Drawing.Point(52, 436);
            borderedPanel3.Name = "borderedPanel3";
            borderedPanel3.Padding = new System.Windows.Forms.Padding(1);
            borderedPanel3.Size = new System.Drawing.Size(534, 160);
            borderedPanel3.TabIndex = 11;
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
            glColumn3.ActivatedEmbeddedType = GlacialComponents.Controls.GLActivatedEmbeddedTypes.None;
            glColumn3.CheckBoxes = true;
            glColumn3.ImageIndex = -1;
            glColumn3.Name = "filename";
            glColumn3.NumericSort = false;
            glColumn3.Text = "  Destination Path";
            glColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            glColumn3.Width = 520;
            this.glacialListPath.Columns.AddRange(new GlacialComponents.Controls.GLColumn[] {
            glColumn3});
            this.glacialListPath.ControlStyle = GlacialComponents.Controls.GLControlStyles.SuperFlat;
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
            this.glacialListPath.Location = new System.Drawing.Point(4, 4);
            this.glacialListPath.Name = "glacialListPath";
            this.glacialListPath.Selectable = true;
            this.glacialListPath.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.glacialListPath.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.glacialListPath.ShowBorder = false;
            this.glacialListPath.ShowFocusRect = false;
            this.glacialListPath.Size = new System.Drawing.Size(526, 159);
            this.glacialListPath.SortType = GlacialComponents.Controls.SortTypes.InsertionSort;
            this.glacialListPath.SuperFlatHeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.glacialListPath.TabIndex = 4;
            this.glacialListPath.Text = "glacialListPath";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(638, 768);
            this.ControlBox = false;
            this.Controls.Add(this.labelStat);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.customButton4);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpenPath);
            this.Controls.Add(label1);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.borderedPanel1);
            this.Controls.Add(this.borderedPanel2);
            this.Controls.Add(borderedPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 770);
            this.MinimumSize = new System.Drawing.Size(640, 770);
            this.Name = "Form1";
            this.panelTitle.ResumeLayout(false);
            this.borderedPanel2.ResumeLayout(false);
            borderedPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private Components.BorderedPanel borderedPanel1;
        private System.Windows.Forms.Button btnOpenPath;
        private GlacialComponents.Controls.GlacialList glacialList;
        private CustomButton button1;
        private CustomButton button2;
        private CustomButton button3;
        private CustomButton button4;
        private CustomButton button5;
        private GlacialComponents.Controls.GlacialList glacialListPath;
        private CustomButton customButton1;
        private CustomButton customButton2;
        private CustomButton customButton3;
        private CustomButton customButton4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelStat;
        private BorderedPanel borderedPanel2;
    }
}

