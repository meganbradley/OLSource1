---
title: "&#39;For&#39; loop control variable cannot be of type &#39;&lt;type&gt;&#39;"
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
  - "vbc30337"
  - "bc30337"
helpviewer_keywords: 
  - "BC30337"
ms.assetid: 988bba15-e9a2-4045-98a0-7f53c8b2c3e3
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;For&#39; loop control variable cannot be of type &#39;&lt;type&gt;&#39;
You have attempted to use a loop control variable that is not a valid type. At the beginning of a `For` loop, the start point, the end point, and the step value are evaluated in textual order. All three expressions must be implicitly convertible to the type of the variable. If the `For` loop variable is of type `Object`, then at least one of the expressions at run time must be of a numeric type, and all three expressions must be coercible to the widest numeric type among them.  
  
 **Error ID:** BC30337  
  
### To correct this error  
  
-   Check the type of the loop control variable and change it to a valid one.  
  
## See Also  
 [For (Visual Basic)](assetId:///c470a263-9b49-4308-8fd6-8592b84a7980)   
 [Do...Loop Statement (Visual Basic)](../vs140/do...loop-statement--visual-basic-.md)   
 [For...Next Statement](../vs140/for...next-statement--visual-basic-.md)