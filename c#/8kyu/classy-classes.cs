// Task

// Your task is to complete this Class, the Person class has been created. You must fill in the Constructor method to accept a name as string and an age as number, complete the get Info property and getInfo method/Info getter which should return johns age is 34


public class Person
{   
 public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }

    public string Info
    {
        get { return $"{this.Name}s age is {this.Age}"; }
        
    }
}