---
title: "&#39;&lt;method1&gt;&#39; cannot override &#39;&lt;method2&gt;&#39; because it expands the access of the base method"
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
  - "vbc32203"
  - "bc32203"
helpviewer_keywords: 
  - "BC32203"
ms.assetid: ef7816a4-5f57-4346-80fc-9311bc150b6b
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;method1&gt;&#39; cannot override &#39;&lt;method2&gt;&#39; because it expands the access of the base method
A procedure specifies `Overrides` but declares an accessibility less restrictive than that of the method to be overridden. You cannot expand the accessibility, meaning you cannot make the overriding method more accessible than the method it overrides. For example, if the base class method is `Protected`, you cannot override it with a `Public` method.  
  
 **Error ID:** BC32203  
  
### To correct this error  
  
-   Remove the `Overrides` keyword, or change the accessibility to be at least as restrictive as that of the base class method.  
  
## See Also  
 [NOT IN BUILD: Overriding Properties and Methods](assetId:///2167e8f5-1225-4b13-9ebd-02591ba90213)   
 [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md)   
 [Shadowing in Visual Basic](../vs140/shadowing-in-visual-basic.md)