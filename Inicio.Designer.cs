namespace Spaceinvaders
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.Btn_Crear = new System.Windows.Forms.Button();
            this.Btn_Unirse = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Crear
            // 
            this.Btn_Crear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Crear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Crear.BackgroundImage")));
            this.Btn_Crear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Crear.Location = new System.Drawing.Point(225, 401);
            this.Btn_Crear.Name = "Btn_Crear";
            this.Btn_Crear.Size = new System.Drawing.Size(347, 49);
            this.Btn_Crear.TabIndex = 0;
            this.Btn_Crear.UseVisualStyleBackColor = false;
            this.Btn_Crear.Click += new System.EventHandler(this.Btn_Crear_Click);
            // 
            // Btn_Unirse
            // 
            this.Btn_Unirse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Unirse.BackgroundImage")));
            this.Btn_Unirse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Unirse.Location = new System.Drawing.Point(225, 471);
            this.Btn_Unirse.Name = "Btn_Unirse";
            this.Btn_Unirse.Size = new System.Drawing.Size(347, 49);
            this.Btn_Unirse.TabIndex = 1;
            this.Btn_Unirse.UseVisualStyleBackColor = true;
            this.Btn_Unirse.Click += new System.EventHandler(this.Btn_Unirse_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.BackgroundImage")));
            this.Btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Salir.Location = new System.Drawing.Point(225, 542);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(347, 49);
            this.Btn_Salir.TabIndex = 2;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(740, 718);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Unirse);
            this.Controls.Add(this.Btn_Crear);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inicio_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Crear;
        private System.Windows.Forms.Button Btn_Unirse;
        private System.Windows.Forms.Button Btn_Salir;
    }
}

