# Project 1 - The Barista
For the procedures used in this project see : [Procedures](Procedures.md)

# Barista API
In this projects should you create an Fluent API for a [barista](https://en.wikipedia.org/wiki/Barista) to create espresso based drinks using code. To get into the Barista domain have a look at [The Ultimate Beginner's Guide to Espresso](https://prima-coffee.com/learn/section/espresso) they also have a [A Beginner's Guide to Espresso](https://www.youtube.com/watch?v=-kd-zX-JOVU) video serie (5 parts).

The API should be made for a barista-programmer, and he/she should be able to produce the following six cofee types using the API:

![Six coffee types](https://www.latteartguide.com/wp-content/uploads/2016/01/different-types-of-coffee-infograph.jpg)

The final method of the API should return a beverage-object of the correct type, depending on the methods which have been executed.

An example of how the API could look (this is pseudo-code!!):

```c#
IBeverage espresso = new FluentEspresso()
                            .AddWater(20)
                            .AddBeans(new Bean(){ 
                                AmountInG = 5,
                                Sort = CoffeSorts.Robusta})
    						.Validate(e => e.Temerature > 90)
                        .ToBeverage();
// espresso is type of Espresso

IBeverage latte = new FluentEspresso()
                            .AddBeans(new Bean(){ 
                                AmountInG = 5,
                                Sort = CoffeSorts.Robusta})
                            .GrindBeans()
                            .AddWater(20)
                            .AddMilk()
       						.Validate(e => e.Temerature < 80)
                        .ToBeverage();
// latte is type of Latte
```

See the IBeverage in code project : [BaristaApi/Beverage.cs](BaristaApi/Beverage.cs)

## The solution 

The solution should cover the following:

- Encapsulation, Inheritance, Polymorphism, Abstraction
- A fluent api, which uses some lambda expressions
- Unit tests, is a must that the solution contains some unit tests

Extra

- The usage of attributes

