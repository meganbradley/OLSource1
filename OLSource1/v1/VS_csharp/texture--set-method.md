---
title: "texture::set Method"
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
  - "amp_graphics/Concurrency::graphics::texture::set"
dev_langs: 
  - "C++"
ms.assetid: c518e29e-64f3-4d27-8e2c-3beb2ce2981c
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# texture::set Method
Sets the value of the element at the specified index.  
  
## Syntax  
  
```  
void set(  
   const index<_Rank>& _Index,  
   const value_type& _Value  
) restrict(amp);  
```  
  
#### Parameters  
 `_Index`  
 The index of the element.  
  
 `_Rank`  
 The rank of the index.  
  
 `_Value`  
 The new value of the element.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** Concurrency::graphics  
  
## See Also  
 [texture Class](../VS_csharp/texture-class.md)