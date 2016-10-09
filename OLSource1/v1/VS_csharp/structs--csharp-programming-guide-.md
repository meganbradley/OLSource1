---
title: "Structs (C# Programming Guide)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 31
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Structs (C# Programming Guide)
Structs are defined by using the [struct](../VS_csharp/struct--csharp-reference-.md) keyword, for example:  
  
 [!code[csProgGuideObjects#39](../VS_csharp/codesnippet/CSharp/structs--csharp-programming-guide-_1.cs)]  
  
 Structs share most of the same syntax as classes, although structs are more limited than classes:  
  
-   Within a struct declaration, fields cannot be initialized unless they are declared as const or static.  
  
-   A struct cannot declare a default constructor (a constructor without parameters) or a destructor.  
  
-   Structs are copied on assignment. When a struct is assigned to a new variable, all the data is copied, and any modification to the new copy does not change the data for the original copy. This is important to remember when working with collections of value types such as Dictionary\<string, myStruct>.  
  
-   Structs are value types and classes are reference types.  
  
-   Unlike classes, structs can be instantiated without using a `new` operator.  
  
-   Structs can declare constructors that have parameters.  
  
-   A struct cannot inherit from another struct or class, and it cannot be the base of a class. All structs inherit directly from `System.ValueType`, which inherits from `System.Object`.  
  
-   A struct can implement interfaces.  
  
-   A struct can be used as a nullable type and can be assigned a null value.  
  
## Related Sections  
 For more information:  
  
-   [Using Structs](../VS_csharp/using-structs--csharp-programming-guide-.md)  
  
-   [Constructors](../VS_csharp/constructors--csharp-programming-guide-.md)  
  
-   [Nullable Types](../VS_csharp/nullable-types--csharp-programming-guide-.md)  
  
-   [How to: Know the Difference Between Passing a Struct and Passing a Class Reference to a Method](../VS_csharp/9c1313a6-32a8-4ea7-a59f-450f66af628b.md)  
  
-   [How to: Implement User-Defined Conversions Between Structs](../VS_csharp/how-to--implement-user-defined-conversions-between-structs--csharp-programming-guide-.md)  
  
-   [More About Variables](http://go.microsoft.com/fwlink/?LinkId=221230) in [Beginning Visual C# 2010](http://go.microsoft.com/fwlink/?LinkId=221214)  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Classes and Structs](../VS_csharp/classes-and-structs--csharp-programming-guide-.md)   
 [Classes](../VS_csharp/classes--csharp-programming-guide-.md)