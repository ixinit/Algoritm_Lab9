using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MajordomoProg
{
    public partial class MajordomoProg : Form
    {
        MajordomoClass recurs = new MajordomoClass();
        public MajordomoProg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (recurs.Put(textBox1.Text))
                label3.Text = recurs.Get();
        }
    }
}
