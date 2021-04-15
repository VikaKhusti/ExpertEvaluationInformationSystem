using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExpertEvaluationIS
{
    public partial class Start_Page : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Start_Page()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                //MaterialSkin.Primary.Purple700,
                MaterialSkin.Primary.Pink200,
                MaterialSkin.Primary.Pink600,
                MaterialSkin.Primary.Pink300,
                MaterialSkin.Accent.DeepPurple700,
                MaterialSkin.TextShade.WHITE
                );
        }
        UserAction useraction;
        private void automaticButton_Click(object sender, EventArgs e)
        {
            useraction = new UserAction(true, null);
        }

        private void manualButton_Click(object sender, EventArgs e)
        {
            useraction = new UserAction(null, true);
        }
    }
}
