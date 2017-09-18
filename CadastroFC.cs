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
    public partial class CadastroFC : Form
    {
        public CadastroFC()
        {
            InitializeComponent();
        }

   

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void CadastroFC_Load(object sender, EventArgs e)
        {

             string aux="";
            int ret = 0;
            string cod="";
            
            using (FbConnection conexaoFireBird = daoFireBird.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    aux = "SELECT GEN_ID(GEN_FUNCIONARIO_ID,0) FROM FUNCIONARIO";
                    FbCommand cmd = new FbCommand(aux, conexaoFireBird);
                    FbDataReader r = cmd.ExecuteReader();
                    
                    while (r.Read())
                    {

                        ret = r.GetInt32(0);

                    }
                    ret++;
                    //System.Windows.Forms.MessageBox.Show("Ponteiro:" + ret);
                }

                catch (FbException fbex)
                {
                    MessageBox.Show("Erro de acesso ao MySQL : " + fbex.Message, "Erro");
                }
                finally
                {
                    conexaoFireBird.Close();
                }
                cod += ret;
                textBox1.Text = cod;
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

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aux = "";
            using (FbConnection conexaoFireBird = daoFireBird.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    aux = "INSERT INTO FUNCIONARIO(CDFUNCIONARIO,NMFUNCIONARIO,CONTRATOFUNC,DTCONTRATO,RG,CPF,CNH,CLT,RUAFUNCIONARIO,BAIRROFUNCIONARIO,NUMFUNCIONARIO,CIDADEFUNCIONARIO,AGENCIAFUNCIONARIO,CONTAFUNCIONARIO,BANCOFUNCIONARIO,TITULARFUNCIONARIO,TELFUNCIONARIO,CELFUNCIONARIO,TELREF_FUNC,NMREF_FUNC,EMAILFUNCIONARIO,VEICULOFUNCIONARIO,PLACA,MODELO,SALARIOFUNC,COMISSAO,HORA,HORAEXTRA,PIS,FOTODIR) VALUES(null,@NMFUNCIONARIO,@CONTRATOFUNC,@DTCONTRATO,@RG,@CPF,@CNH,@CLT,@RUAFUNCIONARIO,@BAIRROFUNCIONARIO,@NUMFUNCIONARIO,@CIDADEFUNCIONARIO,@AGENCIAFUNCIONARIO,@CONTAFUNCIONARIO,@BANCOFUNCIONARIO,@TITULARFUNCIONARIO,@TELFUNCIONARIO,@CELFUNCIONARIO,@TELREF_FUNC,@NMREF_FUNC,@EMAILFUNCIONARIO,@VEICULOFUNCIONARIO,@PLACA,@MODELO,@SALARIOFUNC,@COMISSAO,@HORA,@HORAEXTRA,@PIS,@FOTODIR);";
                    FbCommand cmd = new FbCommand(aux, conexaoFireBird);
                    cmd.Parameters.Add(new FbParameter("@NMFUNCIONARIO",textBox9.Text));
                    DateTime startD = monthCalendar1.SelectionStart;
                    string dateStartStr = startD.Date.ToShortDateString();
                    cmd.Parameters.Add(new FbParameter("@DTCONTRATO", dateStartStr));
                    cmd.Parameters.Add(new FbParameter("@CONTRATOFUNC", comboBox1.Text));
                    cmd.Parameters.Add(new FbParameter("@RG",maskedTextBox1.Text));
                    cmd.Parameters.Add(new FbParameter("@CPF", maskedTextBox6.Text));
                    cmd.Parameters.Add(new FbParameter("@CNH", maskedTextBox2.Text));
                    cmd.Parameters.Add(new FbParameter("@CLT", maskedTextBox3.Text));
                    cmd.Parameters.Add(new FbParameter("@RUAFUNCIONARIO", textBox8.Text));
                    cmd.Parameters.Add(new FbParameter("@BAIRROFUNCIONARIO", textBox7.Text));
                    cmd.Parameters.Add(new FbParameter("@NUMFUNCIONARIO", maskedTextBox7.Text));
                    cmd.Parameters.Add(new FbParameter("@CIDADEFUNCIONARIO", comboBox5.Text));
                    cmd.Parameters.Add(new FbParameter("@AGENCIAFUNCIONARIO", maskedTextBox8.Text));
                    cmd.Parameters.Add(new FbParameter("@CONTAFUNCIONARIO", maskedTextBox9.Text));
                    cmd.Parameters.Add(new FbParameter("@BANCOFUNCIONARIO", textBox3.Text));
                    cmd.Parameters.Add(new FbParameter("@TITULARFUNCIONARIO", textBox10.Text));
                    cmd.Parameters.Add(new FbParameter("@TELFUNCIONARIO", maskedTextBox10.Text));
                    cmd.Parameters.Add(new FbParameter("@CELFUNCIONARIO", maskedTextBox11.Text));
                    cmd.Parameters.Add(new FbParameter("@TELREF_FUNC", maskedTextBox16.Text));
                    cmd.Parameters.Add(new FbParameter("@NMREF_FUNC", textBox4.Text));
                    cmd.Parameters.Add(new FbParameter("@EMAILFUNCIONARIO", textBox11.Text));
                    cmd.Parameters.Add(new FbParameter("@VEICULOFUNCIONARIO", comboBox2.Text));
                    cmd.Parameters.Add(new FbParameter("@PLACA", maskedTextBox4.Text));
                    cmd.Parameters.Add(new FbParameter("@MODELO", textBox2.Text));
                    cmd.Parameters.Add(new FbParameter("@SALARIOFUNC", maskedTextBox5.Text));
                    cmd.Parameters.Add(new FbParameter("@COMISSAO", maskedTextBox12.Text));
                    cmd.Parameters.Add(new FbParameter("@HORA", maskedTextBox13.Text));
                    cmd.Parameters.Add(new FbParameter("@HORAEXTRA", maskedTextBox14.Text));
                    cmd.Parameters.Add(new FbParameter("@PIS", maskedTextBox15.Text));                    
                    aux="";                    
                    aux += pictureBox2.ImageLocation.ToString();
                    cmd.Parameters.Add(new FbParameter("@FOTODIR",aux));
                    cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("Funcionário cadastrado com sucesso!");
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

        }
    }
}
