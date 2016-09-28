---
title: "texture_view::gather_blue Method"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 5da8c286-a247-4c8e-a33e-26bc7297fef6
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# texture_view::gather_blue Method
Samples the texture at the specified coordinates by using the specified sampling configuration and returns the blue (z) components of the four sampled texels.  
  
## Syntax  
  
```  
const gather_return_type gather_blue(  
   const sampler& _Sampler,  
   const coordinates_type& _Coord  
) const restrict(amp);  
  
template<  
   address_mode _Address_mode = address_clamp  
>  
const gather_return_type gather_blue(  
   const coordinates_type& _Coord  
) const restrict(amp);  
```  
  
#### Parameters  
 `_Address_mode`  
 The address mode to use to sample the `texture_view`. The address mode is the same for all dimensions.  
  
 `_Sampler`  
 The sampler configuration to use to sample the `texture_view`.  
  
 `_Coord`  
 The coordinates to take the sample from. Fractional coordinate values are used to interpolate between sample texels.  
  
## Return Value  
 A rank 4 short vector containing the red (x) component of the 4 sampled texel values.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** concurrency::graphics  
  
## See Also  
 [texture_view Class](../vs140/texture_view-class.md)