---
title: "&#39;&lt;method1&gt;&#39; and &#39;&lt;method2&gt;&#39; cannot overload each other because they differ only by return types"
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
  - "bc30301"
  - "vbc30301"
helpviewer_keywords: 
  - "BC30301"
ms.assetid: 5adc442b-9671-4d93-add8-42929b1a09b9
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;method1&gt;&#39; and &#39;&lt;method2&gt;&#39; cannot overload each other because they differ only by return types
You have attempted to overload a method with another method that differs from the first only in its return type. In overloading, you must differentiate any two versions of a method by their argument lists; you cannot use anything other than argument lists to differentiate the methods.  
  
 **Error ID:** BC30301  
  
### To correct this error  
  
-   Ensure that the methods are differentiated by their argument lists.  
  
## See Also  
 [Procedure Overloading](../vs140/procedure-overloading--visual-basic-.md)   
 [Considerations in Overloading Procedures](../vs140/considerations-in-overloading-procedures--visual-basic-.md)