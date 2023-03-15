namespace ConsoleApp30
{
    internal class Drob
    {
        public int Numerator;
        public int Denominator;
        public Drob()
        {
        }

        public Drob(int chiselnik, int znamennuk)
        {
            this.Numerator = chiselnik;
            this.Denominator = znamennuk;
        }
        public static Drob operator +(Drob a, Drob b)
        {
            int one = a.Numerator * b.Denominator + a.Denominator * b.Numerator;
            int two = a.Denominator * b.Denominator;
            return new Drob(one, two);
        }
        public static Drob operator -(Drob a, Drob b)
        {
            int one = a.Numerator * b.Denominator - a.Denominator * b.Numerator;
            int two = a.Denominator * b.Denominator;
            return new Drob(one, two);
        }
        public static Drob operator *(Drob a, Drob b)
        {
            int one = a.Numerator * b.Numerator;
            int two = a.Denominator * b.Denominator;
            return new Drob(one, two);
        }
        public static Drob operator /(Drob a, Drob b)
        {
            int one = a.Numerator * b.Denominator;
            int two = a.Denominator * b.Numerator;
            return new Drob(one, two);
        }
    }
    public class DrobController
    {
        private List<Drob> drobs;

        public DrobController()
        {
            drobs = new List<Drob>();
        }
        public void SaveToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var d in drobs)
                {
                    writer.WriteLine(d.Denominator);
                    writer.WriteLine(d.Numerator);
                }
            }
        }
        public void Calc()
        {
            var a = new Drob();
            Console.WriteLine("Enter 1 drob Numerator");
            a.Numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1 drob Denominator");
            a.Denominator = Convert.ToInt32(Console.ReadLine());
            var b = new Drob();
            Console.WriteLine("Enter 2 drob Numerator");
            b.Numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2 drob Denominator");
            b.Denominator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter action:");
            var action = Console.ReadLine();
            var result = new Drob();
            switch (action)
            {
                case "+":
                    result = a + b;
                    break;
                case "/":
                    result = a / b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "-":
                    result = a - b;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{result.Numerator}/{result.Denominator}");
        }
        public void LoadFromFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    Drob d = new Drob();
                    d.Denominator = Convert.ToInt32(reader.ReadLine());
                    d.Numerator = Convert.ToInt32(reader.ReadLine());
                    drobs.Add(d);
                }
            }
        }
        public void AddDrob()
        {
            Drob c = new Drob();
            Console.WriteLine("Enter denominator:");
            c.Denominator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter numerator:");
            c.Numerator = Convert.ToInt32(Console.ReadLine()); 
            drobs.Add(c);
        }

        public void ShowDrobs()
        {
            Console.WriteLine("Drobs:");
            foreach (var d in drobs)
            {
                Console.WriteLine($"{d.Denominator}/{d.Numerator}");
            }
        }
    }
}
