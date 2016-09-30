---
title: "Unicode (Visual Basic)"
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
  - "vb.Unicode"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Unicode, external references"
  - "Declare statement, marshaling strings"
  - "Unicode keyword"
  - "Unicode, marshaling strings"
ms.assetid: 0021d5ff-3209-444e-8497-420f3e6ee075
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Unicode (Visual Basic)
Specifies that Visual Basic should marshal all strings to Unicode values regardless of the name of the external procedure being declared.  
  
 When you call a procedure defined outside your project, the Visual Basic compiler does not have access to the information it must have in order to call the procedure correctly. This information includes where the procedure is located, how it is identified, its calling sequence and return type, and the string character set it uses. The [Declare Statement](../vs140/declare-statement.md) creates a reference to an external procedure and supplies this necessary information.  
  
 The `charsetmodifier` part in the `Declare` statement supplies the character set information to marshal strings during a call to the external procedure. It also affects how Visual Basic searches the external file for the external procedure name. The `Unicode` modifier specifies that Visual Basic should marshal all strings to Unicode values and should look up the procedure without modifying its name during the search.  
  
 If no character set modifier is specified, `Ansi` is the default.  
  
## Remarks  
 The `Unicode` modifier can be used in this context:  
  
 [Declare Statement](../vs140/declare-statement.md)  
  
## Smart Device Developer Notes  
 This keyword is not supported.  
  
## See Also  
 [Ansi](../vs140/ansi--visual-basic-.md)   
 [Auto](../vs140/auto--visual-basic-.md)   
 [Keywords (Visual Basic)](../vs140/keywords--visual-basic-.md)