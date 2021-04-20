using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ExpertEvaluationIS
{
    public partial class Input : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;        
        public static G gMain = new G(Start_Page.Count, 4);

        List<Gi> giCollection = new List<Gi>();
        int itemCount = 1;
        int click = 1;

        public Input()
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
            titleLabel.Text = $"Критерій №{itemCount}";
            saveButton.AutoSize = true;
           
            //InitializeObjects();
        }
/*
        public Gi InitializeGiInstance(int number)
        {
           
            string name = nameTextField.Text;
            int value = 0, desirableRat = 0;
            Dictionary<int, string> questions = new Dictionary<int, string>();
            Dictionary<int, int> marks = new Dictionary<int, int>();
            questions.Add(1, quest1TextField.Text);
            questions.Add(2, quest2TextField.Text);
            questions.Add(3, quest3TextField.Text);
            questions.Add(4, quest4TextField.Text);

            bool isExceptionShown = false;
            try
            {
                marks.Add(1, Convert.ToInt32(mark1TextField.Text));
                marks.Add(2, Convert.ToInt32(mark2TextField.Text));
                marks.Add(3, Convert.ToInt32(mark3TextField.Text));
                marks.Add(4, Convert.ToInt32(mark4TextField.Text));
                value = Convert.ToInt32(valueTextField.Text);
               // desirableRat = Convert.ToInt32(desiredMarkTextField.Text);
            
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

                    mark1TextField.Text = "";
                    mark2TextField.Text = "";
                    mark3TextField.Text = "";
                    mark4TextField.Text = "";
                    valueTextField.Text = "";
                    //desiredMarkTextField.Text = "";

                    isExceptionShown = !isExceptionShown;
                }
            }
            List<Qij> qcollection = new List<Qij>();
            for (int i = 1; i <= gMain.QCount; i++)
            {
                string quest = "";
                foreach (var item in questions)
                {
                    if (item.Key == i) { quest = item.Value; break; }                  
                }
                int mark = -1;
                foreach (var item in marks)
                {
                    if (item.Key == i) { mark = item.Value; break; }

                }
                //qcollection.Add(new Qij(number, i, quest, mark));
            }
            //return new Gi(name, number, qcollection, value, desirableRat);
        }
*/

        public void InitializeObjects()
        {
            //giCollection.Add(InitializeGiInstance(itemCount));
            if (giCollection.Count == gMain.Count - 1) saveButton.Text = "Збрегти і продовжити";
            if (giCollection.Count == gMain.Count)
            {
                //Result result = new Result();
                //result.ShowDialog();
                Pool pool = new Pool();
                pool.ShowDialog();

                // toDo
                Input input = new Input();
                input.ShowInTaskbar = false;
                input.Location = new Point(-10000, -10000);
            }                    
            
            checkLabel.ForeColor = Color.Green;
            checkLabel.Text = $"Критерій №{itemCount} був збережений";
            itemCount++;
            Thread.Sleep(1000);
            resetFields();
            //Thread.Sleep(3000);
            //setDummyData();

        }

        public void setDummyData(int click)
        {
            nameTextField.Text = $"some name{click}";

            quest1TextField.Text = $"question #(1){click}";
            quest2TextField.Text = $"question #(2){click}";
            quest3TextField.Text = $"question #(3){click}";
            quest4TextField.Text = $"question #(4){click}";

            mark1TextField.Text = $"{click + 5}";
            mark2TextField.Text = $"{click + 10}";
            mark3TextField.Text = $"{click + 15}";
            mark4TextField.Text = $"{click + 20}";

            valueTextField.Text = "25";
            //desiredMarkTextField.Text = "24";
        }
        
        public void resetFields()
        {
            nameTextField.Text = "";

            quest1TextField.Text = "";
            quest2TextField.Text = "";
            quest3TextField.Text = "";
            quest4TextField.Text = "";

            mark1TextField.Text = "";
            mark2TextField.Text = "";
            mark3TextField.Text = "";
            mark4TextField.Text = "";

            valueTextField.Text = "";
            //desiredMarkTextField.Text = "";

            //Thread.Sleep(1500);
            //checkLabel.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            InitializeObjects();
        }

        private void quest1TextField_Click(object sender, EventArgs e)
        {
            if(checkLabel.Text != "") { checkLabel.Text = ""; }
        }

        private void setDummyDataLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            checkLabel.Text = "";
            setDummyData(click);
            click++;
        }
    }
}
