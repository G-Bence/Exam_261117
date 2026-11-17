namespace Exam_261117;

class Program
{
    static void Main(string[] args)
    {
      List< Monsters > monsters = new List<Monsters>();

      MonserDataBase data = new MonserDataBase();

        data.uploadMonster(monsters);

        monsters.ForEach(monster =>
        {
            Console.WriteLine($"ID: {monster.Id}, Name: {monster.Name}, Danger Level: {monster.DangerLevel}, Habitat: {monster.Habitat}, Main Weakness: {monster.MainWeakness}, Most Common: {monster.MostCommon}, Is Dangerous: {monster.IsDangerous}");
        });


    }
}