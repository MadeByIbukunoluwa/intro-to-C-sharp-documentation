

using System;
using System.Reflection;

    class Hello
{
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
   
  
}




