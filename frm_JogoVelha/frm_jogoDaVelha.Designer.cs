﻿namespace frm_JogoVelha
{
    partial class frm_jogoDaVelha
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_jogoDaVelha));
            this.pn_top = new System.Windows.Forms.Panel();
            this.gp_Empate = new System.Windows.Forms.GroupBox();
            this.lb_empate = new System.Windows.Forms.Label();
            this.bt_sair = new System.Windows.Forms.Button();
            this.bt_reiniciar = new System.Windows.Forms.Button();
            this.bt_iniciar = new System.Windows.Forms.Button();
            this.gb_opcao = new System.Windows.Forms.GroupBox();
            this.rb_O = new System.Windows.Forms.RadioButton();
            this.rb_x = new System.Windows.Forms.RadioButton();
            this.gp_placar = new System.Windows.Forms.GroupBox();
            this.lb_pl2 = new System.Windows.Forms.Label();
            this.lb_pl1 = new System.Windows.Forms.Label();
            this.gp_Jogadores = new System.Windows.Forms.GroupBox();
            this.tb_jogador2 = new System.Windows.Forms.TextBox();
            this.tb_jogador1 = new System.Windows.Forms.TextBox();
            this.lb_jogador2 = new System.Windows.Forms.Label();
            this.lb_jogador1 = new System.Windows.Forms.Label();
            this.pn_buttom = new System.Windows.Forms.Panel();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.pn_top.SuspendLayout();
            this.gp_Empate.SuspendLayout();
            this.gb_opcao.SuspendLayout();
            this.gp_placar.SuspendLayout();
            this.gp_Jogadores.SuspendLayout();
            this.pn_buttom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_top
            // 
            this.pn_top.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pn_top.BackgroundImage = global::frm_JogoVelha.Properties.Resources.top;
            this.pn_top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_top.Controls.Add(this.gp_Empate);
            this.pn_top.Controls.Add(this.bt_sair);
            this.pn_top.Controls.Add(this.bt_reiniciar);
            this.pn_top.Controls.Add(this.bt_iniciar);
            this.pn_top.Controls.Add(this.gb_opcao);
            this.pn_top.Controls.Add(this.gp_placar);
            this.pn_top.Controls.Add(this.gp_Jogadores);
            this.pn_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_top.Font = new System.Drawing.Font("Bauhaus 93", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_top.ForeColor = System.Drawing.Color.White;
            this.pn_top.Location = new System.Drawing.Point(0, 0);
            this.pn_top.Name = "pn_top";
            this.pn_top.Size = new System.Drawing.Size(745, 223);
            this.pn_top.TabIndex = 0;
            // 
            // gp_Empate
            // 
            this.gp_Empate.BackColor = System.Drawing.Color.Transparent;
            this.gp_Empate.Controls.Add(this.lb_empate);
            this.gp_Empate.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_Empate.Location = new System.Drawing.Point(496, 12);
            this.gp_Empate.Name = "gp_Empate";
            this.gp_Empate.Size = new System.Drawing.Size(226, 125);
            this.gp_Empate.TabIndex = 6;
            this.gp_Empate.TabStop = false;
            this.gp_Empate.Text = "Empate";
            // 
            // lb_empate
            // 
            this.lb_empate.AutoSize = true;
            this.lb_empate.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_empate.Location = new System.Drawing.Point(108, 55);
            this.lb_empate.Name = "lb_empate";
            this.lb_empate.Size = new System.Drawing.Size(0, 18);
            this.lb_empate.TabIndex = 4;
            // 
            // bt_sair
            // 
            this.bt_sair.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.ForeColor = System.Drawing.Color.Black;
            this.bt_sair.Location = new System.Drawing.Point(626, 186);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(107, 31);
            this.bt_sair.TabIndex = 4;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // bt_reiniciar
            // 
            this.bt_reiniciar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reiniciar.ForeColor = System.Drawing.Color.Black;
            this.bt_reiniciar.Location = new System.Drawing.Point(517, 186);
            this.bt_reiniciar.Name = "bt_reiniciar";
            this.bt_reiniciar.Size = new System.Drawing.Size(107, 31);
            this.bt_reiniciar.TabIndex = 3;
            this.bt_reiniciar.Text = "Reiniciar";
            this.bt_reiniciar.UseVisualStyleBackColor = true;
            this.bt_reiniciar.Click += new System.EventHandler(this.bt_reiniciar_Click);
            // 
            // bt_iniciar
            // 
            this.bt_iniciar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_iniciar.ForeColor = System.Drawing.Color.Black;
            this.bt_iniciar.Location = new System.Drawing.Point(407, 186);
            this.bt_iniciar.Name = "bt_iniciar";
            this.bt_iniciar.Size = new System.Drawing.Size(107, 31);
            this.bt_iniciar.TabIndex = 2;
            this.bt_iniciar.Text = "Iniciar";
            this.bt_iniciar.UseVisualStyleBackColor = true;
            this.bt_iniciar.Click += new System.EventHandler(this.bt_iniciar_Click);
            // 
            // gb_opcao
            // 
            this.gb_opcao.BackColor = System.Drawing.Color.Transparent;
            this.gb_opcao.Controls.Add(this.rb_O);
            this.gb_opcao.Controls.Add(this.rb_x);
            this.gb_opcao.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_opcao.Location = new System.Drawing.Point(12, 143);
            this.gb_opcao.Name = "gb_opcao";
            this.gb_opcao.Size = new System.Drawing.Size(161, 74);
            this.gb_opcao.TabIndex = 1;
            this.gb_opcao.TabStop = false;
            this.gb_opcao.Text = "Opções";
            // 
            // rb_O
            // 
            this.rb_O.AutoSize = true;
            this.rb_O.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_O.Location = new System.Drawing.Point(89, 22);
            this.rb_O.Name = "rb_O";
            this.rb_O.Size = new System.Drawing.Size(57, 40);
            this.rb_O.TabIndex = 3;
            this.rb_O.Text = "O";
            this.rb_O.UseVisualStyleBackColor = true;
            // 
            // rb_x
            // 
            this.rb_x.AutoSize = true;
            this.rb_x.Checked = true;
            this.rb_x.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_x.Location = new System.Drawing.Point(11, 22);
            this.rb_x.Name = "rb_x";
            this.rb_x.Size = new System.Drawing.Size(49, 40);
            this.rb_x.TabIndex = 2;
            this.rb_x.TabStop = true;
            this.rb_x.Text = "X";
            this.rb_x.UseVisualStyleBackColor = true;
            // 
            // gp_placar
            // 
            this.gp_placar.BackColor = System.Drawing.Color.Transparent;
            this.gp_placar.Controls.Add(this.lb_pl2);
            this.gp_placar.Controls.Add(this.lb_pl1);
            this.gp_placar.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_placar.Location = new System.Drawing.Point(264, 12);
            this.gp_placar.Name = "gp_placar";
            this.gp_placar.Size = new System.Drawing.Size(226, 125);
            this.gp_placar.TabIndex = 1;
            this.gp_placar.TabStop = false;
            this.gp_placar.Text = "Placar";
            // 
            // lb_pl2
            // 
            this.lb_pl2.AutoSize = true;
            this.lb_pl2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pl2.Location = new System.Drawing.Point(6, 81);
            this.lb_pl2.Name = "lb_pl2";
            this.lb_pl2.Size = new System.Drawing.Size(0, 18);
            this.lb_pl2.TabIndex = 5;
            // 
            // lb_pl1
            // 
            this.lb_pl1.AutoSize = true;
            this.lb_pl1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pl1.Location = new System.Drawing.Point(6, 31);
            this.lb_pl1.Name = "lb_pl1";
            this.lb_pl1.Size = new System.Drawing.Size(0, 18);
            this.lb_pl1.TabIndex = 4;
            // 
            // gp_Jogadores
            // 
            this.gp_Jogadores.BackColor = System.Drawing.Color.Transparent;
            this.gp_Jogadores.Controls.Add(this.tb_jogador2);
            this.gp_Jogadores.Controls.Add(this.tb_jogador1);
            this.gp_Jogadores.Controls.Add(this.lb_jogador2);
            this.gp_Jogadores.Controls.Add(this.lb_jogador1);
            this.gp_Jogadores.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_Jogadores.Location = new System.Drawing.Point(12, 12);
            this.gp_Jogadores.Name = "gp_Jogadores";
            this.gp_Jogadores.Size = new System.Drawing.Size(216, 125);
            this.gp_Jogadores.TabIndex = 0;
            this.gp_Jogadores.TabStop = false;
            this.gp_Jogadores.Text = "Jogadores";
            // 
            // tb_jogador2
            // 
            this.tb_jogador2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_jogador2.Location = new System.Drawing.Point(6, 72);
            this.tb_jogador2.Name = "tb_jogador2";
            this.tb_jogador2.Size = new System.Drawing.Size(204, 31);
            this.tb_jogador2.TabIndex = 4;
            // 
            // tb_jogador1
            // 
            this.tb_jogador1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_jogador1.Location = new System.Drawing.Point(6, 31);
            this.tb_jogador1.Name = "tb_jogador1";
            this.tb_jogador1.Size = new System.Drawing.Size(204, 31);
            this.tb_jogador1.TabIndex = 2;
            // 
            // lb_jogador2
            // 
            this.lb_jogador2.AutoSize = true;
            this.lb_jogador2.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_jogador2.Location = new System.Drawing.Point(6, 81);
            this.lb_jogador2.Name = "lb_jogador2";
            this.lb_jogador2.Size = new System.Drawing.Size(0, 28);
            this.lb_jogador2.TabIndex = 3;
            // 
            // lb_jogador1
            // 
            this.lb_jogador1.AutoSize = true;
            this.lb_jogador1.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_jogador1.Location = new System.Drawing.Point(6, 31);
            this.lb_jogador1.Name = "lb_jogador1";
            this.lb_jogador1.Size = new System.Drawing.Size(0, 28);
            this.lb_jogador1.TabIndex = 2;
            // 
            // pn_buttom
            // 
            this.pn_buttom.Controls.Add(this.bt3);
            this.pn_buttom.Controls.Add(this.bt9);
            this.pn_buttom.Controls.Add(this.bt8);
            this.pn_buttom.Controls.Add(this.bt7);
            this.pn_buttom.Controls.Add(this.bt6);
            this.pn_buttom.Controls.Add(this.bt5);
            this.pn_buttom.Controls.Add(this.bt4);
            this.pn_buttom.Controls.Add(this.bt2);
            this.pn_buttom.Controls.Add(this.bt1);
            this.pn_buttom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_buttom.Enabled = false;
            this.pn_buttom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pn_buttom.Location = new System.Drawing.Point(0, 223);
            this.pn_buttom.Name = "pn_buttom";
            this.pn_buttom.Size = new System.Drawing.Size(745, 241);
            this.pn_buttom.TabIndex = 1;
            // 
            // bt9
            // 
            this.bt9.BackColor = System.Drawing.Color.Transparent;
            this.bt9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt9.Font = new System.Drawing.Font("Bauhaus 93", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt9.Image = ((System.Drawing.Image)(resources.GetObject("bt9.Image")));
            this.bt9.Location = new System.Drawing.Point(388, 159);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(83, 66);
            this.bt9.TabIndex = 13;
            this.bt9.UseVisualStyleBackColor = false;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.Color.Transparent;
            this.bt8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt8.Font = new System.Drawing.Font("Bauhaus 93", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt8.Image = ((System.Drawing.Image)(resources.GetObject("bt8.Image")));
            this.bt8.Location = new System.Drawing.Point(299, 159);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(83, 66);
            this.bt8.TabIndex = 12;
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.Color.Transparent;
            this.bt7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt7.Font = new System.Drawing.Font("Bauhaus 93", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt7.Image = ((System.Drawing.Image)(resources.GetObject("bt7.Image")));
            this.bt7.Location = new System.Drawing.Point(210, 159);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(83, 66);
            this.bt7.TabIndex = 11;
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.Color.Transparent;
            this.bt6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt6.Font = new System.Drawing.Font("Bauhaus 93", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt6.Image = ((System.Drawing.Image)(resources.GetObject("bt6.Image")));
            this.bt6.Location = new System.Drawing.Point(388, 87);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(83, 66);
            this.bt6.TabIndex = 10;
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.Color.Transparent;
            this.bt5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt5.Font = new System.Drawing.Font("Bauhaus 93", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt5.Image = ((System.Drawing.Image)(resources.GetObject("bt5.Image")));
            this.bt5.Location = new System.Drawing.Point(299, 87);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(83, 66);
            this.bt5.TabIndex = 9;
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.Color.Transparent;
            this.bt4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt4.Font = new System.Drawing.Font("Bauhaus 93", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt4.Image = ((System.Drawing.Image)(resources.GetObject("bt4.Image")));
            this.bt4.Location = new System.Drawing.Point(210, 87);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(83, 66);
            this.bt4.TabIndex = 8;
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.Transparent;
            this.bt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt2.Font = new System.Drawing.Font("Bauhaus 93", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt2.Image = global::frm_JogoVelha.Properties.Resources.bota;
            this.bt2.Location = new System.Drawing.Point(299, 15);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(83, 66);
            this.bt2.TabIndex = 6;
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.Transparent;
            this.bt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt1.Font = new System.Drawing.Font("Bauhaus 93", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt1.Image = global::frm_JogoVelha.Properties.Resources.bota;
            this.bt1.Location = new System.Drawing.Point(210, 15);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(83, 66);
            this.bt1.TabIndex = 5;
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.Transparent;
            this.bt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt3.Font = new System.Drawing.Font("Bauhaus 93", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt3.Image = global::frm_JogoVelha.Properties.Resources.bota;
            this.bt3.Location = new System.Drawing.Point(388, 15);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(83, 66);
            this.bt3.TabIndex = 14;
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // frm_jogoDaVelha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 464);
            this.Controls.Add(this.pn_buttom);
            this.Controls.Add(this.pn_top);
            this.Font = new System.Drawing.Font("Bauhaus 93", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_jogoDaVelha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Velha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.pn_top.ResumeLayout(false);
            this.gp_Empate.ResumeLayout(false);
            this.gp_Empate.PerformLayout();
            this.gb_opcao.ResumeLayout(false);
            this.gb_opcao.PerformLayout();
            this.gp_placar.ResumeLayout(false);
            this.gp_placar.PerformLayout();
            this.gp_Jogadores.ResumeLayout(false);
            this.gp_Jogadores.PerformLayout();
            this.pn_buttom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_top;
        private System.Windows.Forms.Panel pn_buttom;
        private System.Windows.Forms.GroupBox gp_placar;
        private System.Windows.Forms.GroupBox gp_Jogadores;
        private System.Windows.Forms.GroupBox gb_opcao;
        private System.Windows.Forms.Label lb_pl2;
        private System.Windows.Forms.Label lb_pl1;
        private System.Windows.Forms.Label lb_jogador2;
        private System.Windows.Forms.Label lb_jogador1;
        private System.Windows.Forms.TextBox tb_jogador2;
        private System.Windows.Forms.TextBox tb_jogador1;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Button bt_reiniciar;
        private System.Windows.Forms.Button bt_iniciar;
        private System.Windows.Forms.RadioButton rb_O;
        private System.Windows.Forms.RadioButton rb_x;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.GroupBox gp_Empate;
        private System.Windows.Forms.Label lb_empate;
        private System.Windows.Forms.Button bt3;
    }
}

