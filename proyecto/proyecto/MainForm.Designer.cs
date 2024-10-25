/*
 * Created by SharpDevelop.
 * User: CC2_PC31
 * Date: 22/10/2024
 * Time: 07:47 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto
{
	partial class MainForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.TXTnombre = new System.Windows.Forms.TextBox();
			this.TXTapellido1 = new System.Windows.Forms.TextBox();
			this.TXTapellido2 = new System.Windows.Forms.TextBox();
			this.TXTdire = new System.Windows.Forms.TextBox();
			this.TXTtelef = new System.Windows.Forms.TextBox();
			this.CBXsemest = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.LBLrfc = new System.Windows.Forms.Label();
			this.DTPfecha = new System.Windows.Forms.DateTimePicker();
			this.BTNcalcular = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.BTNform1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(44, 74);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(44, 140);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 35);
			this.label2.TabIndex = 1;
			this.label2.Text = "Apellido 1:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(44, 206);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 35);
			this.label3.TabIndex = 2;
			this.label3.Text = "Apellido 2:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(42, 285);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 35);
			this.label4.TabIndex = 3;
			this.label4.Text = "Teléfono:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(42, 354);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 35);
			this.label5.TabIndex = 4;
			this.label5.Text = "Direccion:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(42, 423);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(92, 35);
			this.label6.TabIndex = 5;
			this.label6.Text = "Semestre:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(0, 488);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(172, 35);
			this.label7.TabIndex = 6;
			this.label7.Text = "Fecha de nacimiento:";
			// 
			// TXTnombre
			// 
			this.TXTnombre.Location = new System.Drawing.Point(142, 74);
			this.TXTnombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.TXTnombre.Name = "TXTnombre";
			this.TXTnombre.Size = new System.Drawing.Size(348, 26);
			this.TXTnombre.TabIndex = 7;
			// 
			// TXTapellido1
			// 
			this.TXTapellido1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.TXTapellido1.Location = new System.Drawing.Point(142, 140);
			this.TXTapellido1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.TXTapellido1.Name = "TXTapellido1";
			this.TXTapellido1.Size = new System.Drawing.Size(348, 26);
			this.TXTapellido1.TabIndex = 8;
			// 
			// TXTapellido2
			// 
			this.TXTapellido2.Location = new System.Drawing.Point(142, 211);
			this.TXTapellido2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.TXTapellido2.Name = "TXTapellido2";
			this.TXTapellido2.Size = new System.Drawing.Size(348, 26);
			this.TXTapellido2.TabIndex = 9;
			// 
			// TXTdire
			// 
			this.TXTdire.Location = new System.Drawing.Point(142, 349);
			this.TXTdire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.TXTdire.Name = "TXTdire";
			this.TXTdire.Size = new System.Drawing.Size(348, 26);
			this.TXTdire.TabIndex = 10;
			// 
			// TXTtelef
			// 
			this.TXTtelef.Location = new System.Drawing.Point(142, 282);
			this.TXTtelef.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.TXTtelef.Name = "TXTtelef";
			this.TXTtelef.Size = new System.Drawing.Size(348, 26);
			this.TXTtelef.TabIndex = 11;
			// 
			// CBXsemest
			// 
			this.CBXsemest.FormattingEnabled = true;
			this.CBXsemest.Items.AddRange(new object[] {
									"1° de Alimentos",
									"1° de Administracion",
									"1° de Contabilidad",
									"1° de Mecanica",
									"1° de Programacion",
									"1° de Soporte",
									"1° de Ofimatica",
									"1° de Ciberseguridad",
									"3° de Alimentos",
									"3° de Administracion",
									"3° de Mecanica",
									"3° de Contabilidad",
									"3° de Programacion",
									"3° de Soporte",
									"3° de Ofimatica",
									"5° de Alimentos",
									"5° de Administracion",
									"5° de Contabilidad",
									"5° de Mecanica",
									"5° de Programacion",
									"5° de Soporte",
									"5° de Ofimatica"});
			this.CBXsemest.Location = new System.Drawing.Point(142, 423);
			this.CBXsemest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.CBXsemest.Name = "CBXsemest";
			this.CBXsemest.Size = new System.Drawing.Size(348, 28);
			this.CBXsemest.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(590, 112);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(150, 35);
			this.label8.TabIndex = 14;
			this.label8.Text = "Tu RFC es:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// LBLrfc
			// 
			this.LBLrfc.Location = new System.Drawing.Point(558, 168);
			this.LBLrfc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LBLrfc.Name = "LBLrfc";
			this.LBLrfc.Size = new System.Drawing.Size(182, 42);
			this.LBLrfc.TabIndex = 15;
			this.LBLrfc.Text = "####";
			this.LBLrfc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DTPfecha
			// 
			this.DTPfecha.CustomFormat = "yymmdd";
			this.DTPfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DTPfecha.Location = new System.Drawing.Point(182, 488);
			this.DTPfecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTPfecha.Name = "DTPfecha";
			this.DTPfecha.Size = new System.Drawing.Size(308, 26);
			this.DTPfecha.TabIndex = 13;
			// 
			// BTNcalcular
			// 
			this.BTNcalcular.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BTNcalcular.Location = new System.Drawing.Point(590, 257);
			this.BTNcalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BTNcalcular.Name = "BTNcalcular";
			this.BTNcalcular.Size = new System.Drawing.Size(150, 35);
			this.BTNcalcular.TabIndex = 16;
			this.BTNcalcular.Text = "Calcular";
			this.BTNcalcular.UseVisualStyleBackColor = true;
			this.BTNcalcular.Click += new System.EventHandler(this.BTNcalcularClick);
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(538, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(236, 46);
			this.label9.TabIndex = 17;
			this.label9.Text = "Calcula tu RFC";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(160, 32);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(316, 23);
			this.label10.TabIndex = 18;
			this.label10.Text = "Escribir los apartados con mayuscula";
			// 
			// BTNform1
			// 
			this.BTNform1.Location = new System.Drawing.Point(651, 582);
			this.BTNform1.Name = "BTNform1";
			this.BTNform1.Size = new System.Drawing.Size(138, 71);
			this.BTNform1.TabIndex = 19;
			this.BTNform1.Text = "datos de \r\nusuario";
			this.BTNform1.UseVisualStyleBackColor = true;
			this.BTNform1.Click += new System.EventHandler(this.BTNform1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(801, 665);
			this.Controls.Add(this.BTNform1);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.BTNcalcular);
			this.Controls.Add(this.LBLrfc);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.DTPfecha);
			this.Controls.Add(this.CBXsemest);
			this.Controls.Add(this.TXTtelef);
			this.Controls.Add(this.TXTdire);
			this.Controls.Add(this.TXTapellido2);
			this.Controls.Add(this.TXTapellido1);
			this.Controls.Add(this.TXTnombre);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainForm";
			this.Text = "calculadora de RFC";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button BTNform1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button BTNcalcular;
		private System.Windows.Forms.Label LBLrfc;
		private System.Windows.Forms.Label label8;
		public System.Windows.Forms.DateTimePicker DTPfecha;
		public System.Windows.Forms.ComboBox CBXsemest;
		public System.Windows.Forms.TextBox TXTtelef;
		public System.Windows.Forms.TextBox TXTdire;
		public System.Windows.Forms.TextBox TXTapellido2;
		public System.Windows.Forms.TextBox TXTapellido1;
		public System.Windows.Forms.TextBox TXTnombre;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
		
	}
}
