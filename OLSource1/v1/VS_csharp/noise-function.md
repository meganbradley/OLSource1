---
title: "noise Function"
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
  - "amp/Concurrency::direct3d::noise"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "noise function"
ms.assetid: 86760981-66e3-4cf2-8f17-6e450554e1ef
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# noise Function
Generates a random value using the Perlin noise algorithm  
  
## Syntax  
  
```  
inline float noise(  
   float _X  
) restrict(amp);  
```  
  
#### Parameters  
 `_X`  
 Floating-point value from which to generate Perlin noise  
  
## Return Value  
 Returns The Perlin noise value within a range between -1 and 1  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency::direct3d  
  
## See Also  
 [direct3d Namespace](../VS_csharp/concurrency--direct3d-namespace.md)