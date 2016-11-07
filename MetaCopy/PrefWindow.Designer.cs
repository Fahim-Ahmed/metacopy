namespace MetaCopy {
    partial class PrefWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrefWindow));
            this.LabelHint = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.customButton1 = new MetaCopy.Components.CustomButton();
            this.btnReg = new MetaCopy.Components.CustomButton();
            this.SuspendLayout();
            // 
            // LabelHint
            // 
            this.LabelHint.AutoSize = true;
            this.LabelHint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.LabelHint.Location = new System.Drawing.Point(32, 48);
            this.LabelHint.Name = "LabelHint";
            this.LabelHint.Size = new System.Drawing.Size(145, 13);
            this.LabelHint.TabIndex = 6;
            this.LabelHint.Text = "Windows Shell Integration";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(209, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 26);
            this.btnClose.TabIndex = 20;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.onCloseBtn);
            // 
            // customButton1
            // 
            this.customButton1.backColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.customButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(59)))));
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.foreColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.customButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.customButton1.Location = new System.Drawing.Point(35, 106);
            this.customButton1.Name = "customButton1";
            this.customButton1.onPressBackColour = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.customButton1.onPressForeColour = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.customButton1.Size = new System.Drawing.Size(177, 32);
            this.customButton1.TabIndex = 8;
            this.customButton1.Text = "Deregister Handler";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.onDeregisterBtn);
            // 
            // btnReg
            // 
            this.btnReg.backColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.btnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.btnReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReg.FlatAppearance.BorderSize = 0;
            this.btnReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(59)))));
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.foreColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            this.btnReg.Location = new System.Drawing.Point(35, 68);
            this.btnReg.Name = "btnReg";
            this.btnReg.onPressBackColour = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(59)))));
            this.btnReg.onPressForeColour = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnReg.Size = new System.Drawing.Size(177, 32);
            this.btnReg.TabIndex = 7;
            this.btnReg.Text = "Register Handler";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.onRegisterBtn);
            // 
            // PrefWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(238, 318);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.LabelHint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PrefWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Components.CustomButton btnReg;
        private Components.CustomButton customButton1;
        private System.Windows.Forms.Label LabelHint;
        private System.Windows.Forms.Button btnClose;
    }
}