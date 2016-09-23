---
title: "texture_view::operator() Operator"
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
ms.assetid: 7deeb0b6-2208-4a44-8f2d-0b1b213a17b3
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# texture_view::operator() Operator
Returns the element value by index.  
  
## Syntax  
  
```  
const value_type operator() (  
   const index<_Rank>& _Index  
) const restrict(amp);  
  
const value_type operator() (  
   int _I0  
) const restrict(amp);  
  
const value_type operator() (  
   int _I0,   int _I1  
) const restrict(amp);  
  
const value_type operator() (  
   int _I0,  
   int _I1,  
   int _I2  
) const restrict(amp);  
  
value_type operator() (  
   const index<_Rank>& _Index  
) const restrict(amp);  
  
value_type operator() (  
   int _I0  
) const restrict(amp);  
  
value_type operator() (  
   int _I0,  
   int _I1  
) const restrict(amp);  
  
value_type operator() (  
   int _I0,  
   int _I1,  
   int _I2  
) const restrict(amp);  
```  
  
#### Parameters  
 `_Index`  
 The index, possibly multi-dimensional.  
  
 `_I0`  
 The most-significant component of the index.  
  
 `_I1`  
 The next-to-most-significant component of the index.  
  
 `_I2`  
 The least-significant component of the index.  
  
## Return Value  
 The element value indexed by `_Index`.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** concurrency::graphics  
  
## See Also  
 [texture_view Class](../vs140/texture_view-class.md)