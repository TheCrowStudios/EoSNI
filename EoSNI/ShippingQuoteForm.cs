using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EoSNI
{
    public partial class ShippingQuoteForm : Form
    {
        public ShippingQuoteForm()
        {
            InitializeComponent();
        }

        public ShippingQuoteForm(string quote)
        {
            InitializeComponent();
            txtQuote.Text = quote;
            txtQuote.ReadOnly = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
