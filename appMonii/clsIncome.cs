using System;
using appMonii.pkgServices;

namespace appMonii.pkgDomain
{
    public class clsIncome<T> : clsTransaction<T>, iIdentifiable<T> where T : IComparable<T>
    {
        #region Attributes
        private new clsIncome<T> attMemento;
        #endregion

        #region Constructors
        public clsIncome(T prmOUID, string prmName, string prmDescription, DateTime prmDate, float prmAmount)
            : base(prmOUID, prmName, prmDescription, prmDate, prmAmount)
        {
            attAmount = prmAmount;
            attDate = prmDate;
            attMemento = null;
        }
        #endregion

        

        #region Methods
     
        public new bool opModify(string prmName, string prmDescription, float prmAmount, DateTime prmDate)
        {
            opMemento();
            if (base.opModify(prmName,prmDescription, prmAmount, prmDate))
                return true;

            opRollBack();
            return false;
        }

        protected override void opMemento()
        {
            attMemento = new clsIncome<T>(this.opGetOUID(), this.opGetName(),
                                     this.opGetDescription(), this.opGetDate(), this.opGetAmount());
        }

        protected override void opRollBack()
        {
            if (attMemento == null) return;
            base.opSetOUID(attMemento.opGetOUID());
            base.opSetName(attMemento.opGetName());
            base.opSetDescription(attMemento.opGetDescription());
            base.opSetAmount(attMemento.opGetAmount());
            base.opSetDate(attMemento.opGetDate());
        }
        #endregion
    }
}
