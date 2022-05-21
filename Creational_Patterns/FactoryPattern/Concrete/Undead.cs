using FactoryPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Concrete
{
    public class Undead : Character
    {
        public override string GetCharacter() => "This character is a Undead!";
    }
}
