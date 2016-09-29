---
title: "object (C# Reference)"
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
  - "object_CSharpKeyword"
  - "object"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "object keyword [C#]"
ms.assetid: 93f60c0b-e17a-40a9-9362-cca5fb77b0e7
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# object (C# Reference)
The `object` type is an alias for <xref:System.Object*> in the .NET Framework. In the unified type system of C#, all types, predefined and user-defined, reference types and value types, inherit directly or indirectly from <xref:System.Object*>. You can assign values of any type to variables of type `object`. When a variable of a value type is converted to object, it is said to be *boxed*. When a variable of type object is converted to a value type, it is said to be *unboxed*. For more information, see [Boxing and Unboxing](../VS_csharp/boxing-and-unboxing--csharp-programming-guide-.md).  
  
## Example  
 The following sample shows how variables of type `object` can accept values of any data type and how variables of type `object` can use methods on <xref:System.Object*> from the .NET Framework.  
  
 [!code[csrefKeywordsTypes#16](../VS_csharp/codesnippet/CSharp/object--csharp-reference-_1.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Reference Types](../VS_csharp/reference-types--csharp-reference-.md)   
 [Value Types](../VS_csharp/value-types--csharp-reference-.md)