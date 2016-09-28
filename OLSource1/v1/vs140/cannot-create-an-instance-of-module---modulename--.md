---
title: "Cannot create an instance of Module &#39;&lt;modulename&gt;&#39;"
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
  - "bc30166"
  - "vbc30166"
helpviewer_keywords: 
  - "BC30166"
ms.assetid: 40b9dbd3-9b57-450f-a631-b0ab06ca19c4
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Cannot create an instance of Module &#39;&lt;modulename&gt;&#39;
A module exists only as a single shared instance, and additional instances cannot be created.  
  
 **Error ID:** BC30166  
  
### To correct this error  
  
-   Change the module to a class, or replace it in the `New` clause with a class name.  
  
## See Also  
 [Module Statement](../vs140/module-statement.md)   
 [NOT IN BUILD: Implements Keyword and Implements Statement](assetId:///b96560f7-6413-480f-a1e2-f80253bab5be)