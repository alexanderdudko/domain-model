using System;
using System.Collections.Generic;

namespace DomainModel
{
    public class Model : Entity { }
    public class Entity : Collection<Property> { }
    public class Collection<T> : List<T> { }
    public class Property { }



    public class HospitalModel : Model
    {
        public Collection<PersonEntity> Doctors { get; set; }
        public Collection<PersonEntity> Patients { get; set; }
        public Collection<VisitRecordEntity> Visits { get; set; }
    }

    public class PersonEntity : Entity { }
    public class VisitRecordEntity : Entity { }
}
