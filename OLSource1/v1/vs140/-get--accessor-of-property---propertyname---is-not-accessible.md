---
title: "&#39;Get&#39; accessor of property &#39;&lt;propertyname&gt;&#39; is not accessible"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc31103"
  - "bc31103"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC31103"
ms.assetid: 3c346c32-7669-4b04-841d-7a9df9cb703e
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Get&#39; accessor of property &#39;&lt;propertyname&gt;&#39; is not accessible
A statement attempts to retrieve the value of a property when it does not have access to the property's `Get` procedure.  
  
 If the [Get Statement](../vs140/get-statement.md) is marked with a more restrictive access level than its [Property Statement](../vs140/property-statement.md), an attempt to read the property value could fail in the following cases:  
  
-   The `Get` statement is marked [Private (Visual Basic)](../vs140/private--visual-basic-.md) and the calling code is outside the class or structure in which the property is defined.  
  
-   The `Get` statement is marked [Protected (Visual Basic)](../vs140/protected--visual-basic-.md) and the calling code is not in the class or structure in which the property is defined, nor in a derived class.  
  
-   The `Get` statement is marked [Friend (Visual Basic)](../vs140/friend--visual-basic-.md) and the calling code is not in the same assembly in which the property is defined.  
  
 **Error ID:** BC31103  
  
### To correct this error  
  
-   If you have control of the source code defining the property, consider declaring the `Get` procedure with the same access level as the property itself.  
  
-   If you do not have control of the source code defining the property, or you must restrict the `Get` procedure access level more than the property itself, try to move the statement that reads the property value to a region of code that has better access to the property.  
  
## See Also  
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [How to: Declare a Property with Mixed Access Levels](../vs140/how-to--declare-a-property-with-mixed-access-levels--visual-basic-.md)