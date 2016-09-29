---
title: "&#39;RaiseEvent&#39; method must have the same signature as the containing event&#39;s delegate type &#39;&lt;signature&gt;&#39;"
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
  - "bc31137"
  - "vbc31137"
helpviewer_keywords: 
  - "BC31137"
ms.assetid: 9db77546-9205-4fd2-baf6-6eb1b46b1f1a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;RaiseEvent&#39; method must have the same signature as the containing event&#39;s delegate type &#39;&lt;signature&gt;&#39;
A `Custom Event` declaration must have `RaiseEvent` declaration that has the same signature as the delegate type specified by the custom event's `As` clause.  
  
 For the signatures to match, the `RaiseEvent` declaration and the delegate must have the number of parameters, and the parameters types must match.  
  
 **Error ID:** BC31137  
  
### To correct this error  
  
-   Change the parameters of the `RaiseEvent` declaration to match the parameters of the delegate type.  
  
## Example  
 This example shows a custom event with the correct parameter types for the `RaiseEvent` declaration.  
  
 [!code[VbVbalrEventError#2](../vs140/codesnippet/VisualBasic/-raiseevent--method-must-have-the-same-signature-as-the-containing-event-s-delegate-type---signature--_1.vb)]  
  
## See Also  
 [Event Statement](../vs140/event-statement.md)   
 [RaiseEvent - delete](assetId:///7f765da0-5491-40b6-9ed5-24c98f9daad9)   
 [Delegate Statement](../vs140/delegate-statement.md)   
 [Events in Visual Basic](../vs140/events--visual-basic-.md)