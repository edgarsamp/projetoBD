using GuildInterface.GuildeClasses;
using GuildInterface.Persistencia;

namespace GuildInterface {
    public partial class HeroiGrupoInterface : Form {
        private int? id_selecionado = null;
        private HeroiGrupoDAO bd = new();
        private List<string[]> herois;
        private List<string[]> grupos;
        public HeroiGrupoInterface() {
            InitializeComponent();

            listHeroiGrupo.View = View.Details;
            listHeroiGrupo.LabelEdit = false;
            listHeroiGrupo.AllowColumnReorder = true;
            listHeroiGrupo.FullRowSelect = true;
            listHeroiGrupo.GridLines = true;
            listHeroiGrupo.MultiSelect = false;

            listHeroiGrupo.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listHeroiGrupo.Columns.Add("Heroi", 250, HorizontalAlignment.Left);
            listHeroiGrupo.Columns.Add("Grupo", 250, HorizontalAlignment.Left);

            herois = bd.getHerois();
            cbBoxGrupo.BeginUpdate();
            herois.ForEach(her => { cbBoxHeroi.Items.Add(her[1]); });
            cbBoxGrupo.EndUpdate();

            grupos = bd.getGrupos();
            cbBoxGrupo.BeginUpdate();
            grupos.ForEach(grp => { cbBoxGrupo.Items.Add(grp[1]); });
            cbBoxGrupo.EndUpdate();

            preenche_lista();
        }

        private string getHeroiById(string id) {
            foreach (var her in herois) {
                if (her[0] == id)
                    return her[1];
            }
            return "";
        }

        private string getIdByHeroi(string nome) {
            foreach (var her in herois) {
                if (her[1] == nome)
                    return her[0];
            }
            return "";
        }
        private string getGrupoById(string id) {
            foreach (var grp in grupos) {
                if (grp[0] == id)
                    return grp[1];
            }
            return "";
        }

        private string getIdByGrupo(string nome) {
            foreach (var grp in grupos) {
                if (grp[1] == nome)
                    return grp[0];
            }
            return "";
        }
        private void preenche_lista() {
            List<string[]> r = bd.ConsultarByName();
            listHeroiGrupo.Items.Clear();

            r.ForEach(item => { item[1] = getHeroiById(item[1]); });
            r.ForEach(item => { item[2] = getGrupoById(item[2]); });
            r.ForEach(item => listHeroiGrupo.Items.Add(new ListViewItem(item)));

            ListView.SelectedListViewItemCollection itens_selecionados = listHeroiGrupo.SelectedItems;
            foreach (ListViewItem item in itens_selecionados) {
                id_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                cbBoxHeroi.Text = item.SubItems[1].Text;
                cbBoxGrupo.Text = item.SubItems[2].Text;
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
            if (id_selecionado == null || String.IsNullOrEmpty(cbBoxGrupo.Text) || String.IsNullOrEmpty(cbBoxHeroi.Text)) {
                MessageBox.Show("Selecione todos os campos obrigadorios");
                return;
            }

            var heroi = Convert.ToInt32(getIdByHeroi(cbBoxHeroi.Text));
            var lugar = Convert.ToInt32(getIdByGrupo(cbBoxGrupo.Text));
            HeroiGrupo itm = new(id_selecionado, heroi, lugar);
            bd.Editar(itm);
            limparTela();
            preenche_lista();
        }

        private void button5_Click(object sender, EventArgs e) {
            var r = new List<string[]>();
            if (String.IsNullOrEmpty(cbBoxHeroi.Text)) {
                r = bd.ConsultarByName();
            } else {
                r = bd.ConsultarByName(Convert.ToInt32(getIdByHeroi(cbBoxHeroi.Text)));
            }

            listHeroiGrupo.Items.Clear();
            r.ForEach(item => { item[1] = getHeroiById(item[1]); });
            r.ForEach(item => { item[2] = getGrupoById(item[2]); });
            r.ForEach(item => listHeroiGrupo.Items.Add(new ListViewItem(item)));
        }


        private void btnSalvar_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(cbBoxGrupo.Text) || String.IsNullOrEmpty(cbBoxGrupo.Text)) {
                MessageBox.Show("Preencha todos os campos obrigadorios");
                return;
            }
            var heroi = Convert.ToInt32(getIdByHeroi(cbBoxHeroi.Text));
            var grupo = Convert.ToInt32(getIdByGrupo(cbBoxGrupo.Text));
            HeroiGrupo heroiGrupo = new(heroi, grupo);
            bd.Incluir(heroiGrupo);
            limparTela();
            preenche_lista();
        }

        private void limparTela() {
            cbBoxGrupo.Text = "";
            cbBoxHeroi.Text = "";
            id_selecionado = null;

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        private void LugarInterface_Load(object sender, EventArgs e) {

        }

        private void listHeroisGrupos_SelectedIndexChanged(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection itens_selecionados = listHeroiGrupo.SelectedItems;
            foreach (ListViewItem item in itens_selecionados) {
                id_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                cbBoxHeroi.Text = item.SubItems[1].Text;
                cbBoxGrupo.Text = item.SubItems[2].Text;
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