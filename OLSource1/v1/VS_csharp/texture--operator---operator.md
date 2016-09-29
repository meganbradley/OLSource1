---
title: "texture::operator() Operator"
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
  - "amp_graphics/Concurrency::graphics::texture::operator()"
dev_langs: 
  - "C++"
ms.assetid: 831454d3-d1fa-4a82-a0c8-690155ae1ff0
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# texture::operator() Operator
Returns the element value that is specified by the parameters.  
  
## Syntax  
  
```  
const value_type operator() (  
   const index<_Rank>& _Index  
) const restrict(amp);  
  
const value_type operator() (  
   int _I0  
) const restrict(amp);  
  
const value_type operator() (  
   int _I0,  
   int _I1  
) const restrict(amp);  
  
const value_type operator() (  
   int _I0,  
   int _I1,  
   int _I2  
) const restrict(amp);  
```  
  
#### Parameters  
 `_Index`  
 The index.  
  
 `_I0`  
 The most-significant component of the index.  
  
 `_I1`  
 The next-to-most-significant component of the index.  
  
 `_I2`  
 The least-significant component of the index.  
  
 `_Rank`  
 The rank of the index.  
  
## Return Value  
 The element value that is specified by the parameters.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** Concurrency::graphics  
  
## See Also  
 [texture Class](../VS_csharp/texture-class.md)