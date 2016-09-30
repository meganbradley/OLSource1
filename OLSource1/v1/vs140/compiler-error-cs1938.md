---
title: "Compiler Error CS1938"
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
  - "CS1938"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1938"
ms.assetid: fc8de996-f7a1-46e8-b07b-aea520b391b9
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1938
The name 'name' is not in scope on the right side of 'equals'. Consider swapping the expressions on either side of 'equals'.  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword is a special operator that is used in a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> clause to determine equality between two expressions. The range variable for the left side source sequence is in scope on the left side of equals, and the range variable for the right side source is only in scope on the left side of equals. You can verify this by experimenting with IntelliSense in the following code example.  
  
### To correct this error  
  
1.  Swap the position of the two range variables as shown in the commented line in the following example:  
  
## Example  
 The following code generates CS1938:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [join clause (C# Reference)](../vs140/join-clause--csharp-reference-.md)