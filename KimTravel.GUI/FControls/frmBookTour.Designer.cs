namespace KimTravel.GUI.UControls
{
    partial class frmBookTour
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
            this.ucBook1 = new KimTravel.GUI.UControls.UCBook();
            this.SuspendLayout();
            // 
            // ucBook1
            // 
            this.ucBook1.AutoScroll = true;
            this.ucBook1.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.ucBook1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBook1.Location = new System.Drawing.Point(0, 0);
            this.ucBook1.Name = "ucBook1";
            this.ucBook1.Size = new System.Drawing.Size(1098, 524);
            this.ucBook1.TabIndex = 0;
            this.ucBook1.Tag = "";
            // 
            // frmBookTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.ClientSize = new System.Drawing.Size(1098, 524);
            this.Controls.Add(this.ucBook1);
            this.Name = "frmBookTour";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Book Tour";
            this.Load += new System.EventHandler(this.UCGroupTour_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UCBook ucBook1;
    }
}
