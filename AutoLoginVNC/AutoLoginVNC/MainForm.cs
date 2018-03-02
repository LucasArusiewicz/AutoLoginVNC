/*
 * Created by SharpDevelop.
 * User: lucasarusiewicz
 * Date: 28/02/2018
 * Time: 15:50
 */
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Digitar
{
	public partial class MainForm : Form
	{
		private bool proxClickDigita;
		
		public MainForm()
		{
			InitializeComponent();
			
			MouseHook.Start();
			MouseHook.MouseAction += new EventHandler(Event);
		}
		
		void Button_digitarClick(object sender, EventArgs e)
		{
			proxClickDigita = true;
		}
		
		private void Event(object sender, EventArgs e)
		{ 
			if (proxClickDigita) {
				
				proxClickDigita = false;
				
				//Coleta informacoes do WindowsForm
				string usuario = textBox_usuario.Text;
				string senha = textBox_senha.Text;
			
				//Caso os dois textbox estejam preenchidos
				if (!string.IsNullOrWhiteSpace(usuario) && !string.IsNullOrWhiteSpace(senha)) {
					
					//Margem de erro
					Thread.Sleep(500);
				
					//Digita informacoes
					SendKeys.Send(usuario);
					SendKeys.Send("{TAB}");
					SendKeys.Send(senha);
					SendKeys.Send("{ENTER}");
			
				}
			}
		}
	}
	
	public static class MouseHook
	{
		private enum MouseMessages
		{
			WM_LBUTTONDOWN = 0x0201,
			WM_LBUTTONUP = 0x0202,
			WM_MOUSEMOVE = 0x0200,
			WM_MOUSEWHEEL = 0x020A,
			WM_RBUTTONDOWN = 0x0204,
			WM_RBUTTONUP = 0x0205
		}
		
		[StructLayout(LayoutKind.Sequential)]
		private struct POINT
		{
			public int x;
			public int y;
		}

		[StructLayout(LayoutKind.Sequential)]
		private struct MSLLHOOKSTRUCT
		{
			public POINT pt;
			public uint mouseData;
			public uint flags;
			public uint time;
			public IntPtr dwExtraInfo;
		}
		
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr SetWindowsHookEx(int idHook,
			LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool UnhookWindowsHookEx(IntPtr hhk);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
			IntPtr wParam, IntPtr lParam);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string lpModuleName);
		
		public static event EventHandler MouseAction = delegate { };
		
		private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

		private static IntPtr _hookID = IntPtr.Zero;
		
		private static LowLevelMouseProc _proc = HookCallback;
		
		private const int WH_MOUSE_LL = 14;
		
		public static void Start()
		{
			_hookID = SetHook(_proc);
		}
		public static void stop()
		{
			UnhookWindowsHookEx(_hookID);
		}
		
		private static IntPtr SetHook(LowLevelMouseProc proc)
		{
			using (Process curProcess = Process.GetCurrentProcess())
			using (ProcessModule curModule = curProcess.MainModule) {
				return SetWindowsHookEx(WH_MOUSE_LL, proc,
					GetModuleHandle(curModule.ModuleName), 0);
			}
		}

		private static IntPtr HookCallback(
			int nCode, IntPtr wParam, IntPtr lParam)
		{
			if (nCode >= 0 && MouseMessages.WM_LBUTTONDOWN == (MouseMessages)wParam) {
				MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
				MouseAction(null, new EventArgs());
			}
			return CallNextHookEx(_hookID, nCode, wParam, lParam);
		}
	}
}
