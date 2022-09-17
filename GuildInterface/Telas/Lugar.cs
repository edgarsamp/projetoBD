using GuildInterface.GuildeClasses;
using GuildInterface.Persistencia;

namespace GuildInterface {
    public partial class LugarInterface : Form {
        private int? id_selecionado = null;
        private LugarDAO bd = new();
        public LugarInterface() {
            InitializeComponent();

            listLugares.View = View.Details;
            listLugares.LabelEdit = false;
            listLugares.AllowColumnReorder = true;
            listLugares.FullRowSelect = true;
            listLugares.GridLines = true;
            listLugares.MultiSelect = false;

            listLugares.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listLugares.Columns.Add("Nome", 200, HorizontalAlignment.Left);
            listLugares.Columns.Add("Descrição", 400, HorizontalAlignment.Left);

            preenche_lista();
        }

        private void preenche_lista() {
            List<string[]> r = bd.ConsultarByNome();
            listLugares.Items.Clear();
            r.ForEach(cria => listLugares.Items.Add(new ListViewItem(cria)));
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
            Lugar lug = new(id_selecionado, txtNome.Text, txtDesc.Text);
            bd.Editar(lug);
            limparTela();
            preenche_lista();
        }

        private void button5_Click(object sender, EventArgs e) {
            List<string[]> r = bd.ConsultarByNome(txtNome.Text);
            listLugares.Items.Clear();
            r.ForEach(cria => listLugares.Items.Add(new ListViewItem(cria)));
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtDesc.Text)) {
                MessageBox.Show("Preencha todos os campos obrigadorios");
                return;
            }
            var lug = new Lugar(txtNome.Text, txtDesc.Text);
            bd.Incluir(lug);
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

        private void listLugares_SelectedIndexChanged(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection itens_selecionados = listLugares.SelectedItems;
            foreach (ListViewItem item in itens_selecionados) {
                id_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                txtNome.Text = item.SubItems[1].Text;
                txtDesc.Text = item.SubItems[2].Text;
            }

            if (id_selecionado != null) {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }
    }
}