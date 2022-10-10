using System.ComponentModel.DataAnnotations;
 

namespace CasCade.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }



 
        public State State { get; set; }
    }
}
