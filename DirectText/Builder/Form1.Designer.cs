namespace Builder
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
            this.xylosTabControl1 = new XylosTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtComs = new System.Windows.Forms.TextBox();
            this.btnBuild = new XylosButton();
            this.txtURL = new XylosTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xylosTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xylosTabControl1
            // 
            this.xylosTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.xylosTabControl1.Controls.Add(this.tabPage1);
            this.xylosTabControl1.FirstHeaderBorder = false;
            this.xylosTabControl1.ItemSize = new System.Drawing.Size(40, 130);
            this.xylosTabControl1.Location = new System.Drawing.Point(-1, 0);
            this.xylosTabControl1.Multiline = true;
            this.xylosTabControl1.Name = "xylosTabControl1";
            this.xylosTabControl1.SelectedIndex = 0;
            this.xylosTabControl1.Size = new System.Drawing.Size(478, 471);
            this.xylosTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.xylosTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.txtComs);
            this.tabPage1.Controls.Add(this.btnBuild);
            this.tabPage1.Controls.Add(this.txtURL);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabPage1.Location = new System.Drawing.Point(134, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(340, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            // 
            // txtComs
            // 
            this.txtComs.Location = new System.Drawing.Point(12, 97);
            this.txtComs.Multiline = true;
            this.txtComs.Name = "txtComs";
            this.txtComs.Size = new System.Drawing.Size(319, 360);
            this.txtComs.TabIndex = 3;
            // 
            // btnBuild
            // 
            this.btnBuild.EnabledCalc = true;
            this.btnBuild.Location = new System.Drawing.Point(90, 58);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(97, 33);
            this.btnBuild.TabIndex = 2;
            this.btnBuild.Text = "Build";
            this.btnBuild.Click += new XylosButton.ClickEventHandler(this.btnBuild_Click);
            // 
            // txtURL
            // 
            this.txtURL.EnabledCalc = true;
            this.txtURL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtURL.Location = new System.Drawing.Point(60, 23);
            this.txtURL.MaxLength = 32767;
            this.txtURL.MultiLine = false;
            this.txtURL.Name = "txtURL";
            this.txtURL.ReadOnly = false;
            this.txtURL.Size = new System.Drawing.Size(271, 29);
            this.txtURL.TabIndex = 1;
            this.txtURL.Text = "http://pastebin.com/raw";
            this.txtURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtURL.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(476, 469);
            this.Controls.Add(this.xylosTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Builder";
            this.xylosTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XylosTabControl xylosTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private XylosButton btnBuild;
        private XylosTextBox txtURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComs;
    }
}

