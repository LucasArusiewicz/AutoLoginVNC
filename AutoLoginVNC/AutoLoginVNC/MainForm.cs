/*
 * Created by SharpDevelop.
 * User: lucasarusiewicz
 * Date: 28/02/2018
 * Time: 15:50
 */
using System;
using System.Windows.Forms;
using System.Threading;

namespace Digitar
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Button_digitarClick(object sender, EventArgs e)
		{
			//Coleta informacoes do WindowsForm
			string usuario = textBox_usuario.Text;
			string senha = textBox_senha.Text;
			bool delay = checkBox_delay.Checked;
			int segundos = (int)numericUpDown_segundos.Value;
			
			//Caso os dois textbox estejam preenchidos
			if(!string.IsNullOrWhiteSpace(usuario) && !string.IsNullOrWhiteSpace(senha))
			{
				//Caso tenha delay, realiza sleep
				if(delay){
					Thread.Sleep(segundos * 1000);
				}
				
				//Digita informacoes
				SendKeys.Send(usuario);
				SendKeys.Send("{TAB}");
				SendKeys.Send(senha);
				SendKeys.Send("{ENTER}");
			}
		}
	}
}
