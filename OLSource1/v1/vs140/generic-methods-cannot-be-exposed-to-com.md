---
title: "Generic methods cannot be exposed to COM"
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
  - "vbc30943"
  - "bc30943"
helpviewer_keywords: 
  - "BC30943"
ms.assetid: 0e3bff62-f187-4864-8520-70f6be22e869
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Generic methods cannot be exposed to COM
A [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] component containing one or more generic procedures is exported to a COM component.  
  
 The Component Object Model (COM) does not support generic types, and it cannot interoperate with them.  
  
 **Error ID:** BC30943  
  
### To correct this error  
  
-   Remove the generic procedure or procedures from the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] component, or do not use it for COM interop.  
  
## See Also  
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [COM Interop](../vs140/com-interop--visual-basic-.md)