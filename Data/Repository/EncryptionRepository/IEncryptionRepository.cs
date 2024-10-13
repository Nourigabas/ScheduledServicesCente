using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.EncryptionRepository
{
    public interface IEncryptionRepository
    {
        string Encryption(string plaintext);
        string Decryption(string cipher);
    }
}
