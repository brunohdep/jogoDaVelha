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
            
        }

        public void HabilitarBotões()
        {

        }
    }
}
