using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JapaneseNameGenerator.Entityes
{
    [Table("first_names")]
    public class FirstNameEntity
    {
        [Key]
        [Column("foid")]
        public int Id { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("sex")]
        public SexEntity Sex { get; set; }

        [Column("popularity")]
        public float? Popularity { get; set; }
    }
}
