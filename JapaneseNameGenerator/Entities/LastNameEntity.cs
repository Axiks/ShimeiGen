using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JapaneseNameGenerator.Entityes
{
    [Table("last_names")]
    public class LastNameEntity
    {
        [Key]
        [Column("noid")]
        public int Id { get; set; }

        [Column("name")]
        public string? Name { get; set; }
    }
}
