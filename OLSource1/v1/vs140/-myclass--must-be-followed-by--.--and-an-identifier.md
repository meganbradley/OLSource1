---
title: "&#39;MyClass&#39; must be followed by &#39;.&#39; and an identifier"
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
  - "bc32028"
  - "vbc32028"
helpviewer_keywords: 
  - "BC32028"
ms.assetid: a7e92b54-32b8-4072-9576-632942f05e0f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;MyClass&#39; must be followed by &#39;.&#39; and an identifier
`MyClass` is not a true object variable, and it cannot appear alone. You use it only to access a member of the current instance as if it were `NotOverridable` in the base class.  
  
 **Error ID:** BC32028  
  
### To correct this error  
  
1.  If you intend to access a class member, specify the member access operator (`.`) and a member of the current instance after `MyClass`.  
  
2.  If you do not intend to access a class member, use the `Me` keyword.  
  
## See Also  
 [MyClass - delete](assetId:///5db36f9b-f796-4b6a-ba34-cac1fde6eb62)   
 [Me](assetId:///a65973c7-cf06-4547-9b25-9fba885525c2)   
 [NotOverridable](../vs140/notoverridable--visual-basic-.md)   
 [Inheritance Basics](../vs140/inheritance-basics--visual-basic-.md)