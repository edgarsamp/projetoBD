using GuildInterface.GuildeClasses;
using GuildInterface.Persistencia;
using MySql.Data.MySqlClient;


namespace GuildInterface {
    public partial class ContratanteInterface : Form {
        private int? id_selecionado = null;
        private ContratanteDAO bd = new();
        public ContratanteInterface() {
            InitializeComponent();

            listContratante.View = View.Details;
            listContratante.LabelEdit = false;
            listContratante.AllowColumnReorder = true;
            listContratante.FullRowSelect = true;
            listContratante.GridLines = true;
            listContratante.MultiSelect = false;

            listContratante.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listContratante.Columns.Add("Nome", 200, HorizontalAlignment.Left);
            listContratante.Columns.Add("Profissão", 200, HorizontalAlignment.Left);

            preenche_contratantes();
        }

        private void preenche_contratantes() {
            List<string[]> r = bd.ConsultarByNome();
            listContratante.Items.Clear();
            r.ForEach(cont => listContratante.Items.Add(new ListViewItem(cont)));
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
            preenche_contratantes();
        }

        private void button2_Click(object sender, EventArgs e) {
            if (id_selecionado == null || String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtProfissao.Text)) {
                MessageBox.Show("Preencha todos os campos obrigadorios");
                return;
            }
            Contratante cont = new(id_selecionado, txtNome.Text, txtProfissao.Text);
            bd.Editar(cont);
            limparTela();
            preenche_contratantes();
        }

        private void button5_Click(object sender, EventArgs e) {
            List<string[]> r = bd.ConsultarByNome(txtNome.Text);
            listContratante.Items.Clear();
            r.ForEach(cont => listContratante.Items.Add(new ListViewItem(cont)));
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtProfissao.Text)) {
                MessageBox.Show("Preencha todos os campos obrigadorios");
                return;
            }
            var cont = new Contratante(txtNome.Text, txtProfissao.Text);
            bd.Incluir(cont);
            limparTela();
            preenche_contratantes();
        }

        private void limparTela() {
            txtNome.Text = "";
            txtProfissao.Text = "";
            id_selecionado = null;

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        private void ContratanteInterface_Load(object sender, EventArgs e) {

        }

        private void listContratante_SelectedIndexChanged(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection itens_selecionados = listContratante.SelectedItems;

            foreach (ListViewItem item in itens_selecionados) {
                id_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                txtNome.Text = item.SubItems[1].Text;
                txtProfissao.Text = item.SubItems[2].Text;
            }

            if (id_selecionado != null) {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }
    }
}