using System;
using System.Linq;

namespace Exam_261117;

class Program
{
    static void Main(string[] args)
    {
      List< Monsters > monsters = new List<Monsters>();

      MonserDataBase data = new MonserDataBase();

        data.uploadMonster(monsters);

        //monsters.ForEach(monster =>
        //{
        //    Console.WriteLine($"ID: {monster.Id}, Name: {monster.Name}, Danger Level: {monster.DangerLevel}, Habitat: {monster.Habitat}, Main Weakness: {monster.MainWeakness}, Most Common: {monster.MostCommon}, Is Dangerous: {monster.IsDangerous}");
        //});


        MonsterAnalysis analysis = new MonsterAnalysis(monsters);

        Console.WriteLine($"Number of monsters: {analysis.CountAllMonsters()}");
        Console.WriteLine("\n");

        Console.WriteLine("Dangrous Monsters:");
        analysis.NameOfDangerousMonsters().ToList().ForEach(name => Console.WriteLine($"- {name}"));
        Console.WriteLine("\n");

        Console.WriteLine("Unique Habitats: ");
        analysis.UniqueHabitats().ToList().ForEach(habitat => Console.WriteLine($"- {habitat}"));
        Console.WriteLine("\n");

        Console.WriteLine("Average Danger Level: ");
        Console.WriteLine(analysis.AverageDangerLevel().ToString("0.00"));
        Console.WriteLine("\n");

        Console.WriteLine("Most Dangerous Monsters: ");
        analysis.MostDangerousMonsters().ToList().ForEach(monster => Console.WriteLine($"- {monster.Name} (Danger Level: {monster.DangerLevel})"));
        Console.WriteLine("\n");

        Console.WriteLine("Dangerous Swamp Monsters: ");
        analysis.SwampDangerousMonsters().ToList().ForEach(monster => Console.WriteLine($"- {monster.Name} (Danger Level: {monster.DangerLevel})"));
        Console.WriteLine("\n");

        Console.WriteLine(analysis.DangerousFierWeakMonsters() ? "There IS dangerous monster sensible for fier" : "There is NO dangerous monster sensible for fier");
        Console.WriteLine("\n");

        Console.WriteLine("Monsters By their Habitats: ");
        analysis.MonstersNumberByHabitats().ToList().ForEach(habitat => Console.WriteLine($"- {habitat}"));
    }
}