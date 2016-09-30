---
title: "Compiler Error CS1942"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS1942"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1942"
ms.assetid: afbe5e8e-1944-416e-916b-39e2c373814b
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1942
The type of the expression in the 'clause' clause is incorrect. Type inference failed in the call to 'method'.  
  
 This error is typically generated when the range variable has been given an incorrect explicit type.  
  
### To correct this error  
  
1.  If the range variable is explicitly typed, make sure that the type is either the same as, or implicitly convertible from, the type of the elements in the collection it iterates. If the range variable is preceded with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword, remove <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Example  
 The following code generates CS1942:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 CS1942 is related to CS1949 because the use of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> with a range variable causes the underlying <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operation to fail because <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not a type.  
  
## See Also  
 [var (C# Reference)](../vs140/var--csharp-reference-.md)   
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)