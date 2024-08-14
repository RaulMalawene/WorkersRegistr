namespace programaFuncionario
{
    partial class Form1
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
            this.gravar = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.remover = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textSalarioDiario = new System.Windows.Forms.TextBox();
            this.textDia_traba = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiasTrabalho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // gravar
            // 
            this.gravar.BackColor = System.Drawing.Color.White;
            this.gravar.Location = new System.Drawing.Point(692, 37);
            this.gravar.Name = "gravar";
            this.gravar.Size = new System.Drawing.Size(75, 33);
            this.gravar.TabIndex = 0;
            this.gravar.Text = "Gravar";
            this.gravar.UseVisualStyleBackColor = false;
            this.gravar.Click += new System.EventHandler(this.gravar_Click);
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.Color.White;
            this.sair.Location = new System.Drawing.Point(692, 159);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(75, 34);
            this.sair.TabIndex = 1;
            this.sair.Text = "sair";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // remover
            // 
            this.remover.BackColor = System.Drawing.Color.White;
            this.remover.Location = new System.Drawing.Point(692, 116);
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(75, 37);
            this.remover.TabIndex = 2;
            this.remover.Text = "Remover";
            this.remover.UseVisualStyleBackColor = false;
            this.remover.Click += new System.EventHandler(this.remover_Click);
            // 
            // editar
            // 
            this.editar.BackColor = System.Drawing.Color.White;
            this.editar.Location = new System.Drawing.Point(692, 82);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 29);
            this.editar.TabIndex = 3;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = false;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(118, 34);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(159, 22);
            this.textCodigo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "codigo";
            // 
            // textSalarioDiario
            // 
            this.textSalarioDiario.Location = new System.Drawing.Point(118, 127);
            this.textSalarioDiario.Name = "textSalarioDiario";
            this.textSalarioDiario.Size = new System.Drawing.Size(159, 22);
            this.textSalarioDiario.TabIndex = 6;
            // 
            // textDia_traba
            // 
            this.textDia_traba.Location = new System.Drawing.Point(118, 95);
            this.textDia_traba.Name = "textDia_traba";
            this.textDia_traba.Size = new System.Drawing.Size(159, 22);
            this.textDia_traba.TabIndex = 7;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(118, 62);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(159, 22);
            this.textNome.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "SalaioDiario ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "DiaTrabalho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo,
            this.Nome,
            this.DiasTrabalho,
            this.columnHeader4,
            this.columnHeader5});
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(15, 212);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(752, 226);
            this.listView.TabIndex = 12;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // codigo
            // 
            this.codigo.Text = "codigo";
            this.codigo.Width = 80;
            // 
            // Nome
            // 
            this.Nome.Text = "nome";
            this.Nome.Width = 420;
            // 
            // DiasTrabalho
            // 
            this.DiasTrabalho.Text = "diasTrabalho";
            this.DiasTrabalho.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "salarioDiario";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "salarioMensal";
            this.columnHeader5.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textDia_traba);
            this.Controls.Add(this.textSalarioDiario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.remover);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.gravar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gravar;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Button remover;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSalarioDiario;
        private System.Windows.Forms.TextBox textDia_traba;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader DiasTrabalho;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

