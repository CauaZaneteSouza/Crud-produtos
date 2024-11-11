namespace Crud_de_cadastro_do_produto
{
    partial class Produtos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.btn_cadastra = new System.Windows.Forms.Button();
            this.dtg_produtos = new System.Windows.Forms.DataGridView();
            this.btn_exclui = new System.Windows.Forms.Button();
            this.btn_altera = new System.Windows.Forms.Button();
            this.btn_pesquisa = new System.Windows.Forms.Button();
            this.btn_sai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_aplique = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(70, 55);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(137, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Informe o nome do produto:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(269, 55);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Informe o código de barras do produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Informe o preço do produto:";
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(269, 105);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(100, 20);
            this.txt_code.TabIndex = 6;
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(269, 148);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(100, 20);
            this.txt_preco.TabIndex = 7;
            // 
            // btn_cadastra
            // 
            this.btn_cadastra.Location = new System.Drawing.Point(450, 55);
            this.btn_cadastra.Name = "btn_cadastra";
            this.btn_cadastra.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastra.TabIndex = 8;
            this.btn_cadastra.Text = "Cadastra";
            this.btn_cadastra.UseVisualStyleBackColor = true;
            this.btn_cadastra.Click += new System.EventHandler(this.btn_mostra_Click);
            // 
            // dtg_produtos
            // 
            this.dtg_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_produtos.Location = new System.Drawing.Point(145, 213);
            this.dtg_produtos.Name = "dtg_produtos";
            this.dtg_produtos.Size = new System.Drawing.Size(515, 181);
            this.dtg_produtos.TabIndex = 9;
            this.dtg_produtos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_produtos_CellClick);
            this.dtg_produtos.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.dtg_produtos_CellToolTipTextNeeded);
            // 
            // btn_exclui
            // 
            this.btn_exclui.Location = new System.Drawing.Point(531, 95);
            this.btn_exclui.Name = "btn_exclui";
            this.btn_exclui.Size = new System.Drawing.Size(75, 23);
            this.btn_exclui.TabIndex = 10;
            this.btn_exclui.Text = "Excluir";
            this.btn_exclui.UseVisualStyleBackColor = true;
            this.btn_exclui.Click += new System.EventHandler(this.btn_exclui_Click);
            // 
            // btn_altera
            // 
            this.btn_altera.Location = new System.Drawing.Point(531, 55);
            this.btn_altera.Name = "btn_altera";
            this.btn_altera.Size = new System.Drawing.Size(75, 23);
            this.btn_altera.TabIndex = 12;
            this.btn_altera.Text = "Alterar";
            this.btn_altera.UseVisualStyleBackColor = true;
            this.btn_altera.Click += new System.EventHandler(this.btn_altera_Click);
            // 
            // btn_pesquisa
            // 
            this.btn_pesquisa.Location = new System.Drawing.Point(612, 55);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(75, 23);
            this.btn_pesquisa.TabIndex = 13;
            this.btn_pesquisa.Text = "Pesquisar";
            this.btn_pesquisa.UseVisualStyleBackColor = true;
            this.btn_pesquisa.Click += new System.EventHandler(this.btn_pesquisa_Click);
            // 
            // btn_sai
            // 
            this.btn_sai.Location = new System.Drawing.Point(612, 95);
            this.btn_sai.Name = "btn_sai";
            this.btn_sai.Size = new System.Drawing.Size(75, 23);
            this.btn_sai.TabIndex = 14;
            this.btn_sai.Text = "Sair";
            this.btn_sai.UseVisualStyleBackColor = true;
            this.btn_sai.Click += new System.EventHandler(this.btn_sai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Id do produto";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(157, 19);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 13);
            this.lbl_id.TabIndex = 16;
            // 
            // btn_aplique
            // 
            this.btn_aplique.Location = new System.Drawing.Point(450, 95);
            this.btn_aplique.Name = "btn_aplique";
            this.btn_aplique.Size = new System.Drawing.Size(75, 23);
            this.btn_aplique.TabIndex = 17;
            this.btn_aplique.Text = "Aplique";
            this.btn_aplique.UseVisualStyleBackColor = true;
            this.btn_aplique.Click += new System.EventHandler(this.btn_aplique_Click);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_aplique);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sai);
            this.Controls.Add(this.btn_pesquisa);
            this.Controls.Add(this.btn_altera);
            this.Controls.Add(this.btn_exclui);
            this.Controls.Add(this.dtg_produtos);
            this.Controls.Add(this.btn_cadastra);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Name = "Produtos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Button btn_cadastra;
        private System.Windows.Forms.DataGridView dtg_produtos;
        private System.Windows.Forms.Button btn_exclui;
        private System.Windows.Forms.Button btn_altera;
        private System.Windows.Forms.Button btn_pesquisa;
        private System.Windows.Forms.Button btn_sai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_aplique;
    }
}

