using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Answer : Form
    {
        public Answer(string result)
        {
            InitializeComponent();
            this.label1.Text = result;
        }

        private void Answer_Load(object sender, EventArgs e)
        {

        }
    }
}
