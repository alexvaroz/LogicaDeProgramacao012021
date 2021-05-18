
namespace FormulariosFinal
{
    partial class frm_Principal
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
            this.ckb_SelecaoJogosDigitais = new System.Windows.Forms.CheckBox();
            this.ckb_EngSoftware = new System.Windows.Forms.CheckBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_JogosDigitais = new System.Windows.Forms.Label();
            this.lbl_EngenhariaSoftware = new System.Windows.Forms.Label();
            this.mns_Principal = new System.Windows.Forms.MenuStrip();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difculdadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.definirEstratégiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difícilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparSeleçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.mns_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // ckb_SelecaoJogosDigitais
            // 
            this.ckb_SelecaoJogosDigitais.AutoSize = true;
            this.ckb_SelecaoJogosDigitais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_SelecaoJogosDigitais.Location = new System.Drawing.Point(84, 154);
            this.ckb_SelecaoJogosDigitais.Name = "ckb_SelecaoJogosDigitais";
            this.ckb_SelecaoJogosDigitais.Size = new System.Drawing.Size(180, 29);
            this.ckb_SelecaoJogosDigitais.TabIndex = 0;
            this.ckb_SelecaoJogosDigitais.Text = "Jogos Digitais";
            this.ckb_SelecaoJogosDigitais.UseVisualStyleBackColor = true;
            this.ckb_SelecaoJogosDigitais.CheckedChanged += new System.EventHandler(this.ckb_SelecaoJogosDigitais_CheckedChanged);
            // 
            // ckb_EngSoftware
            // 
            this.ckb_EngSoftware.AutoSize = true;
            this.ckb_EngSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_EngSoftware.Location = new System.Drawing.Point(84, 211);
            this.ckb_EngSoftware.Name = "ckb_EngSoftware";
            this.ckb_EngSoftware.Size = new System.Drawing.Size(283, 29);
            this.ckb_EngSoftware.TabIndex = 1;
            this.ckb_EngSoftware.Text = "Engenharia de Software";
            this.ckb_EngSoftware.UseVisualStyleBackColor = true;
            this.ckb_EngSoftware.CheckedChanged += new System.EventHandler(this.ckb_EngSoftware_CheckedChanged);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(45, 104);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(556, 29);
            this.lbl_Titulo.TabIndex = 2;
            this.lbl_Titulo.Text = "Qual o curso que deseja receber notificações?";
            // 
            // lbl_JogosDigitais
            // 
            this.lbl_JogosDigitais.AutoSize = true;
            this.lbl_JogosDigitais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_JogosDigitais.Location = new System.Drawing.Point(12, 276);
            this.lbl_JogosDigitais.Name = "lbl_JogosDigitais";
            this.lbl_JogosDigitais.Size = new System.Drawing.Size(51, 20);
            this.lbl_JogosDigitais.TabIndex = 3;
            this.lbl_JogosDigitais.Text = "label1";
            // 
            // lbl_EngenhariaSoftware
            // 
            this.lbl_EngenhariaSoftware.AutoSize = true;
            this.lbl_EngenhariaSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EngenhariaSoftware.Location = new System.Drawing.Point(12, 311);
            this.lbl_EngenhariaSoftware.Name = "lbl_EngenhariaSoftware";
            this.lbl_EngenhariaSoftware.Size = new System.Drawing.Size(51, 20);
            this.lbl_EngenhariaSoftware.TabIndex = 4;
            this.lbl_EngenhariaSoftware.Text = "label1";
            // 
            // mns_Principal
            // 
            this.mns_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.difculdadeToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.mns_Principal.Location = new System.Drawing.Point(0, 0);
            this.mns_Principal.MdiWindowListItem = this.iniciarToolStripMenuItem;
            this.mns_Principal.Name = "mns_Principal";
            this.mns_Principal.Size = new System.Drawing.Size(888, 24);
            this.mns_Principal.TabIndex = 5;
            this.mns_Principal.Text = "menuStrip1";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogarToolStripMenuItem,
            this.definirEstratégiaToolStripMenuItem,
            this.limparSeleçãoToolStripMenuItem});
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            // 
            // difculdadeToolStripMenuItem
            // 
            this.difculdadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicianteToolStripMenuItem,
            this.médiaToolStripMenuItem,
            this.difícilToolStripMenuItem});
            this.difculdadeToolStripMenuItem.Name = "difculdadeToolStripMenuItem";
            this.difculdadeToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.difculdadeToolStripMenuItem.Text = "Difculdade";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // jogarToolStripMenuItem
            // 
            this.jogarToolStripMenuItem.Name = "jogarToolStripMenuItem";
            this.jogarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jogarToolStripMenuItem.Text = "Jogar";
            this.jogarToolStripMenuItem.Click += new System.EventHandler(this.jogarToolStripMenuItem_Click);
            // 
            // definirEstratégiaToolStripMenuItem
            // 
            this.definirEstratégiaToolStripMenuItem.Name = "definirEstratégiaToolStripMenuItem";
            this.definirEstratégiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.definirEstratégiaToolStripMenuItem.Text = "Definir estratégia";
            // 
            // inicianteToolStripMenuItem
            // 
            this.inicianteToolStripMenuItem.Name = "inicianteToolStripMenuItem";
            this.inicianteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inicianteToolStripMenuItem.Text = "Iniciante";
            // 
            // médiaToolStripMenuItem
            // 
            this.médiaToolStripMenuItem.Name = "médiaToolStripMenuItem";
            this.médiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.médiaToolStripMenuItem.Text = "Média";
            // 
            // difícilToolStripMenuItem
            // 
            this.difícilToolStripMenuItem.Name = "difícilToolStripMenuItem";
            this.difícilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.difícilToolStripMenuItem.Text = "Difícil";
            // 
            // limparSeleçãoToolStripMenuItem
            // 
            this.limparSeleçãoToolStripMenuItem.Name = "limparSeleçãoToolStripMenuItem";
            this.limparSeleçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.limparSeleçãoToolStripMenuItem.Text = "Limpar seleção";
            this.limparSeleçãoToolStripMenuItem.Click += new System.EventHandler(this.limparSeleçãoToolStripMenuItem_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(888, 395);
            this.Controls.Add(this.lbl_EngenhariaSoftware);
            this.Controls.Add(this.lbl_JogosDigitais);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.ckb_EngSoftware);
            this.Controls.Add(this.ckb_SelecaoJogosDigitais);
            this.Controls.Add(this.mns_Principal);
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mns_Principal;
            this.Name = "frm_Principal";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificações";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mns_Principal.ResumeLayout(false);
            this.mns_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckb_SelecaoJogosDigitais;
        private System.Windows.Forms.CheckBox ckb_EngSoftware;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_JogosDigitais;
        private System.Windows.Forms.Label lbl_EngenhariaSoftware;
        private System.Windows.Forms.MenuStrip mns_Principal;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difculdadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem definirEstratégiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difícilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparSeleçãoToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

