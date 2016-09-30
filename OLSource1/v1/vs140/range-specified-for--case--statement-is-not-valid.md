---
title: "Range specified for &#39;Case&#39; statement is not valid"
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
  - "vbc40052"
  - "bc40052"
helpviewer_keywords: 
  - "BC40052"
ms.assetid: a11d92f6-dc13-46a0-a8ca-5a962a0ed968
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Range specified for &#39;Case&#39; statement is not valid
An invalid range has been specified for a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement.  
  
 When you are comparing the same expression to several different values, you can use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statements as an alternative to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statements. While the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statements can evaluate a different expression in each statement, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement evaluates a single expression only once and then uses it for every comparison. Each <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement can contain more than one value, a range of values, or a combination of values and comparison operators.  
  
 **Error ID:** BC40052  
  
### To correct this error  
  
-   Modify the range to include all values, or use a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement to catch an undefined value.  
  
## See Also  
 [Select...Case Statement (Visual Basic)](../vs140/select...case-statement--visual-basic-.md)   
 [Decision Structures](../vs140/decision-structures--visual-basic-.md)   
 [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md)