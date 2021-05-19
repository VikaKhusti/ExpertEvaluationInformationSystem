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
        static Groups data = SetUp.groups;
        static int GCount = data.Count;
        static int KCount = data.GCollection[0].Count;
        static int QCount = data.GCollection[0].QCount;

        int groupNum = 1;
        int criteriaNum = 1;
        int questionNum = 1;

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
            initializeFields(1, 1, 1);
            //gmain = SetUp.gMain;
            
        }

        private void initializeFields(int groupNum, int criteriaNum, int questionNum)
        {
            criterionLabel.Text = data.GCollection[groupNum - 1].GiCollection[criteriaNum - 1].GName;
            questionLabel.Text = data.GCollection[groupNum - 1].GiCollection[criteriaNum - 1].QijCollection[questionNum-1].Name;
            quest1RadioButton.Text = data.GCollection[groupNum - 1].GiCollection[criteriaNum - 1].QijCollection[questionNum - 1].ansCollection[0].Answer;
            quest2RadioButton.Text = data.GCollection[groupNum - 1].GiCollection[criteriaNum - 1].QijCollection[questionNum - 1].ansCollection[1].Answer;
            quest3RadioButton.Text = data.GCollection[groupNum - 1].GiCollection[criteriaNum - 1].QijCollection[questionNum - 1].ansCollection[2].Answer;
            quest4RadioButton.Text = data.GCollection[groupNum - 1].GiCollection[criteriaNum - 1].QijCollection[questionNum - 1].ansCollection[3].Answer;
        }

        
        private void nextRaisedButton_Click(object sender, EventArgs e)
        {            
            data.GCollection[groupNum - 1].GiCollection[criteriaNum - 1].QijCollection[questionNum - 1].ansCollection[0].isSelected = quest1RadioButton.Checked;
            data.GCollection[groupNum - 1].GiCollection[criteriaNum - 1].QijCollection[questionNum - 1].ansCollection[1].isSelected = quest2RadioButton.Checked;
            data.GCollection[groupNum - 1].GiCollection[criteriaNum - 1].QijCollection[questionNum - 1].ansCollection[2].isSelected = quest3RadioButton.Checked;
            data.GCollection[groupNum - 1].GiCollection[criteriaNum - 1].QijCollection[questionNum - 1].ansCollection[3].isSelected = quest4RadioButton.Checked;

            
            if(questionNum >= QCount)
            {
                questionNum = 0;
                
                if(criteriaNum >= KCount)
                {
                    criteriaNum = 0;                    
                    if(groupNum >= GCount)
                    {
                        //finish
                    }
                    groupNum++;
                }
                criteriaNum++;
            }
            questionNum++;
            initializeFields(groupNum, criteriaNum, questionNum);
        }
    }
}
