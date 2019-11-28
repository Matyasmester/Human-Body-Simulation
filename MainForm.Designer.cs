namespace Human_Body_Simulation_GUI
{
    partial class MainForm
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
            this.GeneralStatusBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HasEatenBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HasDrunkBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EatButton = new System.Windows.Forms.Button();
            this.DrinkButton = new System.Windows.Forms.Button();
            this.timerBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.setHungryButton = new System.Windows.Forms.Button();
            this.setThirstyButton = new System.Windows.Forms.Button();
            this.isFunctionalBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.organFailureButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GeneralStatusBox
            // 
            this.GeneralStatusBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GeneralStatusBox.Location = new System.Drawing.Point(289, 397);
            this.GeneralStatusBox.Name = "GeneralStatusBox";
            this.GeneralStatusBox.ReadOnly = true;
            this.GeneralStatusBox.Size = new System.Drawing.Size(222, 41);
            this.GeneralStatusBox.TabIndex = 0;
            this.GeneralStatusBox.Text = "";
            this.GeneralStatusBox.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "General Statuses:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // HasEatenBox
            // 
            this.HasEatenBox.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HasEatenBox.Location = new System.Drawing.Point(12, 57);
            this.HasEatenBox.Name = "HasEatenBox";
            this.HasEatenBox.ReadOnly = true;
            this.HasEatenBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.HasEatenBox.Size = new System.Drawing.Size(104, 41);
            this.HasEatenBox.TabIndex = 2;
            this.HasEatenBox.Text = "";
            this.HasEatenBox.TextChanged += new System.EventHandler(this.HasEatenBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Is human hungry";
            // 
            // HasDrunkBox
            // 
            this.HasDrunkBox.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HasDrunkBox.Location = new System.Drawing.Point(12, 176);
            this.HasDrunkBox.Name = "HasDrunkBox";
            this.HasDrunkBox.ReadOnly = true;
            this.HasDrunkBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.HasDrunkBox.Size = new System.Drawing.Size(104, 39);
            this.HasDrunkBox.TabIndex = 4;
            this.HasDrunkBox.Text = "";
            this.HasDrunkBox.TextChanged += new System.EventHandler(this.HasDrunkBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Is human thristy:";
            // 
            // EatButton
            // 
            this.EatButton.Location = new System.Drawing.Point(152, 57);
            this.EatButton.Name = "EatButton";
            this.EatButton.Size = new System.Drawing.Size(75, 41);
            this.EatButton.TabIndex = 6;
            this.EatButton.Text = "Eat";
            this.EatButton.UseVisualStyleBackColor = true;
            this.EatButton.Click += new System.EventHandler(this.EatButton_Click);
            // 
            // DrinkButton
            // 
            this.DrinkButton.Location = new System.Drawing.Point(152, 176);
            this.DrinkButton.Name = "DrinkButton";
            this.DrinkButton.Size = new System.Drawing.Size(75, 39);
            this.DrinkButton.TabIndex = 7;
            this.DrinkButton.Text = "Drink";
            this.DrinkButton.UseVisualStyleBackColor = true;
            this.DrinkButton.Click += new System.EventHandler(this.DrinkButton_Click);
            // 
            // timerBox
            // 
            this.timerBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timerBox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timerBox.Location = new System.Drawing.Point(609, 67);
            this.timerBox.Multiline = false;
            this.timerBox.Name = "timerBox";
            this.timerBox.ReadOnly = true;
            this.timerBox.Size = new System.Drawing.Size(73, 31);
            this.timerBox.TabIndex = 8;
            this.timerBox.Text = "";
            this.timerBox.TextChanged += new System.EventHandler(this.TimerBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Timer (Minutes):";
            // 
            // setHungryButton
            // 
            this.setHungryButton.Location = new System.Drawing.Point(260, 57);
            this.setHungryButton.Name = "setHungryButton";
            this.setHungryButton.Size = new System.Drawing.Size(75, 41);
            this.setHungryButton.TabIndex = 10;
            this.setHungryButton.Text = "Set Hungry";
            this.setHungryButton.UseVisualStyleBackColor = true;
            this.setHungryButton.Click += new System.EventHandler(this.SetHungryButton_Click);
            // 
            // setThirstyButton
            // 
            this.setThirstyButton.Location = new System.Drawing.Point(260, 176);
            this.setThirstyButton.Name = "setThirstyButton";
            this.setThirstyButton.Size = new System.Drawing.Size(75, 39);
            this.setThirstyButton.TabIndex = 11;
            this.setThirstyButton.Text = "Set Thirsty";
            this.setThirstyButton.UseVisualStyleBackColor = true;
            this.setThirstyButton.Click += new System.EventHandler(this.SetThirstyButton_Click);
            // 
            // isFunctionalBox
            // 
            this.isFunctionalBox.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.isFunctionalBox.Location = new System.Drawing.Point(12, 306);
            this.isFunctionalBox.Name = "isFunctionalBox";
            this.isFunctionalBox.ReadOnly = true;
            this.isFunctionalBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.isFunctionalBox.Size = new System.Drawing.Size(104, 39);
            this.isFunctionalBox.TabIndex = 12;
            this.isFunctionalBox.Text = "";
            this.isFunctionalBox.TextChanged += new System.EventHandler(this.IsFunctionalBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Is brain functional:";
            // 
            // organFailureButton
            // 
            this.organFailureButton.Location = new System.Drawing.Point(152, 306);
            this.organFailureButton.Name = "organFailureButton";
            this.organFailureButton.Size = new System.Drawing.Size(183, 39);
            this.organFailureButton.TabIndex = 14;
            this.organFailureButton.Text = "Set Organ Failure";
            this.organFailureButton.UseVisualStyleBackColor = true;
            this.organFailureButton.Click += new System.EventHandler(this.OrganFailureButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.organFailureButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.isFunctionalBox);
            this.Controls.Add(this.setThirstyButton);
            this.Controls.Add(this.setHungryButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timerBox);
            this.Controls.Add(this.DrinkButton);
            this.Controls.Add(this.EatButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HasDrunkBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HasEatenBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GeneralStatusBox);
            this.Name = "MainForm";
            this.Text = "Human Body Simulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox GeneralStatusBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox HasEatenBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox HasDrunkBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EatButton;
        private System.Windows.Forms.Button DrinkButton;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.RichTextBox timerBox;
        private System.Windows.Forms.Button setHungryButton;
        private System.Windows.Forms.Button setThirstyButton;
        private System.Windows.Forms.RichTextBox isFunctionalBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button organFailureButton;
    }
}

