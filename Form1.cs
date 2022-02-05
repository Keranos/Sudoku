using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        private List<Control> TextBoxList = new List<Control>();

        public Form1()
        {
            InitializeComponent();
            var unsortedTextBoxList = new List<Control>();
            FindControls(this, unsortedTextBoxList, "textBox");
            TextBoxList = unsortedTextBoxList.OrderBy(x => x.Name).ToList();
        }

        private void FindControls(Control owner, List<Control> list, string name) {
            foreach (Control c in owner.Controls)
                if (c.Name.Contains(name))
                    list.Add(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void solve_Click(object sender, EventArgs e)
        {
            var values = new List<int>();
            foreach (var box in TextBoxList)
            {
                int i;
                values.Add(int.TryParse(box.Text, out i) ? i : 0);
            }
        }
    }
}
