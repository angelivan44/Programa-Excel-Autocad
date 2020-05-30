using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Clases;

namespace WindowsFormsApp1
{
    public partial class Areas : Form
    {
        
        public Areas()
        {
            InitializeComponent();
            foreach(string d in Modulo.localidadesG)
            {
                checkedListBox1.Items.Add(d);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            List<string> listatemporal = new List<string>();
            foreach (string c in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(c);
                listatemporal.Add(c);

            }

            Modulo.listaFinal = listatemporal;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                for(int i=0; i<checkedListBox1.Items.Count; i++)
                    
                {
                    checkedListBox1.SetItemChecked(i,true);
                };
            }
        }
    }
}
