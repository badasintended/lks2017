//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nusantara.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetailScore
    {
        public int ScoreDetailId { get; set; }
        public int DetailId { get; set; }
        public string StudentId { get; set; }
        public Nullable<int> Assignment { get; set; }
        public Nullable<int> MidExam { get; set; }
        public Nullable<int> FinalExam { get; set; }
    
        public virtual DetailSchedule DetailSchedule { get; set; }
        public virtual Student Student { get; set; }
    }
}
