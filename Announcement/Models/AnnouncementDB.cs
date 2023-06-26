using Microsoft.CodeAnalysis;

namespace Announcement.Models
{
    public static class AnnouncementDB
    {
        public static List<Announcement> AnnouncementList;

        static AnnouncementDB()
        {
            AnnouncementList = new List<Announcement>()
            {
                new Announcement()
                {
                    Id = Guid.NewGuid(),
                    Title = "New Feature Update: Real-Time Chat Integration",
                    Description = "We're excited to announce the latest addition to our app - real-time chat! Now you can connect and communicate with other users instantly. Say goodbye to waiting for replies and start enjoying seamless conversations. Update your app now to experience this exciting new feature.",
                    AddDate = DateTime.Now,
                    EditDate = DateTime.Now,
                },

                new Announcement()
                {
                    Id = Guid.NewGuid(),
                    Title = "Upcoming Maintenance Window",
                    Description = "Attention, app users! We have scheduled a maintenance window to enhance our services. During this time, the app may experience temporary disruptions. The maintenance will take place today from 10 AM to 1 pm. We apologize for any inconvenience caused and appreciate your patience as we work to improve your app experience.",
                    AddDate = DateTime.Now,
                    EditDate = DateTime.Now,
                },

                new Announcement()
                {
                    Id = Guid.NewGuid(),
                    Title = "Exclusive Limited-Time Offer: 50% Off Premium Subscription",
                    Description = "For a limited time only, we're offering a special discount of 50% off on our premium subscription plan. Unlock premium features, enjoy ad-free browsing, and get access to exclusive content. Don't miss out on this incredible deal! Upgrade your subscription today.",
                    AddDate = DateTime.Now,
                    EditDate = DateTime.Now,
                },

                new Announcement()
                {
                    Id = Guid.NewGuid(),
                    Title = "Introducing a New Look and Feel",
                    Description = "We're thrilled to unveil a fresh new look for our app! Experience a revamped user interface, sleek design, and improved navigation. We've listened to your feedback and made changes to enhance your app experience. Update now to discover the exciting transformation.",
                    AddDate = DateTime.Now,
                    EditDate = DateTime.Now,
                },
                new Announcement()
                {
                    Id = Guid.NewGuid(),
                    Title = "Community Contest: Show Us Your Creativity!",
                    Description = "Calling all creative minds! We're hosting a community contest where you can showcase your talent. Whether it's artwork, photography, or writing, submit your entries for a chance to win exciting prizes. Don't miss this opportunity to share your creativity with the community. Visit our website for more details on how to participate.",
                    AddDate = DateTime.Now,
                    EditDate = DateTime.Now,
                },
                new Announcement()
                {
                    Id = Guid.NewGuid(),
                    Title = "Improved Search Functionality Now Available",
                    Description = "We're thrilled to announce an upgrade to our search functionality! Finding what you're looking for is now easier than ever. With enhanced search algorithms and filters, you can quickly locate specific content, articles, and resources. Update your app today to take advantage of this powerful search upgrade.",
                    AddDate = DateTime.Now,
                    EditDate = DateTime.Now,
                },
                new Announcement()
                {
                    Id = Guid.NewGuid(),
                    Title = "Save the Date: App User Meetup 2023",
                    Description = "Mark your calendars for the most anticipated event of the year - the App User Meetup 2023! Join us on [date] for an exciting day of networking, workshops, and insightful sessions. Connect with fellow app enthusiasts, learn from industry experts, and discover new possibilities. Stay tuned for more details on registration and location.",
                    AddDate = DateTime.Now,
                    EditDate = DateTime.Now,
                },
                new Announcement()
                {
                    Id = Guid.NewGuid(),
                    Title = "New Feature Request Forum: Your Voice Matters!",
                    Description = "We value your feedback and want to hear your ideas for improving the app. Introducing our new Feature Request Forum! Share your suggestions, vote on existing ideas, and collaborate with the community to shape the future of our app. Together, we can make it even better. Visit the forum section in the app to get started.",
                    AddDate = DateTime.Now,
                    EditDate = DateTime.Now,
                },
                new Announcement()
                {
                    Id = Guid.NewGuid(),
                    Title = "Important Security Update: Two-Factor Authentication",
                    Description = "Your security is our top priority. To provide an extra layer of protection for your account, we're introducing Two-Factor Authentication (2FA). Enable this feature in your account settings to enhance the security of your app. With 2FA, you'll have peace of mind knowing that only you can access your account. Update your app now and enable 2FA.",
                    AddDate = DateTime.Now,
                    EditDate = DateTime.Now,
                },
                new Announcement()
                {
                    Id = Guid.NewGuid(),
                    Title = "App Milestone Reached: Thank You!",
                    Description = "We're thrilled to share that we've reached a significant milestone together! Thanks to your support and engagement, we now have 1000 registered users on our app. We're incredibly grateful for your trust and continued participation. Stay tuned for exciting updates and new features as we continue to grow. Cheers to each and every one of you!",
                    AddDate = DateTime.Now,
                    EditDate = DateTime.Now,
                },
            };
        }
    }
}
