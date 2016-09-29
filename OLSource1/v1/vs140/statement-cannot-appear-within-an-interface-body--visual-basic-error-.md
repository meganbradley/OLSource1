---
title: "Statement cannot appear within an interface body (Visual Basic Error)"
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
  - "bc30604"
  - "vbc30604"
helpviewer_keywords: 
  - "BC30604"
ms.assetid: ce4759fe-5e49-43ad-8405-a3f46ed0a36f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Statement cannot appear within an interface body (Visual Basic Error)
An unexpected language construct was encountered. It is assumed that an `End Interface` construct is missing and that any source code after this point is outside the interface.  
  
 **Error ID:** BC30604  
  
### To correct this error  
  
1.  Verify the syntax of the code used inside the interface definition.  
  
2.  Make sure that the interface definition ends with an `End Interface` construct.  
  
## See Also  
 [Interfaces](../vs140/interfaces--visual-basic-.md)   
 [Interface Statement](../vs140/interface-statement--visual-basic-.md)