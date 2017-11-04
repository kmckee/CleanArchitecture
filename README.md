# Clean Architecture

This is a starter project with the following features:
* [Domain Centric (Onion) Architecture](http://jeffreypalermo.com/blog/the-onion-architecture-part-1/) design heavily influenced by [Steve Smith](https://ardalis.com/)'s excellent [Pluralsight Course](https://www.pluralsight.com/courses/n-tier-apps-part1).  This promotes a logical and physical separation of concerns in your codebase.
* UI and Core projects do not depend on Entity Framework - persistence is a detail encapsulated in the Infrastructure project.
* Ninject Dependency Injection wired up to MVC without the UI project taking on a Ninject dependency.
* MVC 5
* Code first EF from an empty database.


## ToDo
1. Set up unit testing projects including NSubstitute example.
2. Cucumber for ATDD starter.
