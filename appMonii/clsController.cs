using appMonii.pkgServices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace appMonii.pkgDomain
{
    public class ClsController
    {
        /*
        
        private List<clsCategory<T>> attMyCategories = new List<clsCategory<T>>();*/

        private static ClsController attInstance;
        public static ClsController opGetInstance()
        {
            if (attInstance == null)
                attInstance = new ClsController();
            return attInstance;
        }
        #region Incomes
        private List<clsIncome<String>> attMyIncomes = new List<clsIncome<String>>();
        public List<clsIncome<string>> MyIncomes => attMyIncomes;
        public bool opRegisterIncome(String prmOUID, string prmName, string prmDescription, float prmAmount, DateTime prmDate)
        {
            if (clsBrokerCrud.opExistsWith(prmOUID, attMyIncomes)) return false;
            return opUpdateIncome(prmOUID, prmName, prmDescription, prmDate, prmAmount);

        }
        public bool opUpdateIncome(String prmOUID, string prmName, string prmDescription, DateTime prmDate, float prmAmount)
        {
            if (!clsBrokerCrud.opExistsWith(prmOUID, attMyIncomes)) return false;
            return clsBrokerCrud.opRetrieveWith(prmOUID, attMyIncomes).opModify(prmName, prmDescription, prmAmount, prmDate);
        }
        public bool opDeleteIncome(String prmOUID)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Expenses
        private List<clsSpent<String>> attMySpent = new List<clsSpent<String>>();

        public bool opRegisterSpent(String prmOUID, string prmName, string prmDescription,
                              float prmAmount, DateTime prmDate, clsCategory<String> prmCategory)
        {
            if (clsBrokerCrud.opExistsWith(prmOUID, attMySpent))
                return false;

            var newExpense = new clsSpent<String>(
                prmOUID,
                prmName,
                prmDescription,
                prmDate,
                prmAmount,
                prmCategory
            );

            attMySpent.Add(newExpense);
            return true;
        }

        public List<clsCategory<string>> opGetAllCategories()
        {
            return new List<clsCategory<string>>();
        }

        public List<clsCategory<string>> opGetCategoryById(String prmOUID)
        {
            var categories = opGetAllCategories();
            return categories.Where(category => category.opGetOUID() == prmOUID).ToList();
        }

        public bool opDeleteSpent(String prmOUID)
        {
            throw new NotImplementedException();
        }

        #endregion
        #region Saving

        private List<clsSaving<String>> attMySavings = new List<clsSaving<String>>();
        public List<clsSaving<string>> MySavings => attMySavings;
        public bool opRegisterSaving(String prmOUID, string prmName, string prmDescription, DateTime prmDate, float prmAmount, float prmCap, DateTime prmTimeLimit, float prmPeriodicFee, String prmQuotaFrecuency)
        {
            if (clsBrokerCrud.opExistsWith(prmOUID, attMySavings)) return false;
            return opUpdateSaving(prmOUID, prmName, prmDescription, prmCap, prmTimeLimit, prmPeriodicFee, prmQuotaFrecuency, prmDate, prmAmount);
        }
        public bool opUpdateSaving(String prmOUID, string prmName, String prmDescription, float prmCap, DateTime prmTimeLimit, float prmPeriodicFee,   String prmQuotaFrecuency, DateTime prmDate, float prmAmount)
        {
            if (clsBrokerCrud.opExistsWith(prmOUID, attMySavings) == false) return false;
            return clsBrokerCrud.opRetrieveWith(prmOUID, attMySavings).opModify(prmName, prmDescription, prmAmount, prmDate, prmCap, prmTimeLimit, prmPeriodicFee, prmQuotaFrecuency);
        }
        #endregion

        #region Expenses 
        private List<clsSpent<String>> attMyExpenses = new List<clsSpent<String>>();
        public List<clsSpent<string>> MyExpenses => attMyExpenses;


        #endregion
        /* 

         

         public bool opRegisterCategory(T prmOUID, string prmName, string prmDescription,string prmCategoryName)
         {

             if (clsBrokerCrud.opExistsWith(prmOUID, attMyCategories)) return false;
             return opSetCategory(new clsCategory<T>(prmOUID, prmName, prmDescription, prmCategoryName));

         }


         

         public bool opUpdateCategory(T prmOUID, string prmName, string prmDescription, string prmCategoryName)
         {
             if (clsBrokerCrud.opExistsWith(prmOUID, attMyCategories) == false) return false;
             return clsBrokerCrud.opRetrieveWith(prmOUID, attMyCategories).opModify(prmName, prmDescription, prmCategoryName);
         }

         

    
         public bool opDeleteSaving(String prmOUID)
         {
             throw new NotImplementedException();
         }

         public bool opDeleteCategory(String prmOUID)
         {
             throw new NotImplementedException();
         }

         public bool opSetSaving(clsSaving<T> prmobj)
         {
             if (attMySavings != null) return false;
             attMySavings = new List<clsSaving<T>> { prmobj };
             return true;
         }


         public bool opSetIncome(clsIncome<T> prmobj)
         {
             if (attMyIncomes != null) return false;
             attMyIncomes = new List<clsIncome<T>> { prmobj };
             return true;
         }

         public bool opSetSpent(clsSpent<T> prmobj)
         {
             if (attMySpent != null) return false;
             attMySpent = new List<clsSpent<T>> { prmobj };
             return true;
         }

         public bool opSetCategory(clsCategory<T> prmobj)
         {
             if (attMyCategories != null) return false;
             attMyCategories = new List<clsCategory<T>> { prmobj };
             return true;
         }


         public void AddMySpent(clsSpent<T> newSpent)
         {
             if (newSpent == null) return;
             if (this.attMySpent == null)
                 this.attMySpent = new List<clsSpent<T>>();
             if (!this.attMySpent.Contains(newSpent))
                 this.attMySpent.Add(newSpent);
         }
        */


    }
}
