using JapaneseNameGenerator.Entityes;

namespace JapaneseNameGenerator.Models
{
    public struct Person
    {
        public required JpName Name { get; set; }
        public required JpName Surname { get; set; }
        public required SexEntity Sex { get; set; }
        public string RomanjiFullName { get => Name.RomanjiName + " " + Surname.RomanjiName; }
        public string KanjiFullName { get => Name.KanjiName + " " + Surname.KanjiName; }
    }
}