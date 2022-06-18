using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        private List<Subscription> _subscription;
        public Student(Name name, Document document, string email, string address)
        {
            Name = name;
            Document = document;
            Email = email;
            Address = address;
            _subscription = new List<Subscription>();
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscription.ToArray(); } }


        public void AddSubscriptions(Subscription subscription)
        {
            foreach (var item in Subscriptions)
                item.Inactivate();

            _subscription.Add(subscription);
        }
    }
}