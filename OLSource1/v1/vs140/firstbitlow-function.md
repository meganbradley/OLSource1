---
title: "firstbitlow Function"
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
  - "amp/Concurrency::direct3d::firstbitlow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "firstbitlow function"
ms.assetid: 46970414-fe23-4585-a725-8c41d699b3fd
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# firstbitlow Function
Gets the location of the first set bit in _X, beginning with the lowest-order bit and working toward the highest-order bit.  
  
## Syntax  
  
```  
inline int firstbitlow(  
   int _X  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Integer value  
  
## Return Value  
 Returns The location of the first set bit  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency::direct3d  
  
## See Also  
 [direct3d Namespace](../vs140/concurrency--direct3d-namespace.md)