using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exam_261117
{
    internal class MonsterAnalysis
    {
        private List<Monsters> monsters;

        public MonsterAnalysis(List<Monsters> monsters)
        {
            this.monsters = monsters;
        }

        public int CountAllMonsters()
        {
            return monsters.Count;
        }

        public IEnumerable<string> NameOfDangerousMonsters()
        {
            return monsters.Where(m => m.IsDangerous).Select(m => m.Name);
        }

        public IEnumerable<string> UniqueHabitats()
        {
            return monsters.Select(m => m.Habitat).Distinct().OrderBy(m => m);
        }

        public double AverageDangerLevel()
        {
            return monsters.Average(m => m.DangerLevel);
        }

        public IEnumerable<Monsters> MostDangerousMonsters()
        {
            return monsters.Where(m => m.DangerLevel == monsters.Max(monster => monster.DangerLevel));
        }

        public IEnumerable<Monsters> SwampDangerousMonsters()
        {
            return monsters.Where(m => m.Habitat == "Fekete Mocsár" && m.DangerLevel >= 5);
        }

        public bool DangerousFierWeakMonsters()
        {
            return monsters.Any(m => m.MainWeakness == "Tűz" && m.DangerLevel >= 9);
        }

        public IEnumerable<string> MonstersNumberByHabitats()
        {
            return monsters.GroupBy(m => m.Habitat).Select(g => $"{g.Key}: {g.Count()}");
        }
    }
}
