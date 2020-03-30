using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    public class Entity : Value { }
    public class DataEntity : Entity
    {
        public Reference InheritanceParent { get; set; }
        public Collection<Definition> Definitions { get; set; }
    }
    public class ContainerEntity : DataEntity
    {
        public Reference ContainerParent { get; set; }
        public Collection<Entity> NestedEntities { get; set; }
    }
    public class Collection<T> : List<T> { }



    public class Definition
    {
        public string Name { get; set; }
        public Value Value { get; set; }
    }
    public class Property : Definition { }

}
