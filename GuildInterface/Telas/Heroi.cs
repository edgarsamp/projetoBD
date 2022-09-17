using GuildInterface.GuildeClasses;
using GuildInterface.Persistencia;

namespace GuildInterface {
    public partial class HeroiInterface : Form {
        private int? id_selecionado = null;
        private HeroiDAO bd = new();
        private List<string[]> classes;
        public HeroiInterface() {
            InitializeComponent();

            listHerois.View = View.Details;
            listHerois.LabelEdit = false;
            listHerois.AllowColumnReorder = true;
            listHerois.FullRowSelect = true;
            listHerois.GridLines = true;
            listHerois.MultiSelect = false;

            listHerois.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listHerois.Columns.Add("Nome", 250, HorizontalAlignment.Left);
            listHerois.Columns.Add("Nivel", 100, HorizontalAlignment.Left);
            listHerois.Columns.Add("Idade", 100, HorizontalAlignment.Left);
            listHerois.Columns.Add("img", 0, HorizontalAlignment.Left);
            listHerois.Columns.Add("Classe", 150, HorizontalAlignment.Left);

            classes = bd.getClasses();
            cbBoxClasses.BeginUpdate();
            classes.ForEach(classe => { cbBoxClasses.Items.Add(classe[1]); });
            cbBoxClasses.EndUpdate();

            preenche_lista();
        }

        private string getClasseById(string id) {
            foreach (var classe in classes) {
                if (classe[0] == id)
                    return classe[1];
            }
            return "";
        }

        private string getIdByClasse(string nome) {
            foreach (var classe in classes) {
                if (classe[1] == nome)
                    return classe[0];
            }
            return "";
        }

        private void preenche_lista() {
            List<string[]> r = bd.ConsultarByNome();
            listHerois.Items.Clear();

            r.ForEach(r => r[5] = getClasseById(r[5]));
            r.ForEach(heroi => listHerois.Items.Add(new ListViewItem(heroi)));

            ListView.SelectedListViewItemCollection itens_selecionados = listHerois.SelectedItems;
            foreach (ListViewItem item in itens_selecionados) {
                id_selecionado = Convert.ToInt32(item.SubItems[0].Text);
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
            if (pctBoxHeroi.Image == null || id_selecionado == null || String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtNivel.Text) || String.IsNullOrEmpty(txtIdade.Text) || String.IsNullOrEmpty(cbBoxClasses.Text)) {
                MessageBox.Show("Selecione todos os campos obrigadorios");
                return;
            }

            Heroi hero = new(id_selecionado, txtNome.Text, Convert.ToInt32(txtNivel.Text), Convert.ToInt32(txtIdade.Text), pctBoxHeroi, getIdByClasse(cbBoxClasses.Text));
            bd.Editar(hero);
            limparTela();
            preenche_lista();
        }

        private void button5_Click(object sender, EventArgs e) {
            var r = new List<string[]>();
            if (String.IsNullOrEmpty(txtNome.Text)) {
                r = bd.ConsultarByNome();
            } else {
                r = bd.ConsultarByNome(txtNome.Text);
            }

            listHerois.Items.Clear();
            r.ForEach(item => listHerois.Items.Add(new ListViewItem(item)));
        }


        private void btnSalvar_Click(object sender, EventArgs e) {
            if (pctBoxHeroi.Image == null || String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtNivel.Text) || String.IsNullOrEmpty(txtIdade.Text) || String.IsNullOrEmpty(cbBoxClasses.Text)) {
                MessageBox.Show("Preencha todos os campos obrigadorios");
                return;
            }
            Heroi hero = new(txtNome.Text, Convert.ToInt32(txtNivel.Text), Convert.ToInt32(txtIdade.Text), pctBoxHeroi, getIdByClasse(cbBoxClasses.Text));
            bd.Incluir(hero);
            limparTela();
            preenche_lista();
        }

        private void limparTela() {
            txtNome.Text = "";
            txtNivel.Text = "";
            txtIdade.Text = "";
            cbBoxClasses.Text = "";
            id_selecionado = null;

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void LugarInterface_Load(object sender, EventArgs e) {

        }

        private void listHerois_SelectedIndexChanged(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection itens_selecionados = listHerois.SelectedItems;
            foreach (ListViewItem item in itens_selecionados) {
                id_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                txtNome.Text = item.SubItems[1].Text;
                txtNivel.Text = item.SubItems[2].Text;
                txtIdade.Text = item.SubItems[3].Text;
                cbBoxClasses.Text = item.SubItems[5].Text;
                var a = (Bitmap)((new ImageConverter()).ConvertFrom(bd.ConsultarImagem(item.SubItems[0].Text)));
                pctBoxHeroi.Image = a;
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

        private void label1_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Selecione uma foto do heroi";
            fd.Filter = "*.jpg|*.jpeg";

            if (fd.ShowDialog() == DialogResult.OK)
                pctBoxHeroi.ImageLocation = fd.FileName;

        }
    }
}