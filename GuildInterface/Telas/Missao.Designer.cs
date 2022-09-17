namespace GuildInterface {
    partial class MissaoInterface {
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
            this.listMissoes = new System.Windows.Forms.ListView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbBoxLugar = new System.Windows.Forms.ComboBox();
            this.txtCriatura = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.Label();
            this.cbBoxGrupo = new System.Windows.Forms.ComboBox();
            this.dtTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTimeTermino = new System.Windows.Forms.DateTimePicker();
            this.chBoxConcluida = new System.Windows.Forms.CheckBox();
            this.txtNivelDifi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBoxContratante = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listMissoes
            // 
            this.listMissoes.Location = new System.Drawing.Point(10, 216);
            this.listMissoes.Name = "listMissoes";
            this.listMissoes.Size = new System.Drawing.Size(610, 333);
            this.listMissoes.TabIndex = 4;
            this.listMissoes.UseCompatibleStateImageBehavior = false;
            this.listMissoes.SelectedIndexChanged += new System.EventHandler(this.listMissoes_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(9, 187);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(117, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(132, 187);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(378, 187);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(117, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(255, 187);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(117, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(502, 187);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button5_Click);
            // 
            // cbBoxLugar
            // 
            this.cbBoxLugar.FormattingEnabled = true;
            this.cbBoxLugar.Location = new System.Drawing.Point(324, 27);
            this.cbBoxLugar.Name = "cbBoxLugar";
            this.cbBoxLugar.Size = new System.Drawing.Size(295, 23);
            this.cbBoxLugar.TabIndex = 14;
            this.cbBoxLugar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtCriatura
            // 
            this.txtCriatura.AutoSize = true;
            this.txtCriatura.Location = new System.Drawing.Point(322, 9);
            this.txtCriatura.Name = "txtCriatura";
            this.txtCriatura.Size = new System.Drawing.Size(37, 15);
            this.txtCriatura.TabIndex = 15;
            this.txtCriatura.Text = "Lugar";
            this.txtCriatura.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtLugar
            // 
            this.txtLugar.AutoSize = true;
            this.txtLugar.Location = new System.Drawing.Point(10, 9);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(45, 15);
            this.txtLugar.TabIndex = 17;
            this.txtLugar.Text = "Grupo*";
            this.txtLugar.Click += new System.EventHandler(this.txtLugar_Click);
            // 
            // cbBoxGrupo
            // 
            this.cbBoxGrupo.FormattingEnabled = true;
            this.cbBoxGrupo.Location = new System.Drawing.Point(11, 27);
            this.cbBoxGrupo.Name = "cbBoxGrupo";
            this.cbBoxGrupo.Size = new System.Drawing.Size(299, 23);
            this.cbBoxGrupo.TabIndex = 16;
            this.cbBoxGrupo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // dtTimeInicio
            // 
            this.dtTimeInicio.Location = new System.Drawing.Point(12, 76);
            this.dtTimeInicio.Name = "dtTimeInicio";
            this.dtTimeInicio.Size = new System.Drawing.Size(298, 23);
            this.dtTimeInicio.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Data de Inicio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Data de termino";
            // 
            // dtTimeTermino
            // 
            this.dtTimeTermino.Location = new System.Drawing.Point(324, 76);
            this.dtTimeTermino.Name = "dtTimeTermino";
            this.dtTimeTermino.Size = new System.Drawing.Size(295, 23);
            this.dtTimeTermino.TabIndex = 20;
            // 
            // chBoxConcluida
            // 
            this.chBoxConcluida.AutoSize = true;
            this.chBoxConcluida.Location = new System.Drawing.Point(534, 162);
            this.chBoxConcluida.Name = "chBoxConcluida";
            this.chBoxConcluida.Size = new System.Drawing.Size(85, 19);
            this.chBoxConcluida.TabIndex = 22;
            this.chBoxConcluida.Text = "Concluida?";
            this.chBoxConcluida.UseVisualStyleBackColor = true;
            this.chBoxConcluida.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtNivelDifi
            // 
            this.txtNivelDifi.Location = new System.Drawing.Point(12, 130);
            this.txtNivelDifi.Name = "txtNivelDifi";
            this.txtNivelDifi.Size = new System.Drawing.Size(298, 23);
            this.txtNivelDifi.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nivel de dificuldade";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Contratante";
            // 
            // cbBoxContratante
            // 
            this.cbBoxContratante.FormattingEnabled = true;
            this.cbBoxContratante.Location = new System.Drawing.Point(324, 130);
            this.cbBoxContratante.Name = "cbBoxContratante";
            this.cbBoxContratante.Size = new System.Drawing.Size(297, 23);
            this.cbBoxContratante.TabIndex = 25;
            // 
            // MissaoInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbBoxContratante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNivelDifi);
            this.Controls.Add(this.chBoxConcluida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTimeTermino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtTimeInicio);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.cbBoxGrupo);
            this.Controls.Add(this.txtCriatura);
            this.Controls.Add(this.cbBoxLugar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.listMissoes);
            this.Name = "MissaoInterface";
            this.Text = "Missão";
            this.Load += new System.EventHandler(this.LugarInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListView listMissoes;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnBuscar;
        private ComboBox cbBoxLugar;
        private Label txtCriatura;
        private Label txtLugar;
        private ComboBox cbBoxGrupo;
        private DateTimePicker dtTimeInicio;
        private Label label1;
        private Label label2;
        private DateTimePicker dtTimeTermino;
        private CheckBox chBoxConcluida;
        private TextBox txtNivelDifi;
        private Label label3;
        private Label label4;
        private ComboBox cbBoxContratante;
    }
}