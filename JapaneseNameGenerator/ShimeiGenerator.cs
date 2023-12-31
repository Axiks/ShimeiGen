﻿using JapaneseNameGenerator.Entityes;
using JapaneseNameGenerator.Models;
using System.Xml.Linq;

namespace JapaneseNameGenerator
{
    public class ShimeiGenerator
    {
        private static AppDbContext _dbContext;
        private static int _nameCount;
        private static int _surnameCount;
        private static Random _random;
        public ShimeiGenerator()
        {
            string root = Environment.CurrentDirectory;
            _dbContext = new AppDbContext(root);
            Init();
        }

        public ShimeiGenerator(string pathToFolder)
        {
            _dbContext = new AppDbContext(pathToFolder);
            Init();
        }

        private void Init()
        {
            _nameCount = _dbContext.FirstNames.Count();
            _surnameCount = _dbContext.LastNames.Count();
            _random = new Random();
        }

        private (JpName name, SexEntity sex) GetRandomPersonAtom()
        {
            int randIdPosition = _random.Next(1, _nameCount);
            var nameEntity = _dbContext.FirstNames.FirstOrDefault(x => x.Id == randIdPosition && x.Name != null && x.Name != "");
            var result = new JpName(nameEntity.Name);
            if (result.RomanjiName == "") return GetRandomPersonAtom(); // Generate another value if translation through dictionary failed
            return (result, sex: nameEntity.Sex);
        }
        private JpName GetRandomSurname()
        {
            int randIdPosition = _random.Next(1, _surnameCount);
            var nameEntity = _dbContext.LastNames.FirstOrDefault(x => x.Id == randIdPosition && x.Name != null && x.Name != "");
            var result = new JpName(nameEntity.Name);
            if (result.RomanjiName == "") return GetRandomSurname(); // Generate another value if translation through dictionary failed
            return result;
        }
        public async Task<Person> GetRandomPerson()
        {
            var personAtom = GetRandomPersonAtom();
            return new Person{ Name = personAtom.name, Surname = GetRandomSurname(), Sex = personAtom.sex };
        }
    }
}