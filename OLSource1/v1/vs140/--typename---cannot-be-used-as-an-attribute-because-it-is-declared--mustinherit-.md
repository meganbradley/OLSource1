---
title: "&#39;&lt;typename&gt;&#39; cannot be used as an attribute because it is declared &#39;MustInherit&#39;"
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
  - vbc31506
  - bc31506
helpviewer_keywords: 
  - BC31506
ms.assetid: ea2baf3d-b8e8-4738-9b6d-53409fc4d282
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# &#39;&lt;typename&gt;&#39; cannot be used as an attribute because it is declared &#39;MustInherit&#39;
Custom attribute classes cannot be declared as `MustInherit`.  
  
 **Error ID:** BC31506  
  
### To correct this error  
  
-   Remove the `MustInherit` modifier from custom attributes.  
  
## See Also  
 <xref:System.AttributeUsageAttribute?qualifyHint=False>   
 [NOT IN BUILD: Custom Attributes in Visual Basic](assetId:///d72d8a5c-8f64-4614-b15b-cad66845d047)