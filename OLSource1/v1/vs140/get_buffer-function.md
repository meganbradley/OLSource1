---
title: "get_buffer Function"
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
  - "amp/Concurrency::direct3d::get_buffer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_buffer function"
ms.assetid: 2318772a-3254-42c0-b450-a9cc3967e843
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# get_buffer Function
Get the Direct3D buffer interface underlying the specified array.  
  
## Syntax  
  
```  
template<  
   typename _Value_type,  
   int _Rank  
>  
IUnknown *get_buffer(  
   const array<_Value_type, _Rank> &_Array  
)  ;  
```  
  
#### Parameters  
 `_Value_type`  
 The type of elements in the array.  
  
 `_Rank`  
 The rank of the array.  
  
 `_Array`  
 An array on a Direct3D accelerator_view for which the underlying Direct3D buffer interface is returned.  
  
## Return Value  
 The IUnknown interface pointer corresponding to the Direct3D buffer underlying the array.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency::direct3d  
  
## See Also  
 [direct3d Namespace](../vs140/concurrency--direct3d-namespace.md)