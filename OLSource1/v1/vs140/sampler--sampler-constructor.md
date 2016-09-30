---
title: "sampler::sampler Constructor"
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
ms.assetid: 30114744-2d7f-457e-bdad-4eb4a273db61
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sampler::sampler Constructor
Constructs an instance of the [sampler Class](../vs140/sampler-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The filter mode to be used in sampling.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The addressing mode to be used in sampling for all dimensions.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The border color to be used if the address mode is address_border. The default value is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [5] Copy Constructor  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object to copy into the new <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> instance.  
  
 [6] Move Constructor  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object to move into the new <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> instance.  
  
## Construction  
 [1] Default Constructor  
 Constructs the sampler instance by using linear filtering, clamped addressing, and a transparent border color (float_4(0.0f, 0.0f, 0.0f, 0.0f)).  
  
 [2] Constructor  
 Constructs the sampler instance by using the specified filter mode, clamped addressing, and a transparent border color (float_4(0.0f, 0.0f, 0.0f, 0.0f)).  
  
 [3] Constructor  
 Constructs the sampler instance by using the specified address mode, linear filtering, and a transparent border color (float_4(0.0f, 0.0f, 0.0f, 0.0f)).  
  
 [4] Constructor  
 Constructs the sampler instance by using the specified filter mode and address mode, and a transparent border color (float_4(0.0f, 0.0f, 0.0f, 0.0f)).  
  
 [5] Copy Constructor  
 Constructs the sampler instance by copying the specified sampler object.  
  
 [6] Move Constructor  
 Constructs the sampler instance by moving the specified sampler object into the new instance.  
  
## Remarks  
 The configured filter mode applies to the minimization, maximization, and mipmap filters.  
  
 The configured address mode applies to all dimensions.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** concurrency::graphics  
  
## See Also  
 [sampler Class](../vs140/sampler-class.md)