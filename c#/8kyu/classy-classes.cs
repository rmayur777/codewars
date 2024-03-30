// Task

// Your task is to complete this Class, the Person class has been created. You must fill in the Constructor method to accept a name as string and an age as number, complete the get Info property and getInfo method/Info getter which should return johns age is 34


public class Person
{  
  private string Name;
  private int Age;
  public string Info => $"{Name}s age is {Age}";

  public Person(string name, int age)
  {
    Name = name;
    Age = age;
  }
}