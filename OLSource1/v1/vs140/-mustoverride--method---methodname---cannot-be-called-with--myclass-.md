---
title: "&#39;MustOverride&#39; method &#39;&lt;methodname&gt;&#39; cannot be called with &#39;MyClass&#39;"
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
  - "bc30614"
  - "vbc30614"
helpviewer_keywords: 
  - "BC30614"
ms.assetid: fc57af41-1552-46d1-9727-341f1835e661
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;MustOverride&#39; method &#39;&lt;methodname&gt;&#39; cannot be called with &#39;MyClass&#39;
`MyClass` is equivalent to `Me`, but all method invocations on it are treated as if the method being invoked were `NotOverridable`.  
  
 **Error ID:** BC30614  
  
### To correct this error  
  
-   Remove the `MustOverride` modifier, or declare the method in a base class and inherit and override that class.  
  
## See Also  
 [MustOverride](../vs140/mustoverride--visual-basic-.md)   
 [MustInherit](../vs140/mustinherit--visual-basic-.md)   
 [NotOverridable](../vs140/notoverridable--visual-basic-.md)