using FactoryPattern.Abstract;
using FactoryPattern.Concrete;
using FactoryPattern.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryFile
{
    public class Factory
    {
        public Character FactoryMethod(CharacterType characterType)
        {
            Character character = null;
            switch (characterType)
            {
                case CharacterType.Human:
                    character = new Human();
                    break;
                case CharacterType.Dwarf:
                    character = new Dwarf();
                    break;
                case CharacterType.NightElf:
                    character = new NightElf();
                    break;
                case CharacterType.Undead:
                    character = new Undead();
                    break;
            }
            return character;
        }
    }
}
