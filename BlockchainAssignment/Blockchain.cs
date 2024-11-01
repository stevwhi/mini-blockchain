using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    internal class Blockchain
    {
        List<Block> blocks = new List<Block>();

        public List<Transaction> transactionPool = new List<Transaction>();
        
        public Blockchain() { 
            blocks.Add(new Block());
        }

        public string getBlockAsString(int index){
            if (blocks[index] != null){
                return blocks[index].ToString();
            }
            else{
                return "Block doesnt exist";
            }
            
            
        }

        public void AddTransactionToPool(Transaction transaction)
        {
            transactionPool.Add(transaction);
        }


        public override string ToString()
        {
    
            
                String output = String.Empty;
                blocks.ForEach(b => output += (b.ToString() + "\n"));
                return output;
           
        }
    }
}
