using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace CadastroAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int codigoAluno;

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void CarregaDados()
        {
            cboAlunos.DataSource = DalHelper.GetAlunos();
            cboAlunos.ValueMember = "AlunoId";
            cboAlunos.DisplayMember = "Nome";
            cboAlunos.Text = "selecione o aluno";
            LimpaFormulario();
        }
        private void LimpaFormulario()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }
        private void cboAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();

            codigoAluno = Convert.ToInt32(((DataRowView)cboAlunos.SelectedItem)["AlunoId"]);

            aluno = DalHelper.GetAluno(codigoAluno);
            PreencheDados(aluno);
        }
        private void PreencheDados(Aluno aluno)
        {
            txtID.Text = aluno.AlunoId.ToString();
            txtNome.Text = aluno.Nome;
            txtEndereco.Text = aluno.Endereco;
            txtEmail.Text = aluno.Email;
            txtTelefone.Text = aluno.Telefone;
            txtStatus.Text = aluno.Status;
            txtTurma.Text = aluno.Turma;
        }
        private void Alterar_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno aluno = new Aluno();

                aluno.AlunoId = Convert.ToInt32(txtID.Text);
                aluno.Nome = txtNome.Text;
                aluno.Endereco = txtEndereco.Text;
                aluno.Email = txtEmail.Text;
                aluno.Telefone = txtTelefone.Text;
                aluno.Status = txtStatus.Text;
                aluno.Turma = txtTurma.Text;

                DalHelper.Update(aluno);
                CarregaDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }
        private void Deletar_Click(object sender, EventArgs e)
        {
            try
            {
                DalHelper.Delete(codigoAluno);
                CarregaDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Incluir_Click(object sender, EventArgs e)
        {
            if (Incluir.Text.Equals("Incluir"))
            {
                Incluir.Text = "Salvar";
                LimpaFormulario();
                txtID.Enabled = false;
                txtNome.Focus();
            }
            else if (Incluir.Text.Equals("Salvar"))
            {
                Incluir.Text = "Incluir";
                txtID.Enabled = true;
                try
                {
                    Aluno aluno = new Aluno();

                    aluno.Nome = txtNome.Text;
                    aluno.Endereco = txtEndereco.Text;
                    aluno.Email = txtEmail.Text;
                    aluno.Telefone = txtTelefone.Text;
                    aluno.Status = txtStatus.Text;
                    aluno.Turma = txtStatus.Text;

                    DalHelper.Add(aluno);
                    CarregaDados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
            }

        }
    }
}