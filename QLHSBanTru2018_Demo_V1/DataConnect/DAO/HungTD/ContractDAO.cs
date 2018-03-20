using DataConnect.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnect.DAO.HungTD
{
    public class ContractDAO
    {
        QLHSSmartKidsDataContext db;
        Table<Contract> contract;
        Table<Employee> employee;

        public ContractDAO()
        {
            db = new QLHSSmartKidsDataContext();
        }
        public List<ContractViewModel> ListAll()
        {
            contract = db.GetTable<Contract>();
            employee = db.GetTable<Employee>();
            var query = from c in contract
                        join e in employee
                        on c.EmployeeID equals e.EmployeeID
                        join e2 in employee
                        on c.CreatedBy equals e2.EmployeeID
                        where c.Status == true
                        select new ContractViewModel
                        {
                            ContractID = c.ContractID,
                            ContractType = c.ContractType,
                            TimeType = c.TimeType == 0 ? "Không thời hạn" : "Có thời hạn",
                            EmployeeID = e.EmployeeID,
                            EmployeeFullName = e.FirstName + " " + e.LastName,
                            PayRate = c.PayRate,
                            StartDate = c.StartDate,
                            EndDate = c.EndDate,
                            CreatedBy = c.CreatedBy,
                            CreatedByName = e2.FirstName + " " + e2.LastName,
                            CreatedDate = c.CreatedDate,
                            AttachedFile = null,
                            Note = c.Note,
                            Status = c.Status
                        };
            return query.ToList();
        }
        public int Insert(Contract entity)
        {
            try
            {
                contract.InsertOnSubmit(entity);
                db.SubmitChanges();
                //History;
                return entity.ContractID;
            }
            catch
            {
                return 0;
            }
        }
        public bool Edit(Contract entity)
        {
            try
            {
                Contract obj = contract.Single(x => x.ContractID == entity.ContractID);
                obj.ContractType = entity.ContractType;
                obj.EmployeeID = entity.EmployeeID;
                obj.PayRate = entity.PayRate;
                obj.StartDate = entity.StartDate;
                obj.Status = entity.Status;
                db.SubmitChanges();
                //Insert History
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(int contractID)
        {
            try
            {
                Contract obj = contract.Single(x => x.ContractID == contractID);
                obj.Status = false;
                db.SubmitChanges();
                //Insert History
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
