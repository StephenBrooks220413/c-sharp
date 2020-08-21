using System;

class MainClass {
  public static void Main (string[] args) {

    bool name = true;
    string author = "Stephen";
    int age = 40;
    Console.WriteLine(author + " is " + age + " that is " + name);
    Console.WriteLine($"Hello my name is {author}, I am {age} years old, and it is {name} that I live in Oklahoma");
    //Console.ReadLine();
  }
}