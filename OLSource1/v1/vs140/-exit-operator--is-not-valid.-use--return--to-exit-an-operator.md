---
title: "&#39;Exit Operator&#39; is not valid. Use &#39;Return&#39; to exit an Operator"
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
  - "bc33008"
  - "vbc33008"
helpviewer_keywords: 
  - "BC33008"
ms.assetid: 8c44456b-8fd2-4168-ad8c-b6da129242ba
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Exit Operator&#39; is not valid. Use &#39;Return&#39; to exit an Operator
An `Exit Operator` statement appears in an `Operator` procedure.  
  
 You must use a [Return Statement (Visual Basic)](../vs140/return-statement--visual-basic-.md) to return from an `Operator` procedure. The [Exit Statement (Visual Basic)](../vs140/exit-statement--visual-basic-.md) does not accept the `Operator` keyword, and the `End Operator` statement does not return control to the calling code.  
  
 **Error ID:** BC33008  
  
### To correct this error  
  
-   Replace the `Exit Operator` statement with a `Return` statement.  
  
## See Also  
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Operator Statement](../vs140/operator-statement.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)