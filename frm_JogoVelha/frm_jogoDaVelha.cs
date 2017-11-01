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
        string Njogador1, Njogador2, jogada, tip1,tip2;
        int cont =0, Pjogador1= 0, Pjogador2 = 0,empates = 0;

        public frm_jogoDaVelha()
        {
            InitializeComponent();
            lb_empate.Text = empates.ToString();
            lb_pl1.Text = Pjogador1.ToString();
            lb_pl2.Text = Pjogador2.ToString();
            Limpar();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Fechar o Jogo da Velha?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Information,MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Limpar();
            }
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (rb_x.Checked)
            {
                jogada = rb_x.Text;
                rb_O.Checked = true;
                bt1.Text = jogada;
                bt1.Enabled = false;
                cont++;
                if (cont > 4)
                {
                    Vencedor();
                }
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_x.Checked = true;
                bt1.Text = jogada;
                bt1.Enabled = false;
                cont++;
                if (cont > 4)
                {
                    Vencedor();
                }
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (rb_x.Checked)
            {
                jogada = rb_x.Text;
                rb_O.Checked = true;
                bt2.Text = jogada;
                bt2.Enabled = false;
                cont++;
                if (cont > 4)
                {
                    Vencedor();
                }
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_x.Checked = true;
                bt2.Text = jogada;
                bt2.Enabled = false;
                cont++;
                if (cont > 4)
                {
                    Vencedor();
                }
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (rb_x.Checked)
            {
                jogada = rb_x.Text;
                rb_O.Checked = true;
                bt3.Text = jogada;
                bt3.Enabled = false;
                cont++;
                if (cont > 4)
                {
                    Vencedor();
                }
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_x.Checked = true;
                bt3.Text = jogada;
                cont++;
                bt3.Enabled = false;
                if (cont >4)
                {
                    Vencedor();
                }
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (rb_x.Checked)
            {
                jogada = rb_x.Text;
                rb_O.Checked = true;
                bt4.Text = jogada;
                bt4.Enabled = false;
                cont++;
                if (cont > 4)
                {
                    Vencedor();
                }
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_x.Checked = true;
                bt4.Text = jogada;
                bt4.Enabled = false;
                cont++;
                if (cont > 4)
                {
                    Vencedor();
                }
            }
            
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (rb_x.Checked)
            {
                jogada = rb_x.Text;
                rb_O.Checked = true;
                bt5.Text = jogada;
                bt5.Enabled = false;
                cont++;
                if (cont > 4)
                {
                    Vencedor();
                }
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_x.Checked = true;
                bt5.Text = jogada;
                bt5.Enabled = false;
                cont++;
                if (cont > 4)
                {
                    Vencedor();
                }
            }
            
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (rb_x.Checked)
            {
                jogada = rb_x.Text;
                rb_O.Checked = true;
                bt6.Text = jogada;
                bt6.Enabled = false;
                cont++;
                if (cont > 4)
                {
                    Vencedor();
                }
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_x.Checked = true;
                bt6.Text = jogada;
                bt6.Enabled = false;
                cont++;
                if (cont > 4)
                {
                    Vencedor();
                }
            }
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (rb_x.Checked)
            {
                jogada = rb_x.Text;
                rb_O.Checked = true;
                bt7.Text = jogada;
                bt7.Enabled = false;
                cont++;
                if (cont > 4)
                {
                    Vencedor();
                }
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_x.Checked = true;
                bt7.Text = jogada;
                bt7.Enabled = false;
                cont++;
                if (cont > 4)
                {
                    Vencedor();
                }
            }
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (rb_x.Checked)
            {
                jogada = rb_x.Text;
                rb_O.Checked = true;
                bt8.Text = jogada;
                bt8.Enabled = false;
                cont++;
                if (cont > 4)
                {
                    Vencedor();
                }
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_x.Checked = true;
                bt8.Text = jogada;
                bt8.Enabled = false;
                cont++;
                if (cont > 4)
                {
                    Vencedor();
                }
            }
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (rb_x.Checked)
            {
                jogada = rb_x.Text;
                rb_O.Checked = true;
                bt9.Text = jogada;
                bt9.Enabled = false;
                cont++;
                if (cont > 4)
                {
                    Vencedor();
                }
            }
            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_x.Checked = true;
                bt9.Text = jogada;
                bt9.Enabled = false;
                cont++;
                if (cont > 4)
                {
                    Vencedor();
                }
            }
        }

        private void bt_reiniciar_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Vencedor()
        {
            if ((bt1.Text.Equals(bt2.Text)) && (bt2.Text.Equals(bt3.Text)))
            {
                Console.WriteLine("entrou1");
                if (bt1.Text.Equals(""))
                {

                }else if (bt1.Text.Equals(tip1))
                {
                    Pjogador1++;
                    lb_pl1.Text = Pjogador1.ToString();
                    Venceu(Njogador1);
                }
                else
                {
                    Pjogador2++;
                    lb_pl2.Text = Pjogador2.ToString();
                    Venceu(Njogador2);
                }
            }
            else if ((bt4.Text.Equals(bt5.Text)) && (bt5.Text.Equals(bt6.Text)))
            {
                Console.WriteLine("entrou2");
                if (bt4.Text.Equals(""))
                {

                }
                else if(bt4.Text.Equals(tip1))
                {
                    Pjogador1++;
                    lb_pl1.Text = Pjogador1.ToString();
                    Venceu(Njogador1);
                }
                else
                {
                    Pjogador2++;
                    lb_pl2.Text = Pjogador2.ToString();
                    Venceu(Njogador2);
                }
            }
            else if ((bt7.Text.Equals(bt8.Text)) && (bt8.Text.Equals(bt9.Text)))
            {
                Console.WriteLine("entrou3");
                if (bt7.Text.Equals(""))
                {

                }
                else if (bt7.Text.Equals(tip1))
                {
                    Pjogador1++;
                    lb_pl1.Text = Pjogador1.ToString();
                    Venceu(Njogador1);
                }
                else
                {
                    Pjogador2++;
                    lb_pl2.Text = Pjogador2.ToString();
                    Venceu(Njogador2);
                }
            }
            else if ((bt1.Text.Equals(bt4.Text)) && (bt4.Text.Equals(bt7.Text)))
            {
                Console.WriteLine("entrou4");
                if (bt1.Text.Equals(""))
                {

                }
                else if (bt1.Text.Equals(tip1))
                {
                    Pjogador1++;
                    lb_pl1.Text = Pjogador1.ToString();
                    Venceu(Njogador1);
                }
                else
                {
                    Pjogador2++;
                    lb_pl2.Text = Pjogador2.ToString();
                    Venceu(Njogador2);
                }
            }
            else if ((bt2.Text.Equals(bt5.Text)) && (bt5.Text.Equals(bt8.Text)))
            {
                Console.WriteLine("entrou5");

                if (bt2.Text.Equals(""))
                {

                }
                else if (bt2.Text.Equals(tip1))
                {
                    Pjogador1++;
                    lb_pl1.Text = Pjogador1.ToString();
                    Venceu(Njogador1);
                }
                else
                {
                    Pjogador2++;
                    lb_pl2.Text = Pjogador2.ToString();
                    Venceu(Njogador2);
                }
            }
            else if ((bt3.Text.Equals(bt6.Text)) && (bt6.Text.Equals(bt9.Text)))
            {
                Console.WriteLine("entrou6");

                if (bt3.Text.Equals(""))
                {

                }
                else if (bt3.Text.Equals(tip1))
                {
                    Pjogador1++;
                    lb_pl1.Text = Pjogador1.ToString();
                    Venceu(Njogador1);
                }
                else
                {
                    Pjogador2++;
                    lb_pl2.Text = Pjogador2.ToString();
                    Venceu(Njogador2);
                }
            }
            else if ((bt1.Text.Equals(bt5.Text)) && (bt5.Text.Equals(bt9.Text)))
            {
                Console.WriteLine("entrou7");

                if (bt1.Text.Equals(""))
                {

                }
                else if (bt1.Text.Equals(tip1))
                {
                    Pjogador1++;
                    lb_pl1.Text = Pjogador1.ToString();
                    Venceu(Njogador1);
                }
                else
                {
                    Pjogador2++;
                    lb_pl2.Text = Pjogador2.ToString();
                    Venceu(Njogador2);
                }
            }
            else if ((bt3.Text.Equals(bt5.Text)) && (bt5.Text.Equals(bt7.Text)))
            {
                Console.WriteLine("entrou8");
                if (bt3.Text.Equals(""))
                {

                }
                else if (bt3.Text.Equals(tip1))
                {
                    Pjogador1++;
                    lb_pl1.Text = Pjogador1.ToString();
                    Venceu(Njogador1);
                }
                else
                {
                    Pjogador2++;
                    lb_pl2.Text = Pjogador2.ToString();
                    Venceu(Njogador2);
                }
            }
            else
            {
                if (cont == 9)
                {
                    empates++;
                    lb_empate.Text = empates.ToString();
                    if(MessageBox.Show("Empate","Empate",MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        Close();
                    }
                    else
                    {
                        Limpar();
                        HabilitarBotoes();
                    }
                }
            }
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
            cont = 0;
        }

        public void HabilitarBotoes()
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
        public void Venceu(String jogador)
        {
            if(MessageBox.Show("O Jogador " + jogador + "Venceu deseja Continuar?","Fim de jogo",MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)== DialogResult.No)
            {
                Close();
            }
            else
            {
                Limpar();
                HabilitarBotoes();
            }
        }
        public void Reiniciar()
        {
            tb_jogador1.Visible = true;
            tb_jogador2.Visible = true;
            gb_opcao.Enabled = true;
            Pjogador1 = 0;
            Pjogador2 = 0;
            empates = 0;
            lb_jogador1.Text = "";
            lb_jogador2.Text = "";
            lb_pl1.Text = "0";
            lb_pl2.Text = "0";
            lb_empate.Text = "0";
            Limpar();
            HabilitarBotoes();
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
                tip1 = "X";
                tip2 = "O";
            }
            else if (rb_O.Checked)
            {
                lb_jogador1.Text += " O ";
                lb_jogador2.Text += " X ";
                tip1 = "X";
                tip2 = "O";
            }
            gb_opcao.Enabled = false;
            pn_buttom.Enabled = true;
        }
    }
}
