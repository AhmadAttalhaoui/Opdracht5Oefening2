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

        public void AVG()
        {
            double total = 0;
            for (int i = 0; i < lbGemidelde.Items.Count; i++)
            {
                total += double.Parse(lbGemidelde.Items[i].ToString());
            }
            total = total / lbGemidelde.Items.Count;
            tbAvg.Text = total.ToString();
        }
        public void ListToevoegen(int getal)
        {
            lbGemidelde.Items.Add(getal.ToString());
        }

        private void btGetal_Click(object sender, EventArgs e)
        {
            Invoer invoer = new Invoer();
            invoer.ShowDialog();
            if(invoer.DialogResult == DialogResult.OK)
            {
                ListToevoegen(invoer.ReturnInt);
                AVG();

                invoer.Dispose(); 
            }
        }
        
    }
}
