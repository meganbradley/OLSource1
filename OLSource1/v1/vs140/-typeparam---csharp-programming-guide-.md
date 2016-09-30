---
title: "&lt;typeparam&gt; (C# Programming Guide)"
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
  - "typeparam"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "<typeparam> C# XML tag"
  - "typeparam C# XML tag"
ms.assetid: 9b99d400-e911-4e55-99c6-64367c96aa4f
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;typeparam&gt; (C# Programming Guide)
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The name of the type parameter. Enclose the name in double quotation marks (" ").  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A description for the type parameter.  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> tag should be used in the comment for a generic type or method declaration to describe a type parameter. Add a tag for each type parameter of the generic type or method.  
  
 For more information, see [Generics (C# Programmer's Reference)](../vs140/generics--csharp-programming-guide-.md).  
  
 The text for the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> tag will be displayed in IntelliSense, the [Object Browser Window](assetId:///3c7f1673-1f0d-41b1-94ca-a3dcfcb82cda) code comment web report.  
  
 Compile with [/doc](../vs140/-doc--csharp-compiler-options-.md) to process documentation comments to a file.  
  
## Example  
 [!code[csProgGuideDocComments#13](../vs140/codesnippet/CSharp/-typeparam---csharp-programming-guide-_1.cs)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Recommended Tags for Documentation Comments (C# Programmer's Reference)](../vs140/recommended-tags-for-documentation-comments--csharp-programming-guide-.md)