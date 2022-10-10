using System.ComponentModel.DataAnnotations;
 

namespace CasCade.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }





 
        public Country Country { get; set; }
    }
}
