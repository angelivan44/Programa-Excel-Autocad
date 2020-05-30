using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using WindowsFormsApp1.Clases;

namespace WindowsFormsApp1
{
    public partial class BD : Form
    {
        public BD()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
         
         
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            op.ShowDialog();
            Modulo.RutaExcel = op.FileName;
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "dwg files (*.dwg)|*.dwg|All files (*.*)|*.*";
            op.ShowDialog();
            Modulo.RutaAutocad = op.FileName;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog op = new FolderBrowserDialog();
            op.ShowDialog();
            Modulo.RutaGuardado = op.SelectedPath;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
