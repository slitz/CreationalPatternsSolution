namespace CreationalPatternsProject
{
    partial class restaurantMenusForm
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
            this.countryGroupBox = new System.Windows.Forms.GroupBox();
            this.unitedStatesRadioButton = new System.Windows.Forms.RadioButton();
            this.greatBritanRadioButton = new System.Windows.Forms.RadioButton();
            this.restaurantCategoryGroupBox = new System.Windows.Forms.GroupBox();
            this.allDayRadioButton = new System.Windows.Forms.RadioButton();
            this.eveningOnlyRadioButton = new System.Windows.Forms.RadioButton();
            this.dinerRadioButton = new System.Windows.Forms.RadioButton();
            this.menuFormatGroupBox = new System.Windows.Forms.GroupBox();
            this.xmlRadioButton = new System.Windows.Forms.RadioButton();
            this.htmlRadioButton = new System.Windows.Forms.RadioButton();
            this.textRadioButton = new System.Windows.Forms.RadioButton();
            this.generateMenuButton = new System.Windows.Forms.Button();
            this.countryGroupBox.SuspendLayout();
            this.restaurantCategoryGroupBox.SuspendLayout();
            this.menuFormatGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // countryGroupBox
            // 
            this.countryGroupBox.Controls.Add(this.unitedStatesRadioButton);
            this.countryGroupBox.Controls.Add(this.greatBritanRadioButton);
            this.countryGroupBox.Location = new System.Drawing.Point(38, 39);
            this.countryGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.countryGroupBox.Name = "countryGroupBox";
            this.countryGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.countryGroupBox.Size = new System.Drawing.Size(170, 171);
            this.countryGroupBox.TabIndex = 0;
            this.countryGroupBox.TabStop = false;
            this.countryGroupBox.Text = "Country";
            // 
            // unitedStatesRadioButton
            // 
            this.unitedStatesRadioButton.AutoSize = true;
            this.unitedStatesRadioButton.Location = new System.Drawing.Point(29, 95);
            this.unitedStatesRadioButton.Name = "unitedStatesRadioButton";
            this.unitedStatesRadioButton.Size = new System.Drawing.Size(113, 22);
            this.unitedStatesRadioButton.TabIndex = 1;
            this.unitedStatesRadioButton.TabStop = true;
            this.unitedStatesRadioButton.Text = "United States";
            this.unitedStatesRadioButton.UseVisualStyleBackColor = true;
            // 
            // greatBritanRadioButton
            // 
            this.greatBritanRadioButton.AutoSize = true;
            this.greatBritanRadioButton.Checked = true;
            this.greatBritanRadioButton.Location = new System.Drawing.Point(29, 54);
            this.greatBritanRadioButton.Name = "greatBritanRadioButton";
            this.greatBritanRadioButton.Size = new System.Drawing.Size(104, 22);
            this.greatBritanRadioButton.TabIndex = 0;
            this.greatBritanRadioButton.TabStop = true;
            this.greatBritanRadioButton.Text = "Great Britan";
            this.greatBritanRadioButton.UseVisualStyleBackColor = true;
            // 
            // restaurantCategoryGroupBox
            // 
            this.restaurantCategoryGroupBox.Controls.Add(this.allDayRadioButton);
            this.restaurantCategoryGroupBox.Controls.Add(this.eveningOnlyRadioButton);
            this.restaurantCategoryGroupBox.Controls.Add(this.dinerRadioButton);
            this.restaurantCategoryGroupBox.Location = new System.Drawing.Point(241, 39);
            this.restaurantCategoryGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.restaurantCategoryGroupBox.Name = "restaurantCategoryGroupBox";
            this.restaurantCategoryGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.restaurantCategoryGroupBox.Size = new System.Drawing.Size(170, 171);
            this.restaurantCategoryGroupBox.TabIndex = 1;
            this.restaurantCategoryGroupBox.TabStop = false;
            this.restaurantCategoryGroupBox.Text = "Restaurant Category";
            // 
            // allDayRadioButton
            // 
            this.allDayRadioButton.AutoSize = true;
            this.allDayRadioButton.Location = new System.Drawing.Point(29, 124);
            this.allDayRadioButton.Name = "allDayRadioButton";
            this.allDayRadioButton.Size = new System.Drawing.Size(70, 22);
            this.allDayRadioButton.TabIndex = 2;
            this.allDayRadioButton.TabStop = true;
            this.allDayRadioButton.Text = "All Day";
            this.allDayRadioButton.UseVisualStyleBackColor = true;
            // 
            // eveningOnlyRadioButton
            // 
            this.eveningOnlyRadioButton.AutoSize = true;
            this.eveningOnlyRadioButton.Location = new System.Drawing.Point(29, 82);
            this.eveningOnlyRadioButton.Name = "eveningOnlyRadioButton";
            this.eveningOnlyRadioButton.Size = new System.Drawing.Size(110, 22);
            this.eveningOnlyRadioButton.TabIndex = 1;
            this.eveningOnlyRadioButton.TabStop = true;
            this.eveningOnlyRadioButton.Text = "Evening Only";
            this.eveningOnlyRadioButton.UseVisualStyleBackColor = true;
            // 
            // dinerRadioButton
            // 
            this.dinerRadioButton.AutoSize = true;
            this.dinerRadioButton.Checked = true;
            this.dinerRadioButton.Location = new System.Drawing.Point(29, 41);
            this.dinerRadioButton.Name = "dinerRadioButton";
            this.dinerRadioButton.Size = new System.Drawing.Size(59, 22);
            this.dinerRadioButton.TabIndex = 0;
            this.dinerRadioButton.TabStop = true;
            this.dinerRadioButton.Text = "Diner";
            this.dinerRadioButton.UseVisualStyleBackColor = true;
            // 
            // menuFormatGroupBox
            // 
            this.menuFormatGroupBox.Controls.Add(this.xmlRadioButton);
            this.menuFormatGroupBox.Controls.Add(this.htmlRadioButton);
            this.menuFormatGroupBox.Controls.Add(this.textRadioButton);
            this.menuFormatGroupBox.Location = new System.Drawing.Point(444, 39);
            this.menuFormatGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.menuFormatGroupBox.Name = "menuFormatGroupBox";
            this.menuFormatGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.menuFormatGroupBox.Size = new System.Drawing.Size(170, 171);
            this.menuFormatGroupBox.TabIndex = 2;
            this.menuFormatGroupBox.TabStop = false;
            this.menuFormatGroupBox.Text = "Menu Format";
            // 
            // xmlRadioButton
            // 
            this.xmlRadioButton.AutoSize = true;
            this.xmlRadioButton.Location = new System.Drawing.Point(29, 124);
            this.xmlRadioButton.Name = "xmlRadioButton";
            this.xmlRadioButton.Size = new System.Drawing.Size(54, 22);
            this.xmlRadioButton.TabIndex = 2;
            this.xmlRadioButton.TabStop = true;
            this.xmlRadioButton.Text = "XML";
            this.xmlRadioButton.UseVisualStyleBackColor = true;
            // 
            // htmlRadioButton
            // 
            this.htmlRadioButton.AutoSize = true;
            this.htmlRadioButton.Location = new System.Drawing.Point(29, 82);
            this.htmlRadioButton.Name = "htmlRadioButton";
            this.htmlRadioButton.Size = new System.Drawing.Size(65, 22);
            this.htmlRadioButton.TabIndex = 1;
            this.htmlRadioButton.TabStop = true;
            this.htmlRadioButton.Text = "HTML";
            this.htmlRadioButton.UseVisualStyleBackColor = true;
            // 
            // textRadioButton
            // 
            this.textRadioButton.AutoSize = true;
            this.textRadioButton.Checked = true;
            this.textRadioButton.Location = new System.Drawing.Point(29, 41);
            this.textRadioButton.Name = "textRadioButton";
            this.textRadioButton.Size = new System.Drawing.Size(57, 22);
            this.textRadioButton.TabIndex = 0;
            this.textRadioButton.TabStop = true;
            this.textRadioButton.Text = "Text";
            this.textRadioButton.UseVisualStyleBackColor = true;
            // 
            // generateMenuButton
            // 
            this.generateMenuButton.Location = new System.Drawing.Point(254, 233);
            this.generateMenuButton.Name = "generateMenuButton";
            this.generateMenuButton.Size = new System.Drawing.Size(145, 35);
            this.generateMenuButton.TabIndex = 3;
            this.generateMenuButton.Text = "&Generate Menu";
            this.generateMenuButton.UseVisualStyleBackColor = true;
            this.generateMenuButton.Click += new System.EventHandler(this.generateMenuButton_Click);
            // 
            // restaurantMenusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 280);
            this.Controls.Add(this.generateMenuButton);
            this.Controls.Add(this.menuFormatGroupBox);
            this.Controls.Add(this.restaurantCategoryGroupBox);
            this.Controls.Add(this.countryGroupBox);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "restaurantMenusForm";
            this.Text = "Restaurant Menus";
            this.countryGroupBox.ResumeLayout(false);
            this.countryGroupBox.PerformLayout();
            this.restaurantCategoryGroupBox.ResumeLayout(false);
            this.restaurantCategoryGroupBox.PerformLayout();
            this.menuFormatGroupBox.ResumeLayout(false);
            this.menuFormatGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox countryGroupBox;
        private System.Windows.Forms.RadioButton unitedStatesRadioButton;
        private System.Windows.Forms.RadioButton greatBritanRadioButton;
        private System.Windows.Forms.GroupBox restaurantCategoryGroupBox;
        private System.Windows.Forms.RadioButton allDayRadioButton;
        private System.Windows.Forms.RadioButton eveningOnlyRadioButton;
        private System.Windows.Forms.RadioButton dinerRadioButton;
        private System.Windows.Forms.GroupBox menuFormatGroupBox;
        private System.Windows.Forms.RadioButton xmlRadioButton;
        private System.Windows.Forms.RadioButton htmlRadioButton;
        private System.Windows.Forms.RadioButton textRadioButton;
        private System.Windows.Forms.Button generateMenuButton;
    }
}

