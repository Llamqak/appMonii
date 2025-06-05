using System;


namespace appMonii.pkgServices
{
    public interface iIdentifiable<T> where T : IComparable<T>
    {
        #region Getters
        T opGetOUID();
        string opGetName();
        string opGetDescription();
        #endregion
        #region Setters
        bool opSetOUID(T prmValue); 
        bool opSetName(string prmValue);
        bool opSetDescription(string prmValue);
        #endregion
    }
}
