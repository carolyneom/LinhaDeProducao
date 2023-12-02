namespace LinhaDeProducao.view
{
    partial class PaginaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.painelCabecalho = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.barraLateral = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.botaoSetores = new System.Windows.Forms.Button();
            this.botaoOrdemDeProducao = new System.Windows.Forms.Button();
            this.botaoProdutos = new System.Windows.Forms.Button();
            this.botaoLinhaDeProducao = new System.Windows.Forms.Button();
            this.botaoCliente = new System.Windows.Forms.Button();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.painelCabecalho.SuspendLayout();
            this.barraLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelCabecalho
            // 
            this.painelCabecalho.BackColor = System.Drawing.Color.Goldenrod;
            this.painelCabecalho.Controls.Add(this.labelTitulo);
            this.painelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.painelCabecalho.Name = "painelCabecalho";
            this.painelCabecalho.Size = new System.Drawing.Size(800, 64);
            this.painelCabecalho.TabIndex = 0;
            this.painelCabecalho.Paint += new System.Windows.Forms.PaintEventHandler(this.painelCabecalho_Paint);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelTitulo.Location = new System.Drawing.Point(12, 11);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(348, 40);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Linha de Produção";
            // 
            // barraLateral
            // 
            this.barraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.barraLateral.Controls.Add(this.button6);
            this.barraLateral.Controls.Add(this.button5);
            this.barraLateral.Controls.Add(this.botaoSetores);
            this.barraLateral.Controls.Add(this.botaoOrdemDeProducao);
            this.barraLateral.Controls.Add(this.botaoProdutos);
            this.barraLateral.Controls.Add(this.botaoLinhaDeProducao);
            this.barraLateral.Controls.Add(this.botaoCliente);
            this.barraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.barraLateral.Location = new System.Drawing.Point(0, 64);
            this.barraLateral.Name = "barraLateral";
            this.barraLateral.Size = new System.Drawing.Size(200, 436);
            this.barraLateral.TabIndex = 1;
            this.barraLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.barraLateral_Paint);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(12, 360);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(175, 38);
            this.button6.TabIndex = 6;
            this.button6.Text = "Etapas";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(11, 306);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 38);
            this.button5.TabIndex = 5;
            this.button5.Text = "Processos";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // botaoSetores
            // 
            this.botaoSetores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.botaoSetores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoSetores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.botaoSetores.FlatAppearance.BorderSize = 0;
            this.botaoSetores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSetores.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSetores.Location = new System.Drawing.Point(12, 253);
            this.botaoSetores.Name = "botaoSetores";
            this.botaoSetores.Size = new System.Drawing.Size(175, 38);
            this.botaoSetores.TabIndex = 4;
            this.botaoSetores.Text = "Setores";
            this.botaoSetores.UseVisualStyleBackColor = false;
            this.botaoSetores.Click += new System.EventHandler(this.botaoSetores_Click);
            // 
            // botaoOrdemDeProducao
            // 
            this.botaoOrdemDeProducao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.botaoOrdemDeProducao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoOrdemDeProducao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.botaoOrdemDeProducao.FlatAppearance.BorderSize = 0;
            this.botaoOrdemDeProducao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoOrdemDeProducao.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoOrdemDeProducao.Location = new System.Drawing.Point(12, 199);
            this.botaoOrdemDeProducao.Name = "botaoOrdemDeProducao";
            this.botaoOrdemDeProducao.Size = new System.Drawing.Size(175, 38);
            this.botaoOrdemDeProducao.TabIndex = 3;
            this.botaoOrdemDeProducao.Text = "Ordem de Produção";
            this.botaoOrdemDeProducao.UseVisualStyleBackColor = false;
            this.botaoOrdemDeProducao.Click += new System.EventHandler(this.botaoOrdemDeProducao_Click);
            // 
            // botaoProdutos
            // 
            this.botaoProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.botaoProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoProdutos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.botaoProdutos.FlatAppearance.BorderSize = 0;
            this.botaoProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoProdutos.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoProdutos.Location = new System.Drawing.Point(12, 88);
            this.botaoProdutos.Name = "botaoProdutos";
            this.botaoProdutos.Size = new System.Drawing.Size(175, 38);
            this.botaoProdutos.TabIndex = 2;
            this.botaoProdutos.Text = "Produtos";
            this.botaoProdutos.UseVisualStyleBackColor = false;
            this.botaoProdutos.Click += new System.EventHandler(this.button2_Click);
            // 
            // botaoLinhaDeProducao
            // 
            this.botaoLinhaDeProducao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.botaoLinhaDeProducao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoLinhaDeProducao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.botaoLinhaDeProducao.FlatAppearance.BorderSize = 0;
            this.botaoLinhaDeProducao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoLinhaDeProducao.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoLinhaDeProducao.Location = new System.Drawing.Point(12, 143);
            this.botaoLinhaDeProducao.Name = "botaoLinhaDeProducao";
            this.botaoLinhaDeProducao.Size = new System.Drawing.Size(175, 38);
            this.botaoLinhaDeProducao.TabIndex = 1;
            this.botaoLinhaDeProducao.Text = "Linha de Produção";
            this.botaoLinhaDeProducao.UseVisualStyleBackColor = false;
            this.botaoLinhaDeProducao.Click += new System.EventHandler(this.botaoLinhaDeProducao_Click_1);
            // 
            // botaoCliente
            // 
            this.botaoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.botaoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.botaoCliente.FlatAppearance.BorderSize = 0;
            this.botaoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCliente.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCliente.Location = new System.Drawing.Point(11, 35);
            this.botaoCliente.Name = "botaoCliente";
            this.botaoCliente.Size = new System.Drawing.Size(175, 38);
            this.botaoCliente.TabIndex = 0;
            this.botaoCliente.Text = "Clientes";
            this.botaoCliente.UseVisualStyleBackColor = false;
            this.botaoCliente.Click += new System.EventHandler(this.botaoCliente_Click);
            // 
            // panelConteudo
            // 
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(200, 64);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(600, 436);
            this.panelConteudo.TabIndex = 2;
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.barraLateral);
            this.Controls.Add(this.painelCabecalho);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaginaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaginaPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PaginaPrincipal_Load);
            this.painelCabecalho.ResumeLayout(false);
            this.painelCabecalho.PerformLayout();
            this.barraLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelCabecalho;
        private System.Windows.Forms.Panel barraLateral;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button botaoCliente;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Button botaoSetores;
        private System.Windows.Forms.Button botaoOrdemDeProducao;
        private System.Windows.Forms.Button botaoProdutos;
        private System.Windows.Forms.Button botaoLinhaDeProducao;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}