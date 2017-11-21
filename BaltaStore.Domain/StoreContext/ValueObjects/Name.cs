﻿using Flunt.Notifications;
using Flunt.Validations;

namespace BaltaStore.Domain.StoreContext.ValueObjects
{
    public class Name : Notifiable
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(FirstName, 3, nameof(FirstName), "O nome deve conter pelo menos 3 caracteres")
                .HasMaxLen(FirstName, 40, nameof(FirstName), "O nome deve conter no máximo 40 caracteres")
                .HasMinLen(LastName, 3, nameof(LastName), "O sobrenome deve conter pelo menos 3 caracteres")
                .HasMaxLen(LastName, 40, nameof(LastName), "O sobrenome deve conter no máximo 40 caracteres")
            );
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}