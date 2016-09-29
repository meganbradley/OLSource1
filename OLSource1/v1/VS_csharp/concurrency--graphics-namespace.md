---
title: "Concurrency::graphics Namespace"
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
  - "amp_graphics/Concurrency::graphics"
  - "amp_short_vectors/Concurrency::graphics"
dev_langs: 
  - "C++"
ms.assetid: 4529d3b1-d7da-4ffb-82bf-080915e0f23e
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Concurrency::graphics Namespace
The graphics namespace provides types and functions that are designed for graphics programming.  
  
## Syntax  
  
```  
namespace graphics;  
```  
  
## Members  
  
### Namespaces  
  
|Name|Description|  
|----------|-----------------|  
|[Concurrency::graphics::direct3d Namespace](../VS_csharp/concurrency--graphics--direct3d-namespace.md)|Provides functions for Direct3D interop.|  
  
### Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|`uint`|The element type for [uint_2 Class](../VS_csharp/uint_2-class.md), [uint_3 Class](../VS_csharp/uint_3-class.md), and [uint_4 Class](../VS_csharp/uint_4-class.md). Defined as `typedef unsigned int uint;`.|  
  
### Enumerations  
  
|Name|Description|  
|----------|-----------------|  
|[address_mode](../VS_csharp/address_mode-enumeration.md)|Specifies address modes supported for texture sampling.|  
|[filter_mode](../VS_csharp/filter_mode-enumeration.md)|Specifies filter modes supported for texture sampling.|  
  
### Classes  
  
|Name|Description|  
|----------|-----------------|  
|[texture Class](../VS_csharp/texture-class.md)|A texture is a data aggregate on an accelerator_view in the extent domain. It is a collection of variables, one for each element in an extent domain. Each variable holds a value corresponding to C++ primitive type (unsigned int, int, float, double), or scalar type norm, or unorm (defined in concurrency::graphics), or eligible short vector types defined in concurrency::graphics.|  
|[writeonly_texture_view Class](../VS_csharp/writeonly_texture_view-class.md)|A writeonly_texture_view provides writeonly access to a texture.|  
|[double_2 Class](../VS_csharp/double_2-class.md)|Represents a short vector of 2 `double` values.|  
|[double_3 Class](../VS_csharp/double_3-class.md)|Represents a short vector of 3 `double` values.|  
|[double_4 Class](../VS_csharp/double_4-class.md)|Represents a short vector of 4 `double` values.|  
|[float_2 Class](../VS_csharp/float_2-class.md)|Represents a short vector of 2 `float` values.|  
|[float_3 Class](../VS_csharp/float_3-class.md)|Represents a short vector of 3 `float` values.|  
|[float_4 Class](../VS_csharp/float_4-class.md)|Represents a short vector of 4 `float` values.|  
|[int_2 Class](../VS_csharp/int_2-class.md)|Represents a short vector of 2 `int` values.|  
|[int_3 Class](../VS_csharp/int_3-class.md)|Represents a short vector of 3 `int` values.|  
|[int_4 Class](../VS_csharp/int_4-class.md)|Represents a short vector of 4 `int` values.|  
|[norm_2 Class](../VS_csharp/norm_2-class.md)|Represents a short vector of 2 `norm` values.|  
|[norm_3 Class](../VS_csharp/norm_3-class.md)|Represents a short vector of 3 `norm` values.|  
|[norm_4 Class](../VS_csharp/norm_4-class.md)|Represents a short vector of 4 `norm` values.|  
|[uint_2 Class](../VS_csharp/uint_2-class.md)|Represents a short vector of 2 `uint` values.|  
|[uint_3 Class](../VS_csharp/uint_3-class.md)|Represents a short vector of 3 `uint` values.|  
|[uint_4 Class](../VS_csharp/uint_4-class.md)|Represents a short vector of 4 `uint` values.|  
|[unorm_2 Class](../VS_csharp/unorm_2-class.md)|Represents a short vector of 2 `unorm` values.|  
|[unorm_3 Class](../VS_csharp/unorm_3-class.md)|Represents a short vector of 3 `unorm` values.|  
|[unorm_4 Class](../VS_csharp/unorm_4-class.md)|Represents a short vector of 4 `unorm` values.|  
|[Sampler Class](../VS_csharp/sampler-class.md)|Represents the sampler configuration used for texture sampling.|  
|[short_vector Structure](../VS_csharp/short_vector-structure.md)|Provides a basic implementation of a short vector of values.|  
|[short_vector_traits Structure](../VS_csharp/short_vector_traits-structure.md)|Provides for retrieval of the length and type of a short vector.|  
|[texture_view Class](../VS_csharp/texture_view-class.md)|Provides read access and write access to a texture.|  
  
### Functions  
  
|Name|Description|  
|----------|-----------------|  
|[copy Function](../VS_csharp/copy-function.md)|Overloaded. Copies the contents of the source texture into the destination host buffer.|  
|[copy_async Function](../VS_csharp/copy_async-function.md)|Overloaded. Asynchronously copies the contents of the source texture into the destination host buffer.|  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [Concurrency Namespace (C++ AMP)](../VS_csharp/concurrency-namespace--c---amp-.md)