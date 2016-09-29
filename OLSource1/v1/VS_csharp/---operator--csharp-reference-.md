---
title: "?? Operator (C# Reference)"
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
  - "??_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "coalesce operator [C#]"
  - "?? operator [C#]"
  - "conditional-AND operator (&&) [C#]"
ms.assetid: 088b1f0d-c1af-4fe1-b4b8-196fd5ea9132
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ?? Operator (C# Reference)
The `??` operator is called the null-coalescing operator.  It returns the left-hand operand if the operand is not null; otherwise it returns the right hand operand.  
  
## Remarks  
 A nullable type can represent a value from the type’s domain, or the value can be undefined (in which case the value is null). You can use the `??` operator’s syntactic expressiveness to return an appropriate value (the right hand operand) when the left operand has a nullible type whose value is null. If you try to assign a nullable value type to a non-nullable value type without using the `??` operator, you will generate a compile-time error. If you use a cast, and the nullable value type is currently undefined, an `InvalidOperationException` exception will be thrown.  
  
 For more information, see [Nullable Types (C# Programming Guide)](../VS_csharp/nullable-types--csharp-programming-guide-.md).  
  
 The result of a ?? operator is not considered to be a constant even if both its arguments are constants.  
  
## Example  
 [!code[csRefOperators#53](../VS_csharp/codesnippet/CSharp/---operator--csharp-reference-_1.cs)]  
  
## See Also  
 [C# Programmer's Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Operators](../VS_csharp/csharp-operators.md)   
 [Nullable Types (C#)](../VS_csharp/nullable-types--csharp-programming-guide-.md)   
 [What Exactly Does 'Lifted' mean?](http://go.microsoft.com/fwlink/?LinkID=112382)