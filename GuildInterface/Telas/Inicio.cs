using GuildInterface.GuildeClasses;
using GuildInterface.Persistencia;

namespace GuildInterface {
    public partial class InicioInterface : Form {
        private int? id_selecionado = null;
        private RecompensaDAO bd = new();
        private List<string[]> missoes;
        public InicioInterface() {
            InitializeComponent();
        }

        private void LugarInterface_Load(object sender, EventArgs e) {

        }

        private void btnClasse_Click(object sender, EventArgs e) {
            var tela = new ClasseInterface();
            tela.Show();
        }

        private void btnHeroi_Click(object sender, EventArgs e) {
            var tela = new HeroiInterface();
            tela.Show();
        }

        private void btnGrupo_Click(object sender, EventArgs e) {
            var tela = new GrupoInterface();
            tela.Show();
        }

        private void btnMissao_Click(object sender, EventArgs e) {
            var tela = new MissaoInterface();
            tela.Show();
        }

        private void btnContratante_Click(object sender, EventArgs e) {
            var tela = new ContratanteInterface();
            tela.Show();
        }

        private void btnRecompensa_Click(object sender, EventArgs e) {
            var tela = new RecompensaInterface();
            tela.Show();
        }

        private void btnItem_Click(object sender, EventArgs e) {
            var tela = new ItemInterface();
            tela.Show();
        }

        private void btnCategoria_Click(object sender, EventArgs e) {
            var tela = new CategoriaInterface();
            tela.Show();
        }

        private void btnLugar_Click(object sender, EventArgs e) {
            var tela = new LugarInterface();
            tela.Show();
        }

        private void btnCriatura_Click(object sender, EventArgs e) {
            var tela = new CriaturaInterface();
            tela.Show();
        }

        private void button3_Click(object sender, EventArgs e) {
            var tela = new HeroiGrupoInterface();
            tela.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            var tela = new ItemRecompensaInterface();
            tela.Show();
        }

        private void btnCriaturaLugar_Click(object sender, EventArgs e) {
            var tela = new LugarCriaturaInterface();
            tela.Show();
        }
    }
}