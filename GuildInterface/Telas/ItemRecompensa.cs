using GuildInterface.GuildeClasses;
using GuildInterface.Persistencia;

namespace GuildInterface {
    public partial class ItemRecompensaInterface : Form {
        private int? id_selecionado = null;
        private ItemRecompensaDAO bd = new();
        private List<string[]> recompensas;
        private List<string[]> itens;
        public ItemRecompensaInterface() {
            InitializeComponent();

            listItemRecompensa.View = View.Details;
            listItemRecompensa.LabelEdit = false;
            listItemRecompensa.AllowColumnReorder = true;
            listItemRecompensa.FullRowSelect = true;
            listItemRecompensa.GridLines = true;
            listItemRecompensa.MultiSelect = false;

            listItemRecompensa.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listItemRecompensa.Columns.Add("Item", 150, HorizontalAlignment.Left);
            listItemRecompensa.Columns.Add("RecompensaId", 150, HorizontalAlignment.Left);
            listItemRecompensa.Columns.Add("Quantidade", 150, HorizontalAlignment.Left);

            recompensas = bd.getRecompensas();
            cbBoxRecompensa.BeginUpdate();
            recompensas.ForEach(rec => { cbBoxRecompensa.Items.Add(rec[1]); });
            cbBoxRecompensa.EndUpdate();

            itens = bd.getItens();
            cbBoxRecompensa.BeginUpdate();
            itens.ForEach(itm => { cbBoxItem.Items.Add(itm[1]); });
            cbBoxRecompensa.EndUpdate();

            preenche_lista();
        }

        private string getRecompensaById(string id) {
            foreach (var rec in recompensas) {
                if (rec[0] == id)
                    return rec[1];
            }
            return "";
        }

        private string getIdByRecompensa(string nome) {
            foreach (var rec in recompensas) {
                if (rec[1] == nome)
                    return rec[0];
            }
            return "";
        }
        private string getItemById(string id) {
            foreach (var itm in itens) {
                if (itm[0] == id)
                    return itm[1];
            }
            return "";
        }

        private string getIdByItem(string nome) {
            foreach (var itm in itens) {
                if (itm[1] == nome)
                    return itm[0];
            }
            return "";
        }
        private void preenche_lista() {
            List<string[]> r = bd.ConsultarByName();
            listItemRecompensa.Items.Clear();

            r.ForEach(item => { item[1] = getItemById(item[1]); });
            r.ForEach(item => { item[2] = getRecompensaById(item[2]); });
            r.ForEach(item => listItemRecompensa.Items.Add(new ListViewItem(item)));

            ListView.SelectedListViewItemCollection itens_selecionados = listItemRecompensa.SelectedItems;
            foreach (ListViewItem item in itens_selecionados) {
                id_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                cbBoxItem.Text = item.SubItems[1].Text;
                cbBoxRecompensa.Text = item.SubItems[2].Text;
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
            if (id_selecionado == null || String.IsNullOrEmpty(cbBoxRecompensa.Text) || String.IsNullOrEmpty(cbBoxItem.Text)) {
                MessageBox.Show("Selecione todos os campos obrigadorios");
                return;
            }

            var item = Convert.ToInt32(getIdByItem(cbBoxItem.Text));
            var recompensa = Convert.ToInt32(getIdByRecompensa(cbBoxRecompensa.Text));
            ItemRecompensa itmRec = new(id_selecionado, item, recompensa, Convert.ToInt32(txtQuantidade.Text));
            bd.Editar(itmRec);
            limparTela();
            preenche_lista();
        }

        private void button5_Click(object sender, EventArgs e) {
            var r = new List<string[]>();
            if (String.IsNullOrEmpty(cbBoxItem.Text)) {
                r = bd.ConsultarByName();
            } else {
                r = bd.ConsultarById(Convert.ToInt32(getIdByItem(cbBoxItem.Text)));
            }

            listItemRecompensa.Items.Clear();
            r.ForEach(item => { item[1] = getItemById(item[1]); });
            r.ForEach(item => { item[2] = getRecompensaById(item[2]); });
            r.ForEach(item => listItemRecompensa.Items.Add(new ListViewItem(item)));
        }


        private void btnSalvar_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(cbBoxRecompensa.Text) || String.IsNullOrEmpty(cbBoxRecompensa.Text)) {
                MessageBox.Show("Preencha todos os campos obrigadorios");
                return;
            }
            var item = Convert.ToInt32(getIdByItem(cbBoxItem.Text));
            var recompensa = Convert.ToInt32(getIdByRecompensa(cbBoxRecompensa.Text));
            ItemRecompensa itmRec = new(id_selecionado, item, recompensa, Convert.ToInt32(txtQuantidade.Text));
            bd.Incluir(itmRec);
            limparTela();
            preenche_lista();
        }

        private void limparTela() {
            cbBoxRecompensa.Text = "";
            cbBoxItem.Text = "";
            txtQuantidade.Text = "";
            id_selecionado = null;

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        private void LugarInterface_Load(object sender, EventArgs e) {

        }

        private void listItensRecompensas_SelectedIndexChanged(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection itens_selecionados = listItemRecompensa.SelectedItems;
            foreach (ListViewItem item in itens_selecionados) {
                id_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                cbBoxItem.Text = item.SubItems[1].Text;
                cbBoxRecompensa.Text = item.SubItems[2].Text;
                txtQuantidade.Text = item.SubItems[3].Text;
            }

            if (id_selecionado != null) {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void txtLugar_Click(object sender, EventArgs e) {

        }
    }
}