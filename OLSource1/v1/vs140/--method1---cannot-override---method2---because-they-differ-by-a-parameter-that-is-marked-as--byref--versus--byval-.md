---
title: "&#39;&lt;method1&gt;&#39; cannot override &#39;&lt;method2&gt;&#39; because they differ by a parameter that is marked as &#39;ByRef&#39; versus &#39;ByVal&#39;"
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
  - "vbc30398"
  - "bc30398"
helpviewer_keywords: 
  - "BC30398"
ms.assetid: 78d62276-4ad9-4876-8c35-a30c9c195638
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;method1&gt;&#39; cannot override &#39;&lt;method2&gt;&#39; because they differ by a parameter that is marked as &#39;ByRef&#39; versus &#39;ByVal&#39;
You have attempted to override a method with another method that differs by a parameter marked `ByRef` instead of `ByVal`. Overridden members must have the same arguments as the inherited members from the base class.  
  
 **Error ID:** BC30398  
  
### To correct this error  
  
-   Make sure the parameters are either both `ByRef` or both `ByVal`.  
  
## See Also  
 [NOT IN BUILD: Overriding Properties and Methods](assetId:///2167e8f5-1225-4b13-9ebd-02591ba90213)   
 [Passing Arguments by Value and by Reference](../vs140/passing-arguments-by-value-and-by-reference--visual-basic-.md)