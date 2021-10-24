using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht5Oefening2
{
    public partial class Invoer : Form
    {
        
        public Invoer()
        {
            InitializeComponent();
            
        }

        public int ReturnInt { get; private set; }

        private void btWaarde_Click(object sender, EventArgs e)
        {


            this.ReturnInt = int.Parse(tbWaarde.Text);
        }
        
    }
}
