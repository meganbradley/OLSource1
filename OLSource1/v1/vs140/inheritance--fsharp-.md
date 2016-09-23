---
title: "Inheritance (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - object-oriented programming, in F#
  - inheritance, F#
  - object-oriented programming [F#]
  - inheritance [F#]
ms.assetid: 93cd9919-2d37-42d0-a01d-26e4f85add76
caps.latest.revision: 31
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Inheritance (F#)
Inheritance is used to model the "is-a" relationship, or subtyping, in object-oriented programming.  
  
## Specifying Inheritance Relationships  
 You specify inheritance relationships by using the `inherit` keyword in a class declaration. The basic syntactical form is shown in the following example.  
  
```  
type MyDerived(...) =  
   inherit MyBase(...)  
```  
  
 A class can have at most one direct base class. If you do not specify a base class by using the `inherit` keyword, the class implicitly inherits from <xref:System.Object?qualifyHint=False>.  
  
## Inherited Members  
 If a class inherits from another class, the methods and members of the base class are available to users of the derived class as if they were direct members of the derived class.  
  
 Any let bindings and constructor parameters are private to a class and, therefore, cannot be accessed from derived classes.  
  
 The keyword `base` is available in derived classes and refers to the base class instance. It is used like the self-identifier.  
  
## Virtual Methods and Overrides  
 Virtual methods (and properties) work somewhat differently in F# as compared to other .NET languages. To declare a new virtual member, you use the `abstract` keyword. You do this regardless of whether you provide a default implementation for that method. Thus a complete definition of a virtual method in a base class follows this pattern:  
  
 `abstract` `member` `method-name` : `type`  
  
 `default` `self-identifier`.`method-name``argument-list` = `method-body`  
  
 And in a derived class, an override of this virtual method follows this pattern:  
  
 `override` `self-identifier`.`method-name``argument-list` = `method-body`  
  
 If you omit the default implementation in the base class, the base class becomes an abstract class.  
  
 The following code example illustrates the declaration of a new virtual method `function1` in a base class and how to override it in a derived class.  
  
 [!code[FsLangRef1#2601](../vs140/codesnippet/FSharp/inheritance--fsharp-_1.fs)]
  
  
## Constructors and Inheritance  
 The constructor for the base class must be called in the derived class. The arguments for the base class constructor appear in the argument list in the `inherit` clause. The values that are used must be determined from the arguments supplied to the derived class constructor.  
  
 The following code shows a base class and a derived class, where the derived class calls the base class constructor in the inherit clause:  
  
 [!code[FsLangRef1#2602](../vs140/codesnippet/FSharp/inheritance--fsharp-_2.fs)]
  
  
 In the case of multiple constructors, the following code can be used. The first line of the derived class constructors is the `inherit` clause, and the fields appear as explicit fields that are declared with the `val` keyword. For more information, see [Explicit Fields: The val Keyword](../vs140/explicit-fields--the-val-keyword--fsharp-.md).  
  
```f#  
type BaseClass =  
    val string1 : string  
    new (str) = { string1 = str }  
    new () = { string1 = "" }  
  
type DerivedClass =  
    inherit BaseClass  
    val string2 : string  
    new (str1, str2) = { inherit BaseClass(str1); string2 = str2 }  
    new (str2) = { inherit BaseClass(); string2 = str2 }  
  
let obj1 = DerivedClass("A", "B")  
let obj2 = DerivedClass("A")  
  
```  
  
## Alternatives to Inheritance  
 In cases where a minor modification of a type is required, consider using an object expression as an alternative to inheritance. The following example illustrates the use of an object expression as an alternative to creating a new derived type:  
  
 [!code[FsLangRef1#2603](../vs140/codesnippet/FSharp/inheritance--fsharp-_3.fs)]
  
  
 For more information about object expressions, see [Object Expressions](../vs140/object-expressions--fsharp-.md).  
  
 When you are creating object hierarchies, consider using a discriminated union instead of inheritance. Discriminated unions can also model varied behavior of different objects that share a common overall type. A single discriminated union can often eliminate the need for a number of derived classes that are minor variations of each other. For information about discriminated unions, see [Discriminated Unions (F#)](../vs140/discriminated-unions--fsharp-.md).  
  
## See Also  
 [Object Expressions](../vs140/object-expressions--fsharp-.md)   
 [F# Language Reference](../vs140/fsharp-language-reference.md)