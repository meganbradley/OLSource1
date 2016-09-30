---
title: "texture_view::sample Method"
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
ms.assetid: adc55067-a3f0-4611-a2a0-13341cef4cab
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# texture_view::sample Method
Samples the texture at the specified coordinates and level of detail by using the specified sampling configuration.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The filter mode to use to sample the texture_view. The filter mode is the same for the minimization, maximization, and mipmap filters.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The address mode to use to sample the texture_view. The address mode is the same for all dimensions.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The sampler configuration to use to sample the texture_view.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The coordinates to take the sample from. Fractional coordinate values are used to interpolate between texel values.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The value specifies the mipmap level to sample from. Fractional values are used to interpolate between two mipmap levels. The default level of detail is 0, which represents the most detailed mip level.  
  
## Return Value  
 The interpolated sample value.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** concurrency::graphics  
  
## See Also  
 [texture_view Class](../vs140/texture_view-class.md)