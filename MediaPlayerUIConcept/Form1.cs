using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerUIConcept
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DesignForm();
            
        }

        #region SubMenuFunctions
        private void DesignForm()
        {
            panel1.Visible = false;
            SettingsSUBMENU.Visible = false;
            PlaylistSUBMENU.Visible = false;
        }

        private void hideSubMenu()
        {
            if(panel1.Visible==true) panel1.Visible=false;
            if(SettingsSUBMENU.Visible==true) SettingsSUBMENU.Visible=false;
            if(PlaylistSUBMENU.Visible==true) PlaylistSUBMENU.Visible=false;
        }

        private void ShowPanel(Panel panels)
        {
            if (panels.Visible == false)
            {
                hideSubMenu();
                panels.Visible = true;
            }
            else
            {
                panels.Visible=false;
            }
        }
        #endregion
        #region ShowButtons

        private void PlaylistBTN_Click(object sender, EventArgs e)
        {
            ShowPanel(PlaylistSUBMENU);
        }
        private void MediaBTN_Click(object sender, EventArgs e)
        {
            ShowPanel(panel1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private void SettingsBTN_Click(object sender, EventArgs e)
        {
            ShowPanel(SettingsSUBMENU);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle=FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(childForm);
            }
        }


    }
}

