using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDedicnostTeleport
{
    class Teleportacek : Postava
    {
        static Random r = new Random();
        public Teleportacek(string jmeno) : base(jmeno)
        {
        }

        public override void Jdi()
        {
            int x = r.Next(10); //vyvoreni cisla pro x 
            int y = r.Next(10); //vyvoreni cisla pro y

            //nastaveni hodnot
            this.x = x; // this.x odkazuje na x POSTAVY
            this.y = y; // this.y odkazuje na y POSTAVY
        }
    }
}
