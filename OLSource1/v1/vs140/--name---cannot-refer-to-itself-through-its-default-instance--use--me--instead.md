---
title: "&#39;&lt;name&gt;&#39; cannot refer to itself through its default instance, use &#39;Me&#39; instead"
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
  - "vbc31139"
  - "bc31139"
helpviewer_keywords: 
  - "BC31139"
ms.assetid: 459e5d5a-d526-4cd0-934e-96e4e1eb51bb
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;name&gt;&#39; cannot refer to itself through its default instance, use &#39;Me&#39; instead
An attempt has been made from inside a form to refer to that form as a default instance. This can cause the form to call itself recursively.  
  
 In most circumstances, you should use `Me` to when referring to the current instance of the form, instead of using the default instance.  
  
 **Error ID:** BC31139  
  
### To correct this error  
  
-   Use `Me` to refer to the object.  
  
## See Also  
 [Debugger Roadmap](../vs140/debugger-basics.md)