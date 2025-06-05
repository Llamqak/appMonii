using System;
using appMonii.pkgServices;
using System.Collections.Generic;

namespace appMonii.pkgDomain
{
    public class clsTransaction<T> : clsEntity<T>, IComparable<T>, iIdentifiable<T> where T : IComparable<T>
    {
        #region Attributes
        protected clsTransaction<T> attMemento;
        protected float attAmount;
        protected DateTime attDate;
        private List<clsCategory<T>>[] attCategories = null;
        #endregion

        #region Constructors
        public clsTransaction(T prmOUID, string prmName, string prmDescription, DateTime prmDate, float prmAmount)
            : base(prmOUID, prmName, prmDescription)
        {
            attAmount = prmAmount;
            attDate = prmDate;
            attMemento = null;
        }
        #endregion

        #region Methods
        public virtual float opGetAmount()
        {
            return attAmount;
        }

        public DateTime opGetDate()
        {
            return attDate;
        }

        public virtual bool opSetAmount(float prmAmount)
        {
            if (prmAmount < 0) return false;
            attAmount = prmAmount;
            return true;
        }

        public virtual bool opSetDate(DateTime prmDate)
        {
            if (prmDate > DateTime.Now) return false;
            attDate = prmDate;
            return true;
        }

        protected bool opModify(string prmName, string prmDescription, float prmAmount, DateTime prmDate)
        {
            opMemento();
            if (opSetName(prmName) && 
                opSetDescription(prmDescription) && 
                opSetAmount(prmAmount) && 
                opSetDate(prmDate))
                return true;
            
            opRollBack();
            return false;
        }

        protected override void opMemento()
        {
            attMemento = new clsTransaction<T>(
                this.opGetOUID(),
                this.opGetName(),
                this.opGetDescription(),
                this.opGetDate(),
                this.opGetAmount()
            );
        }

        protected override void opRollBack()
        {
            if (attMemento == null) return;
            
            base.opSetOUID(attMemento.opGetOUID());
            base.opSetName(attMemento.opGetName());
            base.opSetDescription(attMemento.opGetDescription());
            this.opSetAmount(attMemento.opGetAmount());
            this.opSetDate(attMemento.opGetDate());
        }

        protected override bool opDie()
        {
            attMemento = null;
            return true;
        }

        // creo que esto se puede eliminar, ya que clsEntity<T> ya implementa IComparable<T>
        public int CompareTo(clsTransaction<T> other)
        {
            return this.opGetOUID().CompareTo(other.opGetOUID());
        }
        #endregion
    }
}
