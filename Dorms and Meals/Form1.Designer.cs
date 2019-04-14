namespace Dorm_and_Meals
{
    partial class Form1
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
            this.lstDorms = new System.Windows.Forms.ListBox();
            this.radSeven = new System.Windows.Forms.RadioButton();
            this.rdbFourteen = new System.Windows.Forms.RadioButton();
            this.rdbUnlimited = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDorms
            // 
            this.lstDorms.FormattingEnabled = true;
            this.lstDorms.Location = new System.Drawing.Point(70, 71);
            this.lstDorms.Name = "lstDorms";
            this.lstDorms.Size = new System.Drawing.Size(373, 199);
            this.lstDorms.TabIndex = 0;
            this.lstDorms.SelectedIndexChanged += new System.EventHandler(this.lstDorms_SelectedIndexChanged);
            // 
            // radSeven
            // 
            this.radSeven.AutoSize = true;
            this.radSeven.Location = new System.Drawing.Point(81, 300);
            this.radSeven.Name = "radSeven";
            this.radSeven.Size = new System.Drawing.Size(56, 17);
            this.radSeven.TabIndex = 1;
            this.radSeven.TabStop = true;
            this.radSeven.Text = "Seven";
            this.radSeven.UseVisualStyleBackColor = true;
            // 
            // rdbFourteen
            // 
            this.rdbFourteen.AutoSize = true;
            this.rdbFourteen.Location = new System.Drawing.Point(81, 342);
            this.rdbFourteen.Name = "rdbFourteen";
            this.rdbFourteen.Size = new System.Drawing.Size(67, 17);
            this.rdbFourteen.TabIndex = 2;
            this.rdbFourteen.TabStop = true;
            this.rdbFourteen.Text = "Fourteen";
            this.rdbFourteen.UseVisualStyleBackColor = true;
            // 
            // rdbUnlimited
            // 
            this.rdbUnlimited.AutoSize = true;
            this.rdbUnlimited.Location = new System.Drawing.Point(81, 386);
            this.rdbUnlimited.Name = "rdbUnlimited";
            this.rdbUnlimited.Size = new System.Drawing.Size(68, 17);
            this.rdbUnlimited.TabIndex = 3;
            this.rdbUnlimited.TabStop = true;
            this.rdbUnlimited.Text = "Unlimited";
            this.rdbUnlimited.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(302, 354);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 520);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rdbUnlimited);
            this.Controls.Add(this.rdbFourteen);
            this.Controls.Add(this.radSeven);
            this.Controls.Add(this.lstDorms);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDorms;
        private System.Windows.Forms.RadioButton radSeven;
        private System.Windows.Forms.RadioButton rdbFourteen;
        private System.Windows.Forms.RadioButton rdbUnlimited;
        private System.Windows.Forms.Button btnCalculate;
    }
}

