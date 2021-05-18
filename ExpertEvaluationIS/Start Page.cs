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
        public static int Count;
        public static int CountOfGroups;
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
            setVisibility(false);
        }

        private void setVisibility(bool visible)
        {
            countLabel.Visible = visible;
            ccountLabel.Visible = visible;
            countOfGroupsTextField.Visible = visible;
            countTextField.Visible = visible;
            nextButton.Visible = visible;
            goBackButton.Visible = visible;
            automaticButton.Visible = !visible;
        }

        UserAction useraction;
        private void automaticButton_Click(object sender, EventArgs e)
        {
            useraction = new UserAction(true, null);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            setVisibility(false);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            try
            {
                CountOfGroups = Convert.ToInt32(countOfGroupsTextField.Text);
                Count = Convert.ToInt32(countTextField.Text);
                //Input inputform = new Input();
                //inputform.ShowDialog();
                SetUp setUp = new SetUp();
                setUp.ShowDialog();
            }
            catch
            {
                MessageBox.Show(
                    "Не вірно внесені дані",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void manualButton_Click(object sender, EventArgs e)
        {
            useraction = new UserAction(null, true);
            setVisibility(true);
        }
    }
}
