namespace CPPPAdvancedProgramming5;

class Program
{
    static void Main(string[] args)
    {
        //Implicit&Explicit Conversion Overloading
        //In short, apart from utilizing from polymorphism or explicit&implicit conversions; there is no way to assign a variable to a different type reference point.
        /*A objA1 = new A(){ANo = 10};
        A objA2 = new A(){ANo = 15};
        B objB1 = new B(){BNo = 20};
        B objB2 = new B(){BNo = 25};
        objA1 = objB1;
        objB2 = (B)objA2;
        Console.WriteLine(objA1.ANo);
        Console.WriteLine(objB2.BNo);*/
    }
}

class A
{
    public int ANo  { get; set; }

    public static implicit operator A(B b)
    {
        return new() {ANo = b.BNo};
    }
}

class B
{
    public int BNo  { get; set; }
    public static explicit operator B(A a)
    {
        return new() {BNo = a.ANo};
    }
}