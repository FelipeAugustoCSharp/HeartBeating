using Firebase.Database;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
using System.Text.Json;
using System.Web.UI.WebControls;
using LiteDB;
using System.Security.Policy;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace HeartBeating
{
    public partial class FrmPrincipal : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=OSA0625262W10-1\\SQLEXPRESS;Initial Catalog=HH;Integrated Security=True");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;

        private void carregarLista() //criacao de método pra abrir o banco de dados e mostrar o que ha na lista
        {

            conn.Open(); // abra o banco de dados
            comando.CommandText = "select * from Empresa"; //armazenando esse comando na variavel
            dr = comando.ExecuteReader();		 //executar

            if (dr.HasRows) //has hows == tem linhas?
            {
                while (dr.Read()) //enquanto estiver lendo os arquivos das linhas...
                {
                    lboCodigo.Items.Add(dr[0].ToString()); // adicionar a primeira linha (codigo) como string dentro do list box                    
                }
            }
            conn.Close(); //fechar o banco de dados
        }


        private void MudasPagina(int n)
        {
            tbcPrincipal.SelectedIndex = n;
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            MudasPagina(3);
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            MudasPagina(2);
        }

        private void btnDoacoes_Click(object sender, EventArgs e)
        {
            MudasPagina(1);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MudasPagina(0);
        }
        private void btnDoar_Click(object sender, EventArgs e)
        {
            MudasPagina(2);
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            MudasPagina(3);
        }

        private void voltar0_Click(object sender, EventArgs e)
        {
            MudasPagina(1);
        }

        private void voltar1_Click(object sender, EventArgs e)
        {
            MudasPagina(1);
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            MudasPagina(0);
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            MudasPagina(1);
        }
        private void labelCadastro_Click(object sender, EventArgs e)
        {
            MudasPagina(6);
        }

        private void BtnCadastrarEmpresa_Click(object sender, EventArgs e)
        {
            MudasPagina(7);
        }

        private void voltar3_Click(object sender, EventArgs e)
        {
            MudasPagina(6);
        }

        private void voltar2_Click(object sender, EventArgs e)
        {
            MudasPagina(5);
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            MudasPagina(5);
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            PictureCircle.Visible = true;
            PictureCircle.Visible = false;
        }
        /* private void txbDATE_Validating(object sender, CancelEventArgs e)
         {
             txbDATE.Clear();
             Regex reg = new Regex(@"^(\d{1,2})/(\d{1,2})/(\d{4})$");
             Match m = reg.Match(txbDATE.Text);
             if (m.Success)
             {
                 int dd = int.Parse(m.Groups[1].Value);
                 int mm = int.Parse(m.Groups[2].Value);
                 int yyyy = int.Parse(m.Groups[3].Value);
                 e.Cancel = dd > 1 || dd < 31 || mm > 1 || mm < 12 || yyyy > 2000;
             }
             else e.Cancel = true;
             if (e.Cancel)
             {
                 if (MessageBox.Show("Wrong date format. The correct format is dd/mm/yyyy\n+ dd should be between 1 and 31.\n+ mm should be between 1 and 12.\n+ yyyy should be before 2025", "Invalid date", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                     e.Cancel = false;
             }
             MessageBox.Show(txbDATE.Text);
         }*/

        /*  private async void EnviarDados()
          {
              lboItens.Items.Clear();
              var resultado = await cliente.Child("produtos").OnceAsJsonAsync();
              JsonDocument importandoMinhaBase = JsonDocument.Parse(resultado);
              JsonElement filho = importandoMinhaBase.RootElement;

              if (filho.ValueKind.ToString() == "Null") return;

              foreach (var item in filho.EnumerateObject())
              {

                  JsonElement produtoFirebase = item.Value;
                   string nome = produtoFirebase.GetProperty("Nome").GetString();
                   string tipo = produtoFirebase.GetProperty("Tipo").GetString();
                   string local = produtoFirebase.GetProperty("LocalEntrega").GetString();
                   string date = produtoFirebase.GetProperty("Dia").GetString();

                  produtos Caridade = new produtos(nome, tipo, local, date);
                  lboItens.Items.Add(Caridade);
              }
          }*/


        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (btnLogin.Text == "Login")
                MudasPagina(5);
            else
                MudasPagina(8);
        }

        //CHAMANDO BANCO DE DADOS PARA LOGIN
        FirebaseClient cliente = new FirebaseClient("https://heartbeating-ac6d4-default-rtdb.firebaseio.com/", new FirebaseOptions
        {
            AuthTokenAsyncFactory = () => LoginAsync()
        });
        private static async Task<string> LoginAsync()
        {
            var config = new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyAuHzz52FfXo-IqgbbUtNtzDQ_rSSnht0g",

                AuthDomain = "heartbeating-ac6d4.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider()
                },
                UserRepository = new FileUserRepository("DadosInstituicao")
            };
            var cliente = new FirebaseAuthClient(config);
            Thread.Sleep(1000);
            return await cliente.User.GetIdTokenAsync();
        }



        private void BtnRegistrar_Click(object sender, EventArgs e)             //REGISTRO
        {
            if (TxbSenhaUser.Text != TxbConfirmarSenhaUser.Text)
            {
                MessageBox.Show("As senhas nao batem!", "Atenção!", MessageBoxButtons.OK);
                BringToFront();
                LabelErroSenha.Visible = true;                                  //CONCERTAR 
                return;
            }
            if (TxbSenhaUser.Text.Length <= 8)
            {
                MessageBox.Show("Insira uma senha maior!", "Atenção!", MessageBoxButtons.OK);
                BringToFront();
                ErroSenhaTamanho.Visible = true;                                 //CONCERTAR 
                return;
            }
            try
            {
                var config = new FirebaseAuthConfig
                {
                    ApiKey = "AIzaSyAuHzz52FfXo-IqgbbUtNtzDQ_rSSnht0g",

                    AuthDomain = "heartbeating-ac6d4.firebaseapp.com",
                    Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider()
                },
                    UserRepository = new FileUserRepository("DadosInstituicao")
                };

                var cliente = new FirebaseAuthClient(config);
                cliente.CreateUserWithEmailAndPasswordAsync(TxbEmailUser.Text, TxbSenhaUser.Text);



                conn.Open(); //CRIAR USER NO SQL SERVER
                comando.CommandText = "insert into Clientes(nome, email) values ('" + TxbNomeUser.Text + "', '" + TxbEmailUser.Text + "')";
                comando.ExecuteNonQuery();
                conn.Close();

                Thread.Sleep(1000);
                MudasPagina(5); //Caso o Registro tenha sucesso, mandar para a tela Login e Mudar no header, a label "login" para "Perfil"
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("EMAIL_EXISTS"))
                {
                    MessageBox.Show("Já existe o e-mail cadastrado");
                }
                else
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void BtnEntrarLogin_Click(object sender, EventArgs e)       //LOGIN
        {
            try
            {
                var config = new FirebaseAuthConfig
                {
                    ApiKey = "AIzaSyAuHzz52FfXo-IqgbbUtNtzDQ_rSSnht0g",

                    AuthDomain = "heartbeating-ac6d4.firebaseapp.com",
                    Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider()
                },
                    UserRepository = new FileUserRepository("NossosDados")
                };

                var cliente = new FirebaseAuthClient(config);
                var auth = cliente.SignInWithEmailAndPasswordAsync(TxbEmailLogin.Text, TxbSenhaLogin.Text).Result;

                //MUDAR O HEADER LOGIN PARA PROFILE

                Thread.Sleep(1000);
                MudasPagina(8);
                btnLogin.Text = "Profile";

                LabelNameUser.Text = cliente.User.ToString();        //NOME DO PERFIL
                LabelTypeUser.Text = cliente.User.ToString();        //TIPO DO PERFIL
                PictureBoxProfile.Image = ImageListProfile.Images[0]; //IMAGEM DO PERFIL
            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("EMAIL_NOT_FOUND"))
                {
                    MessageBox.Show("Não existe este usuario");
                }
                else if (ex.Message.Contains("INVALID_PASSWORD"))
                {
                    MessageBox.Show("Senha incorreta");
                }
                else MessageBox.Show("Erro Ao Realizar o Login. \r Revise seus dados e tente novamente mais tarde");
            }
        }

        private void BtnLogoff_Click(object sender, EventArgs e)
        {
            var config = new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyAuHzz52FfXo-IqgbbUtNtzDQ_rSSnht0g",

                AuthDomain = "heartbeating-ac6d4.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider()
                },
                UserRepository = new FileUserRepository("NossosDados")
            };
            var cliente = new FirebaseAuthClient(config);
            cliente.SignOut();
            MudasPagina(5);
        }
        private void BtnRegistrarEmpresa_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "insert into Empresa(cnpj) values ('" + TxbCNPJEmpresa.Text + "')";
            comando.ExecuteNonQuery();
            conn.Close();
        }
        public FrmPrincipal()
        {
            InitializeComponent();
            comando.Connection = conn;
            carregarLista();
            //EnviarDados();
            MudasPagina(5);            
        }
        private void btnEnviarDoacao_Click(object sender, EventArgs e)
        {
            carregarLista();
            conn.Open();
            comando.CommandText = "insert into Recebemos(tipo, empresa_id, nome, endereco, dia) values ('" + CBTipoDoar.Text + "', '" + lboCodigo.Items.Count + "','" + TxbNomeDoar.Text + "','" + CBLocalDoar.Text + "','" + DataEntregaDoar.Text + "')";
            comando.ExecuteNonQuery();
            conn.Close();


            /*
             * Lembrar de deixar async para utilizar o método abaixo
             * 
             * string nome = TxbNomeDoar.Text;
            string tipo = TxbTipoDoar.Text;
            string local = TxbLocalDoar.Text;
            string dia = DataEntregaDoar.Text;
            produtos prod = new produtos(nome, tipo, local, dia);
            var json = JsonConvert.SerializeObject(prod);
            await cliente.Child("produtos").PostAsync(json);
            EnviarDados();  
            
             
            conn.Open();
            comando.CommandText = "insert into Clientes(nome, email) values ('"+txbNome.Text+"', '"+txbEmail.Text+"')";
            comando.ExecuteNonQuery();
            conn.Close();*/
        }

    }
}
