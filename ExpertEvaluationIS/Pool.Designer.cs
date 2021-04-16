﻿
namespace ExpertEvaluationIS
{
    partial class Pool
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.quest1RadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.quest2RadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.quest3RadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.quest4RadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.nextRaisedButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(13, 86);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(70, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "label1";
            // 
            // quest1RadioButton
            // 
            this.quest1RadioButton.AutoSize = true;
            this.quest1RadioButton.Depth = 0;
            this.quest1RadioButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quest1RadioButton.Location = new System.Drawing.Point(13, 148);
            this.quest1RadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.quest1RadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.quest1RadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.quest1RadioButton.Name = "quest1RadioButton";
            this.quest1RadioButton.Ripple = true;
            this.quest1RadioButton.Size = new System.Drawing.Size(163, 30);
            this.quest1RadioButton.TabIndex = 1;
            this.quest1RadioButton.TabStop = true;
            this.quest1RadioButton.Text = "materialRadioButton1";
            this.quest1RadioButton.UseVisualStyleBackColor = true;
            // 
            // quest2RadioButton
            // 
            this.quest2RadioButton.AutoSize = true;
            this.quest2RadioButton.Depth = 0;
            this.quest2RadioButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quest2RadioButton.Location = new System.Drawing.Point(13, 199);
            this.quest2RadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.quest2RadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.quest2RadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.quest2RadioButton.Name = "quest2RadioButton";
            this.quest2RadioButton.Ripple = true;
            this.quest2RadioButton.Size = new System.Drawing.Size(163, 30);
            this.quest2RadioButton.TabIndex = 2;
            this.quest2RadioButton.TabStop = true;
            this.quest2RadioButton.Text = "materialRadioButton2";
            this.quest2RadioButton.UseVisualStyleBackColor = true;
            // 
            // quest3RadioButton
            // 
            this.quest3RadioButton.AutoSize = true;
            this.quest3RadioButton.Depth = 0;
            this.quest3RadioButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quest3RadioButton.Location = new System.Drawing.Point(13, 253);
            this.quest3RadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.quest3RadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.quest3RadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.quest3RadioButton.Name = "quest3RadioButton";
            this.quest3RadioButton.Ripple = true;
            this.quest3RadioButton.Size = new System.Drawing.Size(163, 30);
            this.quest3RadioButton.TabIndex = 3;
            this.quest3RadioButton.TabStop = true;
            this.quest3RadioButton.Text = "materialRadioButton3";
            this.quest3RadioButton.UseVisualStyleBackColor = true;
            // 
            // quest4RadioButton
            // 
            this.quest4RadioButton.AutoSize = true;
            this.quest4RadioButton.Depth = 0;
            this.quest4RadioButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quest4RadioButton.Location = new System.Drawing.Point(13, 308);
            this.quest4RadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.quest4RadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.quest4RadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.quest4RadioButton.Name = "quest4RadioButton";
            this.quest4RadioButton.Ripple = true;
            this.quest4RadioButton.Size = new System.Drawing.Size(163, 30);
            this.quest4RadioButton.TabIndex = 4;
            this.quest4RadioButton.TabStop = true;
            this.quest4RadioButton.Text = "materialRadioButton4";
            this.quest4RadioButton.UseVisualStyleBackColor = true;
            // 
            // nextRaisedButton
            // 
            this.nextRaisedButton.Depth = 0;
            this.nextRaisedButton.Location = new System.Drawing.Point(13, 374);
            this.nextRaisedButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextRaisedButton.Name = "nextRaisedButton";
            this.nextRaisedButton.Primary = true;
            this.nextRaisedButton.Size = new System.Drawing.Size(163, 38);
            this.nextRaisedButton.TabIndex = 5;
            this.nextRaisedButton.Text = "materialRaisedButton1";
            this.nextRaisedButton.UseVisualStyleBackColor = true;
            this.nextRaisedButton.Click += new System.EventHandler(this.nextRaisedButton_Click);
            // 
            // Pool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextRaisedButton);
            this.Controls.Add(this.quest4RadioButton);
            this.Controls.Add(this.quest3RadioButton);
            this.Controls.Add(this.quest2RadioButton);
            this.Controls.Add(this.quest1RadioButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "Pool";
            this.Text = "Pool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private MaterialSkin.Controls.MaterialRadioButton quest1RadioButton;
        private MaterialSkin.Controls.MaterialRadioButton quest2RadioButton;
        private MaterialSkin.Controls.MaterialRadioButton quest3RadioButton;
        private MaterialSkin.Controls.MaterialRadioButton quest4RadioButton;
        private MaterialSkin.Controls.MaterialRaisedButton nextRaisedButton;
    }
}