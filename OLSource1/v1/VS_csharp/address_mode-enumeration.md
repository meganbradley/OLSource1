---
title: "address_mode Enumeration"
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
ms.assetid: 01cad955-e7ad-429d-a911-9d38420ed544
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# address_mode Enumeration
Enumeration type use to denote address modes supported for texture sampling.  
  
## Syntax  
  
```  
enum address_mode;  
```  
  
## Members  
  
### Values  
  
|Name|Description|  
|----------|-----------------|  
|`address_border`|Returns an arbitrary color, known as the border color, for texture coordinates outside the range of 0.0 to 1.0, inclusive.|  
|`address_clamp`|Clamps the coordinates to the range of 0.0 to 1.0; that is, a coordinate smaller than 0.0 will be treated as 0.0 and a coordinate greater than 1.0 will be treated as 1.0.|  
|`address_mirror`|Discards the integer part of the coordinates specified, but depending on whether the discarded integer is even or odd, it also complements the address—the texture is mirrored between 1.0 and 2.0, and then is normal again between 2.0 and 3.0, and so on.|  
|`address_unknown`|Not exposed by the C++ AMP API. It represents an address mode that's adopted from, and created through, the underlying platform. After it's created, you can adopt it in your C++ AMP code through the platform’s interop APIs.|  
|`address_wrap`|Ignores the integer part of the specified coordinates. This causes the texture to "wrap" around every integer.|  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** concurrency::graphics  
  
## See Also  
 [concurrency::graphics Namespace](../VS_csharp/concurrency--graphics-namespace.md)