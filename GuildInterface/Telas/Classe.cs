using GuildInterface.GuildeClasses;
using GuildInterface.Persistencia;

namespace GuildInterface {
    public partial class ClasseInterface : Form {
        private ClasseDAO bd = new();
        public ClasseInterface() {
            InitializeComponent();

            listClasses.View = View.Details;
            listClasses.LabelEdit = false;
            listClasses.AllowColumnReorder = true;
            listClasses.FullRowSelect = true;
            listClasses.GridLines = true;
            listClasses.MultiSelect = false;

            listClasses.Columns.Add("Codigo", 75, HorizontalAlignment.Left);
            listClasses.Columns.Add("Nome", 200, HorizontalAlignment.Left);

            preenche_lista();
        }

        private void preenche_lista() {
            List<string[]> r = bd.ConsultarByNome();
            listClasses.Items.Clear();
            r.ForEach(cria => listClasses.Items.Add(new ListViewItem(cria)));
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {
            limparTela();
        }

        private void button4_Click(object sender, EventArgs e) {
            bd.Excluir(txtCodigo.Text);
            limparTela();
            preenche_lista();
        }

        private void button2_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtCodigo.Text) || txtCodigo.Text.Length > 3) {
                MessageBox.Show("Preencha todos os requisitos");
                return;
            }
            Classe cla = new(txtCodigo.Text, txtNome.Text);
            bd.Editar(cla);
            limparTela();
            preenche_lista();
        }

        private void button5_Click(object sender, EventArgs e) {
            List<string[]> r = bd.ConsultarByNome(txtNome.Text);
            listClasses.Items.Clear();
            r.ForEach(cria => listClasses.Items.Add(new ListViewItem(cria)));
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtCodigo.Text) || txtCodigo.Text.Length > 3) {
                MessageBox.Show("Preencha todos os requisitos");
                return;
            }
            Classe cla = new(txtCodigo.Text, txtNome.Text);
            bd.Incluir(cla);
            limparTela();
            preenche_lista();
        }

        private void limparTela() {
            txtCodigo.Text = "";
            txtNome.Text = "";

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        private void listClasse_SelectedIndexChanged(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection itens_selecionados = listClasses.SelectedItems;
            foreach (ListViewItem item in itens_selecionados) {
                txtCodigo.Text = item.SubItems[0].Text;
                txtNome.Text = item.SubItems[1].Text;
            }

            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }

    }
}