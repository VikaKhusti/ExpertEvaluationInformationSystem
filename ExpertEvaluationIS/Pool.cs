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
    public partial class Pool : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        G gmain;
        public Pool()
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
                MaterialSkin.Accent.Pink700,
                MaterialSkin.TextShade.WHITE
                );

            gmain = Input.gMain;
        }

        private void InitializeFields(int Gnumber, int Qnumber)
        {
            foreach (var item in gmain.GiCollection)
            {
                if(item.Number == Gnumber)
                {
                    foreach (var q in item.QijCollection)
                    {
                        titleLabel.Text = q.Question;

                    }
                }
            }
            
        }
        private void nextRaisedButton_Click(object sender, EventArgs e)
        {

        }
    }
}
