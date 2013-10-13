using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DispatchLogger.Models
{
    public enum Department
    {
        patient, DME, Pharmacy
    }
    public enum State
    {
        Working, Resolved
    }
    public class CallLog
    {
        public int ID { get; set; }
        public int PatientPhone {get; set;}
        public string ReasonForCall {get; set;}
        public string CallResolution { get; set; }
        public DateTime TimeStamp { get; set; }
        public Department? Department { get; set; }
        public State? State { get; set; }

    }

   
}