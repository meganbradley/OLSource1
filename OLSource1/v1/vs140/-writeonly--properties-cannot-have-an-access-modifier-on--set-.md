---
title: "&#39;WriteOnly&#39; properties cannot have an access modifier on &#39;Set&#39;"
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
  - "bc31104"
  - "vbc31104"
helpviewer_keywords: 
  - "BC31104"
ms.assetid: d1ac04a8-e436-4f3e-8d71-fc4569b35fcd
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;WriteOnly&#39; properties cannot have an access modifier on &#39;Set&#39;
A `WriteOnly` property declaration specifies access levels in both the [Property Statement](../vs140/property-statement.md) and the [Set Statement (Visual Basic)](../vs140/set-statement--visual-basic-.md).  
  
 You can always specify an access level for the property. In addition, you can specify a different access level for at most one of its property procedures (`Get` or `Set`), provided it is more restrictive than the property's access level. You cannot specify access levels for both of the property procedures.  
  
 **Error ID:** BC31104  
  
### To correct this error  
  
-   Remove the access modifier from the `Set` statement. It represents the entire `WriteOnly` property, and you cannot have two access levels for the property.  
  
## See Also  
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [How to: Declare a Property with Mixed Access Levels](../vs140/how-to--declare-a-property-with-mixed-access-levels--visual-basic-.md)