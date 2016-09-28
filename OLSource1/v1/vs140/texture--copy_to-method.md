---
title: "texture::copy_to Method"
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
  - "amp_graphics/Concurrency::graphics::texture::copy_to"
dev_langs: 
  - "C++"
ms.assetid: 9507f6c3-32cf-41d7-b415-c659e7735d3f
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# texture::copy_to Method
Copies the [texture](../vs140/texture-class.md) object to the destination, by doing a deep copy.  
  
## Syntax  
  
```  
void copy_to(  
   texture & _Dest  
) const;  
  
void copy_to(  
   writeonly_texture_view<_Value_type, _Rank> & _Dest  
) const;  
```  
  
#### Parameters  
 `_Dest`  
 The object to copy to.  
  
 `_Rank`  
 The rank of the texture.  
  
 `_Value_type`  
 The type of the elements in the texture.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** Concurrency::graphics  
  
## See Also  
 [texture Class](../vs140/texture-class.md)