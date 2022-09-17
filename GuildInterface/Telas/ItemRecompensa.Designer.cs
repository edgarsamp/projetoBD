namespace GuildInterface {
    partial class ItemRecompensaInterface {
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
            this.listItemRecompensa = new System.Windows.Forms.ListView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbBoxRecompensa = new System.Windows.Forms.ComboBox();
            this.txtRecompensa = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.Label();
            this.cbBoxItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listItemRecompensa
            // 
            this.listItemRecompensa.Location = new System.Drawing.Point(10, 85);
            this.listItemRecompensa.Name = "listItemRecompensa";
            this.listItemRecompensa.Size = new System.Drawing.Size(610, 333);
            this.listItemRecompensa.TabIndex = 4;
            this.listItemRecompensa.UseCompatibleStateImageBehavior = false;
            this.listItemRecompensa.SelectedIndexChanged += new System.EventHandler(this.listItensRecompensas_SelectedIndexChanged);
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
            // cbBoxRecompensa
            // 
            this.cbBoxRecompensa.FormattingEnabled = true;
            this.cbBoxRecompensa.Location = new System.Drawing.Point(229, 27);
            this.cbBoxRecompensa.Name = "cbBoxRecompensa";
            this.cbBoxRecompensa.Size = new System.Drawing.Size(212, 23);
            this.cbBoxRecompensa.TabIndex = 14;
            this.cbBoxRecompensa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtRecompensa
            // 
            this.txtRecompensa.AutoSize = true;
            this.txtRecompensa.Location = new System.Drawing.Point(228, 9);
            this.txtRecompensa.Name = "txtRecompensa";
            this.txtRecompensa.Size = new System.Drawing.Size(75, 15);
            this.txtRecompensa.TabIndex = 15;
            this.txtRecompensa.Text = "Recompensa";
            this.txtRecompensa.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtLugar
            // 
            this.txtLugar.AutoSize = true;
            this.txtLugar.Location = new System.Drawing.Point(10, 9);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(36, 15);
            this.txtLugar.TabIndex = 17;
            this.txtLugar.Text = "Item*";
            this.txtLugar.Click += new System.EventHandler(this.txtLugar_Click);
            // 
            // cbBoxItem
            // 
            this.cbBoxItem.FormattingEnabled = true;
            this.cbBoxItem.Location = new System.Drawing.Point(11, 27);
            this.cbBoxItem.Name = "cbBoxItem";
            this.cbBoxItem.Size = new System.Drawing.Size(212, 23);
            this.cbBoxItem.TabIndex = 16;
            this.cbBoxItem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(447, 27);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(172, 23);
            this.txtQuantidade.TabIndex = 20;
            // 
            // ItemRecompensaInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 425);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.cbBoxItem);
            this.Controls.Add(this.txtRecompensa);
            this.Controls.Add(this.cbBoxRecompensa);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.listItemRecompensa);
            this.Name = "ItemRecompensaInterface";
            this.Text = "Vincular um item a uma recompensa";
            this.Load += new System.EventHandler(this.LugarInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListView listItemRecompensa;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnBuscar;
        private ComboBox cbBoxRecompensa;
        private Label txtRecompensa;
        private Label txtLugar;
        private ComboBox cbBoxItem;
        private Label label1;
        private TextBox txtQuantidade;
    }
}