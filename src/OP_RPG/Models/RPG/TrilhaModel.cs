using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace OP_RPG.Models.RPG
{
    [Table("Trilhas")]
    public class TrilhaModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TrilhaID { get; set; }

        [Key]
        [MaxLength(50)]
        public string? Trilha { get; set; }

        [Required]
        [MaxLength(5000)]
        public string? Descricao { get; set; }

        [ForeignKey("ClasseModel")]
        [MaxLength(50)]
        public string? Classe { get; set; }

        public virtual ClasseModel? ClasseModel { get; set; }
    }
}
