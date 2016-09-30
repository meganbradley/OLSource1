---
title: "Next control variable does not match For loop control variable &#39;&lt;variablename&gt;&#39;"
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
  - "vbc30070"
  - "bc30070"
helpviewer_keywords: 
  - "BC30070"
ms.assetid: e9e96008-b053-4fa0-8966-decaad99fecd
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Next control variable does not match For loop control variable &#39;&lt;variablename&gt;&#39;
The control variable in the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement of a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> loop must match the variable in the corresponding <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement.  
  
 **Error ID:** BC30070  
  
### To correct this error  
  
1.  Check the spelling of the variable in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement and in the corresponding <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement to be sure it matches.  
  
2.  Ensure that no parts of the enclosing loop have been inadvertently deleted.  
  
3.  If this loop is part of a set of nested loops, check that every loop is properly terminated.  
  
## See Also  
 [For...Next Statement](../vs140/for...next-statement--visual-basic-.md)