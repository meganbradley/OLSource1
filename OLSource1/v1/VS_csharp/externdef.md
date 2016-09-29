---
title: "EXTERNDEF"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "EXTERNDEF"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EXTERNDEF directive"
ms.assetid: 95a10de6-c345-4428-a2f2-90f7d411dc86
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# EXTERNDEF
Defines one or more external variables, labels, or symbols called *name* whose type is `type`.  
  
## Syntax  
  
```  
  
EXTERNDEF [[langtype]] name:type [[, [[langtype]] name:type]]...  
```  
  
## Remarks  
 If *name* is defined in the module, it is treated as [PUBLIC](../VS_csharp/public--masm-.md). If *name* is referenced in the module, it is treated as [EXTERN](../VS_csharp/extern--masm-.md). If *name* is not referenced, it is ignored. The `type` can be [ABS](../VS_csharp/operator-abs.md), which imports *name* as a constant. Normally used in include files.  
  
## See Also  
 [Directives Reference](../VS_csharp/directives-reference.md)