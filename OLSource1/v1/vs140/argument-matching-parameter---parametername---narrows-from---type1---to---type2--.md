---
title: "Argument matching parameter &#39;&lt;parametername&gt;&#39; narrows from &#39;&lt;type1&gt;&#39; to &#39;&lt;type2&gt;&#39;"
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
  - "vbc30520"
  - "bc30520"
helpviewer_keywords: 
  - "BC30520"
ms.assetid: 652ff70b-156d-4d1c-af19-fa1c53e2d0b5
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Argument matching parameter &#39;&lt;parametername&gt;&#39; narrows from &#39;&lt;type1&gt;&#39; to &#39;&lt;type2&gt;&#39;
You have made a call to an overloaded method, but the compiler cannot find a method that can be called without a narrowing conversion. A narrowing conversion changes a value to a data type that might not be able to precisely hold some of the possible values.  
  
 **Error ID:** BC30520  
  
### To correct this error  
  
-   Specify `Option Strict Off`.  
  
## See Also  
 [Overloaded Properties and Methods](../vs140/overloaded-properties-and-methods--visual-basic-.md)   
 [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md)   
 [Option Strict Statement](../vs140/option-strict-statement.md)