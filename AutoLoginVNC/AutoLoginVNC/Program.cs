/*
 * Created by SharpDevelop.
 * User: lucasarusiewicz
 * Date: 28/02/2018
 * Time: 15:50
 */
using System;
using System.Windows.Forms;

namespace Digitar
{
	internal sealed class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
