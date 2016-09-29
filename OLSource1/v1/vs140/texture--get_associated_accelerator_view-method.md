---
title: "texture::get_associated_accelerator_view Method"
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
ms.assetid: e2d4d32a-30aa-43b4-9811-1025330e2511
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# texture::get_associated_accelerator_view Method
Returns the accelerator_view that is the preferred target for this texture to be copied to.  
  
## Syntax  
  
```  
Concurrency::accelerator_view get_associated_accelerator_view() const restrict(cpu);  
```  
  
## Return Value  
 The [accelerator_view](../vs140/accelerator_view-class.md) that is the preferred target for this texture to be copied to.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** concurrency::graphics  
  
## See Also  
 [texture Class](../vs140/texture-class.md)