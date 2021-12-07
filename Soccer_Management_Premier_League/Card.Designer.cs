
namespace Soccer_Management_Premier_League
{
    partial class Card
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
            this.lbPlayer = new Guna.UI.WinForms.GunaLabel();
            this.lbTime = new Guna.UI.WinForms.GunaLabel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbPlayer
            // 
            this.lbPlayer.AutoSize = true;
            this.lbPlayer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbPlayer.Location = new System.Drawing.Point(2, 7);
            this.lbPlayer.Name = "lbPlayer";
            this.lbPlayer.Size = new System.Drawing.Size(162, 20);
            this.lbPlayer.TabIndex = 1;
            this.lbPlayer.Text = "Cristial Ronaldo            ";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbTime.Location = new System.Drawing.Point(174, 10);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(19, 15);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "60";
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.Yellow;
            this.pnlCard.Location = new System.Drawing.Point(244, 5);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(15, 20);
            this.pnlCard.TabIndex = 3;
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbPlayer);
            this.Name = "Card";
            this.Size = new System.Drawing.Size(384, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaLabel lbPlayer;
        public Guna.UI.WinForms.GunaLabel lbTime;
        public System.Windows.Forms.Panel pnlCard;
    }
}
