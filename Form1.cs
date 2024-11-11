using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Crud_de_cadastro_do_produto
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }
        produto bd = new produto();
        string tabela = "produtos";
        private void Produtos_Load(object sender, EventArgs e)
        {
            bd.ConectarBD();
        }
        private void btn_mostra_Click(object sender, EventArgs e)
        {
            string coloca;
            string nome = txt_nome.Text;
            int code = int.Parse(txt_code.Text);
            float preco = float.Parse(txt_preco.Text);
            if (txt_nome.Text != "" && int.TryParse(txt_code.Text, out code))
            {
                coloca = String.Format($"INSERT INTO {tabela} VALUES (null, '{txt_nome.Text}', '{code}', '{preco}')");
                bd.executar_comandos(coloca);
                mostra_dados();
                limpa_tela();
            }
            else
            {
                MessageBox.Show("Informação inválida!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void mostra_dados()
        {
            //Preparar o comando
            string dados = $"select * from {tabela}";
            DataTable dt = bd.executar_consulta(dados);
            dtg_produtos.DataSource = dt.AsDataView();
        }
        private void limpa_tela()
        {
            txt_preco.Clear();
            txt_code.Clear();
            txt_nome.Clear();
        }
        private void btn_altera_Click(object sender, EventArgs e)
        {
            string alterar;
            string nome = txt_nome.Text;
            int code = int.Parse(txt_code.Text);
            float preco = float.Parse(txt_preco.Text);
            if (txt_nome.Text != "" && int.TryParse(txt_code.Text, out code))
            {
                alterar = string.Format($"Update {tabela} set nome = '{nome}',código = '{code}',preco = '{preco}',where id = {lbl_id.Text}");
                int resultado = bd.executar_comandos(alterar);
                if (resultado == 1)
                {
                    MessageBox.Show("Alterado com sucesso");
                    mostra_dados();
                    limpa_tela();
                }
                else
                {
                    MessageBox.Show("Erro ao alterar");
                }
            }
        }
        private void dtg_produtos_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            e.ToolTipText = "Clique em uma célula para preencher os campos do formulário";
        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            mostra_dados();
        }

        private void btn_sai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtg_produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //este código imprime os caracteres na label quando o usuário clica em alguma célula
            lbl_id.Text = dtg_produtos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = dtg_produtos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_code.Text = dtg_produtos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_preco.Text = dtg_produtos.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_exclui_Click(object sender, EventArgs e)
        {
            string excluir;
            if (txt_nome.Text != "" && txt_code.Text != "")
            {
                excluir = string.Format($"delete from {tabela} where id = {lbl_id.Text}");
                int resultado = bd.executar_comandos(excluir);
                mostra_dados();
                if (resultado == 1)
                {
                    MessageBox.Show("Deletado com sucesso");
                    mostra_dados();
                    limpa_tela();
                }
                else
                {
                    MessageBox.Show("Erro ao deletar");
                }
            }
        }

        private void btn_aplique_Click(object sender, EventArgs e)
        {
            //Conectar ao banco
            MySqlConnection c = new MySqlConnection("Persist security info = false; server = localhost;" + " database = bd_escola; user =root; pwd=;");
            c.Open();
            //Preparar o comando 
            MySqlCommand cm = new MySqlCommand($"insert into {tabela} values(null ,'{txt_nome.Text}','{txt_code.Text}','{txt_preco.Text}')", c);
            //Executar o comando 
            cm.ExecuteNonQuery();
            //Fechar a conexão com o banco 
            c.Clone();
        }
    }
}
