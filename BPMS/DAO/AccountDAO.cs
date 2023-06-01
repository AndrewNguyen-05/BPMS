using BPMS.Classes;
using BPMS.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

        public List<Account> GetListAccount()
        {
            return db.Accounts.ToList();
        }
        public Account GetAccount(int Id)
        {
            return db.Accounts.Where(e => e.id == Id).FirstOrDefault();
        }
        public Account GetAccount(string userName)
        {
            return db.Accounts.Where(e => e.UserName == userName).FirstOrDefault();
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

        public void CreateAccount(Account acc)
        {
            db.Accounts.AddOrUpdate(acc);
            db.SaveChanges();
        }

        public void DeleteAccount(Account acc)
        {
            var tmp = from pub in db.Publishers
                      where pub.idAccount == acc.id
                      select pub;
            if (tmp.Count() != 0) db.Publishers.Remove(tmp.First());

            var tmp2 = from act in db.Accountants
                      where act.idAccount == acc.id
                      select act;
            if (tmp2.Count() != 0) db.Accountants.Remove(tmp2.First());

            var tmp3 = from agc in db.Agencies
                       where agc.idAccount == acc.id
                       select agc;
            if (tmp3.Count() != 0)  db.Agencies.Remove(tmp3.First());

            db.SaveChanges();
            db.Accounts.Remove(acc);
            db.SaveChanges();
        }
    }
}
