//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class ScheduleInterview
    {
        public int IdSchedule { get; set; }
        public Nullable<int> IdCandidate { get; set; }
        public Nullable<System.DateTime> DateSchedule { get; set; }
        public Nullable<int> IdInterviewMode { get; set; }
    
        public virtual Candidate Candidate { get; set; }
        public virtual InterviewMode InterviewMode { get; set; }
    }
}
