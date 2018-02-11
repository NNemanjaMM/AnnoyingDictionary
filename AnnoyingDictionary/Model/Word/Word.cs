using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnoyingDictionary.Model
{
    public enum Language { GERMAN }
    public enum Type { NOUN, VERB, ADJECTIVE, PRONOUN, NUMBER, OTHER }
    public enum Gender { MASCULINE, FEMININE, NEUTER, PLURAL }

    public abstract class Word
    {
        #region Fields

        private string word;
        private string translation;
        private Language language;
        private Type type;

        #endregion

        public Word(string word, string translation, Language language, Type type)
        {
            this.word = word;
            this.translation = translation;
            this.language = language;
            this.type = type;
        }

        #region Properties

        public string Word
        {
            get { return word; }
            set { word = value; }
        }

        public string Translation
        {
            get { return translation; }
            set { translation = value; }
        }

        public Language Language
        {
            get { return language; }
            set { language = value; }
        }

        public Type Type
        {
            get { return type; }
            set { type = value; }
        }

        #endregion

    }
}
