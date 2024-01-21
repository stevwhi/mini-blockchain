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
    }
}
