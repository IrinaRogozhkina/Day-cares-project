using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanny
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Factory.CreateUser("Ira", "Woodinville", "snleo32@gmail.com");
            var y = Factory.CreateUser("Sasha", "Redmond", "kokoko@gmail.com");
            
            var a = Factory.CreateChildCare("Sarojini", "Bellevue", "Cool");
            var b = Factory.CreateChildCare("Fairyland", "Bellevue", "Not cool");
             
            var s = Factory.CreateReview(x.UserID, a.ChildCareID, 5);
            var t = Factory.CreateReview(x.UserID, b.ChildCareID, 3);

            /*  var x = Factory.RatingUpdate(1, 5);
              var y = Factory.RatingUpdate(1, 4);
              var z = Factory.RatingUpdate(2, 3);
              var a = Factory.RatingUpdate(2, 7);*/
            //   var a = Factory.CreateUser("Jenya", "Bellevue", "frt@gmail.com");
            //  var x = Factory.CreateReview(3, 1, 5);
            //var x = Factory.CreateChildCare("ABC", "Bellevue", "Rock!");
            // var s = Factory.CreateReview(1, 3, 5);

        }
    }
}
;