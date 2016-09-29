---
title: "partial (Type) (C# Reference)"
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
  - "partialtype"
  - "partialtype_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "partial types [C#]"
ms.assetid: 27320743-a22e-4c7b-b0b3-53afe3607334
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# partial (Type) (C# Reference)
Partial type definitions allow for the definition of a class, struct, or interface to be split into multiple files.  
  
 In File1.cs:  
  
 [!code[csrefKeywordsContextual#3](../VS_csharp/codesnippet/CSharp/partial--type---csharp-reference-_1.cs)]  
  
 In File2.cs the declaration:  
  
 [!code[csrefKeywordsContextual#4](../VS_csharp/codesnippet/CSharp/partial--type---csharp-reference-_2.cs)]  
  
## Remarks  
 Splitting a class, struct or interface type over several files can be useful when you are working with large projects, or with automatically generated code such as that provided by the [Windows Forms Designer](assetId:///3c3d61f8-f36c-4d41-b9c3-398376fabb15). A partial type may contain a [partial method](../VS_csharp/partial--method---csharp-reference-.md). For more information, see [Partial Classes and Methods](../VS_csharp/partial-classes-and-methods--csharp-programming-guide-.md).  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Modifiers](../VS_csharp/modifiers--csharp-reference-.md)   
 [Generics (C#)](../VS_csharp/introduction-to-generics--csharp-programming-guide-.md)