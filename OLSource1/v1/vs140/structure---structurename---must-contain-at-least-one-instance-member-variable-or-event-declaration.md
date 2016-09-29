---
title: "Structure &#39;&lt;structurename&gt;&#39; must contain at least one instance member variable or Event declaration"
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
  - "bc30281"
  - "vbc30281"
helpviewer_keywords: 
  - "BC30281"
ms.assetid: a03ee4e2-5fea-4933-898f-7f125b25824e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Structure &#39;&lt;structurename&gt;&#39; must contain at least one instance member variable or Event declaration
A functionally empty structure occurs. At least one variable member must be declared between the `Structure` statement and the `End Structure` statement.  
  
 **Error ID:** BC30281  
  
### To correct this error  
  
-   Add a `Dim` statement or an `Event` statement to the structure.  
  
## See Also  
 [Structure Statement](../vs140/structure-statement.md)   
 [Dim Statement](../vs140/dim-statement--visual-basic-.md)   
 [Event Statement](../vs140/event-statement.md)