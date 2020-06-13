# SingletonDemo
A simple demo of how to implement Singleton Pattern

The Singleton pattern is implemented in two steps:
   1. Ensure that every constructor in the class implementing the Singleton pattern is Non-Public. All constructors must be Protected or Private. 
   2. Implement a Public shared method that creates just one instance of the class.

How do a private constructor and a shared factory method ensure that there is only one instance of the class? 
   The answer is that consumers cannot invoke non-Public constructors; hence they cannot create instances of your class except in the manner you prescribe (example the "Create()" method or the "GetInstance()" property below).
   However, member methods can invoke protected or private methods and can call your Non-Public constructors. 
   The result is that you control the number of instances of your class by controlling access to the constructor.
   
![demo](https://user-images.githubusercontent.com/5296677/84559206-5b1db180-ad6b-11ea-95e7-74026a5c88d5.gif)
