namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        private List<Subscription> _subscription;
        public Student(string firstName, string lastName, string document, string email, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;
            Address = address;
            _subscription = new List<Subscription>();
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
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