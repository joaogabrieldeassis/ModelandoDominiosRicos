using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private List<Subscription> _subscription;
        public Student(Name name, Document document, Email email, Address address)
        {
            Name = name;
            Document = document;
            Email = email;
            Address = address;
            _subscription = new List<Subscription>();
            AddNotifications(name, document, email);
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscription.ToArray(); } }


        public void AddSubscriptions(Subscription subscription)
        {
            var hasSubscriptionActive = false;
            foreach (var sub in _subscription)
            {
                if (sub.Active)
                    hasSubscriptionActive = true;
            }
            // AddNotifications(new Contract<Student>()
            // .Requires()
            // .IsFalse(hasSubscription, "Student.Subscriptions", "Você Já tem uma assinatura ativa")
            // );
            if (hasSubscriptionActive)
                AddNotification("Student.Subscriptions", "Você já tem uma assinatura ativa");
        }
    }
}