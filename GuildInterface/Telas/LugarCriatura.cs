using GuildInterface.GuildeClasses;
using GuildInterface.Persistencia;

namespace GuildInterface {
    public partial class LugarCriaturaInterface : Form {
        private int? id_selecionado = null;
        private LugarCriaturaDAO bd = new();
        private List<string[]> lugares;
        private List<string[]> criaturas;
        public LugarCriaturaInterface() {
            InitializeComponent();

            listLugares.View = View.Details;
            listLugares.LabelEdit = false;
            listLugares.AllowColumnReorder = true;
            listLugares.FullRowSelect = true;
            listLugares.GridLines = true;
            listLugares.MultiSelect = false;

            listLugares.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listLugares.Columns.Add("Lugar", 250, HorizontalAlignment.Left);
            listLugares.Columns.Add("Criatura", 250, HorizontalAlignment.Left);

            lugares = bd.getLugares();
            cbBoxCriatura.BeginUpdate();
            lugares.ForEach(lug => { cbBoxLugar.Items.Add(lug[1]); });
            cbBoxCriatura.EndUpdate();

            criaturas = bd.getCriaturas();
            cbBoxCriatura.BeginUpdate();
            criaturas.ForEach(cria => { cbBoxCriatura.Items.Add(cria[1]); });
            cbBoxCriatura.EndUpdate();

            preenche_lista();
        }

        private string getCriaturaById(string id) {
            foreach (var cria in criaturas) {
                if (cria[0] == id)
                    return cria[1];
            }
            return "";
        }

        private string getIdByCriatura(string nome) {
            foreach (var cria in criaturas) {
                if (cria[1] == nome)
                    return cria[0];
            }
            return "";
        }
        private string getLugarById(string id) {
            foreach (var lud in lugares) {
                if (lud[0] == id)
                    return lud[1];
            }
            return "";
        }

        private string getIdByLugar(string nome) {
            foreach (var lud in lugares) {
                if (lud[1] == nome)
                    return lud[0];
            }
            return "";
        }
        private void preenche_lista() {
            List<string[]> r = bd.ConsultarByNome();
            listLugares.Items.Clear();

            r.ForEach(item => { item[1] = getLugarById(item[1]); });
            r.ForEach(item => { item[2] = getCriaturaById(item[2]); });
            r.ForEach(item => listLugares.Items.Add(new ListViewItem(item)));

            ListView.SelectedListViewItemCollection itens_selecionados = listLugares.SelectedItems;
            foreach (ListViewItem item in itens_selecionados) {
                id_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                cbBoxLugar.Text = item.SubItems[1].Text;
                cbBoxCriatura.Text = item.SubItems[2].Text;
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
            if (id_selecionado == null || String.IsNullOrEmpty(cbBoxCriatura.Text) || String.IsNullOrEmpty(cbBoxLugar.Text)) {
                MessageBox.Show("Selecione todos os campos obrigadorios");
                return;
            }

            var lugar = Convert.ToInt32(getIdByLugar(cbBoxLugar.Text));
            var monstro = Convert.ToInt32(getIdByCriatura(cbBoxCriatura.Text));
            LugarCriatura itm = new(id_selecionado, lugar, monstro);
            bd.Editar(itm);
            limparTela();
            preenche_lista();
        }

        private void button5_Click(object sender, EventArgs e) {
            var r = new List<string[]>();
            if (String.IsNullOrEmpty(cbBoxLugar.Text)) {
                r = bd.ConsultarByNome();
            } else {
                r = bd.ConsultarByNome(Convert.ToInt32(getIdByLugar(cbBoxLugar.Text)));
            }

            listLugares.Items.Clear();
            r.ForEach(item => { item[1] = getLugarById(item[1]); });
            r.ForEach(item => { item[2] = getCriaturaById(item[2]); });
            r.ForEach(item => listLugares.Items.Add(new ListViewItem(item)));
        }


        private void btnSalvar_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(cbBoxCriatura.Text) || String.IsNullOrEmpty(cbBoxCriatura.Text)) {
                MessageBox.Show("Preencha todos os campos obrigadorios");
                return;
            }
            var lugarId = Convert.ToInt32(getIdByLugar(cbBoxLugar.Text));
            var criaturaId = Convert.ToInt32(getIdByCriatura(cbBoxCriatura.Text));
            LugarCriatura itm = new(lugarId, criaturaId);
            bd.Incluir(itm);
            limparTela();
            preenche_lista();
        }

        private void limparTela() {
            cbBoxCriatura.Text = "";
            cbBoxLugar.Text = "";
            id_selecionado = null;

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        private void LugarInterface_Load(object sender, EventArgs e) {

        }

        private void listLugaresCriaturas_SelectedIndexChanged(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection itens_selecionados = listLugares.SelectedItems;
            foreach (ListViewItem item in itens_selecionados) {
                id_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                cbBoxLugar.Text = item.SubItems[1].Text;
                cbBoxCriatura.Text = item.SubItems[2].Text;
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
    }
}