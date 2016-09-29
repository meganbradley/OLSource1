---
title: "Property accessors cannot be declared &#39;&lt;keyword&gt;&#39;"
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
  - "vbc31099"
  - "bc31099"
helpviewer_keywords: 
  - "BC31099"
ms.assetid: d6f3b989-39b9-4c47-995a-bd83ec03d7b8
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Property accessors cannot be declared &#39;&lt;keyword&gt;&#39;
A `Get` or `Set` procedure declaration includes a keyword that is not valid on a property procedure.  
  
 The [Get Statement](../vs140/get-statement.md) and [Set Statement (Visual Basic)](../vs140/set-statement--visual-basic-.md) allow only an access modifier (`Public`, `Protected`, `Friend`, `Protected Friend`, `Private`).  
  
 **Error ID:** BC31099  
  
### To correct this error  
  
-   Remove the invalid keyword from the `Get` or `Set` statement.  
  
## See Also  
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [How to: Declare a Property with Mixed Access Levels](../vs140/how-to--declare-a-property-with-mixed-access-levels--visual-basic-.md)