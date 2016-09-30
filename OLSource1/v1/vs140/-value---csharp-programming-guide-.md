---
title: "&lt;value&gt; (C# Programming Guide)"
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
  - "<value>"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "<value> C# XML tag"
  - "value C# XML tag"
ms.assetid: 08dbadaf-9ab6-43d9-9493-98e43bed199a
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;value&gt; (C# Programming Guide)
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A description for the property.  
  
## Remarks  
 The \<value> tag lets you describe the value that a property represents. Note that when you add a property via code wizard in the Visual Studio .NET development environment, it will add a [\<summary>](../vs140/-summary---csharp-programming-guide-.md) tag for the new property. You should then manually add a \<value> tag to describe the value that the property represents.  
  
 Compile with [/doc](../vs140/-doc--csharp-compiler-options-.md) to process documentation comments to a file.  
  
## Example  
 [!code[csProgGuideDocComments#14](../vs140/codesnippet/CSharp/-value---csharp-programming-guide-_1.cs)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Recommended Tags for Documentation Comments](../vs140/recommended-tags-for-documentation-comments--csharp-programming-guide-.md)