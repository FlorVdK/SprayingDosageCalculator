
namespace SprayingDosageCalculator
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.agentInputTextBox = new System.Windows.Forms.TextBox();
            this.hectaresTextBox = new System.Windows.Forms.TextBox();
            this.sprayRateTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.agentOutputTextbox = new System.Windows.Forms.TextBox();
            this.waterTextbox = new System.Windows.Forms.TextBox();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "How much spraying agent per hectare will be used?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "How much hectares is going to be sprayed?\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "What is the minimum spray rate per hectare of the machine?";
            // 
            // agentInputTextBox
            // 
            this.agentInputTextBox.Location = new System.Drawing.Point(12, 27);
            this.agentInputTextBox.Name = "agentInputTextBox";
            this.agentInputTextBox.Size = new System.Drawing.Size(100, 23);
            this.agentInputTextBox.TabIndex = 3;
            this.agentInputTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.agentInputTextBox_Validating);
            // 
            // hectaresTextBox
            // 
            this.hectaresTextBox.Location = new System.Drawing.Point(12, 71);
            this.hectaresTextBox.Name = "hectaresTextBox";
            this.hectaresTextBox.Size = new System.Drawing.Size(100, 23);
            this.hectaresTextBox.TabIndex = 4;
            this.hectaresTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.hectaresTextBox_Validating);
            // 
            // sprayRateTextBox
            // 
            this.sprayRateTextBox.Location = new System.Drawing.Point(12, 115);
            this.sprayRateTextBox.Name = "sprayRateTextBox";
            this.sprayRateTextBox.Size = new System.Drawing.Size(100, 23);
            this.sprayRateTextBox.TabIndex = 5;
            this.sprayRateTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.sprayRateTextBox_Validating);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(327, 131);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Spraying agent needed in the machine:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Water needed in the machine:";
            // 
            // agentOutputTextbox
            // 
            this.agentOutputTextbox.Location = new System.Drawing.Point(12, 178);
            this.agentOutputTextbox.Name = "agentOutputTextbox";
            this.agentOutputTextbox.ReadOnly = true;
            this.agentOutputTextbox.Size = new System.Drawing.Size(100, 23);
            this.agentOutputTextbox.TabIndex = 9;
            // 
            // waterTextbox
            // 
            this.waterTextbox.Location = new System.Drawing.Point(12, 222);
            this.waterTextbox.Name = "waterTextbox";
            this.waterTextbox.ReadOnly = true;
            this.waterTextbox.Size = new System.Drawing.Size(100, 23);
            this.waterTextbox.TabIndex = 10;
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 329);
            this.Controls.Add(this.waterTextbox);
            this.Controls.Add(this.agentOutputTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.sprayRateTextBox);
            this.Controls.Add(this.hectaresTextBox);
            this.Controls.Add(this.agentInputTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "What is the minimum spray rate per hectare of the machine?";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox agentInputTextBox;
        private System.Windows.Forms.TextBox hectaresTextBox;
        private System.Windows.Forms.TextBox sprayRateTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox agentOutputTextbox;
        private System.Windows.Forms.TextBox waterTextbox;
        private System.Windows.Forms.ErrorProvider errorProviderApp;
    }
}

