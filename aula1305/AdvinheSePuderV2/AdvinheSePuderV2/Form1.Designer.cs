
namespace AdvinheSePuderV2
{
    partial class Form1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInstrucao = new System.Windows.Forms.Label();
            this.btnSortear = new System.Windows.Forms.Button();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.btnTentar = new System.Windows.Forms.Button();
            this.lsbTentativas = new System.Windows.Forms.ListBox();
            this.lblDescrTentativas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Minnie", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.LightGreen;
            this.lblTitulo.Location = new System.Drawing.Point(22, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(406, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Advinhe se puder!!!";
            // 
            // lblInstrucao
            // 
            this.lblInstrucao.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucao.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblInstrucao.Location = new System.Drawing.Point(12, 101);
            this.lblInstrucao.Name = "lblInstrucao";
            this.lblInstrucao.Size = new System.Drawing.Size(433, 128);
            this.lblInstrucao.TabIndex = 1;
            this.lblInstrucao.Text = "Você deve tentar descobrir qual número estou pensando...";
            this.lblInstrucao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSortear
            // 
            this.btnSortear.BackColor = System.Drawing.Color.LightGreen;
            this.btnSortear.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortear.Location = new System.Drawing.Point(87, 297);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(119, 60);
            this.btnSortear.TabIndex = 3;
            this.btnSortear.Text = "Definir número";
            this.btnSortear.UseVisualStyleBackColor = false;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // txtEntrada
            // 
            this.txtEntrada.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEntrada.Enabled = false;
            this.txtEntrada.Font = new System.Drawing.Font("Minnie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEntrada.Location = new System.Drawing.Point(156, 232);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEntrada.Size = new System.Drawing.Size(119, 40);
            this.txtEntrada.TabIndex = 4;
            this.txtEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTentar
            // 
            this.btnTentar.BackColor = System.Drawing.Color.Salmon;
            this.btnTentar.Enabled = false;
            this.btnTentar.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTentar.Location = new System.Drawing.Point(212, 297);
            this.btnTentar.Name = "btnTentar";
            this.btnTentar.Size = new System.Drawing.Size(107, 60);
            this.btnTentar.TabIndex = 5;
            this.btnTentar.Text = "Chute";
            this.btnTentar.UseVisualStyleBackColor = false;
            this.btnTentar.Click += new System.EventHandler(this.btnTentar_Click);
            // 
            // lsbTentativas
            // 
            this.lsbTentativas.BackColor = System.Drawing.Color.MistyRose;
            this.lsbTentativas.Font = new System.Drawing.Font("Minnie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbTentativas.FormattingEnabled = true;
            this.lsbTentativas.ItemHeight = 21;
            this.lsbTentativas.Location = new System.Drawing.Point(144, 409);
            this.lsbTentativas.Name = "lsbTentativas";
            this.lsbTentativas.Size = new System.Drawing.Size(131, 88);
            this.lsbTentativas.TabIndex = 6;
            // 
            // lblDescrTentativas
            // 
            this.lblDescrTentativas.AutoSize = true;
            this.lblDescrTentativas.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrTentativas.Location = new System.Drawing.Point(119, 384);
            this.lblDescrTentativas.Name = "lblDescrTentativas";
            this.lblDescrTentativas.Size = new System.Drawing.Size(179, 22);
            this.lblDescrTentativas.TabIndex = 7;
            this.lblDescrTentativas.Text = "Suas tentativas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(468, 530);
            this.Controls.Add(this.lblDescrTentativas);
            this.Controls.Add(this.lsbTentativas);
            this.Controls.Add(this.btnTentar);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.btnSortear);
            this.Controls.Add(this.lblInstrucao);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInstrucao;
        private System.Windows.Forms.Button btnSortear;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Button btnTentar;
        private System.Windows.Forms.ListBox lsbTentativas;
        private System.Windows.Forms.Label lblDescrTentativas;
    }
}

