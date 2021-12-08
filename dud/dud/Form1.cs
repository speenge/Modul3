using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyDown += new KeyEventHandler(Form1_KeyDown);
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers & (Keys.ShiftKey | Keys.Control)) != 0 &&
                e.KeyCode == Keys.Z) Close();
            
        }

    }
}
