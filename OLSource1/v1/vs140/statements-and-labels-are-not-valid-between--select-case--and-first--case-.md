---
title: "Statements and labels are not valid between &#39;Select Case&#39; and first &#39;Case&#39;"
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
  - "bc30058"
  - "vbc30058"
helpviewer_keywords: 
  - "BC30058"
ms.assetid: 399b4659-f7df-4377-80be-43019f1e6206
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Statements and labels are not valid between &#39;Select Case&#39; and first &#39;Case&#39;
A statement that is not a comment appears between the opening <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement and its first <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement.  
  
 **Error ID:** BC30058  
  
### To correct this error  
  
-   If the intervening statement is a comment, precede it with a comment delimiter (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>). Otherwise, move or delete the statement.  
  
## See Also  
 [Select...Case Statement](../vs140/select...case-statement--visual-basic-.md)