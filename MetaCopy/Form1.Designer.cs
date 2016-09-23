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
            MetaCopy.Components.CustomLabel customLabel1;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.borderedPanel1 = new MetaCopy.Components.BorderedPanel();
            this.btnOpenPath = new System.Windows.Forms.Button();
            customLabel1 = new MetaCopy.Components.CustomLabel();
            label1 = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(208)))), ((int)(((byte)(59)))));
            this.panelTitle.Controls.Add(customLabel1);
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(640, 48);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // customLabel1
            // 
            customLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            customLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            customLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            customLabel1.Location = new System.Drawing.Point(0, 0);
            customLabel1.Name = "customLabel1";
            customLabel1.Size = new System.Drawing.Size(640, 48);
            customLabel1.TabIndex = 0;
            customLabel1.Text = "MetaCopy";
            customLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            customLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // borderedPanel1
            // 
            this.borderedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.borderedPanel1.DefaultBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.borderedPanel1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.borderedPanel1.Location = new System.Drawing.Point(144, 60);
            this.borderedPanel1.Name = "borderedPanel1";
            this.borderedPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.borderedPanel1.Size = new System.Drawing.Size(410, 32);
            this.borderedPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
            label1.Location = new System.Drawing.Point(48, 66);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 18);
            label1.TabIndex = 2;
            label1.Text = "Source Path";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOpenPath
            // 
            this.btnOpenPath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenPath.BackgroundImage")));
            this.btnOpenPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPath.Location = new System.Drawing.Point(560, 60);
            this.btnOpenPath.Name = "btnOpenPath";
            this.btnOpenPath.Size = new System.Drawing.Size(32, 32);
            this.btnOpenPath.TabIndex = 3;
            this.btnOpenPath.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(638, 718);
            this.ControlBox = false;
            this.Controls.Add(this.btnOpenPath);
            this.Controls.Add(label1);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.borderedPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 720);
            this.MinimumSize = new System.Drawing.Size(640, 720);
            this.Name = "Form1";
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private Components.BorderedPanel borderedPanel1;
        private System.Windows.Forms.Button btnOpenPath;
    }
}

