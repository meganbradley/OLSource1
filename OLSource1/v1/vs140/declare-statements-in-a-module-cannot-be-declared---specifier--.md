---
title: "Declare statements in a Module cannot be declared &#39;&lt;specifier&gt;&#39;"
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
  - "vbc30786"
  - "bc30786"
helpviewer_keywords: 
  - "BC30786"
ms.assetid: 488b855f-72ea-414b-bffc-a5b63e97d289
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Declare statements in a Module cannot be declared &#39;&lt;specifier&gt;&#39;
A `Declare` declaration has a specifier that is not valid within a `Module` declaration. Modules can never be instantiated, do not support inheritance, and cannot implement interfaces.  
  
 **Error ID:** BC30786  
  
### To correct this error  
  
-   Remove the specifier.  
  
## See Also  
 [Delegate Statement](../vs140/delegate-statement.md)   
 [Module Statement](../vs140/module-statement.md)