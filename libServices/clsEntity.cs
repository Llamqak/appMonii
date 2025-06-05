using System;

namespace appMonii.pkgServices
{
    public class clsEntity<T> : iIdentifiable<T>, IComparable<T> where T : IComparable<T>
    {
        #region Attributes
        protected T attOUID = default;
        protected string attName = "none";
        protected string attDescription = "none";
        #endregion
        #region Constructors/Destructor
        protected clsEntity()
        {
            throw new NotImplementedException();
        }
        public clsEntity(T prmOUID, string prmName, string prmDescription)
        {
            attOUID = prmOUID;
            attName = prmName;
            attDescription = prmDescription;
        }

        protected bool opModify(String prmNewName, String prmNewDescription) 
        {
            return opSetName(prmNewName) && opSetDescription(prmNewDescription);
        }
        protected virtual bool opDie()
        {
            throw new NotImplementedException();
        }
        public string opGetName() => attName;
        public string opGetDescription() => attDescription;
        public bool opSetName(string prmValue)
        {
            if (string.IsNullOrWhiteSpace(prmValue)) return false;
            attName = prmValue;
            return true;
        }
        public virtual  bool opSetDescription(string prmValue)
        {
            if (string.IsNullOrWhiteSpace(prmValue)) return false;
            attDescription = prmValue;
            return true;
        }
        public virtual bool opSetOUID(T prmValue)
        {
            attOUID = prmValue;
            return true;
        }
        #endregion
        #region Getters
        public virtual T opGetOUID()
        {
            return attOUID;
        }
        #endregion
        #region Comparators
        public virtual int CompareTo(T prmObject)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Memento/RollBack
        protected virtual void opMemento() { }
        protected virtual void opRollBack()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
