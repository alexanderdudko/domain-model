using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    public interface IHierarchy<T>
    {
        ICollection<IHierarchyItem<T>> Children { get; }
    }
    public interface IHierarchyItem<T> : IHierarchy<T>
    {
        IHierarchy<T> Parent { get; set; }
    }
}
