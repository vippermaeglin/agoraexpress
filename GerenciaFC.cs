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
    public partial class GerenciaFC : Form
    {
        private DataSet ds = new DataSet();
        private DataViewManager dvm;
        public GerenciaFC()
        {
            InitializeComponent();
        }

        private void GerenciaFC_Load(object sender, EventArgs e)
        {
            string aux = "";
            using (FbConnection conexaoFireBird = daoFireBird.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();

                    string mSQL = "SELECT * FROM FUNCIONARIO";

                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataAdapter da = new FbDataAdapter(cmd);

                    ds = new DataSet();
                    da.TableMappings.Add("Table", "tabelaClientes");
                    da.Fill(ds);
                    dvm = ds.DefaultViewManager;
                    comboBox1.DataSource = dvm;
                    comboBox1.DisplayMember = "tabelaClientes.NMFUNCIONARIO";
                    comboBox1.ValueMember = "tabelaClientes.NMFUNCIONARIO";
                    
                  
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
            string aux = "";
            using (FbConnection conexaoFireBird = daoFireBird.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    aux = "UPDATE FUNCIONARIO SET NMFUNCIONARIO='"+comboBox1.Text+"',CONTRATOFUNC='"+comboBox3.Text+"',DTCONTRATO='"+maskedTextBox17.Text+"',RG='" + maskedTextBox1.Text.ToString()+"',CPF='"+maskedTextBox6.Text+"',CNH='"+maskedTextBox2.Text+"',CLT='"+maskedTextBox3.Text+"',RUAFUNCIONARIO='"+textBox8.Text;
                    aux+="',BAIRROFUNCIONARIO='"+textBox7.Text+"',NUMFUNCIONARIO='"+maskedTextBox7.Text+"',CIDADEFUNCIONARIO='"+comboBox5.Text+"',AGENCIAFUNCIONARIO='"+maskedTextBox8.Text+"',CONTAFUNCIONARIO='"+maskedTextBox9.Text;
                    aux+="',BANCOFUNCIONARIO='"+textBox3.Text+"',TITULARFUNCIONARIO='"+textBox10.Text+"',TELFUNCIONARIO='"+maskedTextBox10.Text+"',CELFUNCIONARIO='"+maskedTextBox11.Text+"',TELREF_FUNC='"+maskedTextBox16.Text;
                    aux+="',NMREF_FUNC='"+textBox4.Text+"',EMAILFUNCIONARIO='"+textBox11.Text+"',VEICULOFUNCIONARIO='"+comboBox2.Text+"',PLACA='"+maskedTextBox4.Text+"',MODELO='"+textBox2.Text+"',SALARIOFUNC='"+maskedTextBox5.Text;
                    aux+="',COMISSAO='"+maskedTextBox12.Text+"',HORA='"+maskedTextBox13.Text+"',HORAEXTRA='"+maskedTextBox14.Text+"',PIS='"+maskedTextBox15.Text+"',FOTODIR='"+pictureBox2.ImageLocation.ToString();
                    aux+="' WHERE CDFUNCIONARIO = '"+ textBox1.Text.ToString()+"'";
                    FbCommand cmd = new FbCommand(aux, conexaoFireBird);
                    cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("Funcionário atualizado com sucesso!");
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

                    string mSQL = "SELECT * FROM FUNCIONARIO WHERE NMFUNCIONARIO='"+comboBox1.Text.ToString()+"'";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataAdapter da = new FbDataAdapter(cmd);

                    ds = new DataSet();
                    da.TableMappings.Add("Table", "tabelaClientes");
                    da.Fill(ds);
                    dvm = ds.DefaultViewManager;
                    comboBox3.DataBindings.Clear();
                    maskedTextBox17.DataBindings.Clear();
                    textBox1.DataBindings.Clear();
                    maskedTextBox1.DataBindings.Clear();
                    maskedTextBox6.DataBindings.Clear();
                    maskedTextBox2.DataBindings.Clear();
                    maskedTextBox3.DataBindings.Clear();
                    textBox8.DataBindings.Clear();
                    textBox7.DataBindings.Clear();
                    maskedTextBox7.DataBindings.Clear();
                    comboBox5.DataBindings.Clear();
                    maskedTextBox8.DataBindings.Clear();
                    maskedTextBox9.DataBindings.Clear();
                    textBox3.DataBindings.Clear();
                    textBox10.DataBindings.Clear();
                    maskedTextBox10.DataBindings.Clear();
                    maskedTextBox11.DataBindings.Clear();
                    maskedTextBox16.DataBindings.Clear();
                    textBox4.DataBindings.Clear();
                    textBox11.DataBindings.Clear();
                    comboBox2.DataBindings.Clear();
                    maskedTextBox4.DataBindings.Clear();
                    textBox2.DataBindings.Clear();
                    maskedTextBox5.DataBindings.Clear();
                    maskedTextBox12.DataBindings.Clear();
                    maskedTextBox13.DataBindings.Clear();
                    maskedTextBox14.DataBindings.Clear();
                    maskedTextBox15.DataBindings.Clear();
                    pictureBox2.DataBindings.Clear();

                    comboBox3.DataBindings.Add("Text",dvm,"tabelaClientes.CONTRATOFUNC");
                    maskedTextBox17.DataBindings.Add("Text", dvm, "tabelaClientes.DTCONTRATO");
                    textBox1.DataBindings.Add("Text", dvm, "tabelaClientes.CDFUNCIONARIO");
                    //cmd.Parameters.Add(new FbParameter("@DTCONTRATO", dateStartStr));
                    maskedTextBox1.DataBindings.Add("Text", dvm, "tabelaClientes.RG");
                    maskedTextBox6.DataBindings.Add("Text", dvm, "tabelaClientes.CPF");
                    maskedTextBox2.DataBindings.Add("Text", dvm, "tabelaClientes.CNH");
                    maskedTextBox3.DataBindings.Add("Text", dvm, "tabelaClientes.CLT");
                    textBox8.DataBindings.Add("Text", dvm, "tabelaClientes.RUAFUNCIONARIO");
                    textBox7.DataBindings.Add("Text", dvm, "tabelaClientes.BAIRROFUNCIONARIO");
                    maskedTextBox7.DataBindings.Add("Text", dvm, "tabelaClientes.NUMFUNCIONARIO");
                    comboBox5.DataBindings.Add("Text", dvm, "tabelaClientes.CIDADEFUNCIONARIO");
                    maskedTextBox8.DataBindings.Add("Text", dvm, "tabelaClientes.AGENCIAFUNCIONARIO");
                    maskedTextBox9.DataBindings.Add("Text", dvm, "tabelaClientes.CONTAFUNCIONARIO");
                    textBox3.DataBindings.Add("Text", dvm, "tabelaClientes.BANCOFUNCIONARIO");
                    textBox10.DataBindings.Add("Text", dvm, "tabelaClientes.TITULARFUNCIONARIO");
                    maskedTextBox10.DataBindings.Add("Text", dvm, "tabelaClientes.TELFUNCIONARIO");
                    maskedTextBox11.DataBindings.Add("Text", dvm, "tabelaClientes.CELFUNCIONARIO");
                    maskedTextBox16.DataBindings.Add("Text", dvm, "tabelaClientes.TELREF_FUNC");
                    textBox4.DataBindings.Add("Text", dvm, "tabelaClientes.NMREF_FUNC");
                    textBox11.DataBindings.Add("Text", dvm, "tabelaClientes.EMAILFUNCIONARIO");
                    comboBox2.DataBindings.Add("Text", dvm, "tabelaClientes.VEICULOFUNCIONARIO");
                    maskedTextBox4.DataBindings.Add("Text", dvm, "tabelaClientes.PLACA");
                    textBox2.DataBindings.Add("Text", dvm, "tabelaClientes.MODELO");
                    maskedTextBox5.DataBindings.Add("Text", dvm, "tabelaClientes.SALARIOFUNC");
                    maskedTextBox12.DataBindings.Add("Text", dvm, "tabelaClientes.COMISSAO");
                    maskedTextBox13.DataBindings.Add("Text", dvm, "tabelaClientes.HORA");
                    maskedTextBox14.DataBindings.Add("Text", dvm, "tabelaClientes.HORAEXTRA");
                    maskedTextBox15.DataBindings.Add("Text", dvm, "tabelaClientes.PIS"); 
                    pictureBox2.DataBindings.Add("ImageLocation",dvm,"tabelaClientes.FOTODIR");
                    


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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPG Images (*.jpg)|*.jpg";
            openFileDialog.FileName = Application.StartupPath + "\\in.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = openFileDialog.FileName;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sMsg = "Você Deseja Realmente Excluir o cadastro Selecionado?";
            if (MessageBox.Show(sMsg, "Exclusão de Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                using (FbConnection conexaoFireBird = daoFireBird.getInstancia().getConexao())
                {
                    try
                    {
                        conexaoFireBird.Open();

                        string mSQL = "DELETE FROM FUNCIONARIO WHERE CDFUNCIONARIO='" + textBox1.Text.ToString() + "'";
                        FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                        cmd.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show("Funcionário deletado com sucesso!");



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
