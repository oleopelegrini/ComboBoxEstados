using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComboBoxEstados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblALL_Click(object sender, EventArgs e)
        {
            lblALL.Text = comboTodos.Items.Count.ToString();
        }

        private void lblNORTE_Click(object sender, EventArgs e)
        {
            lblNORTE.Text = comboTodos.Items.Count.ToString();
        }

        private void lblNORD_Click(object sender, EventArgs e)
        {
            lblNORD.Text = comboTodos.Items.Count.ToString();
        }

        private void lblCO_Click(object sender, EventArgs e)
        {
            lblCO.Text = comboTodos.Items.Count.ToString();

        }

        private void lblSUD_Click(object sender, EventArgs e)
        {
            lblSUD.Text = comboTodos.Items.Count.ToString();
        }

        private void lblSUL_Click(object sender, EventArgs e)
        {
            lblSUL.Text = comboTodos.Items.Count.ToString();
        }

        private void comboTodos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboTodos.Text == "SP" || comboTodos.Text == "RJ" || comboTodos.Text == "MG" || comboTodos.Text == "ES")
            {
                cboSudeste.Items.Add(comboTodos.Text);
                comboTodos.Items.RemoveAt(comboTodos.SelectedIndex);
                lblALL.Text = comboTodos.Items.Count.ToString();
                lblSUD.Text = cboSudeste.Items.Count.ToString();
                cboSudeste.Sorted = true;
            }

            if (comboTodos.Text == "PR" || comboTodos.Text == "RS" || comboTodos.Text == "SC")
            {
                cboSul.Items.Add(comboTodos.Text);
                comboTodos.Items.RemoveAt(comboTodos.SelectedIndex);
                lblALL.Text = comboTodos.Items.Count.ToString();
                lblSUL.Text = cboSudeste.Items.Count.ToString();
                cboSudeste.Sorted = true;
            }

            if (comboTodos.Text == "MT" || comboTodos.Text == "GO" || comboTodos.Text == "MS")
            {
                cboCO.Items.Add(comboTodos.Text);
                comboTodos.Items.RemoveAt(comboTodos.SelectedIndex);
                lblALL.Text = comboTodos.Items.Count.ToString();
                lblCO.Text = cboCO.Items.Count.ToString();
                cboCO.Sorted = true;
            }

            if (comboTodos.Text == "AC" || comboTodos.Text == "RO" || comboTodos.Text == "AM" || comboTodos.Text == "AP" || comboTodos.Text == "PA" || comboTodos.Text == "RR" || comboTodos.Text == "TO")
            {
                cboNorte.Items.Add(comboTodos.Text);
                comboTodos.Items.RemoveAt(comboTodos.SelectedIndex);
                lblALL.Text = comboTodos.Items.Count.ToString();
                lblNORTE.Text = cboNorte.Items.Count.ToString();
                cboNorte.Sorted = true;
            }

            if (comboTodos.Text == "BA" || comboTodos.Text == "PI" || comboTodos.Text == "MA" || comboTodos.Text == "CE" || comboTodos.Text == "SE" || comboTodos.Text == "PE" || comboTodos.Text == "AL" || comboTodos.Text == "PB" || comboTodos.Text == "RN")
            {
                cboNordeste.Items.Add(comboTodos.Text);
                comboTodos.Items.RemoveAt(comboTodos.SelectedIndex);
                lblALL.Text = comboTodos.Items.Count.ToString();
                lblNORD.Text = cboNordeste.Items.Count.ToString();
                cboNordeste.Sorted = true;
            }
        }
  
        private void cboSudeste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSudeste_Click(object sender, EventArgs e)
        {
            comboTodos.Items.Add(cboSudeste.Text);
            cboSudeste.Items.RemoveAt(cboSudeste.SelectedIndex);
            lblALL.Text = cboSudeste.Items.Count.ToString();
            lblSUD.Text = cboSudeste.Items.Count.ToString();
            cboSudeste.Sorted = true;
            cboSudeste.ResetText();
        }

        private void cboSul_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCO_Click(object sender, EventArgs e)
        {
            comboTodos.Items.Add(cboCO.Text);
            cboCO.Items.RemoveAt(cboCO.SelectedIndex);
            lblALL.Text = cboCO.Items.Count.ToString();
            lblCO.Text = cboCO.Items.Count.ToString();
            cboCO.Sorted = true;
            cboCO.ResetText();
        }

        private void cboCO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboNorte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboNordeste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSUL_Click(object sender, EventArgs e)
        {
            comboTodos.Items.Add(cboSul.Text);
            cboSul.Items.RemoveAt(cboSul.SelectedIndex);
            lblALL.Text = cboSul.Items.Count.ToString();
            lblSUL.Text = cboSul.Items.Count.ToString();
            cboSul.Sorted = true;
            cboSul.ResetText();
        }

        private void btnNORD_Click(object sender, EventArgs e)
        {
            comboTodos.Items.Add(cboNordeste.Text);
            cboNordeste.Items.RemoveAt(cboNordeste.SelectedIndex);
            lblALL.Text = cboNordeste.Items.Count.ToString();
            lblNORD.Text = cboNordeste.Items.Count.ToString();
            cboNordeste.Sorted = true;
            cboNordeste.ResetText();
        }

        private void btnNORTE_Click(object sender, EventArgs e)
        {
            comboTodos.Items.Add(cboNorte.Text);
            cboNorte.Items.RemoveAt(cboNorte.SelectedIndex);
            lblALL.Text = cboNorte.Items.Count.ToString();
            lblNORTE.Text = cboNorte.Items.Count.ToString();
            cboNorte.Sorted = true;
            cboNorte.ResetText();
        }
    }
    }