using System;
using System.Collections.Generic;
using System.text;

namespace _3POO_Licoreria
{
    public abstract class ExtraDecorator : DatosUsuario
    {
        protected DatosUsuario Extras;
        public ExtraDecorator(DatosUsuario Extra)
        {
            Extras = Extra;
        }
    }
}
     