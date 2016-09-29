---
title: "writeonly_texture_view::writeonly_texture_view Constructor"
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
  - "amp_graphics/Concurrency::graphics::writeonly_texture_view::writeonly_texture_view"
dev_langs: 
  - "C++"
ms.assetid: cde30944-8f69-4866-b8e4-2164cc0157e4
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# writeonly_texture_view::writeonly_texture_view Constructor
Initializes a new instance of the [writeonly_texture_view](../vs140/writeonly_texture_view-class.md) class.  
  
## Syntax  
  
```  
writeonly_texture_view(  
   texture<_Value_type,  
   _Rank>& _Src                       
) restrict(amp);  
  
writeonly_texture_view(  
   const writeonly_texture_view<_Value_type,  
   _Rank>& _Src                       
) restrict(amp,cpu);  
```  
  
#### Parameters  
 `_Rank`  
 The rank of the texture.  
  
 `_Value_type`  
 The type of the elements in the texture.  
  
 `_Src`  
 The texture that is used to create the `writeonly_texture_view`.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** Concurrency::graphics  
  
## See Also  
 [writeonly_texture_view Class](../vs140/writeonly_texture_view-class.md)