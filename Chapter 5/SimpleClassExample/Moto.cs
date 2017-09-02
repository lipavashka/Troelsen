using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleClassExample
{
    class Moto
    {
            public int driverIntensity;
    public string driverName;

    #region Constructors
    // Constructors.
    public Moto()
    {
      Console.WriteLine("In default ctor");
    }
    public Moto(int intensity): this(intensity, "")
    {
      Console.WriteLine("In ctor taking an int");
    }
    public Moto(string name) : this(5, name)
    {
      Console.WriteLine("In ctor taking a string");
    }

    // This is the 'master' constructor that does all the real work.
    public Moto(int intensity, string name)
    {
      Console.WriteLine("In master ctor ");
      if (intensity > 10)
      {
        intensity = 10;
      }
      driverIntensity = intensity;
      driverName = name;
    }
    #endregion

    #region Methods
    public void PopAWheely()
    {
      for (int i = 0; i <= driverIntensity; i++)
      {
        Console.WriteLine("Yeeeeeee Haaaaaeewww!");
      }
    }

    public void SetDriverName(string name)
    {
      driverName = name;
    }
    #endregion
    }
}
