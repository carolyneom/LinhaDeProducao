namespace LinhaDeProducao.view
{
    partial class PaginaLinhaDeProducao
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
            this.button1 = new System.Windows.Forms.Button();
            this.listViewLinhaDeProducao = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.button1.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cadastrar Nova Linha de Produção";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewLinhaDeProducao
            // 
            this.listViewLinhaDeProducao.HideSelection = false;
            this.listViewLinhaDeProducao.Location = new System.Drawing.Point(12, 80);
            this.listViewLinhaDeProducao.Name = "listViewLinhaDeProducao";
            this.listViewLinhaDeProducao.Size = new System.Drawing.Size(776, 358);
            this.listViewLinhaDeProducao.TabIndex = 1;
            this.listViewLinhaDeProducao.UseCompatibleStateImageBehavior = false;
            // 
            // PaginaLinhaDeProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewLinhaDeProducao);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaginaLinhaDeProducao";
            this.Text = "PaginaLinhaDeProducao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewLinhaDeProducao;
    }
}