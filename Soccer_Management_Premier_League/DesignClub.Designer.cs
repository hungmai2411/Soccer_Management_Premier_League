
namespace Soccer_Management_Premier_League
{
    partial class DesignClub
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgClub = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbNameClub = new System.Windows.Forms.Label();
            this.lbStadium = new System.Windows.Forms.Label();
            this.lbClick = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.lbClick);
            this.panel1.Controls.Add(this.lbStadium);
            this.panel1.Controls.Add(this.lbNameClub);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 136);
            this.panel1.TabIndex = 1;
            // 
            // imgClub
            // 
            this.imgClub.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.imgClub.CheckedState.Parent = this.imgClub;
            this.imgClub.CustomImages.Parent = this.imgClub;
            this.imgClub.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.imgClub.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.imgClub.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.imgClub.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.imgClub.DisabledState.Parent = this.imgClub;
            this.imgClub.FillColor = System.Drawing.Color.White;
            this.imgClub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.imgClub.ForeColor = System.Drawing.Color.White;
            this.imgClub.HoverState.Parent = this.imgClub;
            this.imgClub.Image = global::Soccer_Management_Premier_League.Properties.Resources.ARS1;
            this.imgClub.ImageSize = new System.Drawing.Size(100, 100);
            this.imgClub.Location = new System.Drawing.Point(61, 86);
            this.imgClub.Name = "imgClub";
            this.imgClub.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imgClub.ShadowDecoration.Parent = this.imgClub;
            this.imgClub.Size = new System.Drawing.Size(96, 98);
            this.imgClub.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Soccer_Management_Premier_League.Properties.Resources.alex_motoc_7NhFrPxlgM8_unsplash;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbNameClub
            // 
            this.lbNameClub.AutoSize = true;
            this.lbNameClub.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lbNameClub.ForeColor = System.Drawing.Color.White;
            this.lbNameClub.Location = new System.Drawing.Point(72, 57);
            this.lbNameClub.Name = "lbNameClub";
            this.lbNameClub.Size = new System.Drawing.Size(74, 25);
            this.lbNameClub.TabIndex = 0;
            this.lbNameClub.Text = "Arsenal";
            this.lbNameClub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbStadium
            // 
            this.lbStadium.AutoSize = true;
            this.lbStadium.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStadium.ForeColor = System.Drawing.Color.White;
            this.lbStadium.Location = new System.Drawing.Point(47, 84);
            this.lbStadium.Name = "lbStadium";
            this.lbStadium.Size = new System.Drawing.Size(125, 20);
            this.lbStadium.TabIndex = 1;
            this.lbStadium.Text = "Emirates Stadium";
            this.lbStadium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbClick
            // 
            this.lbClick.AutoSize = true;
            this.lbClick.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClick.ForeColor = System.Drawing.Color.White;
            this.lbClick.Location = new System.Drawing.Point(57, 112);
            this.lbClick.Name = "lbClick";
            this.lbClick.Size = new System.Drawing.Size(109, 20);
            this.lbClick.TabIndex = 2;
            this.lbClick.Text = "Club Profile ->";
            this.lbClick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DesignClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.imgClub);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DesignClub";
            this.Size = new System.Drawing.Size(213, 270);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbClick;
        public Guna.UI2.WinForms.Guna2CircleButton imgClub;
        public System.Windows.Forms.Label lbStadium;
        public System.Windows.Forms.Label lbNameClub;
        public System.Windows.Forms.Panel panel1;
    }
}
