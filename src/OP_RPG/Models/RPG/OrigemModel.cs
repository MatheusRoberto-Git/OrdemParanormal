using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OP_RPG.Models.RPG
{
    [Table("Origens")]
    public class OrigemModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrigemID { get; set; }

        [Key]
        [MaxLength(25)]
        public string? Origem { get; set; }

        [Required]
        [MaxLength(500)]
        public string? Descricao { get; set; }

        public string? Pericia_1 { get; set; }

        public string? Pericia_2 { get; set; }

        [Required]
        [MaxLength(35)]
        public string? Poder_Origem { get; set; }

        [Required]
        [MaxLength(500)]
        public string? Descricao_Poder { get; set; }        
    }
}