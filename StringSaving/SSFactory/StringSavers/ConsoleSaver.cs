using System;
using System.Collections.Generic;
using System.Text;

namespace StringSaving.SSFactory.StringSavers
{
    class ConsoleSaver: StringSaver
    {
        public override void Save(string inputString)
        {
            Console.WriteLine("Console Duplicate of input string:"); //нет должно быть здесь, single responsibility почитать, в идеале солид почитать
            Console.WriteLine(inputString);
        }
    }
}
