using GuildInterface.GuildeClasses;
using GuildInterface.Persistencia;

namespace GuildInterface {
    public partial class RecompensaInterface : Form {
        private int? id_selecionado = null;
        private RecompensaDAO bd = new();
        private List<string[]> missoes;
        public RecompensaInterface() {
            InitializeComponent();

            listRecompensas.View = View.Details;
            listRecompensas.LabelEdit = false;
            listRecompensas.AllowColumnReorder = true;
            listRecompensas.FullRowSelect = true;
            listRecompensas.GridLines = true;
            listRecompensas.MultiSelect = false;

            listRecompensas.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listRecompensas.Columns.Add("Missao Id", 250, HorizontalAlignment.Left);
            listRecompensas.Columns.Add("Quantidade de inheiro", 250, HorizontalAlignment.Left);

            missoes = bd.getMissoes();
            cbBoxMissao.BeginUpdate();
            missoes.ForEach(miss => { cbBoxMissao.Items.Add(miss[0]); });
            cbBoxMissao.EndUpdate();



            preenche_lista();
        }

        private void preenche_lista() {
            List<string[]> r = bd.ConsultarByRecompensa();
            listRecompensas.Items.Clear();

            r.ForEach(item => listRecompensas.Items.Add(new ListViewItem(item)));

            ListView.SelectedListViewItemCollection itens_selecionados = listRecompensas.SelectedItems;
            foreach (ListViewItem item in itens_selecionados) {
                id_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                cbBoxMissao.Text = item.SubItems[1].Text;
            }
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
            if (id_selecionado == null || String.IsNullOrEmpty(txtDinheiro.Text) || String.IsNullOrEmpty(cbBoxMissao.Text)) {
                MessageBox.Show("Selecione todos os campos obrigadorios");
                return;
            }

            Recompensa rec = new(id_selecionado, Convert.ToInt32(cbBoxMissao.Text), Convert.ToInt32(txtDinheiro.Text));
            bd.Editar(rec);
            limparTela();
            preenche_lista();
        }

        private void button5_Click(object sender, EventArgs e) {
            var r = new List<string[]>();
            if (String.IsNullOrEmpty(cbBoxMissao.Text)) {
                r = bd.ConsultarByRecompensa();
            } else {
                r = bd.ConsultarByRecompensa(Convert.ToInt32(cbBoxMissao.Text));
            }

            listRecompensas.Items.Clear();
            r.ForEach(item => listRecompensas.Items.Add(new ListViewItem(item)));
        }


        private void btnSalvar_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(cbBoxMissao.Text) || String.IsNullOrEmpty(txtDinheiro.Text)) {
                MessageBox.Show("Preencha todos os campos obrigadorios");
                return;
            }
            Recompensa rec = new(Convert.ToInt32(cbBoxMissao.Text), Convert.ToInt32(txtDinheiro.Text));
            bd.Incluir(rec);
            limparTela();
            preenche_lista();
        }

        private void limparTela() {
            txtDinheiro.Text = "";
            cbBoxMissao.Text = "";
            id_selecionado = null;

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        private void LugarInterface_Load(object sender, EventArgs e) {

        }

        private void listRecompensas_SelectedIndexChanged(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection itens_selecionados = listRecompensas.SelectedItems;
            foreach (ListViewItem item in itens_selecionados) {
                id_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                cbBoxMissao.Text = item.SubItems[1].Text;
                txtDinheiro.Text = item.SubItems[2].Text;
            }

            if (id_selecionado != null) {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void txtLugar_Click(object sender, EventArgs e) {

        }
    }
}