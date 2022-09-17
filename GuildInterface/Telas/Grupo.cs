using GuildInterface.GuildeClasses;
using GuildInterface.Persistencia;

namespace GuildInterface {
    public partial class GrupoInterface : Form {
        private int? id_selecionado = null;
        private GrupoDAO bd = new();
        public GrupoInterface() {
            InitializeComponent();

            listGrupo.View = View.Details;
            listGrupo.LabelEdit = false;
            listGrupo.AllowColumnReorder = true;
            listGrupo.FullRowSelect = true;
            listGrupo.GridLines = true;
            listGrupo.MultiSelect = false;

            listGrupo.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listGrupo.Columns.Add("Nome", 200, HorizontalAlignment.Left);
            listGrupo.Columns.Add("Descrição", 400, HorizontalAlignment.Left);

            preenche_lista();
        }

        private void preenche_lista() {
            List<string[]> r = bd.ConsultarByNome();
            listGrupo.Items.Clear();
            r.ForEach(cria => listGrupo.Items.Add(new ListViewItem(cria)));
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
            Grupo grup = new(id_selecionado, txtNome.Text, txtDesc.Text);
            bd.Editar(grup);
            limparTela();
            preenche_lista();
        }

        private void button5_Click(object sender, EventArgs e) {
            List<string[]> r;
            if (String.IsNullOrEmpty(txtNome.Text)) {
                r = bd.ConsultarByNome();
            } else {
                r = bd.ConsultarByNome(txtNome.Text);
            }
            listGrupo.Items.Clear();
            r.ForEach(cria => listGrupo.Items.Add(new ListViewItem(cria)));
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtDesc.Text)) {
                MessageBox.Show("Preencha todos os campos obrigadorios");
                return;
            }
            var lug = new Grupo(txtNome.Text, txtDesc.Text);
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

        private void GrupoInterface_Load(object sender, EventArgs e) {

        }

        private void listGrupos_SelectedIndexChanged(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection itens_selecionados = listGrupo.SelectedItems;
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

        private void txtNome_TextChanged(object sender, EventArgs e) {

        }
    }
}