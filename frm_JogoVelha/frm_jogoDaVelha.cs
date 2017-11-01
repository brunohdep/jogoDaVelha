using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_JogoVelha
{
    public partial class frm_jogoDaVelha : Form
    {
        string Njogador1, Njogador2, jogada;
        int cont =0, Pjogador1= 0, Pjogador2 = 0,empates = 0;

        public frm_jogoDaVelha()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Fechar o Jogo da Velha?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Information,MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Vencedor()
        {

        }

        public void Limpar()
        {
            bt1.Text = "";
            bt2.Text = "";
            bt3.Text = "";
            bt4.Text = "";
            bt5.Text = "";
            bt6.Text = "";
            bt7.Text = "";
            bt8.Text = "";
            bt9.Text = "";
        }

        public void HabilitarBotões()
        {
            bt1.Enabled = true;
            bt2.Enabled = true;
            bt3.Enabled = true;
            bt4.Enabled = true;
            bt5.Enabled = true;
            bt6.Enabled = true;
            bt7.Enabled = true;
            bt8.Enabled = true;
            bt9.Enabled = true;
        }

        private void bt_iniciar_Click(object sender, EventArgs e)
        {
            Njogador1 = tb_jogador1.Text;
            tb_jogador1.Visible = false;
            lb_jogador1.Text = Njogador1 + " Joga com";

            Njogador2 = tb_jogador2.Text;
            tb_jogador2.Visible = false;
            lb_jogador2.Text = Njogador2 + " Joga com";

            if (rb_x.Checked)
            {
                lb_jogador1.Text += " X ";
                lb_jogador2.Text += " O ";
            }
            else if (rb_O.Checked)
            {
                lb_jogador1.Text += " O ";
                lb_jogador2.Text += " X ";
            }
            gb_opcao.Enabled = false;
            pn_buttom.Enabled = true;
        }
    }
}
