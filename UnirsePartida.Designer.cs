namespace Spaceinvaders
{
    partial class UnirsePartida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnirsePartida));
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_IP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(169, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Por favor ingrese la IP del Servidor";
            // 
            // Tb_IP
            // 
            this.Tb_IP.Location = new System.Drawing.Point(305, 467);
            this.Tb_IP.Name = "Tb_IP";
            this.Tb_IP.Size = new System.Drawing.Size(128, 20);
            this.Tb_IP.TabIndex = 4;
            this.Tb_IP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_IP_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(239, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = " y luego presione Enter";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UnirsePartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(773, 726);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_IP);
            this.Controls.Add(this.label1);
            this.Name = "UnirsePartida";
            this.Text = "UnirsePartida";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UnirsePartida_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_IP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}