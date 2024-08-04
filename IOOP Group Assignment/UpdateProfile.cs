using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Group_Assignment
{
    public partial class UpdateProfile : Form
    {
        public UpdateProfile()
        {
            InitializeComponent();
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {

        }

        private void btn_Pfp_Click(object sender, EventArgs e)
        {
            ChangeProfilePicturePage f4 = new ChangeProfilePicturePage();
            f4.ShowDialog();
        }
    }
}
