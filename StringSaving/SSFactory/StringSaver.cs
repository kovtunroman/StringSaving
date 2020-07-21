using System;
using System.Collections.Generic;
using System.Text;

namespace StringSaving
{
    abstract class StringSaver //это должен быть интерфейс, так как у тебя нет методов, которым нужно предоставлять дефолтную реализацию
    {
        public abstract void Save(string inputString);
    }
}
