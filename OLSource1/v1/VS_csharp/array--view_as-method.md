---
title: "array::view_as Method"
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
  - "amp/Concurrency::array::view_as"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "view_as method"
ms.assetid: a13aa5fb-7836-436a-8311-270d459b7e74
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::view_as Method
Reinterprets this array as an [array_view](../VS_csharp/array_view-class.md) of a different rank.  
  
## Syntax  
  
```  
template <  
   int _New_rank  
>  
array_view<_Value_type,_New_rank> view_as(  
   const Concurrency::extent<_New_rank>& _View_extent  
) restrict(amp,cpu);  
  
template <  
   int _New_rank  
>  
array_view<const _Value_type,_New_rank> view_as(  
   const Concurrency::extent<_New_rank>& _View_extent  
) const restrict(amp,cpu);  
```  
  
#### Parameters  
 `_New_rank`  
 The rank of the `extent` object passed as a parameter.  
  
 `_View_extent`  
 The extent that is used to construct the new [array_view](../VS_csharp/array_view-class.md) object.  
  
 `_Value_type`  
 The data type of the elements in both the original [array](../VS_csharp/array-class.md) object and the returned `array_view` object.  
  
## Return Value  
 The [array_view](../VS_csharp/array_view-class.md) object that is constructed.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array Class](../VS_csharp/array-class.md)