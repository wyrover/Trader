﻿namespace Trader
{
    partial class HealthBarUserControl
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
            this.healthProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // healthProgressBar
            // 
            this.healthProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.healthProgressBar.Location = new System.Drawing.Point(3, 3);
            this.healthProgressBar.Name = "healthProgressBar";
            this.healthProgressBar.Size = new System.Drawing.Size(304, 42);
            this.healthProgressBar.TabIndex = 0;
            // 
            // HealthBarUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.healthProgressBar);
            this.Name = "HealthBarUserControl";
            this.Size = new System.Drawing.Size(310, 48);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar healthProgressBar;
    }
}
