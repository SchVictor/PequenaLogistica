namespace PequenaLogistica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "credenciais.txt");
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            bool userFound = false;

            try
            {
                var linhas = File.ReadAllLines(filePath);//lê todas as linhas do arquivo
                foreach (string linha in linhas)
                {
                    var dados = linha.Split(',');

                    if (dados.Length >= 3)
                    {
                        string emailCadastrado = dados[1].Trim();
                        string senhaCadastrada = dados[2].Trim();

                        if (email == emailCadastrado && senha == senhaCadastrada)
                        {
                            userFound = true;
                            break;
                        }
                    }
                }
                if (userFound)
                {
                    MessageBox.Show("Login bem-sucedido!");
                    var home = new Home();
                    home.Show();
                    this.Hide(); // Esconde a tela de login
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
            }

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            var cadastro = new FormCadastroUsuario();
            cadastro.Show();
        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            functionShowPassword(chkshowPassword, txtSenha);
        }
        public void functionShowPassword(CheckBox chkShow, TextBox textPassword)
        {
            if (chkshowPassword.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        
    }
}
