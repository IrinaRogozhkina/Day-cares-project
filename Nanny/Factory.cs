using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanny
{
    public static class Factory
    {
        #region Methods

        public static User CreateUser(string name, string address, string email)
        {
            using (var db = new FactoryModel())
            {
                var u = new User();

                u.UserName = name;
                u.UserAddress = address;
                u.UserEmail = email;

                db.Users.Add(u);
                db.SaveChanges();
                return u;
            }
        }

        public static Review CreateReview(int userID, int childCareID, int rate)
        {
         /*   var id = user.Reviews.Where(p => p.ChildCareID == childCareID).FirstOrDefault();
            if (id != null)
                throw new Exception("User already rated the ChildCare");*/

            using (var db = new FactoryModel())
            {
                User user = db.Users.Where(x => (x.UserID == userID)).Single();

                var id = user.Reviews.Where(p => p.ChildCareID == childCareID).FirstOrDefault();
                if (id != null)
                    throw new Exception("User already rated the ChildCare");

                var r = new Review();

                r.ChildCareID = childCareID;
                r.UserID = userID;
                r.Rate = rate;

                user.Reviews.Add(r);
                db.Reviews.Add(r);
                db.SaveChanges();
                RatingUpdate(db, userID, childCareID, rate);
                return r;
            }
        }

        public static ChildCare CreateChildCare(string name, string address, string description)
        {
            using (var db = new FactoryModel())
            {
                var ch = new ChildCare();

                ch.ChildCareName = name;
                ch.ChildCareAddress = address;
                ch.ChildCareDescription = description;

                db.ChildCares.Add(ch);
                db.SaveChanges();
                return ch;
            }
        }

        public static decimal RatingUpdate(FactoryModel db, int userID, int childCareID, int rating)
        {
            if (rating < 1 || rating > 5)
                return 0;
            var rate = db.ChildCares.Where(s => s.ChildCareID == childCareID).FirstOrDefault();
               if (rate.ChildCareRating == 0)
                {
                    rate.ChildCareRating = rating;
                }
                else
                {
                    rate.ChildCareRating = (rating + rate.ChildCareRating) / 2;
                }
                db.SaveChanges();
                return rate.ChildCareRating;
        }

        #endregion
    }
}
