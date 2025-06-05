using System;
using System.Collections.Generic;


namespace appMonii.pkgServices
{
    public static class clsBrokerCrud
    {
        public static bool opExistsWith<U, T>(U prmOUID, List<T> prmCollection)
            where U : IComparable<U>
            where T : iIdentifiable<U>
        {
            foreach (T varItem in prmCollection)
                if (varItem.opGetOUID().CompareTo(prmOUID) == 0) return true;
            return false;
        }
        public static bool opAssociateWith<T>(T prmObj, List<T> prmCollection)
        {
            prmCollection.Add(prmObj);
            return true;
        }

        public static T opRetrieveWith<U, T>(U prmOUID, List<T> prmCollection)
            where U : IComparable<U>
            where T : iIdentifiable<U>
        {
            foreach (T varItem in prmCollection)
                if (varItem.opGetOUID().CompareTo(prmOUID) == 0) return varItem;
            return default;
        }

        public static bool opDissociateWith<T>(T prmItem, List<T> prmCollection)
        {
            return prmCollection.Remove(prmItem);
        }
    }
}
