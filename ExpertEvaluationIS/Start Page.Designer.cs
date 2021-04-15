
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
            this.SuspendLayout();
            // 
            // manualButton
            // 
            this.manualButton.AutoSize = true;
            this.manualButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.manualButton.Depth = 0;
            this.manualButton.Location = new System.Drawing.Point(296, 176);
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
            this.automaticButton.Location = new System.Drawing.Point(296, 230);
            this.automaticButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.automaticButton.Name = "automaticButton";
            this.automaticButton.Primary = true;
            this.automaticButton.Size = new System.Drawing.Size(195, 35);
            this.automaticButton.TabIndex = 1;
            this.automaticButton.Text = "Внести дані з прикладу";
            this.automaticButton.UseVisualStyleBackColor = true;
            this.automaticButton.Click += new System.EventHandler(this.automaticButton_Click);
            // 
            // Start_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}