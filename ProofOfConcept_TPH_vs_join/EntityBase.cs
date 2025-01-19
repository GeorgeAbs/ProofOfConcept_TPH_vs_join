using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProofOfConcept_TPH_vs_2_queries
{
    public abstract class EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; private set; } 

        public DateTime Created {  get; set; } = DateTime.UtcNow;
    }
}
