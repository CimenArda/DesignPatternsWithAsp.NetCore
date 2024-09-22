##  Design Patterns in ASP.NET Core

This repository contains simple, beginner-friendly implementations of 11 essential design patterns in ASP.NET Core. Each pattern helps solve common software design challenges by organizing code in a way that's easier to understand, extend, and maintain. These mini-projects are designed to help newcomers practice and grasp the fundamental concepts behind design patterns, making it easier to build more structured and scalable applications in the future.
> ## Table of Contents

1.  [Chain of Responsibility](#chain-of-responsibility)
2.  [CQRS](#cqrs)
3.  [Template Method](#template-method)
4.  [Observer](#observer)
5.  [Unit of Work](#unit-of-work)
6.  [Repository](#repository)
7.  [Composite](#composite)
8.  [Mediator](#mediator)
9.  [Iterator](#iterator)
10. [Facade](#facade)
11. [Decorator](#decorator)
### Chain of Responsibility

This pattern passes a request along a chain of handlers. Each handler decides either to process the request or pass it to the next handler in the chain.

----------

### CQRS

CQRS (Command Query Responsibility Segregation) separates read and write operations for a data store, allowing for optimized handling of both operations.

----------

### Template Method

The Template Method pattern defines the skeleton of an algorithm in a method, allowing subclasses to override specific steps without changing its overall structure.

----------

### Observer

The Observer pattern establishes a subscription mechanism to notify multiple objects about any events that happen to the observed object.

----------

### Unit of Work

The Unit of Work pattern maintains a list of objects affected by a business transaction and coordinates the writing out of changes.

----------

### Repository

The Repository pattern abstracts the data layer, providing a clean API to access domain objects while separating business logic from data access code.

----------

### Composite

Composite pattern allows clients to treat individual objects and compositions of objects uniformly by organizing objects into tree structures.

----------

### Mediator

Mediator pattern defines an object that encapsulates how a set of objects interact, promoting loose coupling by preventing direct communication between objects.

----------

### Iterator

Iterator pattern provides a way to access the elements of a collection sequentially without exposing its underlying representation.

----------

### Facade

The Facade pattern provides a simplified interface to a complex system of classes, libraries, or frameworks.

----------

### Decorator

The Decorator pattern allows behavior to be added to individual objects, dynamically, without affecting the behavior of other objects from the same class.
