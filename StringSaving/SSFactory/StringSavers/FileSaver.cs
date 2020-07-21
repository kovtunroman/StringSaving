using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace StringSaving.SSFactory.StringSavers
{
    class FileSaver: StringSaver
    {
        public override void Save(string inputString)
        {
            string path = @"D:\Projects\StringSaving\stringsaverfile.txt";

            using (FileStream fstream = new FileStream($"{path}", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(inputString);
                fstream.Write(array, 0, array.Length);
            }

            Console.WriteLine($"String saved in the {path}");// в классах не должно быть методов вывода в консоль, это должно быть где-то в другом месте

        }
    }
}
