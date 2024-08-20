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
        String sp;

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

        }

        private void lblNORD_Click(object sender, EventArgs e)
        {

        }

        private void lblCO_Click(object sender, EventArgs e)
        {

        }

        private void lblSUD_Click(object sender, EventArgs e)
        {

        }

        private void lblSUL_Click(object sender, EventArgs e)
        {

        }

        private void comboTodos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // Defina o nome específico do item que você deseja mover
                string nomeItemEspecifico = "NomeDoItem"; // Altere para o nome específico do item

                // Encontrar o índice do item específico na comboBox1
                int index = comboBox1.Items.IndexOf(nomeItemEspecifico);

                // Verificar se o item foi encontrado
                if (index != -1)
                {
                    // Adicionar o item à comboBox2
                    comboBox2.Items.Add(comboBox1.Items[index]);
                    // Remover o item da comboBox1
                    comboBox1.Items.RemoveAt(index);
                }
            }
    }
}
