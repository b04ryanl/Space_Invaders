namespace Spaceinvaders
{
    partial class CrearPartida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearPartida));
            this.Btn_Crear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DirIp = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Btn_Crear
            // 
            this.Btn_Crear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Crear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Crear.Enabled = false;
            this.Btn_Crear.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Crear.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Crear.Location = new System.Drawing.Point(290, 591);
            this.Btn_Crear.Name = "Btn_Crear";
            this.Btn_Crear.Size = new System.Drawing.Size(188, 49);
            this.Btn_Crear.TabIndex = 1;
            this.Btn_Crear.Text = "Comenzar";
            this.Btn_Crear.UseVisualStyleBackColor = false;
            this.Btn_Crear.Click += new System.EventHandler(this.Btn_Crear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(99, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Esperando a que se conecte el otro jugador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(75, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(617, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Recuerda que debe conectarse con la siguiente Ip";
            // 
            // DirIp
            // 
            this.DirIp.AutoSize = true;
            this.DirIp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DirIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirIp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DirIp.Location = new System.Drawing.Point(269, 489);
            this.DirIp.Name = "DirIp";
            this.DirIp.Size = new System.Drawing.Size(0, 31);
            this.DirIp.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CrearPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(752, 742);
            this.Controls.Add(this.DirIp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Crear);
            this.Name = "CrearPartida";
            this.Text = "CrearPartida";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CrearPartida_FormClosed);
            this.Load += new System.EventHandler(this.CrearPartida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Crear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DirIp;
        private System.Windows.Forms.Timer timer1;
    }
}