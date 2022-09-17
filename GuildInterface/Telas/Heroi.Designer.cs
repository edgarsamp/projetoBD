namespace GuildInterface {
    partial class HeroiInterface {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeroiInterface));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCriatura = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.cbBoxClasses = new System.Windows.Forms.ComboBox();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.pctBoxHeroi = new System.Windows.Forms.PictureBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listHerois = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxHeroi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(9, 224);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(117, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(132, 224);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(378, 224);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(117, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(255, 224);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(117, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(502, 224);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtCriatura
            // 
            this.txtCriatura.AutoSize = true;
            this.txtCriatura.Location = new System.Drawing.Point(220, 56);
            this.txtCriatura.Name = "txtCriatura";
            this.txtCriatura.Size = new System.Drawing.Size(34, 15);
            this.txtCriatura.TabIndex = 15;
            this.txtCriatura.Text = "Nivel";
            this.txtCriatura.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(219, 150);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(40, 15);
            this.lblClasse.TabIndex = 17;
            this.lblClasse.Text = "Classe";
            this.lblClasse.Click += new System.EventHandler(this.txtLugar_Click);
            // 
            // cbBoxClasses
            // 
            this.cbBoxClasses.FormattingEnabled = true;
            this.cbBoxClasses.Location = new System.Drawing.Point(218, 168);
            this.cbBoxClasses.Name = "cbBoxClasses";
            this.cbBoxClasses.Size = new System.Drawing.Size(398, 23);
            this.cbBoxClasses.TabIndex = 16;
            this.cbBoxClasses.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(220, 74);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(396, 23);
            this.txtNivel.TabIndex = 18;
            // 
            // pctBoxHeroi
            // 
            this.pctBoxHeroi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pctBoxHeroi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctBoxHeroi.InitialImage = ((System.Drawing.Image)(resources.GetObject("pctBoxHeroi.InitialImage")));
            this.pctBoxHeroi.Location = new System.Drawing.Point(12, 12);
            this.pctBoxHeroi.Name = "pctBoxHeroi";
            this.pctBoxHeroi.Size = new System.Drawing.Size(200, 200);
            this.pctBoxHeroi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxHeroi.TabIndex = 19;
            this.pctBoxHeroi.TabStop = false;
            this.pctBoxHeroi.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(220, 121);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(396, 23);
            this.txtIdade.TabIndex = 21;
            this.txtIdade.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Idade";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(220, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(396, 23);
            this.txtNome.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nome*";
            // 
            // listHerois
            // 
            this.listHerois.Location = new System.Drawing.Point(12, 253);
            this.listHerois.Name = "listHerois";
            this.listHerois.Size = new System.Drawing.Size(607, 331);
            this.listHerois.TabIndex = 24;
            this.listHerois.UseCompatibleStateImageBehavior = false;
            this.listHerois.SelectedIndexChanged += new System.EventHandler(this.listHerois_SelectedIndexChanged);
            // 
            // HeroiInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 596);
            this.Controls.Add(this.listHerois);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctBoxHeroi);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.cbBoxClasses);
            this.Controls.Add(this.txtCriatura);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "HeroiInterface";
            this.Text = "Heroi";
            this.Load += new System.EventHandler(this.LugarInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxHeroi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnBuscar;
        private Label txtCriatura;
        private Label lblClasse;
        private ComboBox cbBoxClasses;
        private TextBox txtNivel;
        private PictureBox pctBoxHeroi;
        private TextBox txtIdade;
        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private ListView listHerois;
    }
}