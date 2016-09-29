---
title: "array_view::section Method"
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
  - "amp/Concurrency::array_view::section"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "section method"
ms.assetid: a10f8914-2726-4b84-9a91-9f8749059630
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array_view::section Method
Returns a subsection of the [array_view](../VS_csharp/array_view-class.md) object that's at the specified origin and, optionally, that has the specified extent.  
  
## Syntax  
  
```  
array_view section(  
   const Concurrency::index<_Rank>& _Section_origin,  
   const Concurrency::extent<_Rank>& _Section_extent  
) const restrict(amp,cpu);  
  
array_view section(  
   const Concurrency::index<_Rank>& _Idx  
) const restrict(amp,cpu);  
  
array_view section(  
   const Concurrency::extent<_Rank>& _Ext  
) const restrict(amp,cpu);  
  
array_view section(  
   int _I0,  
   int _E0  
) const restrict(amp,cpu);  
  
array_view section(  
   int _I0,  
   int _I1,  
   int _E0,  
   int _E1  
) const restrict(amp,cpu);  
  
array_view section(  
   int _I0,  
   int _I1,  
   int _I2,  
   int _E0,  
   int _E1,  
   int _E2  
) const restrict(amp,cpu);  
```  
  
#### Parameters  
 `_E0`  
 The most significant component of the extent of this section.  
  
 `_E1`  
 The next-to-most-significant component of the extent of this section.  
  
 `_E2`  
 The least significant component of the extent of this section.  
  
 `_Ext`  
 The [extent](../VS_csharp/extent-class--c---amp-.md) object that specifies the extent of the section. The origin is 0.  
  
 `_Idx`  
 The [index](../VS_csharp/index-class.md) object that specifies the location of the origin. The subsection is the rest of the extent.  
  
 `_I0`  
 The most significant component of the origin of this section.  
  
 `_I1`  
 The next-to-most-significant component of the origin of this section.  
  
 `_I2`  
 The least significant component of the origin of this section.  
  
 `_Rank`  
 The rank of the section.  
  
 `_Section_extent`  
 The [extent](../VS_csharp/extent-class--c---amp-.md) object that specifies the extent of the section.  
  
 `_Section_origin`  
 The [index](../VS_csharp/index-class.md) object that specifies the location of the origin.  
  
## Return Value  
 A subsection of the `array_view` object that's at the specified origin and, optionally, that has the specified extent. When only the `index` object is specified, the subsection contains all elements in the associated extent that have indexes that are larger than the indexes of the elements in the `index` object.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array_view Class](../VS_csharp/array_view-class.md)