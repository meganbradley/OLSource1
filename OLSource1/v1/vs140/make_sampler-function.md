---
title: "make_sampler Function"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
ms.assetid: 135310d3-360b-47f7-80c2-87f3601208e7
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# make_sampler Function
Create a sampler from a D3D sampler state interface pointer.  
  
## Syntax  
  
```  
sampler make_sampler(  
   _In_ IUnknown *_D3D_sampler  
) restrict(amp);  
```  
  
#### Parameters  
 `_D3D_sampler`  
 IUnknown interface pointer of the D3D sampler state to create the sampler from.  
  
## Return Value  
 A sampler represents the provided D3D sampler state.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** concurrency::graphics::direct3d  
  
## See Also  
 [concurrency::graphics::direct3d Namespace](../vs140/concurrency--graphics--direct3d-namespace.md)