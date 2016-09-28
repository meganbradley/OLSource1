---
title: "Interface &#39;&lt;interfacename&gt;&#39; is not implemented by this class"
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
  - "bc31035"
  - "vbc31035"
helpviewer_keywords: 
  - "BC31035"
ms.assetid: 99ddabb5-20e0-4cf6-a8d4-1ca91f3c7511
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Interface &#39;&lt;interfacename&gt;&#39; is not implemented by this class
A member of this class or structure attempts to implement a member of an interface that the class or structure does not implement.  
  
 **Error ID:** BC31035  
  
### To correct this error  
  
-   Add an `Implements` statement at the beginning of the class or structure so that it implements the appropriate interface.  
  
-   Remove the `Implements` keyword from the member that causes this error.  
  
## See Also  
 [Interfaces](../vs140/interfaces--visual-basic-.md)   
 [Implements](../vs140/implements-clause--visual-basic-.md)   
 [Implements Statement](../vs140/implements-statement.md)