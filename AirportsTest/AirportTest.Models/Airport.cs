using System.ComponentModel.DataAnnotations.Schema;

namespace AirportTest.Models
{
    public class Airport: IEntityBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public double Lat { get; set; }

        public double Lon { get; set; }

    }
}
