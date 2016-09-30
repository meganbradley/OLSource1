---
title: "&#39;#ElseIf&#39; must be preceded by a matching &#39;#If&#39; or &#39;#ElseIf&#39;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc30014"
  - "bc30014"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30014"
ms.assetid: 5215585e-2efa-485a-9efe-9833a1cc83a0
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;#ElseIf&#39; must be preceded by a matching &#39;#If&#39; or &#39;#ElseIf&#39;
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder> is a conditional compilation directive. An <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> clause must be preceded by a matching <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> clause.  
  
 **Error ID:** BC30014  
  
### To correct this error  
  
1.  Check that a preceding <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> has not been separated from this <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> by an intervening conditional compilation block or an incorrectly placed <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
2.  If the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is preceded by a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> directive, either remove the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or change it to an <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
3.  If everything else is in order, add an <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> directive to the beginning of the conditional compilation block.  
  
## See Also  
 [#If...Then...#Else Directives](../vs140/sharpif...then...sharpelse-directives.md)