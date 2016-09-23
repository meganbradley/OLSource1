---
title: "texture_view::texture_view Constructor"
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
ms.assetid: f06b4025-cdac-4aee-9b20-e6dbf35653d1
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# texture_view::texture_view Constructor
Constructs a `texture_view` instance.  
  
## Syntax  
  
```  
texture_view(        // [1] constructor  
   texture<_Value_type, _Rank>& _Src  
) restrict(amp);  
  
texture_view(        // [2] constructor  
   texture<_Value_type, _Rank>& _Src,  
   unsigned int _Mipmap_level = 0  
) restrict(cpu);  
  
texture_view(        // [3] constructor  
   const texture<_Value_type, _Rank>& _Src  
) restrict(amp);  
  
texture_view(        // [4] constructor  
   const texture<_Value_type, _Rank>& _Src,  
   unsigned int _Most_detailed_mip,  
   unsigned int _Mip_levels  
) restrict(cpu);  
  
texture_view(        // [5] copy constructor  
   const texture_view<_Value_type, _Rank>& _Other  
) restrict(amp, cpu);  
  
texture_view(        // [6] copy constructor  
   const texture_view<const _Value_type, _Rank>& _Other  
) restrict(amp, cpu);  
  
texture_view(        // [7] copy constructor  
   const texture_view<const _Value_type, _Rank>& _Other,  
   unsigned int _Most_detailed_mip,  
   unsigned int _Mip_levels  
) restrict(cpu);  
```  
  
#### Parameters  
 `_Src`  
 [1, 2] Constructor  
 The `texture` on which the writable `texture_view` is created.  
  
 [3, 4] Constructor  
 The `texture` on which the non-writable `texture_view` is created.  
  
 `_Other`  
 [5] Copy Constructor  
 The source writable `texture_view`.  
  
 [6, 7] Copy Constructor  
 The source non-writable `texture_view`.  
  
 `_Mipmap_level`  
 The specific mipmap level on the source `texture` that this writeable `texture_view` binds to. The default value is 0, which represents the top level (most detailed) mip level.  
  
 `_Most_detailed_mip`  
 Top level (most detailed) mip level for the view, relative to the specified `texture_view` object.  
  
 `_Mip_levels`  
 The number of mipmap levels accessible through the `texture_view`.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** concurrency::graphics  
  
## See Also  
 [texture_view Class](../vs140/texture_view-class.md)