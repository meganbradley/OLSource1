---
title: "is (C# Reference)"
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
  - "is_CSharpKeyword"
  - "is"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "is keyword [C#]"
ms.assetid: bc62316a-d41f-4f90-8300-c6f4f0556e43
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# is (C# Reference)
Checks if an object is compatible with a given type. For example, the following code can determine if an object is an instance of the `MyObject` type, or a type that derives from `MyObject`:  
  
```  
if (obj is MyObject)  
{  
}  
```  
  
 An `is` expression evaluates to `true` if the provided expression is non-null, and the provided object can be cast to the provided type without causing an exception to be thrown.  
  
 The `is` keyword causes a compile-time warning if the expression is known to always be `true` or to always be `false`, but typically evaluates type compatibility at run time.  
  
 The `is` operator cannot be overloaded.  
  
 Note that the `is` operator only considers reference conversions, boxing conversions, and unboxing conversions. Other conversions, such as user-defined conversions, are not considered.  
  
 Anonymous methods are not allowed on the left side of the `is` operator. This exception includes lambda expressions.  
  
## Example  
 [!code[csrefKeywordsOperator#4](../vs140/codesnippet/CSharp/is--csharp-reference-_1.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [typeof](../vs140/typeof--csharp-reference-.md)   
 [as](../vs140/as--csharp-reference-.md)   
 [Operator Keywords](../vs140/operator-keywords--csharp-reference-.md)