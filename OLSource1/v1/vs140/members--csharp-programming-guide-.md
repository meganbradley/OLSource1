---
title: "Members (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "types [C#], nested types"
  - "C# language, type members"
ms.assetid: 4a30a4ab-d690-4936-9124-92ce9448665a
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Members (C# Programming Guide)
Classes and structs have members that represent their data and behavior. A class's members include all the members declared in the class, along with all members (except constructors and destructors) declared in all classes in its inheritance hierarchy. Private members in base classes are inherited but are not accessible from derived classes.  
  
 The following table lists the kinds of members a class or struct may contain:  
  
|Member|Description|  
|------------|-----------------|  
|[Fields (C# Programming Guide)](../vs140/fields--csharp-programming-guide-.md)|Fields are variables declared at class scope. A field may be a built-in numeric type or an instance of another class. For example, a calendar class may have a field that contains the current date.|  
|[Constants (C# Programming Guide)](../vs140/constants--csharp-programming-guide-.md)|Constants are fields or properties whose value is set at compile time and cannot be changed.|  
|[Properties (C# Programming Guide)](../vs140/properties--csharp-programming-guide-.md)|Properties are methods on a class that are accessed as if they were fields on that class. A property can provide protection for a class field to keep it from being changed without the knowledge of the object.|  
|[Methods (C# Programming Guide)](../vs140/methods--csharp-programming-guide-.md)|Methods define the actions that a class can perform. Methods can take parameters that provide input data, and can return output data through parameters. Methods can also return a value directly, without using a parameter.|  
|[Events (C# Programming Guide)](../vs140/events--csharp-programming-guide-.md)|Events provide notifications about occurrences, such as button clicks or the successful completion of a method, to other objects. Events are defined and triggered by using delegates.|  
|[Operators (C# Programming Guide)](../vs140/operators--csharp-programming-guide-.md)|Overloaded operators are considered class members. When you overload an operator, you define it as a public static method in a class. The predefined operators (<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, and so on) are not considered members. For more information, see [Overloadable Operators (Visual C#)](../vs140/overloadable-operators--csharp-programming-guide-.md).|  
|[Indexers (C# Programming Guide)](../vs140/indexers--csharp-programming-guide-.md)|Indexers enable an object to be indexed in a manner similar to arrays.|  
|[Constructors (C# Programming Guide)](../vs140/constructors--csharp-programming-guide-.md)|Constructors are methods that are called when the object is first created. They are often used to initialize the data of an object.|  
|[Destructors (C# Programming Guide)](../vs140/destructors--csharp-programming-guide-.md)|Destructors are used very rarely in C#. They are methods that are called by the runtime execution engine when the object is about to be removed from memory. They are generally used to make sure that any resources which must be released are handled appropriately.|  
|[Nested Types (C# Programming Guide)](../vs140/nested-types--csharp-programming-guide-.md)|Nested types are types declared within another type. Nested types are often used to describe objects that are used only by the types that contain them.|  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Classes (C#)](../vs140/classes--csharp-programming-guide-.md)   
 [Methods (C# Programming Guide)](../vs140/methods--csharp-programming-guide-.md)   
 [Constructors](../vs140/constructors--csharp-programming-guide-.md)   
 [Destructors (C# Programmer's Reference)](../vs140/destructors--csharp-programming-guide-.md)   
 [Properties (C# Programmer's Reference)](../vs140/properties--csharp-programming-guide-.md)   
 [Fields (C# Programming Guide)](../vs140/fields--csharp-programming-guide-.md)   
 [Indexers](../vs140/indexers--csharp-programming-guide-.md)   
 [Events (C#)](../vs140/events--csharp-programming-guide-.md)   
 [Nested Types (C# Programming Guide)](../vs140/nested-types--csharp-programming-guide-.md)   
 [Operators (C# Programming Guide)](../vs140/operators--csharp-programming-guide-.md)   
 [Overloadable Operators (C# Programming Guide)](../vs140/overloadable-operators--csharp-programming-guide-.md)