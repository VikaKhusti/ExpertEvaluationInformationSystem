using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExpertEvaluationIS
{

    public partial class SetUp : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public static Groups groups = new Groups(Start_Page.CountOfGroups); //holds all information from input 
        public static G gMain = new G(Start_Page.Count, 4);

        List<Qij> qiCollecton = new List<Qij>();
        List<Gi> giCollection = new List<Gi>();
        List<Qij> questionCollection = new List<Qij>();
        List<Answers> answersCollection = new List<Answers>();
        List<G> groupsCollection = new List<G>();

        int GCount = 1;
        int QCount = 1;
        int click = 1;

        public SetUp()
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
            titleLabel.Text = $"Критерій №{GCount}";
            questNameLabel.Text = $"Питання №{QCount}";
            checkLabel.Text = "";
            saveButton.AutoSize = true;
            //addQi();
        }

        private void addQi()
        {
            answersCollection.Clear();
            bool isExceptionShown = false;
            string QiName = questTextField.Text;
            string ans1 = q11tf.Text;
            string ans2 = q12tf.Text;
            string ans3 = q13tf.Text;
            string ans4 = q14tf.Text;
            int val1 = -1;
            int val2 = -1;
            int val3 = -1;
            int val4 = -1;
            int mark = -1;
            try
            {
                val1 = Convert.ToInt32(v11tf.Text);
                val2 = Convert.ToInt32(v12tf.Text);
                val3 = Convert.ToInt32(v13tf.Text);
                val4 = Convert.ToInt32(v14tf.Text);
                mark = Convert.ToInt32(questValTextField.Text);
            }
            catch
            {
                if (!isExceptionShown)
                {
                    MessageBox.Show(
                        "Числові дані не вірно внесені",
                        "Помилка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
                isExceptionShown = true;
            }
            answersCollection.Add(new Answers(ans1, val1));
            answersCollection.Add(new Answers(ans2, val2));
            answersCollection.Add(new Answers(ans3, val3));
            answersCollection.Add(new Answers(ans4, val4));

           // List<Answers> tempAns = answersCollection;           
            questionCollection.Add(new Qij(GCount, QCount, QiName, new List<Answers>(answersCollection), mark));
            QCount++;
            if (questionCollection.Count >= gMain.QCount)
            {
                addGi(new List<Qij>(questionCollection));
            }

        }

        private void addGi(List<Qij> questions)
        {
            string GiName = nameTextField.Text;
            giCollection.Add(new Gi(GiName, GCount, questions));
            if (giCollection.Count >= gMain.Count)
            {
                groupsCollection.Add(new G(gMain.Count, 4, new List<Gi>(giCollection)));
                if(groupsCollection.Count >= Start_Page.CountOfGroups)
                {
                    groups.GCollection = groupsCollection;
                    // INPUT COMLITED HERE

                    Pool poolDialog = new Pool();
                    poolDialog.ShowDialog();
                }
                giCollection.Clear();                
            }
            questionCollection.Clear();
            QCount = 1;
            GCount++;
        }

        private void setDummyData(ref int click)
        {
            //titleLabel.Text = $"Критерій №{GCount}";
            //questNameLabel.Text = $"Питання №{QCount}";
            nameTextField.Text = $"G #{click}";
            questTextField.Text = $"Q #{click}";
            //valueTextField.Text = "25";
            questValTextField.Text = "26";

            q11tf.Text = $"quest #1{click}";
            q12tf.Text = $"quest #2{click}";
            q13tf.Text = $"quest #3{click}";
            q14tf.Text = $"quest #4{click}";

            v11tf.Text = "5";
            v12tf.Text = "10";
            v13tf.Text = "15";
            v14tf.Text = "25";

            click++;
        }

        private void resetFields()
        {
            nameTextField.Text = "";
            questTextField.Text = "";
            //valueTextField.Text = "";
            questValTextField.Text = "";

            q11tf.Text = "";
            q12tf.Text = "";
            q13tf.Text = "";
            q14tf.Text = "";

            v11tf.Text = "";
            v12tf.Text = "";
            v13tf.Text = "";
            v14tf.Text = "";
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            addQi();
            resetFields();
            checkLabel.ForeColor = Color.Green;
            checkLabel.Text = "Дані збережені";
            titleLabel.Text = $"Критерій №{GCount}";
            questNameLabel.Text = $"Питання №{QCount}";
        }

        private void setDummyDataLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            setDummyData(ref click);
        }       
    }
}
