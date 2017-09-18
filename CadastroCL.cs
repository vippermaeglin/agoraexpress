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
    public partial class CadastroCL : Form
    {
        public CadastroCL()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox8_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CadastroCL_Load(object sender, EventArgs e)
        {

            string aux="";
            int ret = 0;
            string cod="";
            
            using (FbConnection conexaoFireBird = daoFireBird.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    aux = "SELECT GEN_ID(GEN_CLIENTE_ID,0) FROM CLIENTE";
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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string aux="";
            using (FbConnection conexaoFireBird = daoFireBird.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    aux = "INSERT INTO CLIENTE(CDCLIENTE,COMPLEMCLIENTE,PLANOCLIENTE,RAZAOSOCIAL,INSCMUNICIPAL,INSCESTADUAL,EMPRESACLIENTE,CNPJ,RUACLIENTE,NUMCLIENTE,BAIRROCLIENTE,CIDADECLIENTE,AGENCIACLIENTE,CONTACLIENTE,BANCOCLIENTE,TITULARCLIENTE,CEPCLIENTE,TELCLIENTE,NMCONTCLIENTE,TELCLIENTEII,FAX,EMAILCLIENTE,SITECLIENTE,DATACLIENTE) VALUES(null,@COMPLEMCLIENTE,@PLANOCLIENTE,@RAZAOSOCIAL,@INSCMUNICIPAL,@INSCESTADUAL,@EMPRESACLIENTE,@CNPJ,@RUACLIENTE,@NUMCLIENTE,@BAIRROCLIENTE,@CIDADECLIENTE,@AGENCIACLIENTE,@CONTACLIENTE,@BANCOCLIENTE,@TITULARCLIENTE,@CEPCLIENTE,@TELCLIENTE,@NMCONTCLIENTE,@TELCLIENTEII,@FAX,@EMAILCLIENTE,@SITECLIENTE,@DATACLIENTE);";
                    FbCommand cmd = new FbCommand(aux, conexaoFireBird);
                    cmd.Parameters.Add(new FbParameter("@COMPLEMCLIENTE",textBox3.Text));
                    cmd.Parameters.Add(new FbParameter("@PLANOCLIENTE",comboBox1.Text));
                    cmd.Parameters.Add(new FbParameter("@RAZAOSOCIAL", textBox6.Text));
                    cmd.Parameters.Add(new FbParameter("@INSCMUNICIPAL", textBox5.Text));
                    cmd.Parameters.Add(new FbParameter("@INSCESTADUAL", textBox13.Text));
                    cmd.Parameters.Add(new FbParameter("@EMPRESACLIENTE",textBox9.Text));
                    cmd.Parameters.Add(new FbParameter("@CNPJ", maskedTextBox6.Text));
                    cmd.Parameters.Add(new FbParameter("@RUACLIENTE", textBox8.Text));
                    cmd.Parameters.Add(new FbParameter("@NUMCLIENTE", maskedTextBox7.Text));
                    cmd.Parameters.Add(new FbParameter("@BAIRROCLIENTE", textBox7.Text));
                    cmd.Parameters.Add(new FbParameter("@CIDADECLIENTE", comboBox5.Text));
                    cmd.Parameters.Add(new FbParameter("@AGENCIACLIENTE", maskedTextBox8.Text));
                    cmd.Parameters.Add(new FbParameter("@CONTACLIENTE", maskedTextBox9.Text));
                    cmd.Parameters.Add(new FbParameter("@BANCOCLIENTE", textBox2.Text));
                    cmd.Parameters.Add(new FbParameter("@TITULARCLIENTE", textBox10.Text));
                    cmd.Parameters.Add(new FbParameter("@CEPCLIENTE", maskedTextBox1.Text));
                    cmd.Parameters.Add(new FbParameter("@TELCLIENTE", maskedTextBox10.Text));
                    cmd.Parameters.Add(new FbParameter("@NMCONTCLIENTE", textBox14.Text));
                    cmd.Parameters.Add(new FbParameter("@TELCLIENTEII", maskedTextBox2.Text));
                    cmd.Parameters.Add(new FbParameter("@FAX", maskedTextBox11.Text));
                    cmd.Parameters.Add(new FbParameter("@EMAILCLIENTE", textBox11.Text));
                    cmd.Parameters.Add(new FbParameter("@SITECLIENTE", textBox12.Text));
                    DateTime startD = monthCalendar1.SelectionStart;
                    string dateStartStr = startD.Date.ToShortDateString();
                    cmd.Parameters.Add(new FbParameter("@DATACLIENTE", dateStartStr));
                    cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("Cliente cadastrado com sucesso!");
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
