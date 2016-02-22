using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nanny
{
    public class User
    {
        #region Fields

        private static int lastUserID = 0;

        #endregion

        #region Properties
         
        public int UserID { get; set; }

        [Index("UserIdentityUIX", IsClustered = true, IsUnique = true, Order = 1)]
        public string UserName { get; set; }
        [Index("UserIdentityUIX", IsClustered = true, IsUnique = true, Order = 2)]
        public string UserAddress { get; set; }
        [Index("UserIdentityUIX", IsClustered = true, IsUnique = true, Order = 3)]
        public string UserEmail { get; set; }
    //    public int UserReviewID { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        #endregion

        #region Constructors

        public User()
        {
            //UserID = ++lastUserID;
            //Console.WriteLine("Called again {0}", UserID);
        }

        #endregion

        #region Methods

   /*     public static decimal RatingUpdate(int childCareID, int rating)
        {
            var user = new User();
           
            var id = user.Reviews.Where(p => p.ChildCareID == childCareID);
            if (id != null)
                throw new ArgumentException("User already rated the ChildCare");
            if (rating < 1 || rating > 5)
                return 0;

            using (var db = new FactoryModel())
            {
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

        }*/

        #endregion
    }
}
