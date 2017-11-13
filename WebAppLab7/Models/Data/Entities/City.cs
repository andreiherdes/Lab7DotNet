using System;
using EnsureThat;

namespace WebAppLab7.Models.Data.Entities
{
    public class City
    {
        public Guid Id { get; set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Country { get; private set; }
        public bool IsComplete { get; private set; }

        public static City Create(string name, string description, string country, bool isComplete)
        {
            Ensure.That(name).HasLengthBetween(1, 200);
            Ensure.That(description).HasLengthBetween(1, 300);
            Ensure.That(country).HasLengthBetween(1, 100);
            Ensure.That(isComplete).IsFalse();
            var instance = new City { Id = Guid.NewGuid() };
            instance.Update(name, description, country, true);
            return instance;
        }

        public void Update(string name, string description, string country, bool isComplete)
        {
            Ensure.That(isComplete).IsTrue();
            Name = name;
            Description = description;
            Country = country;
            IsComplete = isComplete;
        }
    }
}
