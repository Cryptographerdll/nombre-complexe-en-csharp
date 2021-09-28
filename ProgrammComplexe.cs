using System;

class Complex
{
  public double a, b;

  public Complex(double real, double imag)
  {
    a = real;
    b = imag;
  }

  public double GetReal()
  {
    return a;
  }

  public void SetReal(double a)
  {
    this.a = a;
  }

  public double GetImaginary()
  {
    return b;
  }

  public void SetImaginary(double b)
  {
    this.b = b;
  }

  public new string ToString()
  {
    return "("+a+","+b+")";
  }

  public double GetMagnitude()
  {
    return Math.Sqrt((a * a) + (b * b));
  }

  public void Sum(Complex c)
  {
    a += c.GetReal();
    b += c.GetImaginary();
  }
}

class Test
{
  static void Main()
  {
    Complex c1 = new Complex(4, 8);
    Console.WriteLine("Le nombre est: "+ c1.ToString());

    c1.SetImaginary(6);
    Console.WriteLine("Le nombre est: "+ c1.ToString());

    Console.Write("L'ordre de grandeur: ");
    Console.WriteLine(c1.GetMagnitude());

    Complex c2 = new Complex(-2, 3);
    c1.Sum(c2);
    Console.Write("Après l'addition: ");
    Console.WriteLine(c1.ToString());
  }
}
