using Kawazu;

namespace JapaneseNameGenerator
{
    public static class KawazuHelper
    {
        private static KawazuConverter _converter = new KawazuConverter();
        public async static Task<string> ConverterToRomanjiAsync(string kanji)
        {
            return await _converter.Convert(kanji, To.Romaji, Mode.Normal, RomajiSystem.Nippon);
        }
    }
}
