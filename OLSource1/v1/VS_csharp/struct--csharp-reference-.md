---
title: "struct (C# Reference)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "struct_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "struct keyword [C#]"
  - "structs [C#], struct keyword"
ms.assetid: ff3dd9b7-dc93-4720-8855-ef5558f65c7c
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
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
 Structs can also contain [constructors](../VS_csharp/constructors--csharp-programming-guide-.md), [constants](../VS_csharp/constants--csharp-programming-guide-.md), [fields](../VS_csharp/fields--csharp-programming-guide-.md), [methods](../VS_csharp/methods--csharp-programming-guide-.md), [properties](../VS_csharp/properties--csharp-programming-guide-.md), [indexers](../VS_csharp/indexers--csharp-programming-guide-.md), [operators](../VS_csharp/operators--csharp-programming-guide-.md), [events](../VS_csharp/events--csharp-programming-guide-.md), and [nested types](../VS_csharp/nested-types--csharp-programming-guide-.md), although if several such members are required, you should consider making your type a class instead.  
  
 For examples, see [Using Structs (C# Programming Guide)](../VS_csharp/using-structs--csharp-programming-guide-.md).  
  
 Structs can implement an interface but they cannot inherit from another struct. For that reason, struct members cannot be declared as `protected`.  
  
 For more information, see [Structs (C#)](../VS_csharp/structs--csharp-programming-guide-.md).  
  
## Examples  
 For examples and more information, see [Using Structs (C# Programming Guide)](../VS_csharp/using-structs--csharp-programming-guide-.md).  
  
## C# Language Specification  
 For examples, see [Using Structs (C# Programming Guide)](../VS_csharp/using-structs--csharp-programming-guide-.md).  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Default Values Table](../VS_csharp/default-values-table--csharp-reference-.md)   
 [Built-in Types Table (Visual C#)](../VS_csharp/built-in-types-table--csharp-reference-.md)   
 [Types](../VS_csharp/types--csharp-reference-.md)   
 [Value Types](../VS_csharp/value-types--csharp-reference-.md)   
 [class](../VS_csharp/class--csharp-reference-.md)   
 [interface (C# Programmer's Reference)](../VS_csharp/interface--csharp-reference-.md)   
 [Objects, Classes and Structs (C# Programmer's Reference)](../VS_csharp/classes-and-structs--csharp-programming-guide-.md)