using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CharCreateInstructions : Form
    {
        Form creator;
        public CharCreateInstructions(Form sender)
        {
            InitializeComponent();
            creator = sender;
        }

        private void CharCreateInstructions_Load(object sender, EventArgs e)
        {

        }

        private void Form_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            creator.Enabled = true;
        }
    }
}
