namespace PortfolioU10787
{
    partial class IMSolver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMSolver));
            this.tabControlMathSolver = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlMathSolver.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMathSolver
            // 
            this.tabControlMathSolver.Controls.Add(this.tabPage1);
            this.tabControlMathSolver.Controls.Add(this.tabPage2);
            this.tabControlMathSolver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMathSolver.Location = new System.Drawing.Point(0, 0);
            this.tabControlMathSolver.Name = "tabControlMathSolver";
            this.tabControlMathSolver.SelectedIndex = 0;
            this.tabControlMathSolver.Size = new System.Drawing.Size(650, 345);
            this.tabControlMathSolver.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(642, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GCD";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(403, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LCM";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // IMSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 345);
            this.Controls.Add(this.tabControlMathSolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IMSolver";
            this.Text = "Interactive Math Solver";
            this.tabControlMathSolver.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMathSolver;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

