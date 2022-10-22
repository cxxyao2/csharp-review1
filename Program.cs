using System;
using System.IO;

namespace HelloWorld
{
   enum Level {
        Low, Medium, High
      };
  interface Swim{
    bool canSwim();
  }
  abstract class Animal{
    public abstract void animalSound();
    public void sleep(){
      Console.WriteLine("ZZZ");
    }

  }

  class Pig: Animal,Swim {
    public string piggy;
    public Pig() {
      piggy = "heir of pig family";
    }
    public override void animalSound()
    {
      Console.WriteLine("The pig says: wee wee");
      throw new NotImplementedException("Please save me. I am not good at swimming.");
    }

    public bool canSwim(){
      return true;
    }
  }

  class Program
  {
   static string addThree(string arg1 = "Dogs") {
    return arg1 + arg1 + "are human frients";
   }
    static int addThree(int arg1 =5 ){
      return arg1 * 3;
    }
    static void Main(string[] args)
    {
      string writeText="Hello Jennifer";
      File.WriteAllText("jennifernote.txt",writeText);

      string readText = File.ReadAllText("jennifernote.txt");
      Console.WriteLine(readText);

      Console.WriteLine("Sqrt(64)"+ Math.Sqrt(64)+" Level " + Level.Medium);
      Console.WriteLine("Hello Jennifer!" + "new Return is"+  addThree(5));
      Console.WriteLine("Hello Jennifer!" + "new Return is"+  addThree(7));
      Console.WriteLine("Hello Jennifer!" + "new friend is"+  addThree("cat"));
       Pig  tom = new Pig();
       Console.WriteLine("Can pig swim", tom.piggy + " can swim " + tom.canSwim());
       try {
       new Pig().animalSound();

       }catch(Exception e) {
        Console.WriteLine("error is"+ e.Message +  "Something go wrong");
       }
    }
  }
}