namespace CadastroCliente
{
    partial class TelaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCliente));
            this.tituloPagina = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.Atualizar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tituloPagina
            // 
            this.tituloPagina.AutoSize = true;
            this.tituloPagina.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tituloPagina.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tituloPagina.Font = new System.Drawing.Font("MS PGothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloPagina.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tituloPagina.Location = new System.Drawing.Point(0, 9);
            this.tituloPagina.Name = "tituloPagina";
            this.tituloPagina.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.tituloPagina.Size = new System.Drawing.Size(534, 39);
            this.tituloPagina.TabIndex = 0;
            this.tituloPagina.Text = "Bem-Vindo Cliente";
            this.tituloPagina.Click += new System.EventHandler(this.tituloPagina_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha uma das opções abaixo:";
            // 
            // Cadastrar
            // 
            this.Cadastrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.Cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cadastrar.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Bold);
            this.Cadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cadastrar.Location = new System.Drawing.Point(77, 132);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(182, 54);
            this.Cadastrar.TabIndex = 2;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = false;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // Consultar
            // 
            this.Consultar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Consultar.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Bold);
            this.Consultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Consultar.Location = new System.Drawing.Point(278, 134);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(180, 51);
            this.Consultar.TabIndex = 3;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = false;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Atualizar
            // 
            this.Atualizar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Atualizar.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Bold);
            this.Atualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Atualizar.Location = new System.Drawing.Point(77, 201);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(182, 60);
            this.Atualizar.TabIndex = 4;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = false;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // Excluir
            // 
            this.Excluir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Excluir.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Bold);
            this.Excluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Excluir.Location = new System.Drawing.Point(278, 201);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(180, 58);
            this.Excluir.TabIndex = 5;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // TelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(533, 376);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tituloPagina);
            this.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(549, 415);
            this.MinimumSize = new System.Drawing.Size(549, 415);
            this.Name = "TelaCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.TelaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloPagina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Button Excluir;
    }
}

