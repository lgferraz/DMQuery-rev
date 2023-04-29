namespace DMQuery
{
    partial class Consulta
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtArquivoQuery = new System.Windows.Forms.TextBox();
            this.btnAbrirArquivo = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkSomenteParaMim = new System.Windows.Forms.CheckBox();
            this.btnPastaRequerente = new System.Windows.Forms.Button();
            this.txtArquivoRequerente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaRotinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbRotinas = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.bntEditar = new System.Windows.Forms.Button();
            this.lbDeveRodar = new System.Windows.Forms.Label();
            this.lbRodouHoje = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtArquivoQuery
            // 
            this.txtArquivoQuery.AllowDrop = true;
            this.txtArquivoQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtArquivoQuery.Location = new System.Drawing.Point(15, 50);
            this.txtArquivoQuery.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtArquivoQuery.Name = "txtArquivoQuery";
            this.txtArquivoQuery.Size = new System.Drawing.Size(562, 26);
            this.txtArquivoQuery.TabIndex = 0;
            this.txtArquivoQuery.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtArquivoQuery.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtCaminhoQuery_DragDrop);
            this.txtArquivoQuery.DragOver += new System.Windows.Forms.DragEventHandler(this.txtCaminhoQuery_DragOver);
            // 
            // btnAbrirArquivo
            // 
            this.btnAbrirArquivo.AllowDrop = true;
            this.btnAbrirArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirArquivo.Location = new System.Drawing.Point(581, 50);
            this.btnAbrirArquivo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAbrirArquivo.Name = "btnAbrirArquivo";
            this.btnAbrirArquivo.Size = new System.Drawing.Size(34, 27);
            this.btnAbrirArquivo.TabIndex = 1;
            this.btnAbrirArquivo.Text = "...";
            this.btnAbrirArquivo.UseVisualStyleBackColor = true;
            this.btnAbrirArquivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.AllowDrop = true;
            this.txtQuery.Font = new System.Drawing.Font("Cascadia Mono Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.Location = new System.Drawing.Point(14, 136);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtQuery.MaxLength = 0;
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuery.Size = new System.Drawing.Size(601, 362);
            this.txtQuery.TabIndex = 2;
            this.txtQuery.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtQuery.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtQuery_DragDrop);
            this.txtQuery.DragOver += new System.Windows.Forms.DragEventHandler(this.txtQuery_DragOver);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Location = new System.Drawing.Point(529, 521);
            this.btnExecutar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(87, 41);
            this.btnExecutar.TabIndex = 3;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkSomenteParaMim);
            this.panel1.Controls.Add(this.btnPastaRequerente);
            this.panel1.Controls.Add(this.txtArquivoRequerente);
            this.panel1.Location = new System.Drawing.Point(15, 521);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 79);
            this.panel1.TabIndex = 6;
            // 
            // chkSomenteParaMim
            // 
            this.chkSomenteParaMim.AutoSize = true;
            this.chkSomenteParaMim.Location = new System.Drawing.Point(7, 45);
            this.chkSomenteParaMim.Name = "chkSomenteParaMim";
            this.chkSomenteParaMim.Size = new System.Drawing.Size(180, 24);
            this.chkSomenteParaMim.TabIndex = 9;
            this.chkSomenteParaMim.Text = "Salvar somente para mim";
            this.chkSomenteParaMim.UseVisualStyleBackColor = true;
            // 
            // btnPastaRequerente
            // 
            this.btnPastaRequerente.AllowDrop = true;
            this.btnPastaRequerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPastaRequerente.Location = new System.Drawing.Point(461, 9);
            this.btnPastaRequerente.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPastaRequerente.Name = "btnPastaRequerente";
            this.btnPastaRequerente.Size = new System.Drawing.Size(37, 31);
            this.btnPastaRequerente.TabIndex = 8;
            this.btnPastaRequerente.Text = "...";
            this.btnPastaRequerente.UseVisualStyleBackColor = true;
            this.btnPastaRequerente.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtArquivoRequerente
            // 
            this.txtArquivoRequerente.AllowDrop = true;
            this.txtArquivoRequerente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtArquivoRequerente.Location = new System.Drawing.Point(6, 10);
            this.txtArquivoRequerente.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtArquivoRequerente.Name = "txtArquivoRequerente";
            this.txtArquivoRequerente.Size = new System.Drawing.Size(451, 26);
            this.txtArquivoRequerente.TabIndex = 7;
            this.txtArquivoRequerente.TextChanged += new System.EventHandler(this.txtRequerente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Requerente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Query";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // bntCancelar
            // 
            this.bntCancelar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCancelar.Location = new System.Drawing.Point(529, 568);
            this.bntCancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(87, 32);
            this.bntCancelar.TabIndex = 10;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotinasToolStripMenuItem,
            this.novaConsultaToolStripMenuItem,
            this.desconectarToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // rotinasToolStripMenuItem
            // 
            this.rotinasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaRotinaToolStripMenuItem,
            this.atualizarToolStripMenuItem});
            this.rotinasToolStripMenuItem.Name = "rotinasToolStripMenuItem";
            this.rotinasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rotinasToolStripMenuItem.Text = "Rotinas";
            // 
            // novaRotinaToolStripMenuItem
            // 
            this.novaRotinaToolStripMenuItem.Name = "novaRotinaToolStripMenuItem";
            this.novaRotinaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.novaRotinaToolStripMenuItem.Text = "Nova Rotina";
            this.novaRotinaToolStripMenuItem.Click += new System.EventHandler(this.novaRotinaToolStripMenuItem_Click);
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.atualizarToolStripMenuItem.Text = "Atualizar";
            this.atualizarToolStripMenuItem.Click += new System.EventHandler(this.atualizarToolStripMenuItem_Click);
            // 
            // novaConsultaToolStripMenuItem
            // 
            this.novaConsultaToolStripMenuItem.Name = "novaConsultaToolStripMenuItem";
            this.novaConsultaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.novaConsultaToolStripMenuItem.Text = "Nova Consulta";
            this.novaConsultaToolStripMenuItem.Click += new System.EventHandler(this.novaConsultaToolStripMenuItem_Click);
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            this.desconectarToolStripMenuItem.Click += new System.EventHandler(this.desconectarToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // cmbRotinas
            // 
            this.cmbRotinas.FormattingEnabled = true;
            this.cmbRotinas.Location = new System.Drawing.Point(15, 84);
            this.cmbRotinas.Name = "cmbRotinas";
            this.cmbRotinas.Size = new System.Drawing.Size(562, 28);
            this.cmbRotinas.TabIndex = 12;
            this.cmbRotinas.SelectedIndexChanged += new System.EventHandler(this.cmbRotinas_SelectedIndexChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AllowDrop = true;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(581, 84);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(34, 27);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "🧹";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // bntEditar
            // 
            this.bntEditar.AllowDrop = true;
            this.bntEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntEditar.Location = new System.Drawing.Point(337, 20);
            this.bntEditar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.Size = new System.Drawing.Size(34, 27);
            this.bntEditar.TabIndex = 14;
            this.bntEditar.Text = "🖊️";
            this.bntEditar.UseVisualStyleBackColor = true;
            this.bntEditar.Click += new System.EventHandler(this.bntEditar_Click);
            // 
            // lbDeveRodar
            // 
            this.lbDeveRodar.AutoSize = true;
            this.lbDeveRodar.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeveRodar.Location = new System.Drawing.Point(127, 115);
            this.lbDeveRodar.Name = "lbDeveRodar";
            this.lbDeveRodar.Size = new System.Drawing.Size(57, 16);
            this.lbDeveRodar.TabIndex = 15;
            this.lbDeveRodar.Text = "Deve rodar:";
            // 
            // lbRodouHoje
            // 
            this.lbRodouHoje.AutoSize = true;
            this.lbRodouHoje.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRodouHoje.Location = new System.Drawing.Point(36, 115);
            this.lbRodouHoje.Name = "lbRodouHoje";
            this.lbRodouHoje.Size = new System.Drawing.Size(57, 16);
            this.lbRodouHoje.TabIndex = 16;
            this.lbRodouHoje.Text = "Rodou hoje:";
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 637);
            this.Controls.Add(this.lbRodouHoje);
            this.Controls.Add(this.lbDeveRodar);
            this.Controls.Add(this.bntEditar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cmbRotinas);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.btnAbrirArquivo);
            this.Controls.Add(this.txtArquivoQuery);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Consulta";
            this.Text = "Consulta Basica";
            this.Load += new System.EventHandler(this.Consulta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtArquivoQuery;
        private System.Windows.Forms.Button btnAbrirArquivo;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPastaRequerente;
        private System.Windows.Forms.TextBox txtArquivoRequerente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkSomenteParaMim;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaRotinaToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbRotinas;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ToolStripMenuItem novaConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
        private System.Windows.Forms.Button bntEditar;
        private System.Windows.Forms.Label lbDeveRodar;
        private System.Windows.Forms.Label lbRodouHoje;
    }
}

