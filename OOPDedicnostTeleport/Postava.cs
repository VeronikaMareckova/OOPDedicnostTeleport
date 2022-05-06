using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDedicnostTeleport
{
     abstract class Postava
    {
        //Atributy
        protected int x;
        protected int y;
        protected string jmeno;

        //Konstruktor
        public Postava(string jmeno)
        {
            this.jmeno = jmeno;
        }


        //GET metody
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        public string GetJmeno()
        {
            return jmeno;
        }
        //SET metody
        public void SetY(int value)
        {
            y = value;
        }
        public void SetX(int value)
        {
            x = value;
        }
        public void SetJmeno(string value)
        {
            jmeno = value;
        }

        //Metody
        public abstract void Jdi();   
        
        public void ZobrazPozice()
        {
            Console.WriteLine("x=[{0}],  y=[{1}]",x,y);
        }
    }
}
