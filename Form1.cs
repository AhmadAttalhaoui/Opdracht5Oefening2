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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Gemidemlde gemidemlde = new Gemidemlde();
            gemidemlde.MdiParent = Form1.ActiveForm;
            gemidemlde.Show();

        }

    }
}
