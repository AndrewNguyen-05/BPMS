using BPMS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPMS.DAO
{
    internal class AgencyDAO
    {
        private static AgencyDAO instance;
        private BPMSEntities db = new BPMSEntities();
        internal static AgencyDAO Instance
        {
            get
            {
                if (instance == null) AgencyDAO.instance = new AgencyDAO();
                return instance;
            }
            set { instance = value; }
        }
        public int GetAgencyID(string agencyName)
        {

            var matchedAgency = from agen in db.Agencies
                                   join acc in db.Accounts on agen.idAccount equals acc.id
                                   where acc.UserName == agencyName
                                   select agen.id;
            if (matchedAgency.Count() == 0)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi! Không có tên Đại lý!", "Thông báo lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return 0;
            }
            return matchedAgency.First();
        }

        public List<Account> GetAgencyAccountList()
        {
            var allAgency = from agen in db.Agencies
                               join acc in db.Accounts on agen.idAccount equals acc.id
                               where agen.isHidden == 0
                               select acc;
            return allAgency.ToList();
        }
    }
}
