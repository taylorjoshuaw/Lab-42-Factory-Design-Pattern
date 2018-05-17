# Document Factory

**Author**: Joshua Taylor
**Version**: 1.0.0

## Overview

This project is a demonstration of implementing the factory method pattern
from the Gang of Four's [_Design Patterns_](https://www.amazon.com/Design-Patterns-Elements-Reusable-Object-Oriented/dp/0201633612).
The scenario of this example is for generating pages using the factory method
pattern for two types of documents: resumes and APA reports. These document
classes derive from an abstract _Document_ class and implement a method called
_MakePage_ which implements the factory method pattern.

## Getting Started

Document Factory is a console application targeting the .NET Core 2.0 platform. The
.NET Core 2.0 SDK can be downloaded from the following URL for Windows, Linux,
and macOS:

https://www.microsoft.com/net/download/

The dotnet CLI utility can be used to build and run the application (after
cloning this repository):

    cd DocumentFactory/DocumentFactory
    dotnet build
    dotnet run

Additionally, users can build, debug, and run Document Factory using Visual Studio
2017 or greater by opening the solution file from this repository.
All dependencies are referenced via NuGet and should be brought in during
the restore process. If this does not occur, the following will download all
needed dependencies:

    dotnet restore

## Operation

![Screenshot](/assets/screenshot.JPG)

## Classes

### Document

An abstract class containing the abstract _MakePage_ factory method to
be overridden by any classes assignable to _Document_. In addition,
_Document_ contains a _Type_ property which provides a human-readable
string representation of the type of document being used.

#### Resume

Concrete class deriving from _Document_ which contains an override for the
_MakePage_ method which switches on its string parameter to decide which
_Page_ assignable class to instantiate and return to the caller. These
class types match against the names of _Page_ assignable classes found within
the _DocumentFactory.Pages.Resume_ namespace. These classes all represent
pages found within a real-world resume. If no match is found, then this 
factory method simply returns null.

#### Report

Concrete class deriving from _Document_ which contains an override for the
_MakePage_ method which switches on its string parameter to decide which
_Page_ assignable class to instantiate and return to the caller. These
class types match against the names of _Page_ assignable classes found within
the _DocumentFactory.Pages.Report namespace. These classes all represent
pages found within a real-world APA report. If no match is found, then
this factory method simply returns null.

### Page

An abstract class containing the abstract _Type_ and _Content_ string
properties representing a human-readable type name of the page ("Cover
Letter" for the _CoverLetter_ class) and the body of the page (respectively)
when overridden by any _Page_ assignable class. All classes deriving from
_Page_ can be found within the _DocumentFactory.Pages.Resume_ and
_DocumentFactory.Pages.Report_ namespaces. Additionally, an override to
the ToString() method is provided which provides a nicely formatted string
representation of the page using its _Type_ and _Content_ properties.

## Factory Method Pattern

The factory method pattern involves a method that can be overridden to provide
a means of instantiating objects using polymorphism to change the behavior
of constructing the requested objects. This can include choosing a specific
child class and/or initializing the instantiated object's state based on 
arguments to the factory method or some form of state found within the factory's
class or elsewhere in the running program. In this example, the _Document_ 
abstract class specifies a _MakePage_ method which implements this pattern and
returns a new object assignable from the _Page_ abstract class based on
_MakePage_'s string argument.

### Product

The product of this factory method implementation is a new object that is
assignable to the _Page_ abstract class. If using the _Resume_ class (derived
from _Document_), then this could be any of the classes defined in the
_DocumentFactory.Pages.Resume_ namespace. If using the _Report_ class (also
derived from _Document_), this could be any of the classes defined in the
_DocumentFactory.Pages.Report_ namespace.

### Concrete Product

Each class assignable to the _Page_ abstract class provide two strings:
_Type_ and _Content_. _Type_ is a human-readable representation of the type
of page, such as "Cover Letter" for the class _CoverLetter_. _Content_ is the
actual body of the page.

### Creator

The creator in this project is the _MakePage_ abstract method from in the
_Document_ abstract class which is overridden by the two concrete classes
that derive from _Document_: _Resume_ and _Report_. Each of these classes'
_MakePage_ overrides contain a switch statement on their single string argument
determining which type of page associated with that document to instantiate.
The cases matching this argument correspond with the output of the C# keyword
__*nameof*__ for the type of page the caller would like to instantiate using
this factory method. If the provided input does not match any of the cases
found in that override of the _MakePage_ method, then the factory will
simply return null.

### Concrete Creator

The creator for this project does not contain any state beyond the override
for the abstract _Type_ string property specific to the _Document_ assignable
class being used. _Type_ for _Document_ assignable classes serves the same
purpose as _Type_ for _Page_ assignable classes in that it provides a
human-readable representation of the type of document being used.

## Unit Testing

Unit testing has not been included for this project.

## Change Log

- 5.16.2018 - [Joshua William Taylor](mailto:taylor.joshua88@gmail.com) -
Initial release. No unit testing included.