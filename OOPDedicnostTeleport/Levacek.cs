using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDedicnostTeleport
{
    class Levacek : Postava
    {
        public Levacek(string jmeno) : base(jmeno)
        {
        }

        public override void Jdi()
        {
            x--;
        }
    }
}
