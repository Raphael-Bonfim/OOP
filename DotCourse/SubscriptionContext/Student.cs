using DotCourse.NotificationContext;
using DotCourse.SharedContext;

namespace DotCourse.SubscriptionContext
{
    internal class Student : Base
    {

        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }

        public IList<Subscription> Subscriptions { get; set; }

        public bool IsPremium  => Subscriptions.Any(x => !x.IsInactive);

        public void CreateSubscription(Subscription subscription)
        {
            if(IsPremium)
            {
                AddNotification(new Notification("Premium", "The student already have a subscription"));
                return;
            }

            Subscriptions.Add(subscription);
        }
    }
}
