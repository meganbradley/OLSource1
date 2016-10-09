---
title: "typeof (C# Reference)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 21
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
# typeof (C# Reference)
Used to obtain the `System.Type` object for a type. A `typeof` expression takes the following form:  
  
```  
System.Type type = typeof(int);  
```  
  
## Remarks  
 To obtain the run-time type of an expression, you can use the .NET Framework method \<xref:System.Object.GetType*>, as in the following example:  
  
```  
int i = 0;  
System.Type type = i.GetType();  
```  
  
 The `typeof` operator cannot be overloaded.  
  
 The `typeof` operator can also be used on open generic types. Types with more than one type parameter must have the appropriate number of commas in the specification. The following example shows how to determine whether the return type of a method is a generic \<xref:System.Collections.Generic.IEnumerable`1>. Assume that method is an instance of a MethodInfo type:  
  
```  
string s = method.ReturnType.GetInterface  
    (typeof(System.Collections.Generic.IEnumerable<>).FullName);  
```  
  
## Example  
 [!code[csrefKeywordsOperator#12](../VS_csharp/codesnippet/CSharp/typeof--csharp-reference-_1.cs)]  
  
## Example  
 This sample uses the \<xref:System.Object.GetType*> method to determine the type that is used to contain the result of a numeric calculation. This depends on the storage requirements of the resulting number.  
  
 [!code[csrefKeywordsOperator#13](../VS_csharp/codesnippet/CSharp/typeof--csharp-reference-_2.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 \<xref:System.Type?displayProperty=fullName>   
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [is](../VS_csharp/is--csharp-reference-.md)   
 [Operator Keywords](../VS_csharp/operator-keywords--csharp-reference-.md)