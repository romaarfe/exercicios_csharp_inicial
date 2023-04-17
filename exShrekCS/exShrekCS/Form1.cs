using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exShrekCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int nascimento = Convert.ToInt32(txtNascimento.Text);
            double valorBase = Convert.ToInt64(txtValor.Text);
            double resultado = 0;

            if (nascimento >= 2000)
            {
                resultado = valorBase - (valorBase* 0.1);
            }

            if (chkEscalao.Checked)
            {
                resultado = resultado - (valorBase * 0.1);
            }
            
            if (chkSocio.Checked)
            {
                resultado = resultado - (valorBase * 0.05);
            }

            if (chkAgravamento.Checked)
            {
                resultado = resultado + 12;
            }

            if (rdbSim.Checked)
            {
                resultado = resultado - (valorBase * 0.01);
            }

            if (cbxConcelho.SelectedIndex == 0)
            {
                resultado = resultado - (valorBase * 0.2);
            }

            txtResultado.Text = Convert.ToString(resultado);

            if (resultado < 100)
            {
                pbxShrek.Load("https://www.ofuxico.com.br/wp-content/uploads/2021/08/shrek-sessao-da-tarde-1.jpg");
                pbxShrek.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbxShrek.Load("https://scontent-lis1-1.xx.fbcdn.net/v/t1.6435-9/44933308_2183417675247655_5278655037466214400_n.jpg?_nc_cat=101&ccb=1-7&_nc_sid=973b4a&_nc_ohc=97SnGUUOa7IAX8uKkAN&_nc_ht=scontent-lis1-1.xx&oh=00_AfABpgsnrrGOfUnT38DFMVbH227K9DIlP3N9qdrXLwm59A&oe=63F9CA18");
            pbxShrek.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }
}
