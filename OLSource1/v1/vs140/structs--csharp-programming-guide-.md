---
title: "Structs (C# Programming Guide)"
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
  - "C# language, structs"
  - "structs [C#]"
ms.assetid: b7cf4ff2-0eb7-4e5c-93d5-b2196b4f5d89
caps.latest.revision: 35
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Structs (C# Programming Guide)
Structs are defined by using the [struct](../vs140/struct--csharp-reference-.md) keyword, for example:  
  
 [!code[csProgGuideObjects#39](../vs140/codesnippet/CSharp/structs--csharp-programming-guide-_1.cs)]  
  
 Structs share most of the same syntax as classes, although structs are more limited than classes:  
  
-   Within a struct declaration, fields cannot be initialized unless they are declared as const or static.  
  
-   A struct cannot declare a default constructor (a constructor without parameters) or a destructor.  
  
-   Structs are copied on assignment. When a struct is assigned to a new variable, all the data is copied, and any modification to the new copy does not change the data for the original copy. This is important to remember when working with collections of value types such as Dictionary<string, myStruct>.  
  
-   Structs are value types and classes are reference types.  
  
-   Unlike classes, structs can be instantiated without using a `new` operator.  
  
-   Structs can declare constructors that have parameters.  
  
-   A struct cannot inherit from another struct or class, and it cannot be the base of a class. All structs inherit directly from `System.ValueType`, which inherits from `System.Object`.  
  
-   A struct can implement interfaces.  
  
-   A struct can be used as a nullable type and can be assigned a null value.  
  
## Related Sections  
 For more information:  
  
-   [Using structs](../vs140/using-structs--csharp-programming-guide-.md)  
  
-   [Constructors (C# Programming Guide)](../vs140/constructors--csharp-programming-guide-.md)  
  
-   [Nullable Types (C# Programming Guide)](../vs140/nullable-types--csharp-programming-guide-.md)  
  
-   [How to: Know the Difference Between Passing a Struct and Passing a Class Reference to a Method](../vs140/how-to--know-the-difference-between-passing-a-struct-and-passing-a-class-reference-to-a-method--csharp-programming-guide-.md)  
  
-   [How to: Implement User-Defined Conversions Between Structs](../vs140/how-to--implement-user-defined-conversions-between-structs--csharp-programming-guide-.md)  
  
-   [More About Variables](http://go.microsoft.com/fwlink/?LinkId=221230) in [Beginning Visual C# 2010](http://go.microsoft.com/fwlink/?LinkId=221214)  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Objects, Classes and Structs (C# Programming Guide)](../vs140/classes-and-structs--csharp-programming-guide-.md)   
 [Classes (C#)](../vs140/classes--csharp-programming-guide-.md)