

using System;
using System.Reflection;
class Hello {
    static void Main()
    {
        Console.WriteLine("Hello");
        var p1 = new Point(0, 0);
        var p2 = new Point(10, 20);
        //Console.WriteLine(p1, p2);
        var pair = new Pair<int, string>(1, "one");
        int i = pair.First;     //TFirst int
        string s = pair.Second;
        Point a = new(10, 20);
        Point b = new Point3D(10, 20, 30);
        EditBox editBox = new();
        IControl control = editBox;
        IDataBound dataBound = editBox;
        var turnip = SomeRootVegetable.Turnip;

        var spring = Seasons.Spring;
        var startingOnEquinox = Seasons.Spring | Seasons.Autumn;
        var theYear = Seasons.All;
        var optionalInt = 5;
        var optionalText = "Hello World";

        //  Tuples
        (double Sum, int Count) t2 = (5.8, 4);
        Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}");
        //This 
        int x, y, z;
        x = 3;
        y = 4;
        z = 5;
        Console.WriteLine("x={0} y ={1} z ={2}", x, y, z);
        // Is equivalent to this
        //int x = 3, y = 4, z = 5;
        //string s = "x={0} y={1} z={2}";
        //object[] args = new object[3];
        //args[0] = x;
        //args[1] = y;
        //args[2] = z;
        //Console.WriteLine(s, args);
        Entity.SetNextSerialNo(1000);
        Entity e1 = new();
        Entity e2 = new();
        Console.WriteLine(e1.GetSerialNo().ToString());
        Console.WriteLine(e2.GetSerialNo().ToString());
        Console.WriteLine(Entity.GetNextSerialNo().ToString());
        double Radius = 2.50;
        double area = Math.PI * Radius * Radius;
        Console.WriteLine(area.ToString());
        //Arrays, collections and LINQ
        // One dimensional array iteration 
        int[] c = new int[10];

        for (int k = 0; k < c.Length; k++)
        {
            c[k] = k * k;
        }
        for (int k = 0; k < c.Length; k++)
        {
            Console.WriteLine($"c[{i}] = {c[i]}");
        }

        int[] a1 = new int[10];
        int[,] a2 = new int[10, 5];
        int[,,] a3 = new int[10, 5, 2];

        int[][] d = new int[3][];
        d[0] = new int[74];
        d[1] = new int[5];
        d[2] = new int[20];
        //Longer version
        //int[] e = new int[] { 1, 2, 3 };
        int[] e = { 1, 2, 3 };
         
        foreach(int item in c )
        {
            Console.WriteLine(item.ToString());
        }
        //delegate 
        double[] g = { 0.0, 0.5, 1.0 };
        double[] squares = Apply(g, (x) => x * x);
        double[] sines = Apply(g, Math.Sin);
        Multiplier m = new(2.0);
        double[] doubles = Apply(a, m.Multiply);

        // Atributes
          Type widgetType = typeof(Widget);

         object[] widgetClassAttributes = widgetType.GetCustomAttributes(typeof(HelpAttribute), false);
        if (widgetClassAttributes.Length > 0)
        {
            HelpAttribute attr = (HelpAttribute)widgetClassAttributes[0];
            Console.WriteLine($"Widget class help URL :{attr.Url} - Related topic : {attr.Topic}");
        }
        System.Reflection.MethodInfo displayMethod = widgetType.GetMethod(nameof(Widget.Display));

        object[] displayMethodAttributes = displayMethod.GetCustomAttributes(typeof(HelpAttribute), false);

        if (displayMethodAttributes.Length > 0)
        {
            HelpAttribute attr = (HelpAttribute)displayMethodAttributes[0];
            Console.WriteLine($"Display method help URL : {attr.Url} - Related topic : {attr.Topic}");
        }
        // Microsoft Learn - Hello World Tutorial
        string greeting = "         Hello World   ";
        Console.WriteLine($"[{greeting}]");

        string trimmedGreeting = greeting.TrimStart();
        Console.WriteLine($"[{trimmedGreeting}]");

        trimmedGreeting = greeting.TrimEnd();
        Console.WriteLine($"[{trimmedGreeting}]");

        trimmedGreeting = greeting.Trim();
        Console.WriteLine($"[{trimmedGreeting}]");
        string hello = "Hello World";
        Console.WriteLine(hello.Replace("Hello", "Hi"));
        Console.WriteLine(hello.ToUpper());
        Console.WriteLine(hello.ToLower());
        Console.WriteLine(hello.Contains("ert").ToString());
        Console.WriteLine(hello.StartsWith("mustard").ToString());
        Console.WriteLine(hello.EndsWith("hel").ToString());

        double q = 9;
        double r = 7;
        double u = 5;
        double t = (q + r) / u;
        Console.WriteLine(t.ToString());

        //The list collection
        var names = new List<string> { "<name>", "ibukunoluwa", "Felipe","lolll","kevwe!","!monalisa" };
        names.Add("fearanmi");
        names.Add("Bill");
        names.Remove("Felipe");
        foreach (var name in names)
        {
            Console.WriteLine($"Hello {name.ToUpper()}!");
        }
        names.IndexOf("ibukunoluwa");
        var fibonacciNumbers = new List<int> { 0, 1 };

        for (int ij = 1; ij < 20; i++)
        {
            var listlen = fibonacciNumbers.Count();
            fibonacciNumbers.Add(fibonacciNumbers[listlen - 1] + fibonacciNumbers[listlen - 2]);
        }

        foreach (var item in fibonacciNumbers)
            Console.WriteLine(item.ToString());


    }
    // Traditonal class
    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y) => (X, Y) = (x, y);
    }
    // Generic Classes - Type Parameters 
    public class Pair<TFirst, TSecond>
    {
        public TFirst First { get; }
        public TSecond Second { get; }

        public Pair(TFirst first, TSecond second) => (First, Second) = (first, second);
    }
    //Base Classes
    public class Point3D : Point
    {
        public int Z { get; set; }

        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
    }
    // Structs
    public struct PointStruct
    {
        public double X { get; }
        public double Y { get; }

        public PointStruct(double x, double y) => (X, Y) = (x, y);
    }
    // Interfaces
    interface IControl
    {
        void Paint();
    }

    interface ITextBox : IControl
    {
        void SetText(string text);
    }

    interface IListBox : IControl
    {
        void SetItems(string[] items);
    }

    interface IComboBox : ITextBox, IListBox { }
    //Implementation of interfaces
    interface IDataBound
    {
        void Bind(Binder b);
    }

    public class EditBox : IControl, IDataBound
    {
        public void Paint() { }
        public void Bind(Binder b) { }
    }
    // Enum
    public enum SomeRootVegetable
    {
        HorseRadish,
        Radish,
        Turnip
    }
    // Enums with Flags
    [Flags]
    public enum Seasons
    {
        None = 0,
        Summer = 1,
        Autumn = 2,
        Winter = 4,
        Spring = 8,
        All = Summer | Autumn | Winter | Spring
    }
    // Nullable and non-Nullable types
    int? optionalInt = default;
   
    // C# Program building blocks
    //Field
    public class Color
    {
        public static readonly Color Black = new Color(0, 0, 0);
        public static readonly Color  White = new Color(0, 0, 0);
        public static readonly Color Red = new Color(0, 0, 0);
        public static readonly Color Green = new Color(0, 0, 0);
        public static readonly Color Blue = new Color(0, 0, 0);

        public byte R;
        public byte G;
        public byte B;

        public override string ToString() => "This is an object";
        public Color (byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }
    }
    //Reference variables 
    static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
    public static void SwapExample()
    {
        int i = 1, j = 2;
        Swap(ref i, ref j);
        Console.WriteLine($"{i}{j}");
    }
    // Out variables
    static void Divide (int x, int y, out int quotient,out int remainder)
    {
        quotient = x / y;
        remainder = x % y;
    }
    public static void OutUsage ()
    {
        Divide(10, 3, out int quo, out int rem);
        Console.WriteLine($"{quo} {rem}");
    }
    public class Console
    {
        public static void Write(string fmt, params object[] args) { }
        public static void WriteLine(string fmt, params object[] args) { }
    }
    class Squares
    {
        public static void WriteSquares()
        {
            int i = 0;
            int j;
            while (i < 10)
            {
                j = i * i;
                Console.WriteLine($"{i} x {i} = {j}");
                i++;
            }
        }
    }
    //Static and instance methods 
    class Entity
    {
        static int s_nextSerialNo;
        int _serialNo;

        public Entity()
        {
            _serialNo = s_nextSerialNo++;
        }
        public int GetSerialNo()
        {
            return _serialNo;
        }
        public static int GetNextSerialNo()
        {
            return s_nextSerialNo;
        }
        public static void SetNextSerialNo(int value)
        {
            s_nextSerialNo = value;
        }

        public abstract class Expression
        {
            public abstract double Evaluate(Dictionary<string, object> vars);
        }
        public class Constant : Expression
        {
            double _value;

            public Constant(double value)
            {
                _value = value;
            }
            public override double Evaluate(Dictionary<string, object> vars)
            {
                return _value;
            }
        }
        public class VariableReference : Expression
        {
            string _name;

        }
        // Method overloading 
        class OverloadingExample
        {
            static void F() => Console.WriteLine("F()");
            static void F(object x) => Console.WriteLine("F()");
            static void F(int x) => Console.WriteLine("F()");
            static void F(double x) => Console.WriteLine("F()");
            static void F<T>(T x) => Console.WriteLine("F()");
            static void F(double x, double y) => Console.WriteLine("F()");

            public static void UsageExample()
            {
                F();
                F(1);
                F(1.0);
                F("abc");
                F((double)1);
                F(1, 1);
            }
        }
        // MyList<T>

        // Constructors

        //Properties

        //Indexer

        // Event
        class EventExample
        {
            static int s_changeCount;

            static void ListChanged(object sender, EventArgs e)
            {
                s_changeCount++;
            }
            public static void Usage()
            {
                //list
                Console.WriteLine(s_changeCount.ToString());
            }
        }
        // Operators
        //Finalizers

       
        //Async Await 
        public async Task<int> RetrieveDocsHomePage()
        {
            var client = new HttpClient();
            byte[] content = await client.GetByteArrayAsync("https://docs.microsoft.com/");
            Console.WriteLine($"{{name of(RetrieveDocsHomePage)}}: Finished downloading.");
            return content.Length;
        }
       
        
    }
}




