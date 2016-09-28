---
title: "get_texture Function"
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
  - "amp_graphics/Concurrency::graphics::direct3d::get_texture"
dev_langs: 
  - "C++"
ms.assetid: 4f3354b8-3d5b-4feb-8825-95f32175d7e0
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# get_texture Function
Gets the Direct3D texture interface underlying the specified [texture](../vs140/texture-class.md) object.  
  
## Syntax  
  
```  
template<  
   typename _Value_type,  
   int _Rank  
>  
_Ret_ IUnknown *get_texture(  
   const texture<_Value_type, _Rank> &_Texture  
) restrict(cpu);  
  
template<  
   typename _Value_type,  
   int _Rank  
>  
_Ret_ IUnknown *get_texture(  
   const writeonly_texture_view<_Value_type, _Rank> &_Texture  
) restrict(cpu);  
  
template<  
   typename _Value_type,  
   int _Rank  
>  
_Ret_ IUnknown *get_texture(  
   const texture_view<_Value_type, _Rank> &_Texture  
) restrict(cpu);  
  
```  
  
#### Parameters  
 `_Value_type`  
 The element type of the texture.  
  
 `_Rank`  
 The rank of the texture.  
  
 `_Texture`  
 A texture or texture view associated with the accelerator_view for which the underlying Direct3D texture interface is returned.  
  
## Return Value  
 The IUnknown interface pointer corresponding to the Direct3D texture underlying the texture.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** Concurrency::graphics::direct3d  
  
## See Also  
 [Concurrency::graphics::direct3d Namespace](../vs140/concurrency--graphics--direct3d-namespace.md)