using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnoyingDictionary.Model.German
{
    public class GermanOther : Word
    {
        public GermanOther(string word, string translation)
            : base(word, translation, Language.GERMAN, Type.OTHER)
        {
        }
    }
}
