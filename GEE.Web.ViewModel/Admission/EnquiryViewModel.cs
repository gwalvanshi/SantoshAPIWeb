using GEE.Web.ViewModel.Admission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEE.Web.ViewModel
{
    public class EnquiryViewModel : BaseViewModel
    {
        public int Enquiry_ID { get; set; }
        public string EnquiryNo { get; set; }
        public int? MarketSource_ID { get; set; }
        public int? EnquiryType_ID { get; set; }
        public string Status { get; set; }
        public int? Sessionyear { get; set; }

        public EnquiryTypeViewModel EnquiryType { get; set; }
        public MarketingSourceViewModel MarketingSource { get; set; }

        public ICollection<ApplicationViewModel> Applications { get; set; }
        public ICollection<CandidateDetailViewModel> CandidateDetails { get; set; }
        public ICollection<DocumentSubmissionViewModel> DocumentSubmissions { get; set; }
        public ICollection<RegistrationViewModel> Registrations { get; set; }
    }
}
