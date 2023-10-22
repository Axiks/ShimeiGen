using System;

namespace JapaneseNameGenerator.Models
{
    public class JpName
    {
        public string KanjiName { get; }
        public string RomanjiName { get; }
        public JpName(string kanjiName)
        {
            KanjiName = kanjiName;
            RomanjiName = KawazuHelper.ConverterToRomanjiAsync(kanjiName).Result;
        }
    }
}
