---
title: "Property accessors cannot be declared &#39;&lt;accessmodifier&gt;&#39; in a &#39;Default&#39; property"
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
  - "bc31107"
  - "vbc31107"
helpviewer_keywords: 
  - "BC31107"
ms.assetid: 25657b33-df85-4535-8043-69795c987175
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Property accessors cannot be declared &#39;&lt;accessmodifier&gt;&#39; in a &#39;Default&#39; property
A [Get Statement](../vs140/get-statement.md) or [Set Statement (Visual Basic)](../vs140/set-statement--visual-basic-.md) in a default property includes the `Private` keyword.  
  
 A default property cannot be `Private`, and neither can its individual property procedures (`Get` or `Set`).  
  
 **Error ID:** BC31107  
  
### To correct this error  
  
-   Remove the `Private` keyword from the `Get` or `Set` statement, or remove `Default` from the [Property Statement](../vs140/property-statement.md).  
  
## See Also  
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [How to: Declare a Property with Mixed Access Levels](../vs140/how-to--declare-a-property-with-mixed-access-levels--visual-basic-.md)   
 [How to: Declare and Call a Default Property in Visual Basic](../vs140/how-to--declare-and-call-a-default-property-in-visual-basic.md)