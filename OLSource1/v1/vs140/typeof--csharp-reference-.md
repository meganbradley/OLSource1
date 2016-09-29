---
title: "typeof (C# Reference)"
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
  - "typeof"
  - "typeof_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "typeof keyword [C#]"
ms.assetid: 0c08d880-515e-46bb-8cd2-48b8dd62c08d
caps.latest.revision: 25
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# typeof (C# Reference)
Used to obtain the `System.Type` object for a type. A `typeof` expression takes the following form:  
  
```  
System.Type type = typeof(int);  
```  
  
## Remarks  
 To obtain the run-time type of an expression, you can use the .NET Framework method <xref:System.Object.GetType*>, as in the following example:  
  
```  
int i = 0;  
System.Type type = i.GetType();  
```  
  
 The `typeof` operator cannot be overloaded.  
  
 The `typeof` operator can also be used on open generic types. Types with more than one type parameter must have the appropriate number of commas in the specification. The following example shows how to determine whether the return type of a method is a generic <xref:System.Collections.Generic.IEnumerable`1*>. Assume that method is an instance of a MethodInfo type:  
  
```  
string s = method.ReturnType.GetInterface  
    (typeof(System.Collections.Generic.IEnumerable<>).FullName);  
```  
  
## Example  
 [!code[csrefKeywordsOperator#12](../vs140/codesnippet/CSharp/typeof--csharp-reference-_1.cs)]  
  
## Example  
 This sample uses the <xref:System.Object.GetType*> method to determine the type that is used to contain the result of a numeric calculation. This depends on the storage requirements of the resulting number.  
  
 [!code[csrefKeywordsOperator#13](../vs140/codesnippet/CSharp/typeof--csharp-reference-_2.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 <xref:System.Type*?displayProperty=fullName>   
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [is](../vs140/is--csharp-reference-.md)   
 [Operator Keywords](../vs140/operator-keywords--csharp-reference-.md)