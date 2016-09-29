---
title: "&#39;&lt;typename&gt;&#39; cannot inherit from &lt;type&gt; &#39;&lt;basetypename&gt;&#39; because it expands the access of the base &lt;type&gt; outside the assembly"
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
  - "vbc30910"
  - "bc30910"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30910"
ms.assetid: 68fc05c5-5d55-4742-9a3b-ea04312594f4
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;typename&gt;&#39; cannot inherit from &lt;type&gt; &#39;&lt;basetypename&gt;&#39; because it expands the access of the base &lt;type&gt; outside the assembly
A class or interface inherits from a base class or interface but has a less restrictive access level.  
  
 For example, a `Public` interface inherits from a `Friend` interface, or a `Protected` class inherits from a `Private` class. This exposes the base class or interface to access beyond the intended level.  
  
 **Error ID:** BC30910  
  
### To correct this error  
  
-   Change the access level of the derived class or interface to be at least as restrictive as that of the base class or interface.  
  
     -or-  
  
-   If you require the less restrictive access level, remove the `Inherits` statement. You cannot inherit from a more restricted base class or interface.  
  
## See Also  
 [Class Statement (Visual Basic)](../vs140/class-statement--visual-basic-.md)   
 [Interface Statement (Visual Basic)](../vs140/interface-statement--visual-basic-.md)   
 [Inherits Statement](../vs140/inherits-statement.md)   
 [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md)