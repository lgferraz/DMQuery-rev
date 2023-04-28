namespace DMQuery
{
    partial class NovaRotina
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
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtArquivoQueryBase = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAbrirPasta = new System.Windows.Forms.Button();
            this.txtPastaRequerente = new System.Windows.Forms.TextBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeRequerente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChamadoBase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeRotina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbQuandoRodar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Query base:";
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(214, 435);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 27);
            this.button1.TabIndex = 28;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtArquivoQueryBase
            // 
            this.txtArquivoQueryBase.AllowDrop = true;
            this.txtArquivoQueryBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtArquivoQueryBase.Location = new System.Drawing.Point(12, 436);
            this.txtArquivoQueryBase.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtArquivoQueryBase.Name = "txtArquivoQueryBase";
            this.txtArquivoQueryBase.Size = new System.Drawing.Size(198, 26);
            this.txtArquivoQueryBase.TabIndex = 27;
            this.txtArquivoQueryBase.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtArquivoQueryBase_DragDrop);
            this.txtArquivoQueryBase.DragOver += new System.Windows.Forms.DragEventHandler(this.txtArquivoQueryBase_DragOver);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(93, 477);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 31);
            this.btnSalvar.TabIndex = 26;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Pasta requerente:";
            // 
            // btnAbrirPasta
            // 
            this.btnAbrirPasta.AllowDrop = true;
            this.btnAbrirPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirPasta.Location = new System.Drawing.Point(214, 380);
            this.btnAbrirPasta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAbrirPasta.Name = "btnAbrirPasta";
            this.btnAbrirPasta.Size = new System.Drawing.Size(34, 27);
            this.btnAbrirPasta.TabIndex = 24;
            this.btnAbrirPasta.Text = "...";
            this.btnAbrirPasta.UseVisualStyleBackColor = true;
            this.btnAbrirPasta.Click += new System.EventHandler(this.btnAbrirPasta_Click);
            // 
            // txtPastaRequerente
            // 
            this.txtPastaRequerente.AllowDrop = true;
            this.txtPastaRequerente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPastaRequerente.Location = new System.Drawing.Point(12, 381);
            this.txtPastaRequerente.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPastaRequerente.Name = "txtPastaRequerente";
            this.txtPastaRequerente.Size = new System.Drawing.Size(198, 26);
            this.txtPastaRequerente.TabIndex = 23;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(12, 247);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(236, 105);
            this.txtObservacoes.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Observações:";
            // 
            // txtNomeRequerente
            // 
            this.txtNomeRequerente.Location = new System.Drawing.Point(12, 136);
            this.txtNomeRequerente.Name = "txtNomeRequerente";
            this.txtNomeRequerente.Size = new System.Drawing.Size(236, 26);
            this.txtNomeRequerente.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nome requerente:";
            // 
            // txtChamadoBase
            // 
            this.txtChamadoBase.Location = new System.Drawing.Point(12, 83);
            this.txtChamadoBase.Name = "txtChamadoBase";
            this.txtChamadoBase.Size = new System.Drawing.Size(236, 26);
            this.txtChamadoBase.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Chamado base:";
            // 
            // txtNomeRotina
            // 
            this.txtNomeRotina.Location = new System.Drawing.Point(12, 31);
            this.txtNomeRotina.Name = "txtNomeRotina";
            this.txtNomeRotina.Size = new System.Drawing.Size(236, 26);
            this.txtNomeRotina.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome rotina:";
            // 
            // cmbQuandoRodar
            // 
            this.cmbQuandoRodar.FormattingEnabled = true;
            this.cmbQuandoRodar.Items.AddRange(new object[] {
            "Diario",
            "Semanal",
            "Mensal",
            "Chamado GLPI",
            "Email",
            "Outro"});
            this.cmbQuandoRodar.Location = new System.Drawing.Point(12, 193);
            this.cmbQuandoRodar.Name = "cmbQuandoRodar";
            this.cmbQuandoRodar.Size = new System.Drawing.Size(100, 28);
            this.cmbQuandoRodar.TabIndex = 30;
            this.cmbQuandoRodar.SelectedValueChanged += new System.EventHandler(this.cmbQuandoRodar_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Quando rodar:";
            // 
            // NovaRotina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 517);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbQuandoRodar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtArquivoQueryBase);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAbrirPasta);
            this.Controls.Add(this.txtPastaRequerente);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeRequerente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChamadoBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeRotina);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NovaRotina";
            this.Text = "NovaRotina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtArquivoQueryBase;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAbrirPasta;
        private System.Windows.Forms.TextBox txtPastaRequerente;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeRequerente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChamadoBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeRotina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbQuandoRodar;
        private System.Windows.Forms.Label label7;
    }
}