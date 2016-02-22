using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nanny
{
    public class ChildCare
    {
        #region Fields

        private static int lastChildCareID = 0;

        #endregion

        #region Properties

        public int ChildCareID { get; set; }
        [Index("ChildCareIdentityUIX", IsClustered = false, IsUnique = true, Order = 1)]
        [StringLength(128)]
            [Required]

        public string ChildCareName { get; set; }
        [Index("ChildCareIdentityUIX", IsClustered =false, IsUnique = true, Order = 2)]
        [StringLength(128)]

        public string ChildCareAddress { get; set; }
        public string ChildCareDescription { get; set; }
        public decimal ChildCareRating { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        #endregion

        #region Constructors

        public ChildCare()
        {
            ChildCareID = ++lastChildCareID;
        }

        #endregion
    }
}
