---
title: "texture::depth_pitch Data Member"
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
ms.assetid: eaada398-85ae-4f69-a2e6-86e3f7496f1d
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# texture::depth_pitch Data Member
Gets the number of bytes between each depth slice in a 3D staging texture on the CPU.  
  
## Syntax  
  
```  
__declspec(property(get=get_depth_pitch)) unsigned int depth_pitch;  
```  
  
## Remarks  
 This property contains the number of bytes between each depth slice in a 3-dimensional staging texture. Given the address of any element in the first depth slice of the texture, you can add `depth_pitch` to calculate the address of the same element in the second depth slice of the same texture, and similarly for subsequent depth slices. The value of `depth_pitch` compensates for the size of the texture elements as well as any additional padding that might exist between depth slices and between rows within each depth slice.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** concurrency::graphics  
  
## See Also  
 [texture Class](../vs140/texture-class.md)