/*
 * Criado por SharpDevelop.
 * Usu�rio: Vipper
 * Data: 26/9/2010
 * Hora: 16:22
 * 
 * Para alterar este modelo use Ferramentas | Op��es | Codifica��o | Editar Cabe�alhos Padr�o.
 */

using System;
using System.Windows.Forms;

//Application.StartupPath + "\\in.pgm";

namespace Agora_Express
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
