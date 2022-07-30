
namespace semana2_formulario
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.nombre1 = new System.Windows.Forms.Label();
            this.nombre2 = new System.Windows.Forms.Label();
            this.nombre3 = new System.Windows.Forms.Label();
            this.nombre4 = new System.Windows.Forms.Label();
            this.nombre5 = new System.Windows.Forms.Label();
            this.nombre6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.nombre7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(195, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Integrantes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombre1
            // 
            this.nombre1.AutoSize = true;
            this.nombre1.Location = new System.Drawing.Point(159, 127);
            this.nombre1.Name = "nombre1";
            this.nombre1.Size = new System.Drawing.Size(0, 13);
            this.nombre1.TabIndex = 1;
            this.nombre1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nombre2
            // 
            this.nombre2.AutoSize = true;
            this.nombre2.Location = new System.Drawing.Point(159, 186);
            this.nombre2.Name = "nombre2";
            this.nombre2.Size = new System.Drawing.Size(0, 13);
            this.nombre2.TabIndex = 2;
            this.nombre2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nombre3
            // 
            this.nombre3.AutoSize = true;
            this.nombre3.Location = new System.Drawing.Point(159, 234);
            this.nombre3.Name = "nombre3";
            this.nombre3.Size = new System.Drawing.Size(0, 13);
            this.nombre3.TabIndex = 3;
            // 
            // nombre4
            // 
            this.nombre4.AutoSize = true;
            this.nombre4.Location = new System.Drawing.Point(412, 127);
            this.nombre4.Name = "nombre4";
            this.nombre4.Size = new System.Drawing.Size(0, 13);
            this.nombre4.TabIndex = 4;
            // 
            // nombre5
            // 
            this.nombre5.AutoSize = true;
            this.nombre5.Location = new System.Drawing.Point(412, 186);
            this.nombre5.Name = "nombre5";
            this.nombre5.Size = new System.Drawing.Size(0, 13);
            this.nombre5.TabIndex = 5;
            this.nombre5.Click += new System.EventHandler(this.label5_Click);
            // 
            // nombre6
            // 
            this.nombre6.AutoSize = true;
            this.nombre6.Location = new System.Drawing.Point(412, 233);
            this.nombre6.Name = "nombre6";
            this.nombre6.Size = new System.Drawing.Size(0, 13);
            this.nombre6.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(237, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 53);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(456, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "Borrar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nombre7
            // 
            this.nombre7.AutoSize = true;
            this.nombre7.Location = new System.Drawing.Point(271, 262);
            this.nombre7.Name = "nombre7";
            this.nombre7.Size = new System.Drawing.Size(0, 13);
            this.nombre7.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.nombre7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nombre6);
            this.Controls.Add(this.nombre5);
            this.Controls.Add(this.nombre4);
            this.Controls.Add(this.nombre3);
            this.Controls.Add(this.nombre2);
            this.Controls.Add(this.nombre1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nombre1;
        private System.Windows.Forms.Label nombre2;
        private System.Windows.Forms.Label nombre3;
        private System.Windows.Forms.Label nombre4;
        private System.Windows.Forms.Label nombre5;
        private System.Windows.Forms.Label nombre6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label nombre7;
    }
}

