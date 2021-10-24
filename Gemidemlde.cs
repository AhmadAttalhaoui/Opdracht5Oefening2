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
    public partial class Gemidemlde : Form
    {
            Invoer invoer= new Invoer();
            
        public Gemidemlde()
        {
            InitializeComponent();
            invoer.MdiParent = this.ParentForm;
            
            
        }

        private void btGetal_Click(object sender, EventArgs e)
        {
            
            invoer.ShowDialog();
            if(invoer.DialogResult == DialogResult.OK)
            {
                

                invoer.Dispose(); 
            }
        }
        
    }
}
