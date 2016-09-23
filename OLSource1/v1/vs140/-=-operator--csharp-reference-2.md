---
title: "-= Operator (C# Reference)2"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
H1: -= Operator (C# Reference)
f1_keywords: 
  - -=_CSharpKeyword
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - subtraction assignment operator (-=) [C#]
  - -= operator (subtraction assignment ) [C#]
ms.assetid: 05c7d68a-423f-4de8-891b-cf24e8fb6ed7
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# -= Operator (C# Reference)2
The subtraction assignment operator.  
  
## Remarks  
 An expression using the `-=` assignment operator, such as  
  
```  
x -= y  
```  
  
 is equivalent to  
  
```  
x = x - y  
```  
  
 except that `x` is only evaluated once. The meaning of the [- operator](../vs140/--operator--csharp-reference-2.md) is dependent on the types of `x` and `y` (subtraction for numeric operands, delegate removal for delegate operands, and so forth).  
  
 The `-=` operator cannot be overloaded directly, but user-defined types can overload the [- operator](../vs140/--operator--csharp-reference-2.md) (see [operator](../vs140/operator--csharp-reference-2.md)).  
  
 The -= operator is also used in C# to unsubscribe from an event. For more information, see [How to: Subscribe to and Unsubscribe from Events (C# Programming Guide)](../vs140/how-to--subscribe-to-and-unsubscribe-from-events--csharp-programming-guide-.md).  
  
## Example  
 [!code[csRefOperators#6](../vs140/codesnippet/CSharp/-=-operator--csharp-reference-2_1.cs)]
  
  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming](../vs140/csharp-programming-guide.md)   
 [C# Operators](../vs140/csharp-operators.md)