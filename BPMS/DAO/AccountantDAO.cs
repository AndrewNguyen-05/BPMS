using BPMS.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMS.DAO
{
    internal class AccountantDAO
    {
        private static AccountantDAO instance;
        private BPMSEntities db = Program.db;
        internal static AccountantDAO Instance
        {
            get
            {
                if (instance == null) AccountantDAO.instance = new AccountantDAO();
                return instance;
            }
            set { instance = value; }
        }

        public Accountant GetAccountantByAccId(int accID)
        {
            var result = from ac in db.Accountants
                         join acc in db.Accounts on ac.idAccount equals acc.id
                         where ac.isHidden == 0 && acc.id == accID
                         select ac;
            return result.FirstOrDefault();
        }

        public void CreateAccountant(Accountant act)
        {
            db.Accountants.AddOrUpdate(act);
            db.SaveChanges();
            db.Entry(act).Reference(c => c.Account).Load();
        }
    }
}
