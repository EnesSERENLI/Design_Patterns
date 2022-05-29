using FactoryPattern.Abstract;
using FactoryPattern.FactoryFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();

            Character human = factory.FactoryMethod(Enums.CharacterType.Human);
            Character dwarf = factory.FactoryMethod(Enums.CharacterType.Dwarf);
            Character nightElf = factory.FactoryMethod(Enums.CharacterType.NightElf);
            Character undead = factory.FactoryMethod(Enums.CharacterType.Undead);

            string result1 = human.GetCharacter();
            string result2 = dwarf.GetCharacter();
            string result3 = nightElf.GetCharacter();
            string result4 = undead.GetCharacter();

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);

            Console.Read(); 
        }
    }
}
