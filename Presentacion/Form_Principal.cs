﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class Form_Principal : Form
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public Form_Principal(int codigo)
        {
            InitializeComponent();

            switch (codigo)
            {
                case 1:
                    this.tabControl1.TabPages.Remove(tabGerente);
                    this.tabControl1.TabPages.Remove(tabAdmin);
                    this.tabControl1.TabPages.Remove(tabEncargado);
                    break;
                case 2:
                    this.tabControl1.TabPages.Remove(tabVendedor);
                    this.tabControl1.TabPages.Remove(tabAdmin);
                    this.tabControl1.TabPages.Remove(tabEncargado);
                    break;
                case 3:
                    this.tabControl1.TabPages.Remove(tabGerente);
                    this.tabControl1.TabPages.Remove(tabVendedor);
                    this.tabControl1.TabPages.Remove(tabAdmin);
                    break;
                case 4:
                    this.tabControl1.TabPages.Remove(tabGerente);
                    this.tabControl1.TabPages.Remove(tabVendedor);
                    this.tabControl1.TabPages.Remove(tabEncargado);
                    break;
                default: break;
            }
        }

        #region EVENTOS

        /// <summary>
        /// Cuando el Formulario Principal se cierra, se cierra toda la aplicacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscarProducto1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
