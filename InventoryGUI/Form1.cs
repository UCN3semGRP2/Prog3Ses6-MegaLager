using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryGUI
{
    public partial class Form1 : Form
    {
        private WcfServiceReference.IService1 srv = new WcfServiceReference.Service1Client();

        public Form1()
        {
            InitializeComponent();
        }
    }
}
