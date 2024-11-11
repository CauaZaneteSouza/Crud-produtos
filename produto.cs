using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_de_cadastro_do_produto
{
    internal class produto
    {
        MySqlConnection conn;
        public void ConectarBD()
        {
            try
            {
                conn = new MySqlConnection("Persist security info = false; server = localhost;" + " database = bd_produtos; user =root; pwd=;");
                conn.Open();
                // MessageBox.Show("Conectado");
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao conectar!" + e.Message);
            }
        }
        //Executa comandos do banco de dados
        public int executar_comandos(string sql)
        {
            int resultado;
            try
            {//conectou ao banco de dados
                ConectarBD();
                //Preparando o comando
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Comando de execução no banco de dados
                cmd.ExecuteNonQuery();
                resultado = 1;
            }
            catch (Exception)
            {
                resultado = 0;
                throw;
            }
            //Fecha a conexão do banco de dados//Boa prática para certificar que a conexão será efetuada
            finally { conn.Close(); }
            return resultado;
        }
        public DataTable executar_consulta(string sql)
        {
            try
            {
                ConectarBD();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                //"Fill" faz o preenchimento da resposta da consulta do banco
                da.Fill(dt);
                return dt;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
