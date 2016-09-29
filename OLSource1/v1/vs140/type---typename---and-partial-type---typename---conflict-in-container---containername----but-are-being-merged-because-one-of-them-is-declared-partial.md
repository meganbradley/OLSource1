---
title: "Type &#39;&lt;typename&gt;&#39; and partial type &#39;&lt;typename&gt;&#39; conflict in container &#39;&lt;containername&gt;&#39;, but are being merged because one of them is declared partial"
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
  - "bc40046"
  - "vbc40046"
helpviewer_keywords: 
  - "BC40046"
ms.assetid: c243e70b-ecd5-49ef-a260-a7bb12a4a3b1
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type &#39;&lt;typename&gt;&#39; and partial type &#39;&lt;typename&gt;&#39; conflict in container &#39;&lt;containername&gt;&#39;, but are being merged because one of them is declared partial
A class or structure is appears in multiple definitions in the same container type, and more than one definition is not marked `Partial`.  
  
 You must use the [Partial (Visual Basic)](../vs140/partial--visual-basic-.md) keyword on at least one of the multiple definitions of a class or structure, but it is recommended that you use it on all the partial definitions.  
  
 By default, this message is a warning. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC40046  
  
### To correct this error  
  
-   Use the [Partial (Visual Basic)](../vs140/partial--visual-basic-.md) keyword on every partial definition of the class or structure.  
  
## See Also  
 [Partial (Visual Basic)](../vs140/partial--visual-basic-.md)