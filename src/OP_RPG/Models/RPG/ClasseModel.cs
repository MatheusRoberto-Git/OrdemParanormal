using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Hosting;

namespace OP_RPG.Models.RPG
{
    [Table("Classes")]
    public class ClasseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClasseID { get; set; }

        [Key]
        [MaxLength(50)]
        public string? Classe { get; set; }

        [Required]
        [MaxLength(5000)]
        public string? Descricao { get; set; }

        [Required]        
        public int PtVidaInicial { get; set; }

        [Required]
        public int PtVidaNex { get; set; }

        [Required]
        public int PtEsforcoInicial { get; set; }

        [Required]
        public int PtEsforcoNex { get; set; }

        [Required]
        public int SanidadeInicial { get; set; }

        [Required]
        public int SanidadeNex { get; set; }

        [Required]
        [MaxLength(1000)]
        public string? PericiasTreinadas { get; set; }

        [Required]
        [MaxLength(1000)]
        public string? Proficiencias { get; set; }

        [Required]
        [MaxLength(1000)]
        public string? HabilidadeClasse { get; set; }

        [Required]
        [MaxLength(1000)]
        public string? HabilidadeClasseDesc { get; set; }

        public List<TrilhaModel>? Trilhas { get; set; }
    }
}
