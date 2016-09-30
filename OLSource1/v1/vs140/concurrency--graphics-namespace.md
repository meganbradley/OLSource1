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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Namespaces  
  
|Name|Description|  
|----------|-----------------|  
|[Concurrency::graphics::direct3d Namespace](../vs140/concurrency--graphics--direct3d-namespace.md)|Provides functions for Direct3D interop.|  
  
### Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The element type for [uint_2 Class](../vs140/uint_2-class.md), [uint_3 Class](../vs140/uint_3-class.md), and [uint_4 Class](../vs140/uint_4-class.md). Defined as <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.|  
  
### Enumerations  
  
|Name|Description|  
|----------|-----------------|  
|[address_mode](../vs140/address_mode-enumeration.md)|Specifies address modes supported for texture sampling.|  
|[filter_mode](../vs140/filter_mode-enumeration.md)|Specifies filter modes supported for texture sampling.|  
  
### Classes  
  
|Name|Description|  
|----------|-----------------|  
|[texture Class](../vs140/texture-class.md)|A texture is a data aggregate on an accelerator_view in the extent domain. It is a collection of variables, one for each element in an extent domain. Each variable holds a value corresponding to C++ primitive type (unsigned int, int, float, double), or scalar type norm, or unorm (defined in concurrency::graphics), or eligible short vector types defined in concurrency::graphics.|  
|[writeonly_texture_view Class](../vs140/writeonly_texture_view-class.md)|A writeonly_texture_view provides writeonly access to a texture.|  
|[double_2 Class](../vs140/double_2-class.md)|Represents a short vector of 2 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> values.|  
|[double_3 Class](../vs140/double_3-class.md)|Represents a short vector of 3 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> values.|  
|[double_4 Class](../vs140/double_4-class.md)|Represents a short vector of 4 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> values.|  
|[float_2 Class](../vs140/float_2-class.md)|Represents a short vector of 2 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> values.|  
|[float_3 Class](../vs140/float_3-class.md)|Represents a short vector of 3 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> values.|  
|[float_4 Class](../vs140/float_4-class.md)|Represents a short vector of 4 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> values.|  
|[int_2 Class](../vs140/int_2-class.md)|Represents a short vector of 2 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> values.|  
|[int_3 Class](../vs140/int_3-class.md)|Represents a short vector of 3 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> values.|  
|[int_4 Class](../vs140/int_4-class.md)|Represents a short vector of 4 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> values.|  
|[norm_2 Class](../vs140/norm_2-class.md)|Represents a short vector of 2 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> values.|  
|[norm_3 Class](../vs140/norm_3-class.md)|Represents a short vector of 3 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> values.|  
|[norm_4 Class](../vs140/norm_4-class.md)|Represents a short vector of 4 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> values.|  
|[uint_2 Class](../vs140/uint_2-class.md)|Represents a short vector of 2 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> values.|  
|[uint_3 Class](../vs140/uint_3-class.md)|Represents a short vector of 3 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> values.|  
|[uint_4 Class](../vs140/uint_4-class.md)|Represents a short vector of 4 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> values.|  
|[unorm_2 Class](../vs140/unorm_2-class.md)|Represents a short vector of 2 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> values.|  
|[unorm_3 Class](../vs140/unorm_3-class.md)|Represents a short vector of 3 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> values.|  
|[unorm_4 Class](../vs140/unorm_4-class.md)|Represents a short vector of 4 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> values.|  
|[Sampler Class](../vs140/sampler-class.md)|Represents the sampler configuration used for texture sampling.|  
|[short_vector Structure](../vs140/short_vector-structure.md)|Provides a basic implementation of a short vector of values.|  
|[short_vector_traits Structure](../vs140/short_vector_traits-structure.md)|Provides for retrieval of the length and type of a short vector.|  
|[texture_view Class](../vs140/texture_view-class.md)|Provides read access and write access to a texture.|  
  
### Functions  
  
|Name|Description|  
|----------|-----------------|  
|[copy Function](../vs140/copy-function.md)|Overloaded. Copies the contents of the source texture into the destination host buffer.|  
|[copy_async Function](../vs140/copy_async-function.md)|Overloaded. Asynchronously copies the contents of the source texture into the destination host buffer.|  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [Concurrency Namespace (C++ AMP)](../vs140/concurrency-namespace--c---amp-.md)