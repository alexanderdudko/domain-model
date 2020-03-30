using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel.Sample
{
    public class HospitalModel : Model
    {
        public Collection<PersonEntity> Doctors { get; set; }
        public Collection<PersonEntity> Patients { get; set; }
        public Collection<VisitRecordEntity> Visits { get; set; }
    }

    public class PersonEntity : DataEntity { }
    public class VisitRecordEntity : DataEntity { }

}
