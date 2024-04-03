using System.ComponentModel.DataAnnotations;

namespace BirdSaleAPI.Data
{
    public class BirdCategory
    {
        [Key]
        public int PkId { get; set; }
        public string Name { get; set; }
    }
}
