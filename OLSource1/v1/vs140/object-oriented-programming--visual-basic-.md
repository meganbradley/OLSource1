---
title: "Object-Oriented Programming (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: 49794de4-64c3-473c-b8ed-fe98835df69c
caps.latest.revision: 6
---
# Object-Oriented Programming (Visual Basic)
Visual Basic provides full support for object-oriented programming including encapsulation, inheritance, and polymorphism.  
  
 *Encapsulation* means that a group of related properties, methods, and other members are treated as a single unit or object.  
  
 *Inheritance* describes the ability to create new classes based on an existing class.  
  
 *Polymorphism* means that you can have multiple classes that can be used interchangeably, even though each class implements the same properties or methods in different ways.  
  
 This section describes the following concepts:  
  
-   [Classes and Objects](#Classes)  
  
    -   [Class Members](#Members)  
  
         [Properties and Fields](#Properties)  
  
         [Methods](#Methods)  
  
         [Constructors](#Constructors)  
  
         [Destructors](#Destructors)  
  
         [Events](#Events)  
  
         [Nested Classes](#NestedClasses)  
  
    -   [Access Modifiers and Access Levels](#AccessModifiers)  
  
    -   [Instantiating Classes](#InstantiatingClasses)  
  
    -   [Shared Classes and Members](#Static)  
  
    -   [Anonymous Types](#AnonymousTypes)  
  
-   [Inheritance](#Inheritance)  
  
    -   [Overriding Members](#Overriding)  
  
-   [Interfaces](#Interfaces)  
  
-   [Generics](#Generics)  
  
-   [Delegates](#Delegates)  
  
##  \<a name="Classes">\</a> Classes and Objects  
 The terms *class* and *object* are sometimes used interchangeably, but in fact, classes describe the *type* of objects, while objects are usable *instances* of classes. So, the act of creating an object is called *instantiation*. Using the blueprint analogy, a class is a blueprint, and an object is a building made from that blueprint.  
  
 To define a class:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Visual Basic also provides a light version of classes called *structures* that are useful when you need to create large array of objects and do not want to consume too much memory for that.  
  
 To define a structure:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For more information, see:  
  
-   [Class Statement (Visual Basic)](../vs140/class-statement--visual-basic-.md)  
  
-   [Structure Statement](../vs140/structure-statement.md)  
  
###  \<a name="Members">\</a> Class Members  
 Each class can have different *class members* that include properties that describe class data, methods that define class behavior, and events that provide communication between different classes and objects.  
  
####  \<a name="Properties">\</a> Properties and Fields  
 Fields and properties represent information that an object contains. Fields are like variables because they can be read or set directly.  
  
 To define a field:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Properties have get and set procedures, which provide more control on how values are set or returned.  
  
 Visual Basic allows you either to create a private field for storing the property value or use so-called auto-implemented properties that create this field automatically behind the scenes and provide the basic logic for the property procedures.  
  
 To define an auto-implemented property:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 If you need to perform some additional operations for reading and writing the property value, define a field for storing the property value and provide the basic logic for storing and retrieving it:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Most properties have methods or procedures to both set and get the property value. However, you can create read-only or write-only properties to restrict them from being modified or read. In Visual Basic you can use <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> keywords. However, auto-implemented properties cannot be read-only or write-only.  
  
 For more information, see:  
  
-   [Property Statement](../vs140/property-statement.md)  
  
-   [Get Statement](../vs140/get-statement.md)  
  
-   [Set Statement (Visual Basic)](../vs140/set-statement--visual-basic-.md)  
  
-   [ReadOnly (Visual Basic)](../vs140/readonly--visual-basic-.md)  
  
-   [WriteOnly](../vs140/writeonly--visual-basic-.md)  
  
####  \<a name="Methods">\</a> Methods  
 A *method* is an action that an object can perform.  
  
> [!NOTE]
>  In Visual Basic, there are two ways to create a method: the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> statement is used if the method does not return a value; the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> statement is used if a method returns a value.  
  
 To define a method of a class:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A class can have several implementations, or *overloads*, of the same method that differ in the number of parameters or parameter types.  
  
 To overload a method:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 In most cases you declare a method within a class definition. However, Visual Basic also supports *extension methods* that allow you to add methods to an existing class outside the actual definition of the class.  
  
 For more information, see:  
  
-   [Function Statement (Visual Basic)](../vs140/function-statement--visual-basic-.md)  
  
-   [Sub Statement (Visual Basic)](../vs140/sub-statement--visual-basic-.md)  
  
-   [Overloads](../vs140/overloads--visual-basic-.md)  
  
-   [Extension Methods (Visual Basic)](../vs140/extension-methods--visual-basic-.md)  
  
####  \<a name="Constructors">\</a> Constructors  
 Constructors are class methods that are executed automatically when an object of a given type is created. Constructors usually initialize the data members of the new object. A constructor can run only once when a class is created. Furthermore, the code in the constructor always runs before any other code in a class. However, you can create multiple constructor overloads in the same way as for any other method.  
  
 To define a constructor for a class:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 For more information, see: [Object Lifetime: How Objects Are Created and Destroyed](../vs140/object-lifetime--how-objects-are-created-and-destroyed--visual-basic-.md).  
  
####  \<a name="Destructors">\</a> Destructors  
 Destructors are used to destruct instances of classes. In the .NET Framework, the garbage collector automatically manages the allocation and release of memory for the managed objects in your application. However, you may still need destructors to clean up any unmanaged resources that your application creates. There can be only one destructor for a class.  
  
 For more information about destructors and garbage collection in the .NET Framework, see [Garbage Collection](assetId:///22b6cb97-0c80-4eeb-a2cf-5ed7655e37f9).  
  
####  \<a name="Events">\</a> Events  
 Events enable a class or object to notify other classes or objects when something of interest occurs. The class that sends (or raises) the event is called the *publisher* and the classes that receive (or handle) the event are called *subscribers*. For more information about events, how they are raised and handled, see [Handling and Raising Events](assetId:///b6f65241-e0ad-4590-a99f-200ce741bb1f).  
  
-   To declare events, use the [Event Statement](../vs140/event-statement.md).  
  
-   To raise events, use the [RaiseEvent Statement](../vs140/raiseevent-statement.md).  
  
-   To specify event handlers using a declarative way, use the [WithEvents](../vs140/withevents--visual-basic-.md) statement and the [Handles](../vs140/handles-clause--visual-basic-.md) clause.  
  
-   To be able to dynamically add, remove, and change the event handler associated with an event, use the [AddHandler Statement](../vs140/addhandler-statement.md) and [RemoveHandler Statement](../vs140/removehandler-statement.md) together with the [AddressOf Operator](../vs140/addressof-operator--visual-basic-.md).  
  
####  \<a name="NestedClasses">\</a> Nested Classes  
 A class defined within another class is called *nested*. By default, the nested class is private.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 To create an instance of the nested class, use the name of the container class followed by the dot and then followed by the name of the nested class:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
###  \<a name="AccessModifiers">\</a> Access Modifiers and Access Levels  
 All classes and class members can specify what access level they provide to other classes by using *access modifiers*.  
  
 The following access modifiers are available:  
  
|Visual Basic Modifier|Definition|  
|---------------------------|----------------|  
|[Public](../vs140/public--visual-basic-.md)|The type or member can be accessed by any other code in the same assembly or another assembly that references it.|  
|[Private](../vs140/private--visual-basic-.md)|The type or member can only be accessed by code in the same class.|  
|[Protected](../vs140/protected--visual-basic-.md)|The type or member can only be accessed by code in the same class or in a derived class.|  
|[Friend](../vs140/friend--visual-basic-.md)|The type or member can be accessed by any code in the same assembly, but not from another assembly.|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|The type or member can be accessed by any code in the same assembly, or by any derived class in another assembly.|  
  
 For more information, see [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md).  
  
###  \<a name="InstantiatingClasses">\</a> Instantiating Classes  
 To create an object, you need to instantiate a class, or create a class instance.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 After instantiating a class, you can assign values to the instance's properties and fields and invoke class methods.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 To assign values to properties during the class instantiation process, use object initializers:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 For more information, see:  
  
-   [New (Visual Basic)](../vs140/new-operator--visual-basic-.md)  
  
-   [Object Initializers: Named and Anonymous Types](../vs140/object-initializers--named-and-anonymous-types--visual-basic-.md)  
  
###  \<a name="Static">\</a> Shared Classes and Members  
 A shared member of the class is a property, procedure, or field that is shared by all instances of a class.  
  
 To define a shared member:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 To access the shared member, use the name of the class without creating an object of this class:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Shared modules in Visual Basic have shared members only and cannot be instantiated. Shared members also cannot access non-shared properties, fields or methods  
  
 For more information, see:  
  
-   [Shared (Visual Basic)](../vs140/shared--visual-basic-.md)  
  
-   [Module Statement](../vs140/module-statement.md)  
  
###  \<a name="AnonymousTypes">\</a> Anonymous Types  
 Anonymous types enable you to create objects without writing a class definition for the data type. Instead, the compiler generates a class for you. The class has no usable name and contains the properties you specify in declaring the object.  
  
 To create an instance of an anonymous type:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 For more information, see: [Anonymous Types](../vs140/anonymous-types--visual-basic-.md).  
  
##  \<a name="Inheritance">\</a> Inheritance  
 Inheritance enables you to create a new class that reuses, extends, and modifies the behavior that is defined in another class. The class whose members are inherited is called the *base class*, and the class that inherits those members is called the *derived class*. However, all classes in Visual Basic implicitly inherit from the \<xref:System.Object*> class that supports .NET class hierarchy and provides low-level services to all classes.  
  
> [!NOTE]
>  Visual Basic doesn't support multiple inheritance, i.e. you can specify only one base class for a derived class.  
  
 To inherit from a base class:  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 By default all classes can be inherited. However, you can specify whether a class must not be used as a base class, or create a class that can be used as a base class only.  
  
 To specify that a class cannot be used as a base class:  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 To specify that a class can be used as a base class only and cannot be instantiated:  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 For more information, see:  
  
-   [Inherits Statement](../vs140/inherits-statement.md)  
  
-   [NotInheritable](../vs140/notinheritable--visual-basic-.md)  
  
-   [MustInherit](../vs140/mustinherit--visual-basic-.md)  
  
###  \<a name="Overriding">\</a> Overriding Members  
 By default, a derived class inherits all members from its base class. If you want to change the behavior of the inherited member, you need to override it. That is, you can define a new implementation of the method, property or event in the derived class.  
  
 The following modifiers are used to control how properties and methods are overridden:  
  
|Visual Basic Modifier|Definition|  
|---------------------------|----------------|  
|[Overridable](../vs140/overridable--visual-basic-.md)|Allows a class member to be overridden in a derived class.|  
|[Overrides](../vs140/overrides--visual-basic-.md)|Overrides a virtual (overridable) member defined in the base class.|  
|[NotOverridable](../vs140/notoverridable--visual-basic-.md)|Prevents a member from being overridden in an inheriting class.|  
|[MustOverride](../vs140/mustoverride--visual-basic-.md)|Requires that a class member to be overridden in the derived class.|  
|[Shadows](../vs140/shadows--visual-basic-.md)|Hides a member inherited from a base class|  
  
##  \<a name="Interfaces">\</a> Interfaces  
 Interfaces, like classes, define a set of properties, methods, and events. But unlike classes, interfaces do not provide implementation. They are implemented by classes, and defined as separate entities from classes. An interface represents a contract, in that a class that implements an interface must implement every aspect of that interface exactly as it is defined.  
  
 To define an interface:  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 To implement an interface in a class:  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 For more information, see:  
  
-   [Interfaces in Visual Basic](../vs140/interfaces--visual-basic-.md)  
  
-   [Interface Statement (Visual Basic)](../vs140/interface-statement--visual-basic-.md)  
  
-   [Implements Statement](../vs140/implements-statement.md)  
  
##  \<a name="Generics">\</a> Generics  
 Classes, structures, interfaces and methods in the .NET Framework can include *type parameters* that define types of objects that they can store or use. The most common example of generics is a collection, where you can specify the type of objects to be stored in a collection.  
  
 To define a generic class:  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 To create an instance of a generic class:  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 For more information, see:  
  
-   [Generics in the .NET Framework](assetId:///2994d786-c5c7-4666-ab23-4c83129fe39c)  
  
-   [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)  
  
##  \<a name="Delegates">\</a> Delegates  
 A *delegate* is a type that defines a method signature, and can provide a reference to any method with a compatible signature. You can invoke (or call) the method through the delegate. Delegates are used to pass methods as arguments to other methods.  
  
> [!NOTE]
>  Event handlers are nothing more than methods that are invoked through delegates. For more information about using delegates in event handling, see [Handling and Raising Events](assetId:///b6f65241-e0ad-4590-a99f-200ce741bb1f).  
  
 To create a delegate:  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 To create a reference to a method that matches the signature specified by the delegate:  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 For more information, see:  
  
-   [Delegates in Visual Basic](../vs140/delegates--visual-basic-.md)  
  
-   [Delegate Statement](../vs140/delegate-statement.md)  
  
-   [AddressOf Operator](../vs140/addressof-operator--visual-basic-.md)  
  
## See Also  
 [Visual Basic Programming Guide](../vs140/visual-basic-programming-guide.md)