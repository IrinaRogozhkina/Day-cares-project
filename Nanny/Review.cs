using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanny
{
    public class Review
    {
        #region Fields

        private static int lastReviewID = 0;

        #endregion

        #region Properties

        public int ReviewID { get; set; }
        public int Rate { get; set; }
        public int UserID { get; set; }
        public int ChildCareID { get; set; }

        public virtual User User { get; set; }
        public virtual ChildCare ChildCare { get; set; }

        #endregion

        #region Constractors

        public Review()
        {
            ReviewID = ++lastReviewID;
        }

        #endregion
    }
}
