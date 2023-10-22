using JapaneseNameGenerator.Entityes;

namespace JapaneseNameGenerator.Models
{
    public struct Person
    {
        public required JpName Name { get; set; }
        public required JpName Surname { get; set; }
        public required SexEntity Sex { get; set; }
        public string RomanjiFullName { get => Name.GetRomanjiAsync().Result + " " + Surname.GetRomanjiAsync().Result; }
        public string KanjiFullName { get => Name.GetKanjiAsync().Result + " " + Surname.GetKanjiAsync().Result; }
    }
}