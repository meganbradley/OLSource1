---
title: "Compiler Error CS1931"
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
  - "CS1931"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1931"
ms.assetid: c0071c3d-ae11-4073-87df-508150daef68
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1931
The range variable 'variable' conflicts with a previous declaration of 'variable'.  
  
 The declaration of a range variable, just like every other declaration, must have an identifier which is unique within the variable's declaration space.  
  
### To correct this error  
  
1.  Give the range variable a unique name.  
  
## Example  
 The following code generates CS1931 because the identifier <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is used both as a local variable in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and as the range variable in the query expression:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)