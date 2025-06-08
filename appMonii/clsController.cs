using appMonii.pkgServices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace appMonii.pkgDomain
{
    public class ClsController
    {

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
        private List<clsSpent<String>> attMyExpenses = new List<clsSpent<String>>();
        public List<clsSpent<string>> MyExpenses => attMyExpenses;

        public bool opRegisterSpent(String prmOUID, string prmName, string prmDescription,
                              float prmAmount, DateTime prmDate, clsCategory<String> prmCategory)
        {
            if (clsBrokerCrud.opExistsWith(prmOUID, attMyExpenses))
                return false;

            var newExpense = new clsSpent<String>(
                prmOUID,
                prmName,
                prmDescription,
                prmDate,
                prmAmount,
                prmCategory
            );

            attMyExpenses.Add(newExpense);
            return true;
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
        public bool opDeleteSaving(String prmOUID)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Categories
        private List<clsCategory<string>> attMyCategories = new List<clsCategory<string>>();

        public List<clsCategory<string>> opGetAllCategories()
        {
            return attMyCategories;
        }

        public List<clsCategory<string>> opGetCategoryById(String prmOUID)
        {
            var categories = opGetAllCategories();
            return categories.Where(category => category.opGetOUID() == prmOUID).ToList();
        }

        public bool opRegisterCategory(string prmOUID, string prmName, string prmDescription, string prmCategoryName)
        {
            if (clsBrokerCrud.opExistsWith(prmOUID, attMyCategories)) return false;
            return opSetCategory(new clsCategory<string>(prmOUID, prmName, prmDescription, prmCategoryName));
        }

        public bool opSetCategory(clsCategory<string> prmobj)
        {
            var existing = clsBrokerCrud.opRetrieveWith(prmobj.opGetOUID(), attMyCategories);
            if (existing != null)
            {
                attMyCategories.Remove(existing);
            }
            attMyCategories.Add(prmobj);
            return true;
        }

        public bool opUpdateCategory(string prmOUID, string prmName, string prmDescription, string prmCategoryName)
        {
            if (!clsBrokerCrud.opExistsWith(prmOUID, attMyCategories)) return false;
            return clsBrokerCrud.opRetrieveWith(prmOUID, attMyCategories).opModify(prmName, prmDescription, prmCategoryName);
        }

        public bool opDeleteCategory(string prmOUID)
        {
            var category = clsBrokerCrud.opRetrieveWith(prmOUID, attMyCategories);
            if (category == null) return false;
            return attMyCategories.Remove(category);
        }
    }

    #endregion

}

