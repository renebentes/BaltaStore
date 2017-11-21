using Flunt.Notifications;
using System;

namespace BaltaStore.Shared.Models
{
    public abstract class Entity : Notifiable
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}