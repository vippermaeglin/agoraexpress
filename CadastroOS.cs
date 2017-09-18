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
    public partial class CadastroOS : Form
    {
        public CadastroOS()
        {
            InitializeComponent();
        }

        private void CadastroOS_Load(object sender, EventArgs e)
        {

            
            string aux = "";
            using (FbConnection conexaoFireBird = daoFireBird.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();

                    string mSQL = "SELECT EMPRESACLIENTE,CDCLIENTE FROM CLIENTE";

                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataAdapter da = new FbDataAdapter(cmd);

                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    comboBox1.DataSource = ds.Tables[0];
                    comboBox1.DisplayMember = ds.Tables[0].Columns[0].ToString();
                    comboBox1.ValueMember = ds.Tables[0].Columns["EMPRESACLIENTE"].ToString();
                    comboBox1.DisplayMember.Insert(0, "<cadastrar>");
                    comboBox1.ValueMember.Insert(0, "<cadastrar>");
                    //comboBox1.Items.Add(ds.Tables[0].Columns[0].ToString());
                    String item;
                    item = ds.Tables[0].Columns[0].ToString();
                    //MessageBox.Show(item);
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

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Rota = "http://maps.google.com.br/maps?f=q&source=s_q&hl=pt-BR&geocode=&q=" +
            " from: " + textBox2.Text.ToString() + ", " + maskedTextBox4.Text.ToString() + ", " +
            comboBox3.Text.ToString() + ", MG, " + " to: " + textBox5.Text.ToString() + ", " +
                      maskedTextBox5.Text.ToString() + ", " + comboBox4.Text.ToString() + ", MG, ";
            RotaOS Rota_OS = new RotaOS(Rota);
            Rota_OS.ShowDialog();

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.Equals("<CADASTRAR>")){
                CadastroCL Cadastro_CL = new CadastroCL();
                Cadastro_CL.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Rota = "http://maps.google.com.br/maps?f=q&source=s_q&hl=pt-BR&geocode=&q=" +
            " from: " + textBox2.Text.ToString() + ", " + maskedTextBox4.Text.ToString() + ", " +
            comboBox3.Text.ToString() + ", MG, " + " to: " + textBox5.Text.ToString() + ", " +
                      maskedTextBox5.Text.ToString() + ", " + comboBox4.Text.ToString() + ", MG, ";
            RotaOS Rota_OS = new RotaOS(Rota);
            Rota_OS.ShowDialog();
        }



    }
}
