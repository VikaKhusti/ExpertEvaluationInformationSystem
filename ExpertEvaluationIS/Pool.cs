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
            Step2(false);
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
            bool callTask2 = false;
            try
            {
                data.GCollection[groupNum - 1].GiCollection[criteriaNum - 1].QijCollection[questionNum - 1].ansCollection[0].isSelected = quest1RadioButton.Checked;
                data.GCollection[groupNum - 1].GiCollection[criteriaNum - 1].QijCollection[questionNum - 1].ansCollection[1].isSelected = quest2RadioButton.Checked;
                data.GCollection[groupNum - 1].GiCollection[criteriaNum - 1].QijCollection[questionNum - 1].ansCollection[2].isSelected = quest3RadioButton.Checked;
                data.GCollection[groupNum - 1].GiCollection[criteriaNum - 1].QijCollection[questionNum - 1].ansCollection[3].isSelected = quest4RadioButton.Checked;
            } catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            
            if(questionNum >= QCount)
            {
                questionNum = 0;
                
                if(criteriaNum >= KCount)
                {
                    criteriaNum = 0;                    
                    if(groupNum >= GCount)
                    {
                        //finish
                        Step2(true);
                        callTask2 = true;
                        //criterionLabel.Text = data.GCollection[G].GiCollection[K].GName;
                    }
                    groupNum++;
                }
                criteriaNum++;
            }
            questionNum++;

            if (!callTask2) initializeFields(groupNum, criteriaNum, questionNum);            
        }

        private void Step2(bool ready)
        {
            criterionLabel.Text = "Задайте бажані значення щодо описаних критеріїв";
            materialLabel1.Visible = ready;
            materialSingleLineTextField.Visible = ready;
            next2Button.Visible = ready;

            questionLabel.Visible = !ready;
            quest1RadioButton.Visible = !ready;
            quest2RadioButton.Visible = !ready;
            quest3RadioButton.Visible = !ready;
            quest4RadioButton.Visible = !ready;
            nextRaisedButton.Visible = !ready;
            task2(0, 0);
        }
        private int task2(int g, int k)
        {
            int value = -1;
            try
            {
                materialLabel1.Text = data.GCollection[g].GiCollection[k].GName;
                if(k > 0)
                {
                    value = Convert.ToInt32(materialSingleLineTextField.Text);
                }

             } catch(Exception ex)
             {
                MessageBox.Show(
                "Не вірно внесені дані",
                "Помилка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );                       
            }
            return value;
        }

        int G = 0, K = 0;
        private void next2Button_Click(object sender, EventArgs e)
        {
            if (G < GCount)
            {
                if (K < KCount)
                {
                    data.GCollection[G].GiCollection[K].DesirableRating = task2(G, K);
                    K++;
                }
                else { G++; K = 0; }
            }
            
        }
    }
}
