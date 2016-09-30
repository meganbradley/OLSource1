---
title: "Compiler Error CS1937"
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
  - "CS1937"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1937"
ms.assetid: f13e8dc9-8c20-477e-8b74-7192848e08a2
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1937
The name 'name' is not in scope on the left side of 'equals'. Consider swapping the expressions on either side of 'equals'.  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword is a special operator that is used in a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> clause to determine equality between two expressions. The range variable for the left side source sequence is in scope on the left side of equals, and the range variable for the right side source is only in scope on the left side of equals. You can verify this by experimenting with IntelliSense in the following code example.  
  
### To correct this error  
  
1.  Swap the position of the two range variables as shown in the commented line in the following example:  
  
## Example  
 The following example generates CS1937.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The left side is generally called the "outer" side and the right is generally called the "inner" side.  
  
## See Also  
 [join clause (C# Reference)](../vs140/join-clause--csharp-reference-.md)