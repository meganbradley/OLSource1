---
title: "Type &#39;&lt;typename&gt;&#39; and partial type &#39;&lt;typename&gt;&#39; declared in &#39;&lt;filename&gt;&#39; conflict in container &#39;&lt;containername&gt;&#39;, but are being merged because one of them is declared partial"
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
  - "vbc40047"
  - "bc40047"
helpviewer_keywords: 
  - "BC40047"
ms.assetid: 05f62dd9-f97d-4893-8904-76ecd2da474c
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type &#39;&lt;typename&gt;&#39; and partial type &#39;&lt;typename&gt;&#39; declared in &#39;&lt;filename&gt;&#39; conflict in container &#39;&lt;containername&gt;&#39;, but are being merged because one of them is declared partial
A class or structure is appears in multiple definitions in the same container type, and more than one definition is not marked `Partial`.  
  
 You must use the [Partial (Visual Basic)](../vs140/partial--visual-basic-.md) keyword on at least one of the multiple definitions of a class or structure, but it is recommended that you use it on all the partial definitions.  
  
 By default, this message is a warning. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC40047  
  
### To correct this error  
  
-   Use the [Partial (Visual Basic)](../vs140/partial--visual-basic-.md) keyword on every partial definition of the class or structure.