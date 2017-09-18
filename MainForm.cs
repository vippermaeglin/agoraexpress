/*
 * Criado por SharpDevelop.
 * Usuário: Vipper
 * Data: 26/9/2010
 * Hora: 16:22
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Configuration;



namespace Agora_Express
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

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        void MainFormLoad(object sender, EventArgs e)
        {
            //acessoFBSingleton();
        }
        public void acessoFBSingleton()
        {
            using (FbConnection conexaoFireBird = daoFireBird.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();

                    string mSQL = "Select * from CLIENTE";

                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                   /* FbDataAdapter da = new FbDataAdapter(cmd);
                    DataTable dtCliente = new DataTable();
                    da.Fill(dtCliente);
                    this.dataGridView1.DataSource = dtCliente;*/
                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro de acesso ao MySQL : " + fbex.Message, "Erro");
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        private void criarNovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroOS Cadastro_OS = new CadastroOS();
            Cadastro_OS.ShowDialog();
        }

        private void cadastrarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCL Cadastro_CL = new CadastroCL();
            Cadastro_CL.ShowDialog();
        }

        private void cadastrarNovoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroFC Cadastro_FC = new CadastroFC();
            Cadastro_FC.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gerenciarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GerenciaFC Gerencia_FC = new GerenciaFC();
            Gerencia_FC.ShowDialog();
        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GERENCIA_CL Gerencia_CL = new GERENCIA_CL();
            Gerencia_CL.ShowDialog();
        }

        

        


    }
}




