﻿namespace Spaceinvaders
{
    partial class Jugar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jugar));
            this.SuspendLayout();
            // 
            // Jugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(746, 749);
            this.Name = "Jugar";
            this.Text = "Jugar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Jugar_FormClosed);
            this.Load += new System.EventHandler(this.Jugar_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Jugar_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion
    }
}