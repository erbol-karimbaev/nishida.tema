using System;

class Program
{
    static void Main(string[] args)
    {
        
        var nishida = new Nishida("Yuji" + " " +  "Nishida");
        var nishida2 = new Nishida("японский" +" " + "волейболист");
        var nishida3 = new Nishida("рост:" + " " + 1.86 + " " + "см");
        var nishida4 = new Nishida("вес:" + " " + 87 + " "+ "кг");
        var nishida5 = new Nishida("прыжок:" + " " + 351 + " " + "см");
        var nishida6 = new Nishida("блок:" + " " + 330 + " " + "см");



        nishida.name = "позиция:";
        nishida.surname = "диагональный";
        (string userName, string fullName) = nishida;
        Console.WriteLine(userName + " " + fullName);








    }
    class Nishida
    {
        public string name;
        public string surname;
        public double height;
        public int wieght;
        public char spike;
        public int block;
        public string japan;
        

        public void Deconstruct(out string userName, out string fullName)
        {
            userName = name;
            fullName = surname;
        }

        public Nishida(string name)
        {
            this.name = name;
            Console.WriteLine(this.name);

        }
        public Nishida(  )
        {
            this.japan = japan;
            Console.WriteLine(this.japan);

        }

        public Nishida( double height)
        {
            this.height = height;
            Console.WriteLine(this.height);
        }

        public Nishida (int wieght)
        {
            this.wieght = wieght;
            Console.WriteLine(this.wieght);
        }


        public Nishida ( char spike)
        {
            this.spike = spike;
            Console.WriteLine(this.spike);
        }

        public Nishida( int block, int bl)
        {
            this.block = block;
            Console.WriteLine(this.block);
        }
    }
    }