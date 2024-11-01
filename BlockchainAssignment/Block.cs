using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    internal class Block
    {
        DateTime timestamp;
        public int index;
        public string hash;
        string prevHash;

       

        public Block(){
            this.timestamp = DateTime.Now;
            this.index = 0;
            this.prevHash = null;
            this.hash = createHash();
        }
        public Block(int index, string prevHash) { 
            this.timestamp = DateTime.Now;
            this.index = index + 1;
            this.prevHash = String.Empty;
            this.hash= createHash();
        }

        public Block(Block lastBlock, List<Transaction> transactionList)
        {
            this.timestamp = DateTime.Now;
            this.index = lastBlock.index + 1;
            this.prevHash = lastBlock.hash;

           

            this.hash = createHash();
            
        }

        public string createHash() {
            SHA256 hasher = SHA256Managed.Create();
            String input = index.ToString() + timestamp.ToString() + prevHash;
            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
            String hash = string.Empty;
            foreach (byte x in hashByte)
                hash += String.Format("{0:x2}", x);
            return hash;
        }

        public override string ToString()
        {
            return "Index: " + index.ToString()
                + "\n" + "Timestamp: " + timestamp.ToString()
                + "\n" + "Previous Hash: " + prevHash
                + "\n" + "Hash: " + hash +"\n";
        }

    }
}
