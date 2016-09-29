---
title: "&#39;AddressOf&#39; operand must be the name of a method (without parentheses)"
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
  - "vbc30577"
  - "bc30577"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30577"
ms.assetid: c2c55640-5c61-4e66-97a4-4322020c6001
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;AddressOf&#39; operand must be the name of a method (without parentheses)
The `AddressOf` operator creates a procedure delegate instance that references a specific procedure. The syntax is as follows.  
  
 `AddressOf` `procedurename`  
  
 You inserted parentheses around the argument following `AddressOf`, where none are needed.  
  
 **Error ID:** BC30577  
  
### To correct this error  
  
1.  Remove the parentheses around the argument following `AddressOf`.  
  
2.  Make sure the argument is a method name.  
  
## See Also  
 [AddressOf Operator](../vs140/addressof-operator--visual-basic-.md)   
 [Delegates (Visual Basic)](../vs140/delegates--visual-basic-.md)