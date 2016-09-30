---
title: "&#39;#ElseIf&#39; cannot follow &#39;#Else&#39; as part of an &#39;#If&#39; block"
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
  - "bc32030"
  - "vbc32030"
helpviewer_keywords: 
  - "BC32030"
ms.assetid: 248d6464-3019-4753-8a33-7070bbe5d2a6
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;#ElseIf&#39; cannot follow &#39;#Else&#39; as part of an &#39;#If&#39; block
An <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> conditional compilation directive follows an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> directive. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> must be the last directive in the conditional block before the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> directive.  
  
 **Error ID:** BC32030  
  
### To correct this error  
  
1.  Check if the preceding <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> should be an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
2.  Check that a preceding <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> block is properly terminated and that a new <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> block is initiated.  
  
3.  If everything else is correct, move this <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> directive and its corresponding statement block to precede the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> block.  
  
## See Also  
 [#If...Then...#Else Directives](../vs140/sharpif...then...sharpelse-directives.md)