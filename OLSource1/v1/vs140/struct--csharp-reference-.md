---
title: "struct (C# Reference)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - struct_CSharpKeyword
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - struct keyword [C#]
  - structs [C#], struct keyword
ms.assetid: ff3dd9b7-dc93-4720-8855-ef5558f65c7c
caps.latest.revision: 27
translation.priority.ht: 
  - de-de
  - ja-jp
---
# struct (C# Reference)
A `struct` type is a value type that is typically used to encapsulate small groups of related variables, such as the coordinates of a rectangle or the characteristics of an item in an inventory. The following example shows a simple struct declaration:  
  
```  
public struct Book  
{  
    public decimal price;  
    public string title;  
    public string author;  
}  
```  
  
## Remarks  
 Structs can also contain [constructors](../vs140/constructors--csharp-programming-guide-.md), [constants](../vs140/constants--csharp-programming-guide-.md), [fields](../vs140/fields--csharp-programming-guide-.md), [methods](../vs140/methods--csharp-programming-guide-.md), [properties](../vs140/properties--csharp-programming-guide-.md), [indexers](../vs140/indexers--csharp-programming-guide-.md), [operators](../vs140/operators--csharp-programming-guide-.md), [events](../vs140/events--csharp-programming-guide-.md), and [nested types](../vs140/nested-types--csharp-programming-guide-.md), although if several such members are required, you should consider making your type a class instead.  
  
 For examples, see [Using Structs (C# Programming Guide)](../vs140/using-structs--csharp-programming-guide-.md).  
  
 Structs can implement an interface but they cannot inherit from another struct. For that reason, struct members cannot be declared as `protected`.  
  
 For more information, see [Structs (C#)](../vs140/structs--csharp-programming-guide-.md).  
  
## Examples  
 For examples and more information, see [Using Structs (C# Programming Guide)](../vs140/using-structs--csharp-programming-guide-.md).  
  
## C# Language Specification  
 For examples, see [Using Structs (C# Programming Guide)](../vs140/using-structs--csharp-programming-guide-.md).  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Default Values Table](../vs140/default-values-table--csharp-reference-.md)   
 [Built-in Types Table (Visual C#)](../vs140/built-in-types-table--csharp-reference-.md)   
 [Types](../vs140/types--csharp-reference-.md)   
 [Value Types](../vs140/value-types--csharp-reference-.md)   
 [class](../vs140/class--csharp-reference-.md)   
 [interface (C# Programmer's Reference)](../vs140/interface--csharp-reference-.md)   
 [Objects, Classes and Structs (C# Programmer's Reference)](../vs140/classes-and-structs--csharp-programming-guide-.md)