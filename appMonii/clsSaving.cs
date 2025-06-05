using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appMonii.pkgServices;

namespace appMonii.pkgDomain
{
    public class clsSaving<T> : clsTransaction<T> where T : IComparable<T>
    {
        #region Attributes
        private new clsSaving<T> attMemento;
        protected float attCap = -1;
        protected DateTime attTimeLimit;
        protected float attPeriodicFee = -1;
        protected String attQuotaFrecuency;
        #endregion

        #region Constructors
        public clsSaving(T prmOUID, string prmName, string prmDescription, DateTime prmDate, float prmAmount, float prmCap, DateTime prmTimeLimit,float prmPeriodicFee, String prmQuotaFrecuency)
    :       base(prmOUID,prmName, prmDescription, prmDate, prmAmount)
        {
            //if (prmAmount < 0) throw new ArgumentException("El monto no puede ser negativo");
           // if (prmDate > DateTime.Now) throw new ArgumentException("La fecha no puede ser futura");
            attMemento = null;
        }
        #endregion

        #region Gets/Sets
        public float opGetCap() { 
        return attCap;
        }

        public DateTime opGetTimeLimit()
        {
            return attTimeLimit;
        }

        public float opGetPeriodicFee()
        {
            return attPeriodicFee; 
        }

        public String opGetQuotaFrecuency()
        {
            return attQuotaFrecuency;
        }

        public bool opSetCap(float prmCap)
        {
            attCap = prmCap;
            return true;
        }

        public bool opSetTimeLimit(DateTime prmTimeLimit)
        {
            attTimeLimit = prmTimeLimit;
            return true;
        }

        public bool opSetPeriodicFee(float prmPeriodicFee)
        {
            attPeriodicFee= prmPeriodicFee;
            return true;
        }

        public bool opSetQuotaFrecuency(String prmQuotaFrecuency)
        {
            attQuotaFrecuency=prmQuotaFrecuency;
            return true;
        }

        #endregion


        #region Methods
        public bool opModify(string prmName, string prmDescription, float prmAmount, DateTime prmDate, float prmCap,
                                  DateTime prmTimeLimit, float prmPeriodicFee, String prmQuotaFrecuency)
        {
            opMemento();

            if (opSetCap(prmCap) &&
                opSetTimeLimit(prmTimeLimit) &&
                opSetPeriodicFee(prmPeriodicFee) &&
                opSetQuotaFrecuency(prmQuotaFrecuency) &&
                base.opModify(prmName,prmDescription,prmAmount,prmDate))
                return true;

            opRollBack();
            return false;
        }

        #endregion

        #region Memento Pattern
        protected override void opMemento()
        {
            attMemento = new clsSaving<T>(
                this.opGetOUID(),
                this.opGetName(),
                this.opGetDescription(),
                this.opGetDate(),
                this.opGetAmount(),
                this.opGetCap(),
                this.opGetTimeLimit(),
                this.opGetPeriodicFee(),
                this.opGetQuotaFrecuency()
            );
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

        protected override bool opDie()
        {
            attMemento = null;
            return true;
        }
        #endregion

        #region Interface Implementation
        public override int CompareTo(T other)
        {
            return this.opGetOUID().CompareTo(other);
        }
        #endregion
    }
}
