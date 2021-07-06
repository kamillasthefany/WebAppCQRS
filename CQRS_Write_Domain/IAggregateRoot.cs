using CQRS_Write_Domain.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Write_Domain
{
    public interface IAggregateRoot<T> : IAggregateRoot
    {
        T id { get; }
    }

    public interface IAggregateRoot
    {
        object GetId();
        int Version { get; }
        IEnumerable<IEvent> GetuncommittedChanges();
        void MarkChangesAsCommitted();
        void LoadsFromHistory(IEnumerable<IEvent> history);
        void ApplyChange(IEvent @event, bool isNew = true);
    }
}
