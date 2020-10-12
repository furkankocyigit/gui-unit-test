namespace ExampleUIDesignPatterns
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageNaive = new System.Windows.Forms.TabPage();
            this.calculatorNaive1 = new ExampleUIDesignPatterns.CalculatorNaive();
            this.tabPageMVP = new System.Windows.Forms.TabPage();
            this.calculatorMVP1 = new ExampleUIDesignPatterns.CalculatorMVPView();
            this.tabPageMVVM = new System.Windows.Forms.TabPage();
            this.calculatorMVVMView1 = new ExampleUIDesignPatterns.CalculatorMVVMView();
            this.tabControl1.SuspendLayout();
            this.tabPageNaive.SuspendLayout();
            this.tabPageMVP.SuspendLayout();
            this.tabPageMVVM.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageNaive);
            this.tabControl1.Controls.Add(this.tabPageMVP);
            this.tabControl1.Controls.Add(this.tabPageMVVM);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(547, 454);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageNaive
            // 
            this.tabPageNaive.Controls.Add(this.calculatorNaive1);
            this.tabPageNaive.Location = new System.Drawing.Point(4, 22);
            this.tabPageNaive.Name = "tabPageNaive";
            this.tabPageNaive.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNaive.Size = new System.Drawing.Size(539, 428);
            this.tabPageNaive.TabIndex = 2;
            this.tabPageNaive.Text = "Naive";
            this.tabPageNaive.UseVisualStyleBackColor = true;
            // 
            // calculatorNaive1
            // 
            this.calculatorNaive1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculatorNaive1.Location = new System.Drawing.Point(3, 3);
            this.calculatorNaive1.Name = "calculatorNaive1";
            this.calculatorNaive1.Size = new System.Drawing.Size(533, 422);
            this.calculatorNaive1.TabIndex = 0;
            // 
            // tabPageMVP
            // 
            this.tabPageMVP.Controls.Add(this.calculatorMVP1);
            this.tabPageMVP.Location = new System.Drawing.Point(4, 22);
            this.tabPageMVP.Name = "tabPageMVP";
            this.tabPageMVP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMVP.Size = new System.Drawing.Size(539, 428);
            this.tabPageMVP.TabIndex = 1;
            this.tabPageMVP.Text = "Model-View-Presenter";
            this.tabPageMVP.UseVisualStyleBackColor = true;
            // 
            // calculatorMVP1
            // 
            this.calculatorMVP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculatorMVP1.Location = new System.Drawing.Point(3, 3);
            this.calculatorMVP1.Name = "calculatorMVP1";
            this.calculatorMVP1.Size = new System.Drawing.Size(533, 422);
            this.calculatorMVP1.TabIndex = 0;
            // 
            // tabPageMVVM
            // 
            this.tabPageMVVM.Controls.Add(this.calculatorMVVMView1);
            this.tabPageMVVM.Location = new System.Drawing.Point(4, 22);
            this.tabPageMVVM.Name = "tabPageMVVM";
            this.tabPageMVVM.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMVVM.Size = new System.Drawing.Size(539, 428);
            this.tabPageMVVM.TabIndex = 0;
            this.tabPageMVVM.Text = "Mode-View-ViewModel";
            this.tabPageMVVM.UseVisualStyleBackColor = true;
            // 
            // calculatorMVVMView1
            // 
            this.calculatorMVVMView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculatorMVVMView1.Location = new System.Drawing.Point(3, 3);
            this.calculatorMVVMView1.Name = "calculatorMVVMView1";
            this.calculatorMVVMView1.Size = new System.Drawing.Size(533, 422);
            this.calculatorMVVMView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 454);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageNaive.ResumeLayout(false);
            this.tabPageMVP.ResumeLayout(false);
            this.tabPageMVVM.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMVVM;
        private System.Windows.Forms.TabPage tabPageMVP;
        private System.Windows.Forms.TabPage tabPageNaive;
        private CalculatorNaive calculatorNaive1;
        private CalculatorMVVMView calculatorMVVMView1;
        public CalculatorMVPView calculatorMVP1;
    }
}

