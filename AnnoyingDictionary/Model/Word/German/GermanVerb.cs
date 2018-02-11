using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnoyingDictionary.Model.German
{
    public class GermanVerb : WordBase
    {
        #region Fields

        private bool isRegular;
        private string presentFirstPerson;
        private string presentSecondPerson;
        private string presentThirdPerson;
        private string imperfect;
        private string participle;

        #endregion

        #region Counstructors

        public GermanVerb(string word, string translation, bool isRegular)
            : base(word, translation, Language.GERMAN, Type.VERB)
        {
            this.isRegular = isRegular;
            this.presentFirstPerson = null;
            this.presentSecondPerson = null;
            this.presentThirdPerson = null;
            this.imperfect = null;
            this.participle = null;
        }

        public GermanVerb(string word, string translation, bool isRegular, string imperfect, string participle)
            : base(word, translation, Language.GERMAN, Type.VERB)
        {
            this.isRegular = isRegular;
            this.presentFirstPerson = null;
            this.presentSecondPerson = null;
            this.presentThirdPerson = null;
            this.imperfect = imperfect;
            this.participle = participle;
        }

        public GermanVerb(string word, string translation, bool isRegular, string imperfect, string participle, 
                          string presentFirstPerson, string presentSecondPerson, string presentThirdPerson)
            : base(word, translation, Language.GERMAN, Type.VERB)
        {
            this.isRegular = isRegular;
            this.presentFirstPerson = presentFirstPerson;
            this.presentSecondPerson = presentSecondPerson;
            this.presentThirdPerson = presentThirdPerson;
            this.imperfect = imperfect;
            this.participle = participle;
        }

        #endregion

        #region Properties

        public bool IsRegular
        {
            get { return isRegular; }
            set { isRegular = value; }
        }

        public string Imperfect
        {
            get { return imperfect == null ? String.Empty : imperfect; }
            set { imperfect = value; }
        }

        public string Participle
        {
            get { return participle == null ? String.Empty : participle; }
            set { participle = value; }
        }

        public string PresentFirstPerson
        {
            get { return presentFirstPerson == null ? String.Empty : presentFirstPerson; }
            set { presentFirstPerson = value; }
        }

        public string PresentSecondPerson
        {
            get { return presentSecondPerson == null ? String.Empty : presentSecondPerson; }
            set { presentSecondPerson = value; }
        }

        public string PresentThirdPerson
        {
            get { return presentThirdPerson == null ? String.Empty : presentThirdPerson; }
            set { presentThirdPerson = value; }
        }

        #endregion

    }
}
