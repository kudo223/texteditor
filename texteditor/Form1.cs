using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;     

namespace texteditor
{
    public partial class Form1 : Form
    {
        
        
        string filePath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "All files|*.*|C# class|*.cs|Text file|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                Text = filePath;
                if (File.Exists(filePath))
                {
                    textContent.Text = File.ReadAllText(filePath);
                    buttonSave.Enabled = true;
                    buttonSaveAs.Enabled = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {

        }
    }
}
