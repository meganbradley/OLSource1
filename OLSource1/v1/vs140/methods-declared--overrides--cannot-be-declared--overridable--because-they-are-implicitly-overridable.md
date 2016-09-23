---
title: "Methods declared &#39;Overrides&#39; cannot be declared &#39;Overridable&#39; because they are implicitly overridable"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - bc30730
  - vbc30730
helpviewer_keywords: 
  - BC30730
ms.assetid: cc892f81-eb1f-42a9-8f54-eff352adb5dd
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Methods declared &#39;Overrides&#39; cannot be declared &#39;Overridable&#39; because they are implicitly overridable
Unlike most methods, methods marked with the `Overrides` modifier are overridable by default.  
  
 **Error ID:** BC30730  
  
### To correct this error  
  
-   Omit the `Overridable` modifier from methods marked with the `Overrides` modifier.  
  
## See Also  
 [Overrides](../vs140/overrides--visual-basic-.md)   
 [Overridable](../vs140/overridable--visual-basic-.md)