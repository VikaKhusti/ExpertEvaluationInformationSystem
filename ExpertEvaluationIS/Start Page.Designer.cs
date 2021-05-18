
namespace ExpertEvaluationIS
{
    partial class Start_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.manualButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.automaticButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.countLabel = new MaterialSkin.Controls.MaterialLabel();
            this.countOfGroupsTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nextButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.goBackButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.countTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ccountLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // manualButton
            // 
            this.manualButton.AutoSize = true;
            this.manualButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.manualButton.Depth = 0;
            this.manualButton.Location = new System.Drawing.Point(296, 211);
            this.manualButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.manualButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.manualButton.Name = "manualButton";
            this.manualButton.Primary = false;
            this.manualButton.Size = new System.Drawing.Size(195, 36);
            this.manualButton.TabIndex = 0;
            this.manualButton.Text = "Внести дані самостійно";
            this.manualButton.UseVisualStyleBackColor = true;
            this.manualButton.Click += new System.EventHandler(this.manualButton_Click);
            // 
            // automaticButton
            // 
            this.automaticButton.Depth = 0;
            this.automaticButton.Location = new System.Drawing.Point(296, 167);
            this.automaticButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.automaticButton.Name = "automaticButton";
            this.automaticButton.Primary = true;
            this.automaticButton.Size = new System.Drawing.Size(195, 35);
            this.automaticButton.TabIndex = 1;
            this.automaticButton.Text = "Внести дані з прикладу";
            this.automaticButton.UseVisualStyleBackColor = true;
            this.automaticButton.Click += new System.EventHandler(this.automaticButton_Click);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Depth = 0;
            this.countLabel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.countLabel.Location = new System.Drawing.Point(204, 271);
            this.countLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(209, 19);
            this.countLabel.TabIndex = 2;
            this.countLabel.Text = "Введіть к-сть груп критеріїв:";
            // 
            // countOfGroupsTextField
            // 
            this.countOfGroupsTextField.Depth = 0;
            this.countOfGroupsTextField.Hint = "";
            this.countOfGroupsTextField.Location = new System.Drawing.Point(421, 269);
            this.countOfGroupsTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.countOfGroupsTextField.Name = "countOfGroupsTextField";
            this.countOfGroupsTextField.PasswordChar = '\0';
            this.countOfGroupsTextField.SelectedText = "";
            this.countOfGroupsTextField.SelectionLength = 0;
            this.countOfGroupsTextField.SelectionStart = 0;
            this.countOfGroupsTextField.Size = new System.Drawing.Size(91, 23);
            this.countOfGroupsTextField.TabIndex = 3;
            this.countOfGroupsTextField.Text = "2";
            this.countOfGroupsTextField.UseSystemPasswordChar = false;
            // 
            // nextButton
            // 
            this.nextButton.Depth = 0;
            this.nextButton.Location = new System.Drawing.Point(356, 340);
            this.nextButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextButton.Name = "nextButton";
            this.nextButton.Primary = true;
            this.nextButton.Size = new System.Drawing.Size(75, 30);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Далі";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.AutoSize = true;
            this.goBackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.goBackButton.Depth = 0;
            this.goBackButton.Location = new System.Drawing.Point(340, 399);
            this.goBackButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.goBackButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Primary = false;
            this.goBackButton.Size = new System.Drawing.Size(110, 36);
            this.goBackButton.TabIndex = 5;
            this.goBackButton.Text = "Повернутися";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // countTextField
            // 
            this.countTextField.Depth = 0;
            this.countTextField.Hint = "";
            this.countTextField.Location = new System.Drawing.Point(421, 302);
            this.countTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.countTextField.Name = "countTextField";
            this.countTextField.PasswordChar = '\0';
            this.countTextField.SelectedText = "";
            this.countTextField.SelectionLength = 0;
            this.countTextField.SelectionStart = 0;
            this.countTextField.Size = new System.Drawing.Size(91, 23);
            this.countTextField.TabIndex = 7;
            this.countTextField.Text = "4";
            this.countTextField.UseSystemPasswordChar = false;
            // 
            // ccountLabel
            // 
            this.ccountLabel.AutoSize = true;
            this.ccountLabel.Depth = 0;
            this.ccountLabel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ccountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ccountLabel.Location = new System.Drawing.Point(187, 302);
            this.ccountLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ccountLabel.Name = "ccountLabel";
            this.ccountLabel.Size = new System.Drawing.Size(226, 19);
            this.ccountLabel.TabIndex = 6;
            this.ccountLabel.Text = "Введіть к-сть критеріїв в групі:";
            // 
            // Start_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.countTextField);
            this.Controls.Add(this.ccountLabel);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.countOfGroupsTextField);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.automaticButton);
            this.Controls.Add(this.manualButton);
            this.Name = "Start_Page";
            this.Text = "Start_Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton manualButton;
        private MaterialSkin.Controls.MaterialRaisedButton automaticButton;
        private MaterialSkin.Controls.MaterialLabel countLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField countOfGroupsTextField;
        private MaterialSkin.Controls.MaterialRaisedButton nextButton;
        private MaterialSkin.Controls.MaterialFlatButton goBackButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField countTextField;
        private MaterialSkin.Controls.MaterialLabel ccountLabel;
    }
}