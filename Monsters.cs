using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_261117
{
    internal class Monsters
    {
        private int id;
        private string name;
        private int dangerLevel;
        private string habitat;
        private string mainWeakness;
        private string mostCommon;
        private bool isDangerous;

        public Monsters(int id, string name, int dangerLevel, string habitat, string mainWeakness, string mostCommon, bool isDangerous)
        {
            this.id = id;
            this.name = name;
            this.dangerLevel = dangerLevel;
            this.habitat = habitat;
            this.mainWeakness = mainWeakness;
            this.mostCommon = mostCommon;
            this.isDangerous = isDangerous;
        }

        public int Id { get => id;}
        public string Name { get => name;}
        public int DangerLevel { get => dangerLevel;}
        public string Habitat { get => habitat;}
        public string MainWeakness { get => mainWeakness;}
        public string MostCommon { get => mostCommon;}
        public bool IsDangerous { get => isDangerous;}
    }
}
