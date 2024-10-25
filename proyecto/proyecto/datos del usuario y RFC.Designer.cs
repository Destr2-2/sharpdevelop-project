/*
 * Created by SharpDevelop.
 * User: moren
 * Date: 24/10/2024
 * Time: 07:52 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto
{
	partial class datos_del_usuario_y_RFC
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.LBLcompleto = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.LBLrfcnn = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(65, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(411, 61);
			this.label1.TabIndex = 0;
			this.label1.Text = "Su nombre completo es:";
			// 
			// LBLcompleto
			// 
			this.LBLcompleto.Location = new System.Drawing.Point(65, 92);
			this.LBLcompleto.Name = "LBLcompleto";
			this.LBLcompleto.Size = new System.Drawing.Size(378, 23);
			this.LBLcompleto.TabIndex = 1;
			//this.LBLcompleto.Click += new System.EventHandler(this.LBLcompletoClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(160, 164);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(186, 31);
			this.label2.TabIndex = 2;
			this.label2.Text = "su RFC es:";
			// 
			// LBLrfcnn
			// 
			this.LBLrfcnn.Location = new System.Drawing.Point(65, 232);
			this.LBLrfcnn.Name = "LBLrfcnn";
			this.LBLrfcnn.Size = new System.Drawing.Size(364, 23);
			this.LBLrfcnn.TabIndex = 3;
			this.LBLrfcnn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// datos_del_usuario_y_RFC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(530, 417);
			this.Controls.Add(this.LBLrfcnn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.LBLcompleto);
			this.Controls.Add(this.label1);
			this.Name = "datos_del_usuario_y_RFC";
			this.Text = "datos_del_usuario_y_RFC";
			this.ResumeLayout(false);
		}
		public System.Windows.Forms.Label LBLrfcnn;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label LBLcompleto;
		private System.Windows.Forms.Label label1;
	}
}
