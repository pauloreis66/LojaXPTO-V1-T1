using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LojaXPTO
{

    public partial class FormCategorias : Form
    {
        //declarar um vetor para armazenar os registos
        private const int MaxCategorias = 100;
        private readonly Categorias[] categoriasVetor;

        //declarar um contador de registo
        private int num_categorias;

        public FormCategorias()
        {
            //criar e inicializar o vetor
            categoriasVetor = new Categorias[MaxCategorias];
            num_categorias = 0;

            InitializeComponent();
        }

        private void Limpar()
        {
            txtCodigo.ResetText();
            txtCategoria.ResetText();
            txtZona.ResetText();
            txtFila.ResetText();
            txtPrateleira.ResetText();
            txtCodigo.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            //configurar o datagridview
            grelha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grelha.RowHeadersVisible= false;
            grelha.AllowUserToAddRows = false;
            grelha.AllowUserToDeleteRows = false;
            grelha.AllowUserToResizeRows = false;
            grelha.AllowUserToResizeColumns = false;
            grelha.EditMode = DataGridViewEditMode.EditProgrammatically;
            grelha.ColumnCount = 5;
            grelha.Columns[0].Name= "Código";
            grelha.Columns[0].Width= 100;
            grelha.Columns[1].Name = "Categoria";
            grelha.Columns[1].Width= 250;
            grelha.Columns[2].Name = "Zona";
            grelha.Columns[2].Width= 80;
            grelha.Columns[3].Name = "Fila";
            grelha.Columns[3].Width= 80;
            grelha.Columns[4].Name = "Prateleira";
            grelha.Columns[4].Width= 150;
            grelha.Rows.Clear();

            Limpar();
            statusMsg.Text=String.Empty;   //""
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnNovo_Click(object sender, EventArgs e) 
        {
            //verificar se os dados são válidos
            int x;
            try 
            {
                //verificar se codigo é inteiro
                if (!int.TryParse(txtCodigo.Text, out x))
                {
                    txtCodigo.Focus();
                    throw new Exception("Insira um código inteiro.");
                }
                else if (Convert.ToInt32(txtCodigo.Text) < 1)
                {
                    txtCodigo.Focus();
                    throw new Exception("Insira um código maior que 0.");
                }

                //verificar se é uma descrição da categoria é válida
                if (txtCategoria.Text.Equals("") ||
                    txtCategoria.Text.Length < 3 ||
                    txtCategoria.Text.Length > 50)
                {
                    txtCategoria.Focus();
                    throw new Exception("Insira a descrição da categoria (3 a 50 chars).");
                }

                //verificar se é uma zona válida
                if (txtZona.Text.Equals("") ||
                    !System.Text.RegularExpressions.Regex.IsMatch(txtZona.Text, "^[a-zA-Z ]"))
                {
                    txtZona.Focus();
                    throw new Exception("Insira a zona (letra A a Z).");
                }

                //verificar se fila é inteiro
                if (!int.TryParse(txtFila.Text, out x))
                {
                    txtFila.Focus();
                    throw new Exception("Insira na fila um valor inteiro.");
                }
                else if (Convert.ToInt32(txtFila.Text) < 1 || Convert.ToInt32(txtFila.Text) > 100)
                {
                    txtFila.Focus();
                    throw new Exception("Insira um valor para a fila entre 1 e 100.");
                }

                //verificar se prateleira é inteiro
                if (!int.TryParse(txtPrateleira.Text, out x))
                {
                    txtPrateleira.Focus();
                    throw new Exception("Insira na prateleira um valor inteiro.");
                }
                else if (Convert.ToInt32(txtPrateleira.Text) < 1 || Convert.ToInt32(txtPrateleira.Text) > 10)
                {
                    txtPrateleira.Focus();
                    throw new Exception("Insira um valor para a prateleira entre 1 e 10.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //colocar uma linha no datagridview
            grelha.Rows.Add(txtCodigo.Text, txtCategoria.Text, txtZona.Text, txtFila.Text, txtPrateleira.Text);

            statusMsg.Text = "Adicionado uma nova categoria.";
            Limpar();
        }

        //saber qual o index da categoria selecionado na datagridview
        private int posLista = -1;
        private void grelha_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            posLista = grelha.CurrentCell.RowIndex;
            if (posLista != -1) {

                txtCodigo.Text = grelha.Rows[posLista].Cells[0].Value.ToString();
                txtCategoria.Text = grelha.Rows[posLista].Cells[1].Value.ToString();
                txtZona.Text = grelha.Rows[posLista].Cells[2].Value.ToString();
                txtFila.Text = grelha.Rows[posLista].Cells[3].Value.ToString();
                txtPrateleira.Text = grelha.Rows[posLista].Cells[4].Value.ToString();
                txtCodigo.Focus();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (posLista != -1)
            {

                //verificar se os dados são válidos
                int x;
                try
                {
                    //verificar se codigo é inteiro
                    if (!int.TryParse(txtCodigo.Text, out x))
                    {
                        txtCodigo.Focus();
                        throw new Exception("Insira um código inteiro.");
                    }
                    else if (Convert.ToInt32(txtCodigo.Text) < 1)
                    {
                        txtCodigo.Focus();
                        throw new Exception("Insira um código maior que 0.");
                    }

                    //verificar se é uma descrição da categoria é válida
                    if (txtCategoria.Text.Equals("") ||
                        txtCategoria.Text.Length < 3 ||
                        txtCategoria.Text.Length > 50)
                    {
                        txtCategoria.Focus();
                        throw new Exception("Insira a descrição da categoria (3 a 50 chars).");
                    }

                    //verificar se é uma zona válida
                    if (txtZona.Text.Equals("") ||
                        !System.Text.RegularExpressions.Regex.IsMatch(txtZona.Text, "^[a-zA-Z ]"))
                    {
                        txtZona.Focus();
                        throw new Exception("Insira a zona (letra A a Z).");
                    }

                    //verificar se fila é inteiro
                    if (!int.TryParse(txtFila.Text, out x))
                    {
                        txtFila.Focus();
                        throw new Exception("Insira na fila um valor inteiro.");
                    }
                    else if (Convert.ToInt32(txtFila.Text) < 1 || Convert.ToInt32(txtFila.Text) > 100)
                    {
                        txtFila.Focus();
                        throw new Exception("Insira um valor para a fila entre 1 e 100.");
                    }

                    //verificar se prateleira é inteiro
                    if (!int.TryParse(txtPrateleira.Text, out x))
                    {
                        txtPrateleira.Focus();
                        throw new Exception("Insira na prateleira um valor inteiro.");
                    }
                    else if (Convert.ToInt32(txtPrateleira.Text) < 1 || Convert.ToInt32(txtPrateleira.Text) > 10)
                    {
                        txtPrateleira.Focus();
                        throw new Exception("Insira um valor para a prateleira entre 1 e 10.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //remover e inserir na mesma posição no datagridview
                grelha.Rows.RemoveAt(posLista);
                grelha.Rows.Insert(posLista, txtCodigo.Text, txtCategoria.Text, 
                    txtZona.Text, txtFila.Text, txtPrateleira.Text);

                statusMsg.Text = "Alterada a categoria.";
                posLista = -1;
                Limpar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (posLista !=-1)
            {
                grelha.Rows.RemoveAt(posLista);
                statusMsg.Text = "Removida a categoria.";
                posLista = -1;
                Limpar();
            } else
            {
                MessageBox.Show("Não existe nenhuma categoria selecionada.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }

        private void AdicionaCategoria(Categorias c)
        {
            if (num_categorias < MaxCategorias)
            {
                categoriasVetor[num_categorias++] = c;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //colocar os itens da datagridbiú fazendo uma selecão linha a linha
            foreach (DataGridViewRow linha in grelha.Rows)
            {
                int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());
                string categoria = linha.Cells[1].Value.ToString();
                string zona = linha.Cells[2].Value.ToString();
                int fila = Convert.ToInt32(linha.Cells[3].Value.ToString());
                int prateleira = Convert.ToInt32(linha.Cells[4].Value.ToString());

                AdicionaCategoria(new Categorias(codigo,categoria, zona, fila, prateleira));

                MessageBox.Show("Registo guardados com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
