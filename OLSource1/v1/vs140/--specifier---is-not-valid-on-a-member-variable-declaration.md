---
title: "&#39;&lt;specifier&gt;&#39; is not valid on a member variable declaration"
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
  - "vbc30235"
  - "bc30235"
helpviewer_keywords: 
  - "BC30235"
ms.assetid: 8c5764e4-0096-4ca0-8656-05341a39833a
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;specifier&gt;&#39; is not valid on a member variable declaration
A <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement contains an invalid keyword. A <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement can include only the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keywords.  
  
 This message can also appear if you declare a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> variable outside of a procedure. You can use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> only at procedure level.  
  
 Note that if you include a valid keyword in a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> statement, you can optionally omit the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> keyword.  
  
 **Error ID:** BC30235  
  
### To correct this error  
  
1.  Remove the invalid keyword from the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> statement.  
  
2.  If you have declared a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> variable outside of a procedure, either move the declaration inside a procedure or remove the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> keyword.  
  
## See Also  
 [Dim Statement](../vs140/dim-statement--visual-basic-.md)