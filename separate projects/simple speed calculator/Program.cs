using System;

class Program {
  public static void Main (string[] args) 
  {
    
    int speedObjectOne = 0, speedObjectTwo = 0, weightObjectOne = 0, weightObjectTwo = 0;
    int factoringOne, weightSum, factoringTwo, factoringSum, finalSpeed;
    

    Console.Write($"Enter Object One's weight: ");
    weightObjectOne = int.Parse(Console.ReadLine());
    
    Console.Write("Enter Object Two's weight: ");
    weightObjectTwo = int.Parse(Console.ReadLine());
    
    Console.Write("Enter Object One's speed: ");
    speedObjectOne = int.Parse(Console.ReadLine());

    Console.Write("Enter Object Two's speed: ");
    speedObjectTwo = int.Parse(Console.ReadLine());
    
    factoringOne = weightObjectOne * speedObjectOne;
    factoringTwo = weightObjectTwo * speedObjectTwo;
    weightSum = weightObjectOne + weightObjectTwo;
    factoringSum = factoringOne + factoringTwo;
    finalSpeed = factoringSum / weightSum;

    Console.WriteLine($"Final speed is {finalSpeed}");  
  }
}