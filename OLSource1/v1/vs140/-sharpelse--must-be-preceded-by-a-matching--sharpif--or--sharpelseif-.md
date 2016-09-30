---
title: "&#39;#Else&#39; must be preceded by a matching &#39;#If&#39; or &#39;#ElseIf&#39;"
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
  - "vbc30028"
  - "bc30028"
helpviewer_keywords: 
  - "BC30028"
ms.assetid: c6ed34de-d6ed-4227-9880-538055aff20a
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;#Else&#39; must be preceded by a matching &#39;#If&#39; or &#39;#ElseIf&#39;
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder> is a conditional compilation directive. An <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> directive is not preceded by a corresponding <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> directive.  
  
 **Error ID:** BC30028  
  
### To correct this error  
  
1.  Check that a preceding <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not separated from this <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> by an intervening conditional compilation block or an incorrectly placed <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
2.  Check that <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is preceded by another <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> directive. If it is, either remove <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or change it to an <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
3.  If everything else is in order, add an <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> directive to the beginning of the conditional compilation block.  
  
## See Also  
 [#If...Then...#Else Directives](../vs140/sharpif...then...sharpelse-directives.md)