/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 01/03/2022
 * Time: 14:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tugas_2
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
		
		void Btn1Click(object sender, EventArgs e)
		{
			string name = tB1.Text;


				lB.Items.Add(name);
			
			
			tB1.Clear();
		}
	}
}
