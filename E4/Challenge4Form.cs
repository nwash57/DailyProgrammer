using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E4
{
    public partial class Challenge4Form : Form
    {
        public Challenge4Form()
        {
            InitializeComponent();
        }

        private void Challenge4Form_Load(object sender, EventArgs e)
        {

        }

        private void txtPassLength_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Challenge4.passLength = Convert.ToInt32(txtPassLength.Text);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }

        private void txtNumOfPass_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Challenge4.numOfPass = Convert.ToInt32(txtNumOfPass.Text);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }

        private void lbxPasswords_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPassCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Challenge4.CreatePasswords();

                for (int i = 0; i < Challenge4.passwords.Count; i++)
                {
                    lbxPasswords.Items.Add(Challenge4.passwords[i]);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }
    }
}
