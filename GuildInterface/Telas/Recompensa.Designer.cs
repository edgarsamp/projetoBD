namespace GuildInterface {
    partial class RecompensaInterface {
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
            this.listRecompensas = new System.Windows.Forms.ListView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCriatura = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.Label();
            this.cbBoxMissao = new System.Windows.Forms.ComboBox();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listRecompensas
            // 
            this.listRecompensas.Location = new System.Drawing.Point(10, 85);
            this.listRecompensas.Name = "listRecompensas";
            this.listRecompensas.Size = new System.Drawing.Size(610, 333);
            this.listRecompensas.TabIndex = 4;
            this.listRecompensas.UseCompatibleStateImageBehavior = false;
            this.listRecompensas.SelectedIndexChanged += new System.EventHandler(this.listRecompensas_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(9, 56);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(117, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(132, 56);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(378, 56);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(117, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(255, 56);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(117, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(502, 56);
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
            this.txtCriatura.Location = new System.Drawing.Point(322, 9);
            this.txtCriatura.Name = "txtCriatura";
            this.txtCriatura.Size = new System.Drawing.Size(132, 15);
            this.txtCriatura.TabIndex = 15;
            this.txtCriatura.Text = "Quantidade de dinheiro";
            this.txtCriatura.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtLugar
            // 
            this.txtLugar.AutoSize = true;
            this.txtLugar.Location = new System.Drawing.Point(10, 9);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(78, 15);
            this.txtLugar.TabIndex = 17;
            this.txtLugar.Text = "Id da missão*";
            this.txtLugar.Click += new System.EventHandler(this.txtLugar_Click);
            // 
            // cbBoxMissao
            // 
            this.cbBoxMissao.FormattingEnabled = true;
            this.cbBoxMissao.Location = new System.Drawing.Point(11, 27);
            this.cbBoxMissao.Name = "cbBoxMissao";
            this.cbBoxMissao.Size = new System.Drawing.Size(299, 23);
            this.cbBoxMissao.TabIndex = 16;
            this.cbBoxMissao.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Location = new System.Drawing.Point(322, 27);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(297, 23);
            this.txtDinheiro.TabIndex = 18;
            // 
            // RecompensaInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 425);
            this.Controls.Add(this.txtDinheiro);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.cbBoxMissao);
            this.Controls.Add(this.txtCriatura);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.listRecompensas);
            this.Name = "RecompensaInterface";
            this.Text = "Adicionar uma recompensa em dinheiro a uma missão";
            this.Load += new System.EventHandler(this.LugarInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListView listRecompensas;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnBuscar;
        private Label txtCriatura;
        private Label txtLugar;
        private ComboBox cbBoxMissao;
        private TextBox txtDinheiro;
    }
}