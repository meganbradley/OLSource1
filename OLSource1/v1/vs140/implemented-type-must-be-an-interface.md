---
title: "Implemented type must be an interface"
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
  - "bc30232"
  - "vbc30232"
helpviewer_keywords: 
  - "BC30232"
ms.assetid: 63f3dd4c-2f99-4070-b506-2fa808df24d4
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Implemented type must be an interface
An `Implements` statement does not specify an interface. A class can implement only an interface.  
  
 **Error ID:** BC30232  
  
### To correct this error  
  
1.  Ensure that the interface name is spelled correctly.  
  
2.  If the statement specifies a class, consider using the `Inherits` statement.  
  
## See Also  
 [Implements Statement](../vs140/implements-statement.md)   
 [Inherits Statement](../vs140/inherits-statement.md)   
 [NOT IN BUILD: Inheritance in Visual Basic](assetId:///e5e6e240-ed31-4657-820c-079b7c79313c)