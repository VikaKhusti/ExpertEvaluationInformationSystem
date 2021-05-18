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
        int GCount = 1;
        int QCount = 1;
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

            //gmain = SetUp.gMain;
            InitializeFields();
        }

        private void InitializeFields()
        {
            foreach (var item in gmain.GiCollection)
            {
                if(item.Number == GCount)
                {
                    foreach (var q in item.QijCollection)
                    {
                        questionLabel.Text = q.Name;
                        if(q.Number == QCount)
                        {
                            foreach (var a in q.ansCollection)
                            {
                                quest1RadioButton.Name = a.Answer;
                            }
                        }

                    }
                }
            }
            
        }
        private void nextRaisedButton_Click(object sender, EventArgs e)
        {

        }
    }
}
