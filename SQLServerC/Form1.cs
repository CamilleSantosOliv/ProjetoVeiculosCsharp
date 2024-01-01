using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLServerC {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            if (ValidarBuscar()) 

                Buscar();
        }

        private bool ValidarBuscar() {

            if (cbxBuscar.Text == "") {

                MessageBox.Show("Selecione o campo a ser pesquisado");
                cbxBuscar.Focus();
                return false;
            }
            else if (txtBuscar.Text == "") { 

                MessageBox.Show("Campo buscar é obrigatório, digite algo: ");
                return false;
            }
            return true; 
        }

        private void Buscar() {
            sttslbl.Text = "Você está conectado ao Banco de dados :D";
            statusStrip1.Refresh(); 

            try { 
                using (SqlConnection cn = new SqlConnection(Conn.StrCon)) { 
                    cn.Open();

                    var sqlQuery = "SELECT * FROM tb_veiculos Where ";
                    switch (cbxBuscar.Text) {

                        case "Fabricante / Marca":
                            sqlQuery += "Nome like '%" + txtBuscar.Text + "%'";
                            break;
                        case "Modelo":
                            sqlQuery += "Modelo like '%" + txtBuscar.Text + "%'";
                            break;
                        case "Ano":
                            sqlQuery += "Ano =" + txtBuscar.Text;
                            break;
                        case "Cor":
                            sqlQuery += "Cor like '%" + txtBuscar.Text + "%'";
                            break;
                        case "Valor":
                            sqlQuery += "Valor >=" + txtBuscar.Text;
                            break;

                    } 

                    sqlQuery += " Order by Nome";


                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn)) { 

                        using (DataTable dt = new DataTable()) {
                            da.Fill(dt); 
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex) {

                sttslbl.Text = "Falha ao tentar acessar";
                statusStrip1.Refresh();

                MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);

            }


        }

        private void Form1_Load(object sender, EventArgs e) {
            sttslbl.Text = "";
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e) {
            FrmVeiculosAdicionar frm = new FrmVeiculosAdicionar(0);
            frm.ShowDialog();//FrmVeiculosAdicionar(0);--> passado o numero 0 pq ainda vai estra sendo criado
        }

        private void btnAlterar_Click(object sender, EventArgs e) {
            var id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);

            FrmVeiculosAdicionar frm = new FrmVeiculosAdicionar(id);
            frm.ShowDialog();//FrmVeiculosAdicionar(0); --> passado o numero 0 (zero) para a classe form por ser o numero que vai estar na grade 
        }

 
    }
        }
   
