---
title: "Compiler Error CS0755"
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
  - "CS0755"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0755"
ms.assetid: 80613029-a009-4bdf-b1c2-1eec1e60c7b4
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0755
Both partial method declarations must be extension methods or neither may be an extension method.  
  
 A partial method consists of a defining declaration (signature) and an optional implementing declaration (body). If the defining declaration is an extension method, the implementing declaration, if one is defined, must also be an extension method. And if the defining method is not an extension method, the implementing must not be one either.  
  
### To correct this error  
  
1.  Either remove the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> modifier from one of the parts, or add it to the other.  
  
## Example  
 The following example generates CS0755:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Extension Methods (C# Programming Guide)](../vs140/extension-methods--csharp-programming-guide-.md)