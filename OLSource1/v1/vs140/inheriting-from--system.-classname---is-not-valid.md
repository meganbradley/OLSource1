---
title: "Inheriting from &#39;System.&lt;classname&gt;&#39; is not valid"
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
  - "vbc30015"
  - "bc30015"
helpviewer_keywords: 
  - "BC30015"
ms.assetid: b4c005df-a510-47c7-b5cc-27f4514d32b6
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Inheriting from &#39;System.&lt;classname&gt;&#39; is not valid
A class cannot inherit from `System.Array`, `System.Delegate`, `System.Enum`, or `System.ValueType`.  
  
 **Error ID:** BC30015  
  
### To correct this error  
  
-   Remove the `Inherits` statement or change it to inherit from a valid base class.  
  
## See Also  
 [Inheritance Basics](../vs140/inheritance-basics--visual-basic-.md)   
 [Object Variable Declaration](../vs140/object-variable-declaration--visual-basic-.md)