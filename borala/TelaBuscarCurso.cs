﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace borala
{
    public partial class TelaBuscarCurso : Form
    {
        public TelaBuscarCurso()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            CadastrarCurso tela = new CadastrarCurso();
            tela.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_curso_Click(object sender, EventArgs e)
        {
            CadastrarCurso tela = new CadastrarCurso();
            tela.Show();
        }
    }
}
