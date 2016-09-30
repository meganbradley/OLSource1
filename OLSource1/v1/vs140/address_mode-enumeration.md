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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Values  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Returns an arbitrary color, known as the border color, for texture coordinates outside the range of 0.0 to 1.0, inclusive.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Clamps the coordinates to the range of 0.0 to 1.0; that is, a coordinate smaller than 0.0 will be treated as 0.0 and a coordinate greater than 1.0 will be treated as 1.0.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Discards the integer part of the coordinates specified, but depending on whether the discarded integer is even or odd, it also complements the address—the texture is mirrored between 1.0 and 2.0, and then is normal again between 2.0 and 3.0, and so on.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Not exposed by the C++ AMP API. It represents an address mode that's adopted from, and created through, the underlying platform. After it's created, you can adopt it in your C++ AMP code through the platform’s interop APIs.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Ignores the integer part of the specified coordinates. This causes the texture to "wrap" around every integer.|  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** concurrency::graphics  
  
## See Also  
 [concurrency::graphics Namespace](../vs140/concurrency--graphics-namespace.md)