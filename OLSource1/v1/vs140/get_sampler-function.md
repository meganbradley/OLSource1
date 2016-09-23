---
title: "get_sampler Function"
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
ms.assetid: bd7111d1-35da-48c1-a669-95f29b3a0189
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# get_sampler Function
Get the D3D sampler state interface on the given accelerator view that represents the specified sampler object.  
  
## Syntax  
  
```  
IUnknown * get_sampler(  
   const Concurrency::accelerator_view &_Av,  
   const sampler &_Sampler  
) restrict(amp);  
```  
  
#### Parameters  
 `_Av`  
 A D3D accelerator view on which the D3D sampler state is to be created.  
  
 `_Sampler`  
 A sampler object for which the underlying D3D sampler state interface is created.  
  
## Return Value  
 The IUnknown interface pointer corresponding to the D3D sampler state that represents the given sampler.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** concurrency::graphics::direct3d  
  
## See Also  
 [concurrency::graphics::direct3d Namespace](../vs140/concurrency--graphics--direct3d-namespace.md)