namespace JapaneseNameGenerator.Models
{
    public struct JpName
    {
        private string _kanjiName;
        public JpName(string kanjiName)
        {
            _kanjiName = kanjiName;
        }
        public async Task<string> GetKanjiAsync() => _kanjiName;
        public async Task<string> GetRomanjiAsync()
        {
            return await KawazuHelper.ConverterToRomanjiAsync(_kanjiName);
        }
    }
}
