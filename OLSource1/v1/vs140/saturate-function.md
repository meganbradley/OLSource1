---
title: "saturate Function"
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
  - "amp/Concurrency::direct3d::saturate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "saturate function"
ms.assetid: dfefbee9-84f1-4c6c-bb36-b41e1dc6d205
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# saturate Function
Clamps _X within the range of 0 to 1  
  
## Syntax  
  
```  
inline float saturate(  
   float _X  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value  
  
## Return Value  
 Returns _X clamped within the range of 0 to 1  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency::direct3d  
  
## See Also  
 [direct3d Namespace](../vs140/concurrency--direct3d-namespace.md)