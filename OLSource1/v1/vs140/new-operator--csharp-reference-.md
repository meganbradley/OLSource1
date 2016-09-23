---
title: "new Operator (C# Reference)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - new operator keyword [C#]
ms.assetid: a212b697-a79b-4105-9923-1f7b108036e8
caps.latest.revision: 26
translation.priority.ht: 
  - de-de
  - ja-jp
---
# new Operator (C# Reference)
Used to create objects and invoke constructors. For example:  
  
```  
Class1 obj  = new Class1();  
```  
  
 It is also used to create instances of anonymous types:  
  
```  
var query = from cust in customers  
            select new {Name = cust.Name, Address = cust.PrimaryAddress};  
```  
  
 The `new` operator is also used to invoke the default constructor for value types. For example:  
  
```  
int i = new int();  
```  
  
 In the preceding statement, `i` is initialized to `0`, which is the default value for the type `int`. The statement has the same effect as the following:  
  
```  
int i = 0;  
```  
  
 For a complete list of default values, see [Default Values Table](../vs140/default-values-table--csharp-reference-.md).  
  
 Remember that it is an error to declare a default constructor for a [struct](../vs140/struct--csharp-reference-.md) because every value type implicitly has a public default constructor. It is possible to declare parameterized constructors on a struct type to set its initial values, but this is only necessary if values other than the default are required.  
  
 Value-type objects such as structs are created on the stack, while reference-type objects such as classes are created on the heap. Both types of objects are destroyed automatically, but objects based on value types are destroyed when they go out of scope, whereas objects based on reference types are destroyed at an unspecified time after the last reference to them is removed. For reference types that consume fixed resources such as large amounts of memory, file handles, or network connections, it is sometimes desirable to employ deterministic finalization to ensure that the object is destroyed as soon as possible. For more information, see [using Statement (C# Programmer's Reference)](../vs140/using-statement--csharp-reference-.md).  
  
 The `new` operator cannot be overloaded.  
  
 If the `new` operator fails to allocate memory, it throws the exception, <xref:System.OutOfMemoryException?qualifyHint=False>.  
  
## Example  
 In the following example, a `struct` object and a class object are created and initialized by using the `new` operator and then assigned values. The default and the assigned values are displayed.  
  
 [!code[csrefKeywordsOperator#7](../vs140/codesnippet/CSharp/new-operator--csharp-reference-_1.cs)]
  
  
 Notice in the example that the default value of a string is `null`. Therefore, it is not displayed.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Operator Keywords](../vs140/operator-keywords--csharp-reference-.md)   
 [new](../vs140/new--csharp-reference-.md)   
 [Anonymous Types (C# Programming Guide)](../vs140/anonymous-types--csharp-programming-guide-.md)