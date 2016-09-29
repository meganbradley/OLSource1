---
title: "array::section Method"
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
  - "amp/Concurrency::array::section"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "section method"
ms.assetid: 18cb537a-de02-404a-808a-2d52014f74f1
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::section Method
Returns a subsection of the [array](../vs140/array-class.md) object that is at the specified origin and, optionally, that has the specified extent.  
  
## Syntax  
  
```  
array_view<_Value_type,_Rank> section(  
   const Concurrency::index<_Rank>& _Section_origin,  
   const Concurrency::extent<_Rank>& _Section_extent  
) restrict(amp,cpu);  
  
array_view<const _Value_type,_Rank> section(  
   const Concurrency::index<_Rank>& _Section_origin,  
   const Concurrency::extent<_Rank>& _Section_extent  
) const restrict(amp,cpu);  
  
array_view<_Value_type,_Rank> section(  
   const Concurrency::extent<_Rank>& _Ext  
) restrict(amp,cpu);  
  
array_view<const _Value_type,_Rank> section(  
   const Concurrency::extent<_Rank>& _Ext  
) const restrict(amp,cpu);  
  
array_view<_Value_type,_Rank> section(  
   const index<_Rank>& _Idx  
) restrict(amp,cpu);  
  
array_view<const _Value_type,_Rank> section(  
   const index<_Rank>& _Idx  
) const restrict(amp,cpu);  
  
array_view<_Value_type,1> section(  
   int _I0,  
   int _E0  
) restrict(amp,cpu);  
  
array_view<const _Value_type,1> section(  
   int _I0,  
   int _E0  
) const restrict(amp,cpu);  
  
array_view<_Value_type,2> section(  
   int _I0,  
   int _I1,  
   int _E0,  
   int _E1  
) restrict(amp,cpu);  
  
array_view<const _Value_type,2> section(  
   int _I0,  
   int _I1,  
   int _E0,  
   int _E1  
) const restrict(amp,cpu);  
  
array_view<_Value_type,3> section(  
   int _I0,  
   int _I1,  
   int _I2,  
   int _E0,  
   int _E1,  
   int _E2  
) restrict(amp,cpu);  
  
array_view<const _Value_type,3> section(  
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
 The [extent](../vs140/extent-class--c---amp-.md) object that specifies the extent of the section. The origin is 0.  
  
 `_Idx`  
 The [index](../vs140/index-class.md) object that specifies the location of the origin. The subsection is the rest of the extent.  
  
 `_I0`  
 The most significant component of the origin of this section.  
  
 `_I1`  
 The next-to-most-significant component of the origin of this section.  
  
 `_I2`  
 The least significant component of the origin of this section.  
  
 `_Rank`  
 The rank of the section.  
  
 `_Section_extent`  
 The [extent](../vs140/extent-class--c---amp-.md) object that specifies the extent of the section.  
  
 `_Section_origin`  
 The [index](../vs140/index-class.md) object that specifies the location of the origin.  
  
 `_Value_type`  
 The data type of the elements that are copied.  
  
## Return Value  
 Returns a subsection of the `array` object that is at the specified origin and, optionally, that has the specified extent. When only the `index` object is specified, the subsection contains all elements in the associated grid that have indexes that are larger than the indexes of the elements in the `index` object.  
  
## Remarks  
 The overloads of this method let you create subsections of the [array](../vs140/array-class.md) objects that have one, two, or three dimension.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array Class](../vs140/array-class.md)