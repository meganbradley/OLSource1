---
title: "texture::get_row_pitch Method"
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
ms.assetid: 95c93b71-4e62-4084-8a8b-98801690abe9
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# texture::get_row_pitch Method
Returns the number of bytes between each row in a 2-dimensional staging texture, or between each row of a depth slice in 3-dimensional staging texture.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The number of bytes between each row in a 2-dimensional staging texture, or between each row of a depth slice in 3-dimensional staging texture.  
  
## Remarks  
 Given the address of any element in the first row of the 2D texture or depth slice, you can add <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to calculate the address of the same element in the second row of the same texture or depth slice, and similarly for subsequent rows. The value of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> compensates for the size of the texture elements as well as any additional padding that might exist between rows within the texture or depth slice. The value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> does not compensate for any additional padding between depth slices in a 3-dimensional texture, and can’t be used to move between depth slices; to move between depth slices, use the [texture::get_depth_pitch Method](../vs140/texture--get_depth_pitch-method.md) instead.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** concurrency::graphics  
  
## See Also  
 [texture Class](../vs140/texture-class.md)