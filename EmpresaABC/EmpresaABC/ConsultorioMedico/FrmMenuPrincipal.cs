﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ConsultorioMedico
{
    public partial class FrmMenuPrincipal : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmLogin voltar = new FrmLogin();
            voltar.Show();
            this.Hide();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            FrmConsulta abrir = new FrmConsulta();
            abrir.Show();
            this.Hide();
        }

        private void btnMédico_Click(object sender, EventArgs e)
        {
            FrmMedicos abrir = new FrmMedicos();
            abrir.Show();
            this.Hide();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            frmPacientes abrir = new frmPacientes();
            abrir.Show();
            this.Hide();
        }

        private void btnExames_Click(object sender, EventArgs e)
        {
            FrmExames abrir = new FrmExames();
            abrir.Show();
            this.Hide();
        }

        private void btnConvenio_Click(object sender, EventArgs e)
        {
            FrmConvenio abrir = new FrmConvenio();
            abrir.Show();
            this.Hide();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            FrmAgenda abrir = new FrmAgenda();
            abrir.Show();
            this.Hide();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
    }
}
