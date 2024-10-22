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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.LBLrfc = new System.Windows.Forms.Label();
			this.DTPfecha = new System.Windows.Forms.DateTimePicker();
			this.BTNcalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(29, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(29, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Apellido 1:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(29, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Apellido 2:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(28, 185);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Teléfono:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(28, 230);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Direccion:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(28, 275);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Semestre:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(0, 317);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(115, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "Fecha de nacimiento:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(95, 48);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(233, 20);
			this.textBox1.TabIndex = 7;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(95, 91);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(233, 20);
			this.textBox2.TabIndex = 8;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(95, 137);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(233, 20);
			this.textBox3.TabIndex = 9;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(95, 227);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(233, 20);
			this.textBox4.TabIndex = 10;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(95, 182);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(233, 20);
			this.textBox5.TabIndex = 11;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
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
			this.comboBox1.Location = new System.Drawing.Point(95, 275);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(233, 21);
			this.comboBox1.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(393, 73);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "Tu RFC es de:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// LBLrfc
			// 
			this.LBLrfc.Location = new System.Drawing.Point(393, 109);
			this.LBLrfc.Name = "LBLrfc";
			this.LBLrfc.Size = new System.Drawing.Size(100, 23);
			this.LBLrfc.TabIndex = 15;
			this.LBLrfc.Text = "####";
			this.LBLrfc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DTPfecha
			// 
			this.DTPfecha.Location = new System.Drawing.Point(121, 317);
			this.DTPfecha.Name = "DTPfecha";
			this.DTPfecha.Size = new System.Drawing.Size(207, 20);
			this.DTPfecha.TabIndex = 13;
			// 
			// BTNcalcular
			// 
			this.BTNcalcular.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BTNcalcular.Location = new System.Drawing.Point(393, 167);
			this.BTNcalcular.Name = "BTNcalcular";
			this.BTNcalcular.Size = new System.Drawing.Size(100, 23);
			this.BTNcalcular.TabIndex = 16;
			this.BTNcalcular.Text = "Calcular";
			this.BTNcalcular.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 432);
			this.Controls.Add(this.BTNcalcular);
			this.Controls.Add(this.LBLrfc);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.DTPfecha);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "proyecto";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button BTNcalcular;
		private System.Windows.Forms.Label LBLrfc;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker DTPfecha;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
		
	}
}
