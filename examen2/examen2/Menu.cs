﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuariosform userform = new Usuariosform();
            userform.MdiParent = this;
            userform.Show();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ticketformulario userform = new ticketformulario();
            userform.MdiParent = this;
            userform.Show();
        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultatickt userform = new consultatickt();
            userform.MdiParent = this;
            userform.Show();
        }
    }
}
