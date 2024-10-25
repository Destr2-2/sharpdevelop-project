/*
 * Created by SharpDevelop.
 * User: CC2_PC31
 * Date: 22/10/2024
 * Time: 07:47 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		
		
		
		
		// se declara el boton que sera para calcular
		void BTNcalcularClick(object sender, EventArgs e)
		{
			
			// se agrega la fecha en el orden de anio mes y dia
			DateTime fecha = DTPfecha.Value;
			string RFC = fecha.ToString("yyMMdd");
			
			// se agrega la letra del nombre para el RFC
			string nombre = TXTnombre.Text;
			string prim = nombre.Substring(0,1);

			// lo mismo de arriba pero se agregaran 2 letras
			string apellido1 = TXTapellido1.Text;
			string app1 = apellido1.Substring(0, 2);

			// los mismo que lo anterior pero como el nombre solo se agregara la primera letra y
			// se imprimira en un Leabel el cual al final de este llevara las letras SF6
			string appellido2 = TXTapellido2.Text;
			string app2 = appellido2.Substring(0,1);
			LBLrfc.Text = app1 + app2 + prim + RFC + "SF6";
		
		
		}
		
		void BTNform1Click(object sender, EventArgs e)
		{
			DateTime fecha = DTPfecha.Value;
			string RFC = fecha.ToString("yyMMdd");
			string nombre = TXTnombre.Text;
			string prim = nombre.Substring(0,1);
			string apellido1 = TXTapellido1.Text;
			string app1 = apellido1.Substring(0, 2);
			string appellido2 = TXTapellido2.Text;
			string app2 = appellido2.Substring(0,1);;
			string nc=app1+app2+prim;
			string nc2=nombre+" "+apellido1+" "+appellido2;
			datos_del_usuario_y_RFC form = new datos_del_usuario_y_RFC();
			datos_del_usuario_y_RFC.LBLcompleto.Text=nc2;
			datos_del_usuario_y_RFC.LBLrfcnn.Text=nc.ToUpper()+fecha+"SF6";

			form.Show();
		}
	}
}
