using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void customizeDesign()
        {
            panel_stdsubmenu.Visible = false;
            panel_coursesubmenu.Visible = false;
            panel_scoresubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panel_stdsubmenu.Visible == true)
            {
                panel_stdsubmenu.Visible = false;
            }
            if(panel_coursesubmenu.Visible == true)
            {
                panel_coursesubmenu.Visible = false;
            }
            if (panel_scoresubmenu.Visible == true)
            {
                panel_scoresubmenu.Visible = false;
            }
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_stdsubmenu);
        }
        #region StudentSubmenu
        private void btn_registration_Click(object sender, EventArgs e)
        {
            //...
            //Your code here
            //...
            hideSubmenu();
        }

        private void btn_managestd_Click(object sender, EventArgs e)
        {
            //...
            //Your code here
            //...
            hideSubmenu();
        }

        private void btn_status_Click(object sender, EventArgs e)
        {
            //...
            //Your code here
            //...
            hideSubmenu();
        }

        private void btn_printstd_Click(object sender, EventArgs e)
        {
            //...
            //Your code here
            //...
            hideSubmenu();
        }
        #endregion StudentSubmenu
        private void btn_course_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_coursesubmenu);
        }
        #region CourseSubmenu
        private void btn_newcourse_Click(object sender, EventArgs e)
        {
            //...
            //Your code here
            //...
            hideSubmenu();
        }

        private void btn_managecourse_Click(object sender, EventArgs e)
        {
            //...
            //Your code here
            //...
            hideSubmenu();
        }

        private void btn_printcourse_Click(object sender, EventArgs e)
        {
            //...
            //Your code here
            //...
            hideSubmenu();
        }
        #endregion CourseSubmenu
        private void btn_score_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_scoresubmenu);
        }
        #region ScoreSubmenu
        private void btn_newscore_Click(object sender, EventArgs e)
        {
            //...
            //Your code here
            //...
            hideSubmenu();
        }

        private void btn_managescore_Click(object sender, EventArgs e)
        {
            //...
            //Your code here
            //...
            hideSubmenu();
        }

        private void btn_printscore_Click(object sender, EventArgs e)
        {
            //...
            //Your code here
            //...
            hideSubmenu();
        }
        #endregion ScoreSubmenu

    }
}
