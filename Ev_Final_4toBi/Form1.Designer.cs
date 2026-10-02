namespace Ev_Final_4toBi
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
			this.LBL1 = new System.Windows.Forms.Label();
			this.TextUsuario = new System.Windows.Forms.TextBox();
			this.TextContrasena = new System.Windows.Forms.TextBox();
			this.BtnIngresar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LBL1
			// 
			this.LBL1.AutoSize = true;
			this.LBL1.Location = new System.Drawing.Point(322, 199);
			this.LBL1.Name = "LBL1";
			this.LBL1.Size = new System.Drawing.Size(100, 20);
			this.LBL1.TabIndex = 0;
			this.LBL1.Text = "Examen final";
			// 
			// TextUsuario
			// 
			this.TextUsuario.Location = new System.Drawing.Point(292, 93);
			this.TextUsuario.Name = "TextUsuario";
			this.TextUsuario.Size = new System.Drawing.Size(100, 26);
			this.TextUsuario.TabIndex = 1;
			// 
			// TextContrasena
			// 
			this.TextContrasena.Location = new System.Drawing.Point(466, 107);
			this.TextContrasena.Name = "TextContrasena";
			this.TextContrasena.Size = new System.Drawing.Size(100, 26);
			this.TextContrasena.TabIndex = 2;
			// 
			// BtnIngresar
			// 
			this.BtnIngresar.Location = new System.Drawing.Point(354, 161);
			this.BtnIngresar.Name = "BtnIngresar";
			this.BtnIngresar.Size = new System.Drawing.Size(75, 23);
			this.BtnIngresar.TabIndex = 3;
			this.BtnIngresar.Text = "ingresar";
			this.BtnIngresar.UseVisualStyleBackColor = true;
			this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.BtnIngresar);
			this.Controls.Add(this.TextContrasena);
			this.Controls.Add(this.TextUsuario);
			this.Controls.Add(this.LBL1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LBL1;
		private System.Windows.Forms.TextBox TextUsuario;
		private System.Windows.Forms.TextBox TextContrasena;
		private System.Windows.Forms.Button BtnIngresar;
	}
}

