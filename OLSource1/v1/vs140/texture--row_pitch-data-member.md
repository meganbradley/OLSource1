---
title: "texture::row_pitch Data Member"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
ms.assetid: 12687149-6fe0-4a4b-9b65-2c2e6516d4bd
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# texture::row_pitch Data Member
Gets the number of bytes between each row in a 2D or 3D staging texture on the CPU.  
  
## Syntax  
  
```  
__declspec(property(get=get_row_pitch)) unsigned int row_pitch;  
```  
  
## Remarks  
 This property contains the number of bytes between each row in a 2-dimensional staging texture, or between each row of a depth slice in 3-dimensional staging texture. Given the address of any element in the first row of the texture or depth slice, you can add `row_pitch` to calculate the address of the same element in the second row of the same texture or depth slice, and similarly for subsequent rows. The value of `row_pitch` compensates for the size of the texture elements as well as any additional padding that might exist between rows within the texture or depth slice. The value of `row_pitch` does not compensate for any additional padding between depth slices in a 3-dimensional texture, and can’t be used to move between depth slices; to move between depth slices, use the [texture::depth_pitch Data Member](../vs140/texture--depth_pitch-data-member.md) instead.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** concurrency::graphics  
  
## See Also  
 [texture Class](../vs140/texture-class.md)