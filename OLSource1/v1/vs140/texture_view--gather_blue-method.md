---
title: "texture_view::gather_blue Method"
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
ms.assetid: 5da8c286-a247-4c8e-a33e-26bc7297fef6
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# texture_view::gather_blue Method
Samples the texture at the specified coordinates by using the specified sampling configuration and returns the blue (z) components of the four sampled texels.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The address mode to use to sample the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. The address mode is the same for all dimensions.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The sampler configuration to use to sample the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The coordinates to take the sample from. Fractional coordinate values are used to interpolate between sample texels.  
  
## Return Value  
 A rank 4 short vector containing the red (x) component of the 4 sampled texel values.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** concurrency::graphics  
  
## See Also  
 [texture_view Class](../vs140/texture_view-class.md)