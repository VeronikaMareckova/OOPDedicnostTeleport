using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDedicnostTeleport
{
    class Pravacek : Postava
    {
        public Pravacek(string jmeno) : base(jmeno)
        {
        }

        public override void Jdi()
        {
            x++;
        }
    }
}
