using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLServerC {
    public partial class FrmVeiculosAdicionar : Form {
        int id = 0;
        public FrmVeiculosAdicionar(int id) {
            InitializeComponent();
            this.id = id; //this.id = id; --> o id eh a class que eh igual ao id que for colocado

            if (this.id > 0) //se o id for maior que 0, vai ser chamado o metodo getveiculos pra fazer a alteracao
                GetVeiculos(id);
        }

        private void GetVeiculos(int id) {//o id que esta aqui, eh a identificacao do veiculo qque vai ser alterado
            toolStripStatusLabel1.Text = "Conectando";//mensagem ao servidor
            statusStrip1.Refresh();

            try { //o try vai fazer a tentativa de acao
                using (SqlConnection cn = new SqlConnection(Conn.StrCon)) {//iniciando a conexao com o banco de dados
                    cn.Open();//abrindo a conexao

                    var sql = "Select * from tb_veiculos where id=" + id; //trazendo o comando sql do sqlserver que vai selecionar o veiculo que foi passado pelo id, que esta na criacao do metodo

                    using (SqlCommand cmd = new SqlCommand(sql, cn)) {//criando um command e instanciando e conectando com a classe 
                        toolStripStatusLabel1.Text = "Veículo encontrado!";
                        statusStrip1.Refresh();

                        //o dataReader ai receber o comando sql do sqlCommand que esta no select acima
                        using (SqlDataReader dr = cmd.ExecuteReader()) {

                            if (dr.HasRows) {//verificando se a informacao chegou

                                if (dr.Read()) {

                                    //pegando as informaçoes das colunas do banco de dados e associando as colunas que estao no formulario de adicionar
                                    txtNome.Text = dr["Nome"].ToString();
                                    txtModelo.Text = dr["Modelo"].ToString();
                                    txtAno.Text = dr["Ano"].ToString();
                                    txtFabricacao.Text = dr["Fabricacao"].ToString();
                                    txtCor.Text = dr["Cor"].ToString();


                                    switch (Convert.ToInt32(dr["Combustivel"])) { //pegando o que o usuario colocar no campo "combustivel"

                                        case 1: //(Convert.ToInt32 --> conversao para numero
                                            cbxCombustivel.Text = "1 Gasolina";//se o usuario escolher gasolina, entao vai para essa opcao e vice versa
                                            break;
                                        case 2:
                                            cbxCombustivel.Text = "2 Álcool";
                                            break;
                                        case 3:
                                            cbxCombustivel.Text = "3 Flex";
                                            break;
                                        case 4:
                                            cbxCombustivel.Text = "4 Diesel";
                                            break;
                                        case 5:
                                            cbxCombustivel.Text = "5 Gás Natural";
                                            break;

                                    }

                                    if (Convert.ToBoolean(dr["automatico"]))
                                        cbxAutomatico.Text = "Sim";
                                    //se o cbx for verdadeiroo, vai ser registrada a informação no formulario de adicionar                                        
                                    else
                                        cbxAutomatico.Text = "Não";

                                    txtValor.Text = dr["Valor"].ToString();

                                }
                            }
                        }
                    }
                }
                }
            catch (Exception ex) {
                toolStripStatusLabel1.Text = "Falha";
                statusStrip1.Refresh();
                MessageBox.Show("Nenhum dado foi alterado! \n\n" + ex.Message);
            }
            }


        private void btnSalvar_Click(object sender, EventArgs e) {
            SalvarVeiculo();
            this.Close();
        }
        private void SalvarVeiculo() {
            toolStripStatusLabel1.Text = "Conectando... Aguarde!";
            statusStrip1.Refresh();

            try { //o sqlServer começa a ser utilizado do "try" em diante
                using (SqlConnection cn = new SqlConnection(Conn.StrCon)) { 
                    cn.Open();

                    var sql = "";
                    
                    if (this.id == 0) 
                        //se o id for igual a zero 0, vai ser captado os dados abaixo, vai ser feito o INSERT

                        sql = "INSERT INTO tb_Veiculos (Nome, Modelo, Ano, Fabricacao, Cor, Combustivel, Automatico, Valor) VALUES (@Nome, @Modelo, @Ano, @Fabricacao, @Cor, @Combustivel, @Automatico, @Valor)";

                        else // se nao for igual a zero, vai ser feito um UPDATE
                        //o "@Nome" eh o mesmo de "Nome", esta diferente p sao parametros

                            sql = "UPDATE tb_Veiculos Set Nome=@Nome, Modelo=@Modelo, Ano=@Ano, Fabricacao=@Fabricacao, Cor=@Cor, Combustivel=@Combustivel, Automatico=@Automatico, Valor=@Valor WHERE id=" + this.id;
                    

                    using (SqlCommand cmd = new SqlCommand(sql, cn)) {
                        //o sqlCommand eh o que consegue executar o comando sql numa conexao
                        //a conexao no codigo eh o cn (Conn.StrCon) que ja tinnha sido declarado acima
                        //o nome do SqlCommand eh o cmd

                       
                        toolStripStatusLabel1.Text = "Atualizando a tabela...";
                        statusStrip1.Refresh();
                        //o que esta abaixo vai receber o que vai ser colocado pelo usuario no formulario
                        cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@Modelo", txtModelo.Text);
                        cmd.Parameters.AddWithValue("@Ano", txtAno.Text);
                        cmd.Parameters.AddWithValue("@Fabricacao", txtFabricacao.Text);
                        cmd.Parameters.AddWithValue("@Cor", txtCor.Text);
                        cmd.Parameters.AddWithValue("@Combustivel", cbxCombustivel.Text.Substring(0,1));
                        //.Substring(0,1)); --> esta pegando o primeiro caractere do combustivel text
                        // como a posicao do primeiro caractere e 0 e o segundo valor e o tipo do combustivel entao fica assim (0,1)

                        cmd.Parameters.AddWithValue("@Automatico", cbxAutomatico.Text.Substring(0,1) == "S" ? 1 : 0);
                        // == "S" ? 1 : 0); --> o "S", quer dizer "sim", se for não, vai ser "zero" (0)
                        cmd.Parameters.AddWithValue("@Valor", txtValor.Text.Replace(",","."));
                        cmd.ExecuteNonQuery();//ExecuteNonQuery --> nao da retorno de dados            
                    }
                    toolStripStatusLabel1.Text = "Atualização concluída";
                    statusStrip1.Refresh();
                }
            }
            catch (Exception ex) {//o catch eh oo comando de codigo que tem que ter se caso der erro
                toolStripStatusLabel1.Text = "Falha ao tentar atualizar os dados da tabela!";
                statusStrip1.Refresh();
                MessageBox.Show("Falha ao inserir os dados. \n\n" + ex.Message);
            }
        }

    }
}
