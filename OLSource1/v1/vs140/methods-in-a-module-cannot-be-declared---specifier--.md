---
title: "Methods in a Module cannot be declared &#39;&lt;specifier&gt;&#39;"
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
  - "bc30433"
  - "vbc30433"
helpviewer_keywords: 
  - "BC30433"
ms.assetid: e9fa204c-a40f-439e-95bb-048a89a19159
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Methods in a Module cannot be declared &#39;&lt;specifier&gt;&#39;
You have used a specifier that is not valid on a method within a `Module` statement. Modules can never be instantiated, do not support inheritance, and cannot implement interfaces.  
  
 **Error ID:** BC30433  
  
### To correct this error  
  
-   Remove the specifier.  
  
## See Also  
 [Module Statement](../vs140/module-statement.md)