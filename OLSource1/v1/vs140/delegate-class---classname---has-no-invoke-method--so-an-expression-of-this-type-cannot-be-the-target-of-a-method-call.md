---
title: "Delegate class &#39;&lt;classname&gt;&#39; has no Invoke method, so an expression of this type cannot be the target of a method call"
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
  - "vbc30220"
  - "bc30220"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30220"
ms.assetid: 6be0d61c-f2f9-4f9b-ab90-8871a0d7206d
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Delegate class &#39;&lt;classname&gt;&#39; has no Invoke method, so an expression of this type cannot be the target of a method call
A call to `Invoke` through a delegate has failed because `Invoke` is not implemented on the delegate class.  
  
 **Error ID:** BC30220  
  
### To correct this error  
  
1.  Ensure that an instance of the delegate class has been created with a `Dim` statement and that a procedure has been assigned to the delegate instance with the `AddressOf` operator.  
  
2.  Locate the code that implements the delegate class and make sure it implements the `Invoke` procedure.  
  
## See Also  
 [Delegates in Visual Basic](../vs140/delegates--visual-basic-.md)   
 [Delegate Statement](../vs140/delegate-statement.md)   
 [AddressOf Operator](../vs140/addressof-operator--visual-basic-.md)   
 [Dim Statement](../vs140/dim-statement--visual-basic-.md)