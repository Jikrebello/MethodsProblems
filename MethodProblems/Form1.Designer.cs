
namespace MethodProblems
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
            this.BtnVolume = new System.Windows.Forms.Button();
            this.BtnEvenOrOdd = new System.Windows.Forms.Button();
            this.BtnRemainder = new System.Windows.Forms.Button();
            this.BtnCubeRoot = new System.Windows.Forms.Button();
            this.BtnMailCostCalculator = new System.Windows.Forms.Button();
            this.BtnDiceRoll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVolume
            // 
            this.BtnVolume.Location = new System.Drawing.Point(12, 12);
            this.BtnVolume.Name = "BtnVolume";
            this.BtnVolume.Size = new System.Drawing.Size(204, 45);
            this.BtnVolume.TabIndex = 0;
            this.BtnVolume.Text = "Volume of a Box";
            this.BtnVolume.UseVisualStyleBackColor = true;
            this.BtnVolume.Click += new System.EventHandler(this.BtnVolume_Click);
            // 
            // BtnEvenOrOdd
            // 
            this.BtnEvenOrOdd.Location = new System.Drawing.Point(12, 63);
            this.BtnEvenOrOdd.Name = "BtnEvenOrOdd";
            this.BtnEvenOrOdd.Size = new System.Drawing.Size(204, 45);
            this.BtnEvenOrOdd.TabIndex = 1;
            this.BtnEvenOrOdd.Text = "Even Or Odd";
            this.BtnEvenOrOdd.UseVisualStyleBackColor = true;
            this.BtnEvenOrOdd.Click += new System.EventHandler(this.BtnEvenOrOdd_Click);
            // 
            // BtnRemainder
            // 
            this.BtnRemainder.Location = new System.Drawing.Point(12, 114);
            this.BtnRemainder.Name = "BtnRemainder";
            this.BtnRemainder.Size = new System.Drawing.Size(204, 45);
            this.BtnRemainder.TabIndex = 2;
            this.BtnRemainder.Text = "Remainder Calculator";
            this.BtnRemainder.UseVisualStyleBackColor = true;
            this.BtnRemainder.Click += new System.EventHandler(this.BtnRemainder_Click);
            // 
            // BtnCubeRoot
            // 
            this.BtnCubeRoot.Location = new System.Drawing.Point(12, 165);
            this.BtnCubeRoot.Name = "BtnCubeRoot";
            this.BtnCubeRoot.Size = new System.Drawing.Size(204, 45);
            this.BtnCubeRoot.TabIndex = 3;
            this.BtnCubeRoot.Text = "Cube Root Calculator";
            this.BtnCubeRoot.UseVisualStyleBackColor = true;
            this.BtnCubeRoot.Click += new System.EventHandler(this.BtnCubeRoot_Click);
            // 
            // BtnMailCostCalculator
            // 
            this.BtnMailCostCalculator.Location = new System.Drawing.Point(12, 216);
            this.BtnMailCostCalculator.Name = "BtnMailCostCalculator";
            this.BtnMailCostCalculator.Size = new System.Drawing.Size(204, 45);
            this.BtnMailCostCalculator.TabIndex = 4;
            this.BtnMailCostCalculator.Text = "Mail Cost Calculator";
            this.BtnMailCostCalculator.UseVisualStyleBackColor = true;
            this.BtnMailCostCalculator.Click += new System.EventHandler(this.BtnMailCostCalculator_Click);
            // 
            // BtnDiceRoll
            // 
            this.BtnDiceRoll.Location = new System.Drawing.Point(12, 267);
            this.BtnDiceRoll.Name = "BtnDiceRoll";
            this.BtnDiceRoll.Size = new System.Drawing.Size(204, 45);
            this.BtnDiceRoll.TabIndex = 5;
            this.BtnDiceRoll.Text = "Dice Roll";
            this.BtnDiceRoll.UseVisualStyleBackColor = true;
            this.BtnDiceRoll.Click += new System.EventHandler(this.BtnDiceRoll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 321);
            this.Controls.Add(this.BtnDiceRoll);
            this.Controls.Add(this.BtnMailCostCalculator);
            this.Controls.Add(this.BtnCubeRoot);
            this.Controls.Add(this.BtnRemainder);
            this.Controls.Add(this.BtnEvenOrOdd);
            this.Controls.Add(this.BtnVolume);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVolume;
        private System.Windows.Forms.Button BtnEvenOrOdd;
        private System.Windows.Forms.Button BtnRemainder;
        private System.Windows.Forms.Button BtnCubeRoot;
        private System.Windows.Forms.Button BtnMailCostCalculator;
        private System.Windows.Forms.Button BtnDiceRoll;
    }
}

