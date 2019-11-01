namespace Cash_Register_Summative
{
    partial class PokeMart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokeMart));
            this.calculateTotalsButton = new System.Windows.Forms.Button();
            this.pokeballLabel = new System.Windows.Forms.Label();
            this.greatballLabel = new System.Windows.Forms.Label();
            this.ultraballLabel = new System.Windows.Forms.Label();
            this.pokeInput = new System.Windows.Forms.TextBox();
            this.greatInput = new System.Windows.Forms.TextBox();
            this.ultraInput = new System.Windows.Forms.TextBox();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.subOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculateTotalsButton
            // 
            this.calculateTotalsButton.BackColor = System.Drawing.Color.DarkRed;
            this.calculateTotalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateTotalsButton.ForeColor = System.Drawing.Color.White;
            this.calculateTotalsButton.Location = new System.Drawing.Point(69, 129);
            this.calculateTotalsButton.Name = "calculateTotalsButton";
            this.calculateTotalsButton.Size = new System.Drawing.Size(169, 23);
            this.calculateTotalsButton.TabIndex = 0;
            this.calculateTotalsButton.Text = "Calculate Totals";
            this.calculateTotalsButton.UseVisualStyleBackColor = false;
            this.calculateTotalsButton.Click += new System.EventHandler(this.CalculateTotalsButton_Click);
            // 
            // pokeballLabel
            // 
            this.pokeballLabel.Location = new System.Drawing.Point(52, 31);
            this.pokeballLabel.Name = "pokeballLabel";
            this.pokeballLabel.Size = new System.Drawing.Size(100, 23);
            this.pokeballLabel.TabIndex = 1;
            this.pokeballLabel.Text = "Pokeball";
            // 
            // greatballLabel
            // 
            this.greatballLabel.Location = new System.Drawing.Point(52, 60);
            this.greatballLabel.Name = "greatballLabel";
            this.greatballLabel.Size = new System.Drawing.Size(100, 23);
            this.greatballLabel.TabIndex = 2;
            this.greatballLabel.Text = "GreatBall";
            // 
            // ultraballLabel
            // 
            this.ultraballLabel.Location = new System.Drawing.Point(52, 92);
            this.ultraballLabel.Name = "ultraballLabel";
            this.ultraballLabel.Size = new System.Drawing.Size(100, 23);
            this.ultraballLabel.TabIndex = 3;
            this.ultraballLabel.Text = "Ultraball";
            // 
            // pokeInput
            // 
            this.pokeInput.Location = new System.Drawing.Point(138, 28);
            this.pokeInput.Name = "pokeInput";
            this.pokeInput.Size = new System.Drawing.Size(41, 20);
            this.pokeInput.TabIndex = 4;
            // 
            // greatInput
            // 
            this.greatInput.Location = new System.Drawing.Point(138, 60);
            this.greatInput.Name = "greatInput";
            this.greatInput.Size = new System.Drawing.Size(41, 20);
            this.greatInput.TabIndex = 5;
            // 
            // ultraInput
            // 
            this.ultraInput.Location = new System.Drawing.Point(138, 89);
            this.ultraInput.Name = "ultraInput";
            this.ultraInput.Size = new System.Drawing.Size(41, 20);
            this.ultraInput.TabIndex = 6;
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Location = new System.Drawing.Point(52, 166);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(53, 13);
            this.subTotalLabel.TabIndex = 7;
            this.subTotalLabel.Text = "Sub Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(52, 193);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(25, 13);
            this.taxLabel.TabIndex = 8;
            this.taxLabel.Text = "Tax";
            // 
            // subOutput
            // 
            this.subOutput.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.subOutput.Location = new System.Drawing.Point(135, 166);
            this.subOutput.Name = "subOutput";
            this.subOutput.Size = new System.Drawing.Size(100, 13);
            this.subOutput.TabIndex = 9;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.taxOutput.Location = new System.Drawing.Point(135, 193);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(100, 13);
            this.taxOutput.TabIndex = 10;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(52, 216);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total";
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.totalOutput.Location = new System.Drawing.Point(135, 216);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(100, 13);
            this.totalOutput.TabIndex = 12;
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.BackColor = System.Drawing.Color.DarkRed;
            this.printReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printReceiptButton.ForeColor = System.Drawing.Color.White;
            this.printReceiptButton.Location = new System.Drawing.Point(69, 260);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(180, 23);
            this.printReceiptButton.TabIndex = 16;
            this.printReceiptButton.Text = "Print Receipt";
            this.printReceiptButton.UseVisualStyleBackColor = false;
            this.printReceiptButton.Click += new System.EventHandler(this.PrintReceiptButton_Click);
            // 
            // PokeMart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subOutput);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.ultraInput);
            this.Controls.Add(this.greatInput);
            this.Controls.Add(this.pokeInput);
            this.Controls.Add(this.ultraballLabel);
            this.Controls.Add(this.greatballLabel);
            this.Controls.Add(this.pokeballLabel);
            this.Controls.Add(this.calculateTotalsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PokeMart";
            this.Text = "PokeMart";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateTotalsButton;
        private System.Windows.Forms.Label pokeballLabel;
        private System.Windows.Forms.Label greatballLabel;
        private System.Windows.Forms.Label ultraballLabel;
        private System.Windows.Forms.TextBox pokeInput;
        private System.Windows.Forms.TextBox greatInput;
        private System.Windows.Forms.TextBox ultraInput;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label subOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Button printReceiptButton;
    }
}

