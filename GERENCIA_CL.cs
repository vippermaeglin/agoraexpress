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
    public partial class GERENCIA_CL : Form
    {
        private DataSet ds = new DataSet();
        private DataViewManager dvm;
        public GERENCIA_CL()
        {
            InitializeComponent();
        }

        private void GERENCIA_CL_Load(object sender, EventArgs e)
        {
            
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

        private void button2_Click(object sender, EventArgs e)
        {
            string aux = "";
            using (FbConnection conexaoFireBird = daoFireBird.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    aux = "UPDATE CLIENTE SET EMPRESACLIENTE='"+comboBox1.Text+"',COMPLEMCLIENTE='"+textBox3.Text+"',PLANOCLIENTE='"+comboBox2.Text+"',RAZAOSOCIAL='"+textBox6.Text+"',INSCMUNICIPAL='"+textBox5.Text+"',INSCESTADUAL='"+textBox13.Text;
                    aux += "', CNPJ='"+maskedTextBox6.Text+"',RUACLIENTE='"+textBox8.Text+"',NUMCLIENTE='"+maskedTextBox7.Text+"',BAIRROCLIENTE='"+textBox7.Text+"',CIDADECLIENTE='"+comboBox5.Text+"',AGENCIACLIENTE='"+maskedTextBox8.Text+"',CONTACLIENTE='"+maskedTextBox9.Text;
                    aux+= "',BANCOCLIENTE='"+textBox2.Text+"',TITULARCLIENTE='"+textBox10.Text+"',CEPCLIENTE='"+maskedTextBox1.Text+"',TELCLIENTE='"+maskedTextBox10.Text+"',NMCONTCLIENTE='"+textBox14.Text+"',TELCLIENTEII='"+maskedTextBox2.Text+"',FAX='"+maskedTextBox11.Text+"',EMAILCLIENTE='"+textBox11.Text;
                    aux += "',SITECLIENTE='"+textBox12.Text+"' WHERE CDCLIENTE = '" + textBox1.Text.ToString() + "'";
                    FbCommand cmd = new FbCommand(aux, conexaoFireBird);
                    cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("Cliente atualizado com sucesso!");
                }

                catch (FbException fbex)
                {
                    MessageBox.Show("Erro de acesso ao MySQL : " + fbex.Message, "Erro");
                }
                finally
                {
                    conexaoFireBird.Close();
                }
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (FbConnection conexaoFireBird = daoFireBird.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();

                    string mSQL = "SELECT * FROM CLIENTE WHERE EMPRESACLIENTE='" + comboBox1.Text.ToString() + "'";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataAdapter da = new FbDataAdapter(cmd);

                    ds = new DataSet();
                    da.TableMappings.Add("Table", "tabelaClientes");
                    da.Fill(ds);
                    dvm = ds.DefaultViewManager;
                    
                    
                    //cmd.Parameters.Add(new FbParameter("@DATACLIENTE", dateStartStr));



                    textBox1.DataBindings.Clear();
                    textBox1.DataBindings.Add("Text", dvm, "tabelaClientes.CDCLIENTE");
                    textBox3.DataBindings.Clear();
                    textBox3.DataBindings.Add("Text", dvm, "tabelaClientes.COMPLEMCLIENTE");
                    comboBox2.DataBindings.Clear();
                    comboBox2.DataBindings.Add("Text", dvm, "tabelaClientes.PLANOCLIENTE");
                    textBox6.DataBindings.Clear();
                    textBox6.DataBindings.Add("Text", dvm, "tabelaClientes.RAZAOSOCIAL");
                    textBox5.DataBindings.Clear();
                    textBox5.DataBindings.Add("Text", dvm, "tabelaClientes.INSCMUNICIPAL");
                    textBox13.DataBindings.Clear();
                    maskedTextBox6.DataBindings.Clear();
                    textBox13.DataBindings.Add("Text", dvm, "tabelaClientes.INSCESTADUAL");
                    maskedTextBox6.DataBindings.Add("Text", dvm, "tabelaClientes.CNPJ");
                    textBox8.DataBindings.Clear();
                    textBox8.DataBindings.Add("Text", dvm, "tabelaClientes.RUACLIENTE");
                    maskedTextBox7.DataBindings.Clear();
                    maskedTextBox7.DataBindings.Add("Text", dvm, "tabelaClientes.NUMCLIENTE");
                    textBox7.DataBindings.Clear();
                    textBox7.DataBindings.Add("Text", dvm, "tabelaClientes.BAIRROCLIENTE");
                    comboBox5.DataBindings.Clear();
                    comboBox5.DataBindings.Add("Text", dvm, "tabelaClientes.CIDADECLIENTE");
                    maskedTextBox8.DataBindings.Clear();
                    maskedTextBox8.DataBindings.Add("Text", dvm, "tabelaClientes.AGENCIACLIENTE");
                    maskedTextBox9.DataBindings.Clear();
                    maskedTextBox9.DataBindings.Add("Text", dvm, "tabelaClientes.CONTACLIENTE");
                    maskedTextBox2.DataBindings.Clear();
                    textBox2.DataBindings.Clear();
                    textBox2.DataBindings.Add("Text", dvm, "tabelaClientes.BANCOCLIENTE");
                    textBox10.DataBindings.Clear();
                    textBox10.DataBindings.Add("Text", dvm, "tabelaClientes.TITULARCLIENTE");
                    maskedTextBox1.DataBindings.Clear();
                    maskedTextBox1.DataBindings.Add("Text", dvm, "tabelaClientes.CEPCLIENTE");
                    maskedTextBox10.DataBindings.Clear();
                    maskedTextBox10.DataBindings.Add("Text", dvm, "tabelaClientes.TELCLIENTE");
                    textBox14.DataBindings.Clear();
                    textBox14.DataBindings.Add("Text", dvm, "tabelaClientes.NMCONTCLIENTE");
                    maskedTextBox2.DataBindings.Add("Text", dvm, "tabelaClientes.TELCLIENTEII");
                    maskedTextBox11.DataBindings.Clear();
                    maskedTextBox11.DataBindings.Add("Text", dvm, "tabelaClientes.FAX");
                    textBox11.DataBindings.Clear();
                    textBox11.DataBindings.Add("Text", dvm, "tabelaClientes.EMAILCLIENTE");
                    textBox12.DataBindings.Clear();
                    textBox12.DataBindings.Add("Text", dvm, "tabelaClientes.SITECLIENTE");
                    maskedTextBox3.DataBindings.Clear();
                    maskedTextBox3.DataBindings.Add("Text", dvm, "tabelaClientes.DATACLIENTE");



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

        private void button1_Click(object sender, EventArgs e)
        {
            string sMsg = "Você Deseja Realmente Excluir o cadastro Selecionado?";
            if (MessageBox.Show(sMsg, "Exclusão de Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                using (FbConnection conexaoFireBird = daoFireBird.getInstancia().getConexao())
                {
                    try
                    {
                        conexaoFireBird.Open();

                        string mSQL = "DELETE FROM CLIENTE WHERE CDCLIENTE='" + textBox1.Text.ToString() + "'";
                        FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                        cmd.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show("Cliente deletado com sucesso!");



                    }

                    catch (FbException fbex)
                    {
                        MessageBox.Show("Erro de acesso ao MySQL : " + fbex.Message, "Erro");
                    }
                    finally
                    {
                        conexaoFireBird.Close();
                    }
                    this.Close();
                }
            }
        
        }
    }
}
