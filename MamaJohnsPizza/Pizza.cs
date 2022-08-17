using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamaJohn_sPizza
{
    /// <summary>
    /// A single pizza
    /// </summary>
    public class Pizza
    {
        // Tell EF Core to make this a Primary Key for Order Id
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The shape of the pizza
        /// </summary>
        public string Shape { get; set; }

        /// <summary>
        /// The number of toppings on the pizza
        /// </summary>
        public int NumOfToppings { get; set; }

        /// <summary>
        /// The crust type of the pizza
        /// </summary>
        public string CrustType { get; set; }

        /// <summary>
        /// The size of the pizza
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// The total cost of the pizza
        /// </summary>
        public double TotalCost { get; set; }
    }
}
