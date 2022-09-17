using GuildInterface.GuildeClasses;
using GuildInterface.Persistencia;

namespace GuildInterface {
    public partial class MissaoInterface : Form {
        private int? id_selecionado = null;
        private MissaoDAO bd = new();
        private List<string[]> grupos;
        private List<string[]> lugares;
        private List<string[]> contratantes;
        public MissaoInterface() {
            InitializeComponent();

            listMissoes.View = View.Details;
            listMissoes.LabelEdit = false;
            listMissoes.AllowColumnReorder = true;
            listMissoes.FullRowSelect = true;
            listMissoes.GridLines = true;
            listMissoes.MultiSelect = false;

            listMissoes.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listMissoes.Columns.Add("dtInicio", 100, HorizontalAlignment.Left);
            listMissoes.Columns.Add("dtTermino", 100, HorizontalAlignment.Left);
            listMissoes.Columns.Add("Concluida?", 50, HorizontalAlignment.Left);
            listMissoes.Columns.Add("Dificuldade", 50, HorizontalAlignment.Left);
            listMissoes.Columns.Add("ContratanteId", 100, HorizontalAlignment.Left);
            listMissoes.Columns.Add("Grupo", 75, HorizontalAlignment.Left);
            listMissoes.Columns.Add("Lugar", 100, HorizontalAlignment.Left);

            grupos = bd.getGrupos();
            cbBoxLugar.BeginUpdate();
            grupos.ForEach(gp => { cbBoxGrupo.Items.Add(gp[1]); });
            cbBoxLugar.EndUpdate();

            lugares = bd.getLugares();
            cbBoxLugar.BeginUpdate();
            lugares.ForEach(lug => { cbBoxLugar.Items.Add(lug[1]); });
            cbBoxLugar.EndUpdate();

            contratantes = bd.getContratantes();
            cbBoxLugar.BeginUpdate();
            contratantes.ForEach(cont => { cbBoxContratante.Items.Add(cont[1]); });
            cbBoxLugar.EndUpdate();

            preenche_lista();
        }

        private string getGrupoById(string id) {
            foreach (var gp in grupos) {
                if (gp[0] == id)
                    return gp[1];
            }
            return "";
        }

        private string getIdByGrupo(string nome) {
            foreach (var gp in grupos) {
                if (gp[1] == nome)
                    return gp[0];
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
        private string getContratanteById(string id) {
            foreach (var cont in contratantes) {
                if (cont[0] == id)
                    return cont[1];
            }
            return "";
        }

        private string getIdByContratante(string nome) {
            foreach (var cont in contratantes) {
                if (cont[1] == nome)
                    return cont[0];
            }
            return "";
        }
        private void preenche_lista() {
            List<string[]> r = bd.ConsultarByGrupoId();
            listMissoes.Items.Clear();

            r.ForEach(item => { item[7] = getLugarById(item[7]); });
            r.ForEach(item => { item[6] = getGrupoById(item[6]); });
            r.ForEach(item => { item[5] = getContratanteById(item[5]); });
            r.ForEach(item => listMissoes.Items.Add(new ListViewItem(item)));

            ListView.SelectedListViewItemCollection itens_selecionados = listMissoes.SelectedItems;
            foreach (ListViewItem item in itens_selecionados) {
                id_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                cbBoxGrupo.Text = item.SubItems[1].Text;
                cbBoxLugar.Text = item.SubItems[2].Text;
                cbBoxLugar.Text = item.SubItems[3].Text;
                cbBoxLugar.Text = item.SubItems[4].Text;
                cbBoxLugar.Text = item.SubItems[5].Text;
                cbBoxLugar.Text = item.SubItems[6].Text;
                cbBoxLugar.Text = item.SubItems[7].Text;
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
            if (id_selecionado == null || String.IsNullOrEmpty(cbBoxLugar.Text) || String.IsNullOrEmpty(cbBoxGrupo.Text) || String.IsNullOrEmpty(cbBoxContratante.Text) || String.IsNullOrEmpty(txtNivelDifi.Text) || String.IsNullOrEmpty(dtTimeInicio.Text)) {
                MessageBox.Show("Selecione todos os campos obrigadorios");
                return;
            }

            var lugar = Convert.ToInt32(getIdByLugar(cbBoxLugar.Text));
            var contratante = Convert.ToInt32(getIdByContratante(cbBoxContratante.Text));
            var grupo = Convert.ToInt32(getIdByGrupo(cbBoxGrupo.Text));

            Missao miss = new(id_selecionado, Convert.ToDateTime(dtTimeInicio.Text), Convert.ToDateTime(dtTimeTermino.Text), chBoxConcluida.Checked, Convert.ToInt32(txtNivelDifi.Text), contratante, grupo, lugar);
            bd.Editar(miss);
            limparTela();
            preenche_lista();
        }

        private void button5_Click(object sender, EventArgs e) {
            var r = new List<string[]>();
            if (String.IsNullOrEmpty(cbBoxGrupo.Text)) {
                r = bd.ConsultarByGrupoId();
            } else {
                r = bd.ConsultarByGrupoId(Convert.ToInt32(getIdByGrupo(cbBoxGrupo.Text)));
            }

            listMissoes.Items.Clear();

            r.ForEach(miss => { miss[7] = getLugarById(miss[7]); });
            r.ForEach(miss => { miss[6] = getGrupoById(miss[6]); });
            r.ForEach(miss => { miss[5] = getContratanteById(miss[5]); });
            r.ForEach(miss => listMissoes.Items.Add(new ListViewItem(miss)));
        }


        private void btnSalvar_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(cbBoxLugar.Text) || String.IsNullOrEmpty(cbBoxGrupo.Text) || String.IsNullOrEmpty(cbBoxContratante.Text) || String.IsNullOrEmpty(txtNivelDifi.Text) || String.IsNullOrEmpty(dtTimeInicio.Text)) {
                MessageBox.Show("Preencha todos os campos obrigadorios");
                return;
            }

            var lugar = Convert.ToInt32(getIdByLugar(cbBoxLugar.Text));
            var contratante = Convert.ToInt32(getIdByContratante(cbBoxContratante.Text));
            var grupo = Convert.ToInt32(getIdByGrupo(cbBoxGrupo.Text));


            Missao miss = new(Convert.ToDateTime(dtTimeInicio.Text), Convert.ToDateTime(dtTimeTermino.Text), chBoxConcluida.Checked, Convert.ToInt32(txtNivelDifi.Text), contratante, grupo, lugar);
            bd.Incluir(miss);
            limparTela();
            preenche_lista();
        }

        private void limparTela() {
            cbBoxLugar.Text = "";
            cbBoxGrupo.Text = "";
            dtTimeInicio.Text = "";
            dtTimeTermino.Text = "";
            txtNivelDifi.Text = "";
            cbBoxContratante.Text = "";
            chBoxConcluida.Checked = false;
            id_selecionado = null;

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        private void LugarInterface_Load(object sender, EventArgs e) {

        }

        private void listMissoes_SelectedIndexChanged(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection itens_selecionados = listMissoes.SelectedItems;
            foreach (ListViewItem item in itens_selecionados) {
                id_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                dtTimeInicio.Text = item.SubItems[1].Text;
                dtTimeTermino.Text = item.SubItems[2].Text;
                chBoxConcluida.Checked = item.SubItems[3].Text == "True";
                txtNivelDifi.Text = item.SubItems[4].Text;
                cbBoxContratante.Text = item.SubItems[5].Text;
                cbBoxGrupo.Text = item.SubItems[6].Text;
                cbBoxLugar.Text = item.SubItems[7].Text;
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

        private void label1_Click(object sender, EventArgs e) {

        }

        private void txtLugar_Click(object sender, EventArgs e) {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }
    }
}