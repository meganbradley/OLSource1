---
title: "Concurrency::direct3d Namespace"
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
  - "amp/Concurrency::direct3d"
  - "amprt/Concurrency::direct3d"
  - "amp_short_vectors/Concurrency::direct3d"
  - "amp_graphics/Concurrency::direct3d"
  - "amp_math/Concurrency::direct3d"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "direct3d namespace"
ms.assetid: 9566a2f1-4d5f-43e4-a3ac-676643d38420
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Concurrency::direct3d Namespace
The `direct3d` namespace provides functions that support D3D interoperability. It enables seamless use of D3D resources for compute in AMP code as well as allow use of resources created in AMP in D3D code, without creating redundant intermediate copies. You can incrementally accelerate the compute intensive sections of your DirectX applications by using C++ AMP and use the D3D API on data produced from AMP computations.  
  
## Syntax  
  
```  
namespace direct3d;  
```  
  
## Members  
  
### Classes  
  
|Name|Description|  
|----------|-----------------|  
|[scoped_d3d_access_lock Class](../vs140/scoped_d3d_access_lock-class.md)|An RAII wrapper for a D3D access lock on an `accelerator_view` object.|  
  
### Structures  
  
|Name|Description|  
|----------|-----------------|  
|[adopt_d3d_access_lock_t](../vs140/adopt_d3d_access_lock_t-structure.md)|Tag type to indicate the D3D access lock should be adopted rather than acquired.|  
  
### Functions  
  
|Name|Description|  
|----------|-----------------|  
|[Abs Function](../vs140/abs-function.md)|Returns the absolute value of the argument|  
|[clamp Function](../vs140/clamp-function.md)|Overloaded. Clamps _X to the specified _Min and _Max range|  
|[countbits Function](../vs140/countbits-function.md)|Counts the number of set bits in _X|  
|[create_accelerator_view Function](../vs140/create_accelerator_view-function.md)|Creates an [accelerator_view](../vs140/accelerator_view-class.md) from a pointer to a Direct3D device interface|  
|[d3d_access_lock Function](../vs140/d3d_access_lock-function.md)|Acquires a lock on an accelerator_view for the purpose of safely performing D3D operations on resources shared with the accelerator_view|  
|[d3d_access_try_lock Function](../vs140/d3d_access_try_lock-function.md)|Attempt to acquire the D3D access lock on an accelerator_view without blocking.|  
|[d3d_access_unlock Function](../vs140/d3d_access_unlock-function.md)|Release the D3D access lock on the given accelerator_view.|  
|[firstbithigh Function](../vs140/firstbithigh-function.md)|Gets the location of the first set bit in _X, starting from the highest order bit and working downward|  
|[firstbitlow Function](../vs140/firstbitlow-function.md)|Gets the location of the first set bit in _X, starting from the lowest order bit and working upward|  
|[get_buffer Function](../vs140/get_buffer-function.md)|Get the D3D buffer interface underlying an array.|  
|[imax Function](../vs140/imax-function.md)|Compares two values, returning the value which is greater.|  
|[imin Function](../vs140/imin-function.md)|Compares two values, returning the value which is smaller.|  
|[is_timeout_disabled Function](../vs140/is_timeout_disabled-function.md)|Returns a boolean flag indicating if timeout is disabled for the specified accelerator_view.|  
|[mad Function](../vs140/mad-function.md)|Overloaded. Performs an arithmetic multiply/add operation on three arguments: _X * _Y + _Z|  
|[make_array Function](../vs140/make_array-function.md)|Create an array from a D3D buffer interface pointer.|  
|[noise Function](../vs140/noise-function.md)|Generates a random value by using the Perlin noise algorithm|  
|[radians Function](../vs140/radians-function.md)|Converts _X from degrees to radians|  
|[rcp Function](../vs140/rcp-function.md)|Calculates a fast, approximate reciprocal of the argument|  
|[reversebits Function](../vs140/reversebits-function.md)|Reverses the order of the bits in _X|  
|[saturate Function](../vs140/saturate-function.md)|Clamps _X within the range of 0 to 1|  
|[sign Function](../vs140/sign-function.md)|Overloaded. Returns the sign of the argument|  
|[smoothstep Function](../vs140/smoothstep-function.md)|Returns a smooth Hermite interpolation between 0 and 1, if _X is in the range [_Min, _Max].|  
|[step Function](../vs140/step-function.md)|Compares two values, returning 0 or 1 based on which value is greater|  
|[umax Function](../vs140/umax-function.md)|Compares two unsigned values, returning the value which is greater.|  
|[umin Function](../vs140/umin-function.md)|Compares two unsigned values, returning the value which is smaller.|  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [Concurrency Namespace (C++ Accelerated Massive Parallelism)](../vs140/concurrency-namespace--c---amp-.md)