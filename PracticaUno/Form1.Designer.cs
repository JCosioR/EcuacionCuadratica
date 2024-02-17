namespace PracticaUno
{
    partial class Lbl_Ecuacion
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
            this.Tbx_a = new System.Windows.Forms.TextBox();
            this.Tbx_b = new System.Windows.Forms.TextBox();
            this.Tbx_c = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Exp = new System.Windows.Forms.Label();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_x1 = new System.Windows.Forms.Label();
            this.Lbl_x2 = new System.Windows.Forms.Label();
            this.Btn_Resolver = new System.Windows.Forms.Button();
            this.Lbl_b = new System.Windows.Forms.Label();
            this.Lbl_a = new System.Windows.Forms.Label();
            this.Lbl_c = new System.Windows.Forms.Label();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tbx_a
            // 
            this.Tbx_a.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_a.Location = new System.Drawing.Point(63, 47);
            this.Tbx_a.Name = "Tbx_a";
            this.Tbx_a.Size = new System.Drawing.Size(38, 38);
            this.Tbx_a.TabIndex = 0;
            this.Tbx_a.Text = "a";
            this.Tbx_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tbx_b
            // 
            this.Tbx_b.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_b.Location = new System.Drawing.Point(150, 49);
            this.Tbx_b.Name = "Tbx_b";
            this.Tbx_b.Size = new System.Drawing.Size(39, 38);
            this.Tbx_b.TabIndex = 1;
            this.Tbx_b.Text = "b";
            this.Tbx_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tbx_c
            // 
            this.Tbx_c.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_c.Location = new System.Drawing.Point(236, 47);
            this.Tbx_c.Name = "Tbx_c";
            this.Tbx_c.Size = new System.Drawing.Size(40, 38);
            this.Tbx_c.TabIndex = 2;
            this.Tbx_c.Text = "c";
            this.Tbx_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "    x +      x +      = 0";
            // 
            // Lbl_Exp
            // 
            this.Lbl_Exp.AutoSize = true;
            this.Lbl_Exp.Location = new System.Drawing.Point(118, 49);
            this.Lbl_Exp.Name = "Lbl_Exp";
            this.Lbl_Exp.Size = new System.Drawing.Size(13, 13);
            this.Lbl_Exp.TabIndex = 5;
            this.Lbl_Exp.Text = "2";
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Arial Black", 20F);
            this.Lbl_Titulo.Location = new System.Drawing.Point(12, 6);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(325, 38);
            this.Lbl_Titulo.TabIndex = 6;
            this.Lbl_Titulo.Text = "Ecuación Cuadrática";
            // 
            // Lbl_x1
            // 
            this.Lbl_x1.AutoSize = true;
            this.Lbl_x1.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.Lbl_x1.Location = new System.Drawing.Point(167, 128);
            this.Lbl_x1.Name = "Lbl_x1";
            this.Lbl_x1.Size = new System.Drawing.Size(56, 31);
            this.Lbl_x1.TabIndex = 7;
            this.Lbl_x1.Text = "x1 =";
            // 
            // Lbl_x2
            // 
            this.Lbl_x2.AutoSize = true;
            this.Lbl_x2.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.Lbl_x2.Location = new System.Drawing.Point(167, 159);
            this.Lbl_x2.Name = "Lbl_x2";
            this.Lbl_x2.Size = new System.Drawing.Size(56, 31);
            this.Lbl_x2.TabIndex = 8;
            this.Lbl_x2.Text = "x2 =";
            // 
            // Btn_Resolver
            // 
            this.Btn_Resolver.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.Btn_Resolver.Location = new System.Drawing.Point(228, 90);
            this.Btn_Resolver.Name = "Btn_Resolver";
            this.Btn_Resolver.Size = new System.Drawing.Size(109, 34);
            this.Btn_Resolver.TabIndex = 9;
            this.Btn_Resolver.Text = "Resolver";
            this.Btn_Resolver.UseVisualStyleBackColor = true;
            this.Btn_Resolver.Click += new System.EventHandler(this.Btn_Resolver_Click);
            // 
            // Lbl_b
            // 
            this.Lbl_b.AutoSize = true;
            this.Lbl_b.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.Lbl_b.Location = new System.Drawing.Point(57, 159);
            this.Lbl_b.Name = "Lbl_b";
            this.Lbl_b.Size = new System.Drawing.Size(45, 31);
            this.Lbl_b.TabIndex = 11;
            this.Lbl_b.Text = "b =";
            // 
            // Lbl_a
            // 
            this.Lbl_a.AutoSize = true;
            this.Lbl_a.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.Lbl_a.Location = new System.Drawing.Point(57, 128);
            this.Lbl_a.Name = "Lbl_a";
            this.Lbl_a.Size = new System.Drawing.Size(45, 31);
            this.Lbl_a.TabIndex = 10;
            this.Lbl_a.Text = "a =";
            // 
            // Lbl_c
            // 
            this.Lbl_c.AutoSize = true;
            this.Lbl_c.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.Lbl_c.Location = new System.Drawing.Point(57, 190);
            this.Lbl_c.Name = "Lbl_c";
            this.Lbl_c.Size = new System.Drawing.Size(44, 31);
            this.Lbl_c.TabIndex = 12;
            this.Lbl_c.Text = "c =";
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.Btn_Salir.Location = new System.Drawing.Point(679, 269);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(109, 34);
            this.Btn_Salir.TabIndex = 13;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Lbl_Ecuacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 315);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Lbl_c);
            this.Controls.Add(this.Lbl_b);
            this.Controls.Add(this.Lbl_a);
            this.Controls.Add(this.Btn_Resolver);
            this.Controls.Add(this.Lbl_x2);
            this.Controls.Add(this.Lbl_x1);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Lbl_Exp);
            this.Controls.Add(this.Tbx_c);
            this.Controls.Add(this.Tbx_b);
            this.Controls.Add(this.Tbx_a);
            this.Controls.Add(this.label1);
            this.Name = "Lbl_Ecuacion";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tbx_a;
        private System.Windows.Forms.TextBox Tbx_b;
        private System.Windows.Forms.TextBox Tbx_c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Exp;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_x1;
        private System.Windows.Forms.Label Lbl_x2;
        private System.Windows.Forms.Button Btn_Resolver;
        private System.Windows.Forms.Label Lbl_b;
        private System.Windows.Forms.Label Lbl_a;
        private System.Windows.Forms.Label Lbl_c;
        private System.Windows.Forms.Button Btn_Salir;
    }
}

