using System;
using System.Collections.Generic;
using System.Text;
using StringSaving.SSFactory.StringSavers;

namespace StringSaving.SSFactory.StringSaverFactories
{
    class FileSaverFactory: StringSaverFactory
    {
        public override StringSaver Create()
        {
            return new FileSaver();
        }
    }
}
