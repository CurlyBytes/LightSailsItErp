using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel.Models
{
    /// <summary>
    /// Base class for entities.
    /// </summary>
    public abstract class Entity
    {

        private List<IHaveDomainEvent> _domainEvents;

        /// <summary>
        /// Domain events occurred.
        /// </summary>
        public IReadOnlyCollection<IHaveDomainEvent> DomainEventBase => _domainEvents?.AsReadOnly();

        /// <summary>
        /// Add domain event.
        /// </summary>
        /// <param name="domainEvent"></param>
        protected void AddDomainEvent(IHaveDomainEvent domainEvent)
        {
            _domainEvents = _domainEvents ?? new List<IHaveDomainEvent>();
            this._domainEvents.Add(domainEvent);
        }

        /// <summary>
        /// Clear domain events.
        /// </summary>
        public void ClearDomainEvents()
        {
            _domainEvents?.Clear();
        }


    }
}
