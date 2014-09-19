namespace WindowsFormsControlLibrary1
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TagTxt = new System.Windows.Forms.TextBox();
            this.RegisterTxt = new System.Windows.Forms.TextBox();
            this.ValueTxt = new System.Windows.Forms.TextBox();
            this.SetButton = new System.Windows.Forms.Button();
            this.NoTxt = new System.Windows.Forms.TextBox();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TagTxt
            // 
            this.TagTxt.Location = new System.Drawing.Point(40, 5);
            this.TagTxt.Name = "TagTxt";
            this.TagTxt.ReadOnly = true;
            this.TagTxt.Size = new System.Drawing.Size(100, 20);
            this.TagTxt.TabIndex = 0;
            // 
            // RegisterTxt
            // 
            this.RegisterTxt.Location = new System.Drawing.Point(147, 5);
            this.RegisterTxt.Name = "RegisterTxt";
            this.RegisterTxt.ReadOnly = true;
            this.RegisterTxt.Size = new System.Drawing.Size(100, 20);
            this.RegisterTxt.TabIndex = 1;
            // 
            // ValueTxt
            // 
            this.ValueTxt.Location = new System.Drawing.Point(254, 5);
            this.ValueTxt.Name = "ValueTxt";
            this.ValueTxt.Size = new System.Drawing.Size(65, 20);
            this.ValueTxt.TabIndex = 2;
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(324, 4);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(66, 23);
            this.SetButton.TabIndex = 3;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // NoTxt
            // 
            this.NoTxt.Location = new System.Drawing.Point(3, 5);
            this.NoTxt.Name = "NoTxt";
            this.NoTxt.ReadOnly = true;
            this.NoTxt.Size = new System.Drawing.Size(31, 20);
            this.NoTxt.TabIndex = 4;
            // 
            // Btn0
            // 
            this.Btn0.Location = new System.Drawing.Point(396, 4);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(33, 23);
            this.Btn0.TabIndex = 5;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(435, 4);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(42, 23);
            this.Btn5.TabIndex = 6;
            this.Btn5.Text = "5000";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(483, 3);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(50, 23);
            this.Btn1.TabIndex = 7;
            this.Btn1.Text = "10000";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.NoTxt);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.ValueTxt);
            this.Controls.Add(this.RegisterTxt);
            this.Controls.Add(this.TagTxt);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(536, 33);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TagTxt;
        private System.Windows.Forms.TextBox RegisterTxt;
        private System.Windows.Forms.TextBox ValueTxt;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.TextBox NoTxt;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn1;
    }
}
