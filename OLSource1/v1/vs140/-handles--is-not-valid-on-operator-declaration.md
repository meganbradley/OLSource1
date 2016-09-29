---
title: "&#39;Handles&#39; is not valid on operator declaration"
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
  - "bc33003"
  - "vbc33003"
helpviewer_keywords: 
  - "BC33003"
ms.assetid: 8336402c-9393-4e8e-834d-55c2268f24f6
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Handles&#39; is not valid on operator declaration
An [Operator Statement](../vs140/operator-statement.md) specifies the [Handles](../vs140/handles-clause--visual-basic-.md) keyword.  
  
 Only a `Sub` procedure can handle events. An `Operator` procedure cannot. For more information on event handlers, see [How to: Call an Event Handler in Visual Basic](../vs140/how-to--call-an-event-handler-in-visual-basic.md).  
  
 An `Operator` procedure requires both the `Public` and `Shared` keywords, and a conversion operator requires either the `Widening` or the `Narrowing` keyword. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
 **Error ID:** BC33003  
  
### To correct this error  
  
-   If you intend this procedure to handle events, rewrite it as a `Sub` procedure.  
  
-   If you intend this procedure to define an operator, remove the `Handles` keyword from its declaration.  
  
## See Also  
 [Operator Statement](../vs140/operator-statement.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)