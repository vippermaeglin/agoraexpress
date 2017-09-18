using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;


namespace Agora_Express
{
    public partial class GerenciaCL : Form
    {
        private DataSet ds = new DataSet();
        private DataViewManager dvm;
        public GerenciaCL()
        {
            InitializeComponent();
        }

        private void GerenciaCL_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ROLOIU");
            using (FbConnection conexaoFireBird = daoFireBird.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();

                    string mSQL = "SELECT * FROM CLIENTE";

                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataAdapter da = new FbDataAdapter(cmd);

                    ds = new DataSet();
                    da.TableMappings.Add("Table", "tabelaClientes");
                    da.Fill(ds);
                    dvm = ds.DefaultViewManager;
                    comboBox1.DataSource = dvm;
                    comboBox1.DisplayMember = "tabelaClientes.EMPRESACLIENTE";
                    comboBox1.ValueMember = "tabelaClientes.EMPRESACLIENTE";
                    
                    
                  
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
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }
    }
}
