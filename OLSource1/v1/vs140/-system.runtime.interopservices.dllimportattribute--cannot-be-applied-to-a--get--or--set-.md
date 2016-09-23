---
title: "&#39;System.Runtime.InteropServices.DllImportAttribute&#39; cannot be applied to a &#39;Get&#39; or &#39;Set&#39;"
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
  - vbc31524
  - bc31524
helpviewer_keywords: 
  - BC31524
ms.assetid: 3603e33a-a80b-448d-83e0-e5dbc9af4dcf
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# &#39;System.Runtime.InteropServices.DllImportAttribute&#39; cannot be applied to a &#39;Get&#39; or &#39;Set&#39;
The `DllImportAttribute` attribute was applied to a `Get` or `Set` property procedure.  
  
 **Error ID:** BC31524  
  
### To correct this error  
  
1.  Remove `DllImportAttribute` from `Get` and `Set` property procedures.  
  
## See Also  
 <xref:System.Runtime.InteropServices.DllImportAttribute?qualifyHint=False>   
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)