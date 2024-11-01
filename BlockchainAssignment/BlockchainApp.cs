using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockchainAssignment
{
    public partial class BlockchainApp : Form
    {
        Blockchain blockchain;

        bool walletGenerated;
        public BlockchainApp()
        {
            InitializeComponent();

            blockchain = new Blockchain();
            UpdateOutputBox("New Blockchain Initialized!");


            this.walletGenerated = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void UpdateOutputBox(String text)
        {
            outputBox.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 0;
            if(Int32.TryParse(textBox1.Text, out index)){
                outputBox.Text = blockchain.getBlockAsString(index);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            String privKey;
            Wallet.Wallet myNewWallet = new Wallet.Wallet(out privKey);
            publicKeyTextBox.Text = myNewWallet.publicID;
            privateKeyTextBox.Text = privKey;

            walletGenerated = true;

        }

        private void label1_Click(object sender, EventArgs e) { }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Wallet.Wallet.ValidatePrivateKey(privateKeyTextBox.Text, publicKeyTextBox.Text)){
                outputBox.Text = "Keys are valid.";

            } else{
                outputBox.Text = "Keys are invalid.";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if(walletGenerated == true)
            {
                double amount;
                double fee;
                String senderAddress;
                String receiverAddress;
                String privateKey;
                string amountText = amountTextBox.Text;
                string feeText = feeTextBox.Text;

                if (!double.TryParse(amountText, out amount))
                {
                    outputBox.Text = "Invalid amount. Please enter a valid number.";
                    return;
                }

                if (!double.TryParse(feeText, out fee))
                {
                    outputBox.Text = "Invalid fee. Please enter a valid number.";
                    return;
                }

                senderAddress = publicKeyTextBox.Text; //where do i get this from?
                receiverAddress = receiverKeyTextBox.Text; //where do i get this from?
                privateKey = privateKeyTextBox.Text; //what is this?
                Transaction transaction = new Transaction(senderAddress, receiverAddress, amount, fee, privateKey);
                blockchain.AddTransactionToPool(transaction);

                outputBox.Text = transaction.ToString();
            }
            else if(walletGenerated == false)
            {
                outputBox.Text = "Wallet not generated.";

            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
