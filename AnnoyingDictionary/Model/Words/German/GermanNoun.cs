using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnoyingDictionary.Model.German
{
    public class GermanNoun : Word
    {
        #region Fields

        private Gender gender;
        private string plaural;

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Plaural
        {
            get { return plaural; }
            set { plaural = value; }
        }

        #endregion

        public GermanNoun(string word, string translation, Gender gender, string plaural)
            : base(word, translation, Language.GERMAN, Type.NOUN)
        {
            this.gender = gender;
            this.plaural = plaural;
        }

        #region Properties

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Plaural
        {
            get { return plaural == null ? String.Empty : plaural; }
            set { plaural = value; }
        }

        #endregion

    }
}
