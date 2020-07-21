using System;
using System.Collections.Generic;
using System.Text;

namespace StringSaving
{
    abstract class StringSaverFactory
    {
        public abstract StringSaver Create();
    }
}
