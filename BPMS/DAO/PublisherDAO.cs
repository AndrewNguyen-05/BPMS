﻿using BPMS.DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace BPMS.DAO
{
    internal class PublisherDAO
    {
        private static PublisherDAO instance;
        private BPMSEntities db = Program.db;
        internal static PublisherDAO Instance
        {
            get
            {
                if (instance == null) PublisherDAO.instance = new PublisherDAO();
                return instance;
            }
            set { instance = value; }
        }
        public int GetPublisherID(string publisherName)
        {
            
            var matchedPublisher = from pub in db.Publishers
                                   join acc in db.Accounts on pub.idAccount equals acc.id
                                   where acc.UserName == publisherName
                                   select pub.id;
            if(matchedPublisher.Count() == 0 ) 
            {
                System.Windows.Forms.MessageBox.Show("Lỗi! Không có tên Nhà Xuất Bản!", "Thông báo lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return 0;
            }
            return matchedPublisher.First();
        }

        public List<Account> GetPublisherAccountList()
        {
            var allPublisher = from pb in db.Publishers
                               join acc in db.Accounts on pb.idAccount equals acc.id
                               where pb.isHidden == 0
                               select acc;
            return allPublisher.ToList();
        }

        public Publisher GetPublisherByAccId(int accID)
        {
            var result = from pb in db.Publishers
                         join acc in db.Accounts on pb.idAccount equals acc.id
                         where pb.isHidden == 0 && acc.id == accID
                         select pb;
            return result.FirstOrDefault();
        }

        public void CreatePublisher(Publisher pb)
        {
            db.Publishers.AddOrUpdate(pb);
            db.SaveChanges();
            db.Entry(pb).Reference(c => c.Account).Load();
        }
    }
}
