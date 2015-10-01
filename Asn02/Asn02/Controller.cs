using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asn02
{
    public partial class Controller : Form
    {
        Main _mainForm;

        public Controller()
        {
            InitializeComponent();
        }

        public Controller(Main mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();

            num_S.Value = _mainForm.S;
            num_G.Value = _mainForm.G;
        }

        private void btn_ToggleClick(object sender, EventArgs e)
        {
            _mainForm.PanelClick(sender, e);
        }

        private void numSChanged(object sender, EventArgs e)
        {
            _mainForm.S = (int)num_S.Value;
            _mainForm.Refresh();
        }

        private void numGChanged(object sender, EventArgs e)
        {
            _mainForm.G = (int)num_G.Value;
            _mainForm.Refresh();
        }
    }
}
