namespace BlockchainAssignment
{
    partial class BlockchainApp
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
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.createTransactionButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.feeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.receiverKeyTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.privateKeyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.publicKeyTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.printBlockButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.outputBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputBox.Location = new System.Drawing.Point(24, 23);
            this.outputBox.Margin = new System.Windows.Forms.Padding(6);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(1310, 600);
            this.outputBox.TabIndex = 0;
            this.outputBox.Text = "";
            this.outputBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // createTransactionButton
            // 
            this.createTransactionButton.Location = new System.Drawing.Point(38, 825);
            this.createTransactionButton.Name = "createTransactionButton";
            this.createTransactionButton.Size = new System.Drawing.Size(185, 88);
            this.createTransactionButton.TabIndex = 9;
            this.createTransactionButton.Text = "Create Transaction";
            this.createTransactionButton.UseVisualStyleBackColor = true;
            this.createTransactionButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 885);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "fee";
            // 
            // feeTextBox
            // 
            this.feeTextBox.Location = new System.Drawing.Point(377, 882);
            this.feeTextBox.Name = "feeTextBox";
            this.feeTextBox.Size = new System.Drawing.Size(149, 31);
            this.feeTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 830);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "amount";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(377, 825);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(149, 31);
            this.amountTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(595, 891);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "receiver key";
            // 
            // receiverKeyTextBox
            // 
            this.receiverKeyTextBox.Location = new System.Drawing.Point(739, 885);
            this.receiverKeyTextBox.Name = "receiverKeyTextBox";
            this.receiverKeyTextBox.Size = new System.Drawing.Size(394, 31);
            this.receiverKeyTextBox.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1164, 780);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 95);
            this.button3.TabIndex = 8;
            this.button3.Text = "Validate Keys";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1164, 653);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 95);
            this.button2.TabIndex = 7;
            this.button2.Text = "Generate Wallet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 720);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Private Key";
            // 
            // privateKeyTextBox
            // 
            this.privateKeyTextBox.Location = new System.Drawing.Point(739, 717);
            this.privateKeyTextBox.Name = "privateKeyTextBox";
            this.privateKeyTextBox.Size = new System.Drawing.Size(394, 31);
            this.privateKeyTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 653);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Public Key";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // publicKeyTextBox
            // 
            this.publicKeyTextBox.Location = new System.Drawing.Point(739, 653);
            this.publicKeyTextBox.Name = "publicKeyTextBox";
            this.publicKeyTextBox.Size = new System.Drawing.Size(394, 31);
            this.publicKeyTextBox.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 662);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 31);
            this.textBox1.TabIndex = 2;
            // 
            // printBlockButton
            // 
            this.printBlockButton.Location = new System.Drawing.Point(38, 653);
            this.printBlockButton.Name = "printBlockButton";
            this.printBlockButton.Size = new System.Drawing.Size(185, 48);
            this.printBlockButton.TabIndex = 1;
            this.printBlockButton.Text = "PRINT BLOCK";
            this.printBlockButton.UseVisualStyleBackColor = true;
            this.printBlockButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1362, 925);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.receiverKeyTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.feeTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.createTransactionButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.privateKeyTextBox);
            this.Controls.Add(this.publicKeyTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.printBlockButton);
            this.Controls.Add(this.outputBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BlockchainApp";
            this.Text = "Blockchain App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Button createTransactionButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox feeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox receiverKeyTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox privateKeyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox publicKeyTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button printBlockButton;
    }
}

