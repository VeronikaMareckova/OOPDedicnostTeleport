using System;
using System.Collections.Generic;

namespace OOPDedicnostTeleport
{
    class Program
    {
        static void Main(string[] args)
        {
            //OBJEKTy
            Postava p1 = new Levacek("Martin L.");
            Postava p2 = new Pravacek("Eva P.");
            Postava p3 = new Teleportacek("Tomáš T.");
            Postava p4 = new Teleportacek("Kateřina T.");


            List<Postava> postavy = new List<Postava>() { p1,p2,p3,p4};

            foreach(var postava in postavy)
            {
                postava.Jdi();
            }

            //p1.Jdi();
            //p2.Jdi();
            //p3.Jdi();
            //p4.Jdi();
            //p5.Jdi();
            //p6.Jdi();

            foreach (var postava in postavy)
            {
                //Console.WriteLine(postava.GetJmeno());
                postava.ZobrazPozice();
            }

        }
    }
}
