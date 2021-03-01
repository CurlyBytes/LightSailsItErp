using SharedKernel.Events;
using System.Collections.Generic;

namespace SharedKernel
{
    public interface IHaveDomainEvent
    {
        public List<DomainEvent> DomainEvents { get; set; }
    }
}