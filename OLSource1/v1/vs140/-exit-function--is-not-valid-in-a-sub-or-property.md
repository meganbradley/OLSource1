---
title: "&#39;Exit Function&#39; is not valid in a Sub or Property"
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
  - "vbc30067"
  - "bc30067"
helpviewer_keywords: 
  - "BC30067"
ms.assetid: 207fef65-4383-4120-9e5a-e0e14d168a72
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Exit Function&#39; is not valid in a Sub or Property
`Exit Function` appears in a `Sub` procedure or a `Property` procedure. An `Exit` statement must match the block in which it occurs.  
  
 **Error ID:** BC30067  
  
### To correct this error  
  
-   Replace the `Exit Function` with the `Exit Sub` or `Exit Property` statement as appropriate.  
  
## See Also  
 [Sub Procedures](../vs140/sub-procedures--visual-basic-.md)   
 [Function Procedures](../vs140/function-procedures--visual-basic-.md)   
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)