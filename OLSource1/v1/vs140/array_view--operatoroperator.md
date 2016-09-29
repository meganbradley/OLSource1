---
title: "array_view::operatorOperator"
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
  - "amp/Concurrency::array_view::operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator[]"
ms.assetid: aaad2e89-adc8-429f-8e8d-242d854a3b63
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array_view::operatorOperator
Returns the element that is specified by the parameters.  
  
## Syntax  
  
```  
typename details::_Projection_result_type<_Value_type,_Rank>::_Const_result_type operator[] (  
   int _I  
) const restrict(amp,cpu);  
  
value_type& operator[] (  
   const index<_Rank>& _Index  
) const restrict(amp,cpu);  
  
```  
  
#### Parameters  
 `_Index`  
 The index.  
  
 `_I`  
 The index.  
  
## Return Value  
 The value of the element at the index, or an `array_view` projected on the most-significant dimension.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array_view Class](../vs140/array_view-class.md)