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
        private BPMSEntities db = Program.db;
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
            return db.Accounts.Where(e => e.isHidden == 0).ToList();
        }
        public Account GetAccount(int Id)
        {
            return db.Accounts.Where(e => e.id == Id).FirstOrDefault();
        }
        public Account GetAccount(string userName)
        {
            return db.Accounts.Where(e => e.UserName == userName && e.isHidden == 0).FirstOrDefault();
        }
        public Permissions GetAccountType(int id)
        {
            var accountType = from acc in db.Accounts
                              where acc.id == id && acc.isHidden == 0
                              select acc.type;
            return (Permissions)accountType.First();
        }

        public bool CheckPassword(string userName, string password)
        {
            var pass = from acc in db.Accounts
                       where acc.PassWord == password && acc.UserName == userName && acc.isHidden == 0
                       select acc.id;
            if (pass.Count() == 0) return false;
            return true;
        }

        public int GetAccountId(string userName)
        {
            var AccountId = from acc in db.Accounts
                              where acc.UserName == userName && acc.isHidden == 0
                              select acc.id;
            return AccountId.First();
        }

        public void CreateAccount(ref Account acc)
        {
            db.Accounts.AddOrUpdate(acc);
            db.SaveChanges();
        }

        public void DeleteAccount(Account acc)
        {
            var tmp = from pub in db.Publishers
                      where pub.idAccount == acc.id
                      select pub;
            if (tmp.Count() != 0)
            {
                tmp.FirstOrDefault().isHidden = 1;
                db.Publishers.AddOrUpdate(tmp.FirstOrDefault());
            }

            var tmp2 = from act in db.Accountants
                      where act.idAccount == acc.id
                      select act;
            if (tmp2.Count() != 0)
            {
                tmp2.FirstOrDefault().isHidden = 1;
                db.Accountants.AddOrUpdate(tmp2.FirstOrDefault());
            }

            var tmp3 = from agc in db.Agencies
                       where agc.idAccount == acc.id
                       select agc;
            if (tmp3.Count() != 0)
            {
                tmp3.FirstOrDefault().isHidden = 1;
                db.Agencies.AddOrUpdate(tmp3.FirstOrDefault());
            }

            acc.isHidden = 1;
            db.Accounts.AddOrUpdate(acc);
            db.SaveChanges();
        }
    }
}
