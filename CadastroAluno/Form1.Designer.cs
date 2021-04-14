
namespace CadastroAluno
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Delete = new System.Windows.Forms.Button();
            this.Alterar = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cboAlunos = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.Selecione = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.NOME = new System.Windows.Forms.Label();
            this.Endereço = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.Label();
            this.Turma = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.Incluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(214, 304);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 28);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Deletar";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Deletar_Click);
            // 
            // Alterar
            // 
            this.Alterar.Location = new System.Drawing.Point(120, 304);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(75, 28);
            this.Alterar.TabIndex = 2;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseVisualStyleBackColor = true;
            this.Alterar.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(312, 304);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(75, 28);
            this.Sair.TabIndex = 3;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(12, 134);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(406, 23);
            this.txtEndereco.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 90);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(406, 23);
            this.txtNome.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 178);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(406, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // cboAlunos
            // 
            this.cboAlunos.FormattingEnabled = true;
            this.cboAlunos.Location = new System.Drawing.Point(120, 46);
            this.cboAlunos.Name = "cboAlunos";
            this.cboAlunos.Size = new System.Drawing.Size(298, 23);
            this.cboAlunos.TabIndex = 9;
            this.cboAlunos.SelectedIndexChanged += new System.EventHandler(this.cboAlunos_SelectedIndexChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 46);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(83, 23);
            this.txtID.TabIndex = 10;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(14, 266);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(173, 23);
            this.txtStatus.TabIndex = 11;
            // 
            // txtTurma
            // 
            this.txtTurma.Location = new System.Drawing.Point(193, 266);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(225, 23);
            this.txtTurma.TabIndex = 12;
            // 
            // Selecione
            // 
            this.Selecione.AutoSize = true;
            this.Selecione.Location = new System.Drawing.Point(120, 28);
            this.Selecione.Name = "Selecione";
            this.Selecione.Size = new System.Drawing.Size(100, 15);
            this.Selecione.TabIndex = 13;
            this.Selecione.Text = "Selecione o aluno";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(12, 28);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 15);
            this.ID.TabIndex = 14;
            this.ID.Text = "ID";
            // 
            // NOME
            // 
            this.NOME.AutoSize = true;
            this.NOME.Location = new System.Drawing.Point(12, 72);
            this.NOME.Name = "NOME";
            this.NOME.Size = new System.Drawing.Size(40, 15);
            this.NOME.TabIndex = 15;
            this.NOME.Text = "Nome";
            // 
            // Endereço
            // 
            this.Endereço.AutoSize = true;
            this.Endereço.Location = new System.Drawing.Point(12, 116);
            this.Endereço.Name = "Endereço";
            this.Endereço.Size = new System.Drawing.Size(56, 15);
            this.Endereço.TabIndex = 16;
            this.Endereço.Text = "Endereço";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(12, 160);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 15);
            this.Email.TabIndex = 17;
            this.Email.Text = "E-mail";
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Location = new System.Drawing.Point(13, 204);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(51, 15);
            this.Telefone.TabIndex = 18;
            this.Telefone.Text = "Telefone";
            // 
            // Turma
            // 
            this.Turma.AutoSize = true;
            this.Turma.Location = new System.Drawing.Point(193, 248);
            this.Turma.Name = "Turma";
            this.Turma.Size = new System.Drawing.Size(41, 15);
            this.Turma.TabIndex = 19;
            this.Turma.Text = "Turma";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(14, 248);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(39, 15);
            this.Status.TabIndex = 20;
            this.Status.Text = "Status";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(13, 222);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(405, 23);
            this.txtTelefone.TabIndex = 23;
            // 
            // Incluir
            // 
            this.Incluir.Location = new System.Drawing.Point(20, 304);
            this.Incluir.Name = "Incluir";
            this.Incluir.Size = new System.Drawing.Size(75, 28);
            this.Incluir.TabIndex = 0;
            this.Incluir.Text = "Incluir";
            this.Incluir.Click += new System.EventHandler(this.Incluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 358);
            this.Controls.Add(this.Incluir);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Turma);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Endereço);
            this.Controls.Add(this.NOME);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Selecione);
            this.Controls.Add(this.txtTurma);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cboAlunos);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.Delete);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Alterar;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cboAlunos;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.Label Selecione;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label NOME;
        private System.Windows.Forms.Label Endereço;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.Label Turma;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button Incluir;
    }
}

