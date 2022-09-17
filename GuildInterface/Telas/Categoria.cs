using GuildInterface.GuildeClasses;
using GuildInterface.Persistencia;

namespace GuildInterface {
    public partial class CategoriaInterface : Form {
        private int? id_selecionado = null;
        private CategoriaDAO bd = new();
        public CategoriaInterface() {
            InitializeComponent();

            listCategorias.View = View.Details;
            listCategorias.LabelEdit = false;
            listCategorias.AllowColumnReorder = true;
            listCategorias.FullRowSelect = true;
            listCategorias.GridLines = true;
            listCategorias.MultiSelect = false;

            listCategorias.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listCategorias.Columns.Add("Nome", 200, HorizontalAlignment.Left);

            preenche_lista();
        }

        private void preenche_lista() {
            List<string[]> r = bd.ConsultarByNome();
            listCategorias.Items.Clear();
            r.ForEach(cria => listCategorias.Items.Add(new ListViewItem(cria)));
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {
            limparTela();
        }

        private void button4_Click(object sender, EventArgs e) {
            bd.Excluir(id_selecionado);
            limparTela();
            preenche_lista();
        }

        private void button2_Click(object sender, EventArgs e) {
            if (id_selecionado == null || String.IsNullOrEmpty(txtNome.Text)) {
                MessageBox.Show("Preencha todos os campos obrigadorios");
                return;
            }
            Categoria cat = new(id_selecionado, txtNome.Text);
            bd.Editar(cat);
            limparTela();
            preenche_lista();
        }

        private void button5_Click(object sender, EventArgs e) {
            List<string[]> r = bd.ConsultarByNome(txtNome.Text);
            listCategorias.Items.Clear();
            r.ForEach(cria => listCategorias.Items.Add(new ListViewItem(cria)));
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtNome.Text)) {
                MessageBox.Show("Preencha todos os campos obrigadorios");
                return;
            }
            Categoria cat = new(id_selecionado, txtNome.Text);
            bd.Incluir(cat);
            limparTela();
            preenche_lista();
        }

        private void limparTela() {
            txtNome.Text = "";
            id_selecionado = null;

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        private void listCategorias_SelectedIndexChanged(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection itens_selecionados = listCategorias.SelectedItems;
            foreach (ListViewItem item in itens_selecionados) {
                id_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                txtNome.Text = item.SubItems[1].Text;
            }

            if (id_selecionado != null) {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

    }
}