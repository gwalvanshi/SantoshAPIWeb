﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEE.Web.ViewModel.Admission
{
    public class ApplicationViewModel : BaseViewModel
    {
        public int Application_ID { get; set; }
        public int? Enquiry_ID { get; set; }
        public string ApplicaitonNo { get; set; }
        public bool IsSubmitted { get; set; }
        public DateTime? SubmitDate { get; set; }
        public bool IsOnline { get; set; }
        public int? Sessionyear { get; set; }
        //public DocumentSubmissionModel DocumentSubmissions { get; set; }
    }
}
