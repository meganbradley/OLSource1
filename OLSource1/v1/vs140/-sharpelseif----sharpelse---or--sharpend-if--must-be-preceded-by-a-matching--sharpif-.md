---
title: "&#39;#ElseIf&#39;, &#39;#Else&#39;, or &#39;#End If&#39; must be preceded by a matching &#39;#If&#39;"
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
  - "vbc30013"
  - "bc30013"
helpviewer_keywords: 
  - "BC30013"
ms.assetid: 8fe2d23c-8b8f-46d8-90f2-7f8857ea43bb
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;#ElseIf&#39;, &#39;#Else&#39;, or &#39;#End If&#39; must be preceded by a matching &#39;#If&#39;
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> are conditional compilation directives. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not preceded by a corresponding <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> directive.  
  
 **Error ID:** BC30013  
  
### To correct this error  
  
1.  Check that the intended <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is not separated from the clause in question by an intervening conditional compilation block or an incorrectly placed <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
    > [!NOTE]
    >  Only one <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is permitted in each <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> block, so two successive <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> directives cause this error.  
  
2.  Check that the leading <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is not missing from an earlier <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> directive.  
  
3.  If everything else is in order, add an <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> directive to the beginning of the conditional compilation block.  
  
## See Also  
 [#If...Then...#Else Directives](../vs140/sharpif...then...sharpelse-directives.md)