---
title: "&#39;&lt;type1&gt;&#39; cannot override &lt;type2&gt; because it is not declared &#39;Overridable&#39;"
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
  - "bc31086"
  - "vbc31086"
helpviewer_keywords: 
  - "BC31086"
ms.assetid: ce071994-2e32-4460-a65d-f48f914386c6
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;type1&gt;&#39; cannot override &lt;type2&gt; because it is not declared &#39;Overridable&#39;
A member in a derived class overrides a base class member that is not marked with the `Overridable` modifier.  
  
 **Error ID:** BC31086  
  
### To correct this error  
  
1.  Add the `Overridable` modifier to the overridden member in the base class.  
  
2.  Use the `Shadows` keyword to shadow the item in the base class.  
  
## See Also  
 [Overridable](../vs140/overridable--visual-basic-.md)   
 [Overrides](../vs140/overrides--visual-basic-.md)   
 [Shadows](../vs140/shadows--visual-basic-.md)