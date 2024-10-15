namespace task_2
{
    partial class AdditionalInfoForm
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
            this.tbDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbDetails
            // 
            this.tbDetails.BackColor = System.Drawing.Color.LightCyan;
            this.tbDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbDetails.ForeColor = System.Drawing.Color.Teal;
            this.tbDetails.Location = new System.Drawing.Point(4, 3);
            this.tbDetails.Multiline = true;
            this.tbDetails.Name = "tbDetails";
            this.tbDetails.ReadOnly = true;
            this.tbDetails.Size = new System.Drawing.Size(390, 170);
            this.tbDetails.TabIndex = 0;
            this.tbDetails.TextChanged += new System.EventHandler(this.tbDetails_TextChanged);
            // 
            // AdditionalInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(397, 178);
            this.Controls.Add(this.tbDetails);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Teal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdditionalInfoForm";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додаткові відомості";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDetails;
    }
}