namespace MistelteinnDirectoryProject
{
    partial class Initialize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Initialize));
            this.siticoneElipse1 = new ns1.SiticoneElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.LogoInitialize = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoInitialize)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 5;
            this.siticoneElipse1.TargetControl = this;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 3;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 50;
            this.bunifuPictureBox1.Image = global::MistelteinnDirectoryProject.Properties.Resources.LogoFix;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(150, 30);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 2;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // LogoInitialize
            // 
            this.LogoInitialize.AllowFocused = false;
            this.LogoInitialize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogoInitialize.BackColor = System.Drawing.Color.Transparent;
            this.LogoInitialize.BorderRadius = 0;
            this.LogoInitialize.Image = ((System.Drawing.Image)(resources.GetObject("LogoInitialize.Image")));
            this.LogoInitialize.IsCircle = false;
            this.LogoInitialize.Location = new System.Drawing.Point(150, 30);
            this.LogoInitialize.Name = "LogoInitialize";
            this.LogoInitialize.Size = new System.Drawing.Size(100, 100);
            this.LogoInitialize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoInitialize.TabIndex = 1;
            this.LogoInitialize.TabStop = false;
            this.LogoInitialize.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // Initialize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.LogoInitialize);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Initialize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoInitialize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.SiticoneElipse siticoneElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPictureBox LogoInitialize;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
    }
}

