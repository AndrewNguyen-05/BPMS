using BPMS.Classes;
using BPMS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMS.DAO
{
    internal class AccountDAO
    {
        private static AccountDAO instance;
        private BPMSEntities db = new BPMSEntities();
        internal static AccountDAO Instance
        {
            get
            {
                if (instance == null) AccountDAO.instance = new AccountDAO();
                return instance;
            }
            set { instance = value; }
        }
        public Permissions GetAccountType(string userName)
        {
            var accountType = from acc in db.Accounts
                              where acc.UserName == userName
                              select acc.type;
            return (Permissions)accountType.First();
        }

        public Permissions GetAccountType(int id)
        {
            var accountType = from acc in db.Accounts
                              where acc.id == id
                              select acc.type;
            return (Permissions)accountType.First();
        }

        public bool CheckPassword(string userName, string password)
        {
            var pass = from acc in db.Accounts
                       where acc.PassWord == password && acc.UserName == userName
                       select acc.id;
            if (pass.Count() == 0) return false;
            return true;
        }

        public int GetAccountId(string userName)
        {
            var AccountId = from acc in db.Accounts
                              where acc.UserName == userName
                              select acc.id;
            return AccountId.First();
        }
    }
}
