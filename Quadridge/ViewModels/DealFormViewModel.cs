using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quadridge.Models;
using System.ComponentModel.DataAnnotations;

namespace Quadridge.ViewModels
{
    public class DealFormViewModel
    {
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<DealType> DealTypes { get; set; }
        public IEnumerable<Bank> Banks { get; set; }
        public IEnumerable<Lawyer> Lawyers { get; set; }
        public IEnumerable<Status> Statuses { get; set; }
        public int DealId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public int DealTypeId { get; set; }

        public int? RevenueId { get; set; }

        public int? BankId { get; set; }

        public int StatusId { get; set; }

        public int? LawyerId { get; set; }

        public string Title
        {
            get
            {
                return DealId != 0 ? "Edit Deal" : "New Deal";
            }
        }

        public DealFormViewModel()
        {

        }

        public DealFormViewModel(Deal deal)
        {
            DealId = deal.DealId;
            Name = deal.Name;
            DealTypeId = deal.DealTypeId;
            RevenueId = deal.RevenueId;
            BankId = deal.BankId;
            StatusId = deal.StatusId;
            LawyerId = deal.LawyerId;

        }
    }

}