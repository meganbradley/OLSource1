---
title: "texture_view::operatorOperator"
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
ms.assetid: 2627af70-55d0-425c-9bd3-6184dc7a9ddf
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# texture_view::operatorOperator
Returns the element value by index.  
  
## Syntax  
  
```  
const value_type operator[] (  
   const index<_Rank>& _Index  
) const restrict(amp);  
  
const value_type operator[] (  
   int _I0  
) const restrict(amp);  
  
value_type operator[] (  
   const index<_Rank>& _Index  
) const restrict(amp);  
  
value_type operator[] (  
   int _I0  
) const restrict(amp);  
```  
  
#### Parameters  
 `_Index`  
 The index, possibly multi-dimensional.  
  
 `_I0`  
 The one-dimensional index.  
  
## Return Value  
 The element value indexed by `_Index`.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** concurrency::graphics  
  
## See Also  
 [texture_view Class](../vs140/texture_view-class.md)