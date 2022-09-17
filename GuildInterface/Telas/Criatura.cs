using GuildInterface.GuildeClasses;
using GuildInterface.Persistencia;

namespace GuildInterface {
    public partial class CriaturaInterface : Form {
        private int? id_selecionado = null;
        private CriaturaDAO bd = new();
        public CriaturaInterface() {
            InitializeComponent();

            listCriaturas.View = View.Details;
            listCriaturas.LabelEdit = false;
            listCriaturas.AllowColumnReorder = true;
            listCriaturas.FullRowSelect = true;
            listCriaturas.GridLines = true;
            listCriaturas.MultiSelect = false;

            listCriaturas.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listCriaturas.Columns.Add("Nome", 200, HorizontalAlignment.Left);
            listCriaturas.Columns.Add("Nivel de Periculosidade", 200, HorizontalAlignment.Left);

            preenche_lista();
        }

        private void preenche_lista() {
            List<string[]> r = bd.ConsultarByNome();
            listCriaturas.Items.Clear();
            r.ForEach(cria => listCriaturas.Items.Add(new ListViewItem(cria)));
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
            if (id_selecionado == null || txtNome.Text == null || txtNivelPericulosidade.Text == null) {
                MessageBox.Show("Preencha todos os campos obrigadorios");
                return;
            }
            Criatura cria = new(id_selecionado, txtNome.Text, Convert.ToInt32(txtNivelPericulosidade.Text));
            bd.Editar(cria);
            limparTela();
            preenche_lista();
        }

        private void button5_Click(object sender, EventArgs e) {
            List<string[]> r = bd.ConsultarByNome(txtNome.Text);
            listCriaturas.Items.Clear();
            r.ForEach(cria => listCriaturas.Items.Add(new ListViewItem(cria)));
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtNivelPericulosidade.Text)) {
                MessageBox.Show("Preencha todos os campos obrigadorios");
                return;
            }
            var cria = new Criatura(txtNome.Text, Convert.ToInt32(txtNivelPericulosidade.Text));
            bd.Incluir(cria);
            limparTela();
            preenche_lista();
        }

        private void limparTela() {
            txtNome.Text = "";
            txtNivelPericulosidade.Text = "";
            id_selecionado = null;

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        private void CriaturaInterface_Load(object sender, EventArgs e) {

        }

        private void listCriaturas_SelectedIndexChanged(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection itens_selecionados = listCriaturas.SelectedItems;
            foreach (ListViewItem item in itens_selecionados) {
                id_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                txtNome.Text = item.SubItems[1].Text;
                txtNivelPericulosidade.Text = item.SubItems[2].Text;
            }

            if (id_selecionado != null) {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }
    }
}