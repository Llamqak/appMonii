using System;
using appMonii.pkgServices;

namespace appMonii.pkgDomain
{
    public class clsSpent<T> : clsTransaction<T>, iIdentifiable<T> where T : IComparable<T>
    {
        #region Attributes
        private float attAmount;
        private DateTime attDate;
        private string attAlert;
        private clsSpent<T> attMemento;
        private clsCategory<T>[] attCategory;

        public clsCategory<T> Category
        {
            get { return attCategory != null && attCategory.Length > 0 ? attCategory[0] : null; }
            set { attCategory = new clsCategory<T>[] { value }; }
        }
        #endregion

        #region Constructors
        public clsSpent(T prmOUID, string prmName, string prmDescription, DateTime prmDate, float prmAmount, clsCategory<T> prmCategory, string prmAlert = "")
                : base(prmOUID, prmName, prmDescription, prmDate, prmAmount)
        {
            if (prmAmount < 0) throw new ArgumentException("El monto no puede ser negativo");
            if (prmDate > DateTime.Now) throw new ArgumentException("La fecha no puede ser futura");

            attAmount = prmAmount;
            attDate = prmDate;
            attAlert = prmAlert ?? string.Empty;
            attMemento = null;
            attCategory = new clsCategory<T>[] { prmCategory };
        }

        public bool opSetCategory(clsCategory<T> prmCategory)
        {
            if (prmCategory == null) return false;
            attCategory = new clsCategory<T>[] { prmCategory };
            return true;
        }

        #endregion

        #region Properties
        public float Amount
        {
            get { return attAmount; }
            private set { attAmount = value; }
        }

        public DateTime Date
        {
            get { return attDate; }
            private set { attDate = value; }
        }

        public string Alert
        {
            get { return attAlert; }
            private set { attAlert = value ?? string.Empty; }
        }
        #endregion

        #region Methods
        public override float opGetAmount()
        {
            return attAmount;
        }

        public DateTime opGetDate()
        {
            return attDate;
        }

        public string opGetAlert()
        {
            return attAlert;
        }

        public override bool opSetAmount(float prmAmount)
        {
            if (prmAmount < 0) return false;
            attAmount = prmAmount;
            return true;
        }

        public override bool opSetDate(DateTime prmDate)
        {
            if (prmDate > DateTime.Now) return false;
            attDate = prmDate;
            return true;
        }

        public bool opSetAlert(string prmAlert)
        {
            attAlert = prmAlert ?? string.Empty;
            return true;
        }

        public bool opModify(string prmName, string prmDescription, float prmAmount,
                       DateTime prmDate, clsCategory<T> prmCategory, string prmAlert = "")
        {
            opMemento();
            if (base.opSetName(prmName) &&
                base.opSetDescription(prmDescription) &&
                opSetAmount(prmAmount) &&
                opSetDate(prmDate) &&
                opSetCategory(prmCategory)) // Nueva validación
            {
                opSetAlert(prmAlert);
                return true;
            }

            opRollBack();
            return false;
        }
        protected override void opMemento()
        {
            attMemento = new clsSpent<T>(
                this.opGetOUID(),
                this.opGetName(),
                this.opGetDescription(),
                this.Date,
                this.Amount,
                this.Category, 
                this.Alert
            );
        }

        protected override void opRollBack()
        {
            if (attMemento == null) return;
            base.opSetOUID(attMemento.opGetOUID());
            base.opSetName(attMemento.opGetName());
            base.opSetDescription(attMemento.opGetDescription());
            this.opSetAmount(attMemento.Amount);
            this.opSetDate(attMemento.Date);
            this.opSetAlert(attMemento.Alert);
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
