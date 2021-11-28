using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace samuraiSudoku
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void thread5Button_Click(object sender, EventArgs e)
        {
            Thread5 thread5 = new Thread5();
            thread5.Show();
        }

        private void thread10Button_Click(object sender, EventArgs e)
        {
            Thread10 thread10 = new Thread10();
            thread10.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
