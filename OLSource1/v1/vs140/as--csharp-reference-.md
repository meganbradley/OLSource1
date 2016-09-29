---
title: "as (C# Reference)"
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
  - "as_CSharpKeyword"
  - "as"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "type conversion [C#], as keyword"
  - "as keyword [C#]"
ms.assetid: a9be126b-cbf4-4990-a70d-d0e1983cad0e
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# as (C# Reference)
You can use the `as` operator to perform certain types of conversions between compatible reference types or [nullable types](../vs140/nullable-types--csharp-programming-guide-.md). The following code shows an example.  
  
 [!code[csrefKeywordsOperator#1](../vs140/codesnippet/CSharp/as--csharp-reference-_1.cs)]  
  
## Remarks  
 The `as` operator is like a cast operation. However, if the conversion isn't possible, `as` returns `null` instead of raising an exception. Consider the following example:  
  
```  
expression as type  
```  
  
 The code is equivalent to the following expression except that the `expression` variable is evaluated only one time.  
  
```  
expression is type ? (type)expression : (type)null  
```  
  
 Note that the `as` operator performs only reference conversions, nullable conversions, and boxing conversions. The `as` operator can't perform other conversions, such as user-defined conversions, which should instead be performed by using cast expressions.  
  
## Example  
 [!code[csrefKeywordsOperator#2](../vs140/codesnippet/CSharp/as--csharp-reference-_2.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [is](../vs140/is--csharp-reference-.md)   
 [?: Operator](../vs140/---operator--csharp-reference-.md)   
 [Operator Keywords](../vs140/operator-keywords--csharp-reference-.md)