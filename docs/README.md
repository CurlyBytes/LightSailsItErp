# Project arrangement 
Enterprise Resource Planning of LightSails IT

``
The application implemented is base on the requirement from the Process Owner
``

#Technology Use
- Visual Studio 2019 Developer Edition
- Google Chrome Browser
- Docker COotainer
- DotnetCore 5

#Libraries in Used
- Xunit 
- Moq
- Mediatr
- Ardalis Guard Clause 
- Ardalis Specification Pattern
- 

## Class Structure
- Static Variables
- Static Methods
- Public Variables
- Protected Variables
- Private Variables
- Constructors
- Public Methods
- Protected Methods
- Private Methods
- I use the following rules:

##Naming Convention
- Method Name and Class Name is CamelCase
- local variables must be PascalCase 
- class variable must be PascalCase with Underscore 
- Interface class should start with _IHave_
- Other specific Class like repository, handler, events will be Hungarian Notation 

## File and Folder Structure 
- File and folder arrange should be Feature by Type
- Follow Domain Driven Design Archictecture 


#Domain Driven Design Rules impelment

static before anything
variables before constructors before methods (i consider constructors to be in the category of methods)
public before protected before private



