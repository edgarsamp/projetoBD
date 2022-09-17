using GuildInterface.GuildeClasses;
using GuildInterface.Persistencia;

namespace GuildInterface {
    public partial class ItemInterface : Form {
        private int? id_selecionado = null;
        private ItemDAO bd = new();
        private List<string[]> categorias;
        public ItemInterface() {
            InitializeComponent();

            listItens.View = View.Details;
            listItens.LabelEdit = false;
            listItens.AllowColumnReorder = true;
            listItens.FullRowSelect = true;
            listItens.GridLines = true;
            listItens.MultiSelect = false;

            listItens.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listItens.Columns.Add("Nome", 100, HorizontalAlignment.Left);
            listItens.Columns.Add("Raridade", 75, HorizontalAlignment.Left);
            listItens.Columns.Add("Descrição", 250, HorizontalAlignment.Left);
            listItens.Columns.Add("Preço", 50, HorizontalAlignment.Left);
            listItens.Columns.Add("Categoria", 75, HorizontalAlignment.Left);

            categorias = bd.getCategoria();
            cbBoxCategoria.BeginUpdate();
            categorias.ForEach(cat => { cbBoxCategoria.Items.Add(cat[1]); });
            cbBoxCategoria.EndUpdate();

            preenche_lista();
        }

        private string getCategoriaByCodigo(string codigo) {
            foreach (var categoria in categorias) {
                if (categoria[0] == codigo)
                    return categoria[1];
            }
            return "";
        }
        private void preenche_lista() {
            List<string[]> r = bd.ConsultarByNome();
            listItens.Items.Clear();

            r.ForEach(item => { item[5] = getCategoriaByCodigo(item[5]); });
            r.ForEach(item => listItens.Items.Add(new ListViewItem(item)));

            ListView.SelectedListViewItemCollection itens_selecionados = listItens.SelectedItems;
            foreach (ListViewItem item in itens_selecionados) {
                id_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                txtNome.Text = item.SubItems[1].Text;
                txtRaridade.Text = item.SubItems[2].Text;
                txtDesc.Text = item.SubItems[3].Text;
                txtPrecoMedio.Text = item.SubItems[4].Text;
                txtDesc.Text = item.SubItems[5].Text;
            }
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

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
            if (id_selecionado == null || String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtDesc.Text)) {
                MessageBox.Show("Preencha todos os campos obrigadorios");
                return;
            }

            var categoria = Convert.ToInt32(getCodigoByCategoria(cbBoxCategoria.Text));
            Item itm = new(id_selecionado, txtNome.Text, Convert.ToInt32(txtRaridade.Text), txtDesc.Text, Convert.ToInt32(txtPrecoMedio.Text), categoria);
            bd.Editar(itm);
            limparTela();
            preenche_lista();
        }

        private void button5_Click(object sender, EventArgs e) {
            List<string[]> r = bd.ConsultarByNome(txtNome.Text);
            listItens.Items.Clear();
            r.ForEach(item => { item[5] = getCategoriaByCodigo(item[5]); });
            r.ForEach(item => listItens.Items.Add(new ListViewItem(item)));
        }

        private string getCodigoByCategoria(string cat) {
            foreach (var categoria in categorias) {
                if (categoria[1] == cat)
                    return categoria[0];
            }
            return "";
        }
        private void btnSalvar_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtDesc.Text)) {
                MessageBox.Show("Preencha todos os campos obrigadorios");
                return;
            }
            var categoria = Convert.ToInt32(getCodigoByCategoria(cbBoxCategoria.Text));
            Item itm = new(txtNome.Text, Convert.ToInt32(txtRaridade.Text), txtDesc.Text, Convert.ToInt32(txtPrecoMedio.Text), categoria);
            bd.Incluir(itm);
            limparTela();
            preenche_lista();
        }

        private void limparTela() {
            txtNome.Text = "";
            txtDesc.Text = "";
            id_selecionado = null;

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        private void LugarInterface_Load(object sender, EventArgs e) {

        }

        private void listItens_SelectedIndexChanged(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection itens_selecionados = listItens.SelectedItems;
            foreach (ListViewItem item in itens_selecionados) {
                id_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                txtNome.Text = item.SubItems[1].Text;
                txtRaridade.Text = item.SubItems[2].Text;
                txtDesc.Text = item.SubItems[3].Text;
                txtPrecoMedio.Text = item.SubItems[4].Text;
                cbBoxCategoria.Text = item.SubItems[5].Text;
            }

            if (id_selecionado != null) {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}