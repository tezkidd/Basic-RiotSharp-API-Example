namespace Riot_API
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.DragControl = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.controlBox = new Siticone.UI.WinForms.SiticoneControlBox();
            this.Region_ComboBox = new Siticone.UI.WinForms.SiticoneComboBox();
            this.Information_GroupBox = new Siticone.UI.WinForms.SiticoneGroupBox();
            this.siticoneLabel2 = new Siticone.UI.WinForms.SiticoneLabel();
            this.Elipse = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.DragControl2 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.Search_TextBox = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.Search_Button = new Siticone.UI.WinForms.SiticoneButton();
            this.Information_ListBox = new System.Windows.Forms.ListBox();
            this.DragControl3 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.AnimateWindow = new Siticone.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.Information_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this;
            // 
            // controlBox
            // 
            this.controlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBox.BorderRadius = 5;
            this.controlBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.controlBox.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.controlBox.HoveredState.IconColor = System.Drawing.Color.White;
            this.controlBox.HoveredState.Parent = this.controlBox;
            this.controlBox.IconColor = System.Drawing.Color.White;
            this.controlBox.Location = new System.Drawing.Point(379, 6);
            this.controlBox.Name = "controlBox";
            this.controlBox.ShadowDecoration.Parent = this.controlBox;
            this.controlBox.Size = new System.Drawing.Size(32, 27);
            this.controlBox.TabIndex = 49;
            this.controlBox.TabStop = false;
            // 
            // Region_ComboBox
            // 
            this.Region_ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.Region_ComboBox.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Region_ComboBox.BorderRadius = 3;
            this.Region_ComboBox.DisplayMember = "Euw";
            this.Region_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Region_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Region_ComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.Region_ComboBox.FocusedColor = System.Drawing.Color.DodgerBlue;
            this.Region_ComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Region_ComboBox.ForeColor = System.Drawing.Color.White;
            this.Region_ComboBox.FormattingEnabled = true;
            this.Region_ComboBox.HoveredState.BorderColor = System.Drawing.Color.White;
            this.Region_ComboBox.HoveredState.Parent = this.Region_ComboBox;
            this.Region_ComboBox.ItemHeight = 30;
            this.Region_ComboBox.Items.AddRange(new object[] {
            "Euw"});
            this.Region_ComboBox.ItemsAppearance.Parent = this.Region_ComboBox;
            this.Region_ComboBox.Location = new System.Drawing.Point(11, 42);
            this.Region_ComboBox.Name = "Region_ComboBox";
            this.Region_ComboBox.ShadowDecoration.Parent = this.Region_ComboBox;
            this.Region_ComboBox.Size = new System.Drawing.Size(397, 36);
            this.Region_ComboBox.StartIndex = 0;
            this.Region_ComboBox.TabIndex = 53;
            this.Region_ComboBox.TabStop = false;
            // 
            // Information_GroupBox
            // 
            this.Information_GroupBox.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Information_GroupBox.BorderRadius = 3;
            this.Information_GroupBox.Controls.Add(this.Information_ListBox);
            this.Information_GroupBox.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.Information_GroupBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.Information_GroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Information_GroupBox.ForeColor = System.Drawing.Color.White;
            this.Information_GroupBox.Location = new System.Drawing.Point(11, 126);
            this.Information_GroupBox.Name = "Information_GroupBox";
            this.Information_GroupBox.ShadowDecoration.Parent = this.Information_GroupBox;
            this.Information_GroupBox.Size = new System.Drawing.Size(397, 387);
            this.Information_GroupBox.TabIndex = 55;
            this.Information_GroupBox.TabStop = false;
            this.Information_GroupBox.Text = "Information";
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel2.Location = new System.Drawing.Point(11, 11);
            this.siticoneLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(161, 17);
            this.siticoneLabel2.TabIndex = 54;
            this.siticoneLabel2.TabStop = false;
            this.siticoneLabel2.Text = "Basic RiotSharp API Example";
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 4;
            this.Elipse.TargetControl = this;
            // 
            // DragControl2
            // 
            this.DragControl2.TargetControl = this.Information_ListBox;
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Search_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search_TextBox.DefaultText = "Summoner Name";
            this.Search_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Search_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Search_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_TextBox.DisabledState.Parent = this.Search_TextBox;
            this.Search_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.Search_TextBox.FocusedState.BorderColor = System.Drawing.Color.White;
            this.Search_TextBox.FocusedState.Parent = this.Search_TextBox;
            this.Search_TextBox.ForeColor = System.Drawing.Color.White;
            this.Search_TextBox.HoveredState.BorderColor = System.Drawing.Color.White;
            this.Search_TextBox.HoveredState.Parent = this.Search_TextBox;
            this.Search_TextBox.Location = new System.Drawing.Point(11, 84);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.PasswordChar = '\0';
            this.Search_TextBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.Search_TextBox.PlaceholderText = "Summoner Name";
            this.Search_TextBox.SelectedText = "";
            this.Search_TextBox.ShadowDecoration.Parent = this.Search_TextBox;
            this.Search_TextBox.Size = new System.Drawing.Size(200, 36);
            this.Search_TextBox.TabIndex = 56;
            this.Search_TextBox.TabStop = false;
            // 
            // Search_Button
            // 
            this.Search_Button.BorderRadius = 3;
            this.Search_Button.CheckedState.Parent = this.Search_Button;
            this.Search_Button.CustomImages.Parent = this.Search_Button;
            this.Search_Button.FillColor = System.Drawing.Color.DodgerBlue;
            this.Search_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Search_Button.ForeColor = System.Drawing.Color.White;
            this.Search_Button.HoveredState.Parent = this.Search_Button;
            this.Search_Button.Location = new System.Drawing.Point(217, 84);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.ShadowDecoration.Parent = this.Search_Button;
            this.Search_Button.Size = new System.Drawing.Size(188, 36);
            this.Search_Button.TabIndex = 57;
            this.Search_Button.Text = "Search";
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Information_ListBox
            // 
            this.Information_ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.Information_ListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Information_ListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Information_ListBox.ForeColor = System.Drawing.Color.White;
            this.Information_ListBox.FormattingEnabled = true;
            this.Information_ListBox.ItemHeight = 15;
            this.Information_ListBox.Location = new System.Drawing.Point(3, 42);
            this.Information_ListBox.Name = "Information_ListBox";
            this.Information_ListBox.Size = new System.Drawing.Size(391, 330);
            this.Information_ListBox.TabIndex = 0;
            // 
            // DragControl3
            // 
            this.DragControl3.TargetControl = this.Information_GroupBox;
            // 
            // AnimateWindow
            // 
            this.AnimateWindow.AnimationType = Siticone.UI.WinForms.SiticoneAnimateWindow.AnimateWindowType.AW_BLEND;
            this.AnimateWindow.Interval = 250;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(417, 525);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Search_TextBox);
            this.Controls.Add(this.Information_GroupBox);
            this.Controls.Add(this.siticoneLabel2);
            this.Controls.Add(this.Region_ComboBox);
            this.Controls.Add(this.controlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Information_GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.UI.WinForms.SiticoneDragControl DragControl;
        private Siticone.UI.WinForms.SiticoneControlBox controlBox;
        private Siticone.UI.WinForms.SiticoneGroupBox Information_GroupBox;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;
        private Siticone.UI.WinForms.SiticoneComboBox Region_ComboBox;
        private Siticone.UI.WinForms.SiticoneElipse Elipse;
        private Siticone.UI.WinForms.SiticoneDragControl DragControl2;
        private Siticone.UI.WinForms.SiticoneButton Search_Button;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox Search_TextBox;
        private System.Windows.Forms.ListBox Information_ListBox;
        private Siticone.UI.WinForms.SiticoneDragControl DragControl3;
        private Siticone.UI.WinForms.SiticoneAnimateWindow AnimateWindow;
    }
}

