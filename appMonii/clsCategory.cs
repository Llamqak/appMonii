using System;
using System.Collections.Generic;
using appMonii.pkgServices;

namespace appMonii.pkgDomain
{
    public class clsCategory<T> : clsEntity<T>, iIdentifiable<T> where T : IComparable<T>
    {
        #region Attributes
        private string attCategoryName;
        private clsCategory<T> attMemento;

        #endregion

        #region Constructors
        public clsCategory(T prmOUID, string prmName, string prmDescription,
                      string prmCategoryName)
       : base(prmOUID, prmName, prmDescription)
        {
            attCategoryName = prmCategoryName;
            attMemento = null;
        }
        #endregion


        #region Methods
        public string opGetCategoryName()
        {
            return attCategoryName;
        }

        public bool opSetCategoryName(string prmCategoryName)
        {
            if (string.IsNullOrEmpty(prmCategoryName)) return false;
            attCategoryName = prmCategoryName;
            return true;
        }

        public bool opModify(string prmName, string prmDescription,
                                      string prmCategoryName)
        {
            opMemento();

            if (base.opModify(prmName, prmDescription) &&
                opSetCategoryName(prmCategoryName))
                return true;

            opRollBack();
            return false;
        }

        protected override void opMemento()
        {
            attMemento = new clsCategory<T>(
                this.opGetOUID(), 
                this.opGetName(), 
                this.opGetDescription(),
                this.opGetCategoryName());
        }

        protected override void opRollBack()
        {
            if (attMemento == null) return;
            base.opSetOUID(attMemento.opGetOUID());
            base.opSetName(attMemento.opGetName());
            base.opSetDescription(attMemento.opGetDescription());
            this.opSetCategoryName(attMemento.opGetCategoryName());
        }

     
        #endregion
    }
}
