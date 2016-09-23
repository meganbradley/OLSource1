---
title: "array::operator() Operator"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - amp/Concurrency::array::operator()
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator()
ms.assetid: aea59605-4038-4826-9dfb-99babc971ac3
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# array::operator() Operator
Returns the element value that is specified by the parameters.  
  
## Syntax  
  
```  
value_type& operator() (const index<_Rank>& _Index) restrict(amp,cpu);  
  
const value_type& operator() (const index<_Rank>& _Index) const restrict(amp,cpu);  
  
value_type& operator() (int _I0, int _I1) restrict(amp,cpu);  
  
const value_type& operator() (int _I0, int _I1) const restrict(amp,cpu);  
  
value_type& operator() (int _I0, int _I1, int _I2) restrict(amp,cpu);  
  
const value_type& operator() (int _I0, int _I1, int _I2) const restrict(amp,cpu);  
  
typename details::_Projection_result_type<_Value_type,_Rank>::_Result_type operator()(int _I) restrict(amp,cpu);  
  
typename details::_Projection_result_type<_Value_type,_Rank>::_Const_result_type operator()(int _I) const restrict(amp,cpu);  
```  
  
#### Parameters  
 `_Index`  
 The location of the element.  
  
 `_I0`  
 The most significant component of the origin of this section.  
  
 `_I1`  
 The next-to-most-significant component of the origin of this section.  
  
 `_I2`  
 The least significant component of the origin of this section.  
  
 `_I`  
 The location of the element.  
  
## Return Value  
 The element value specified by the parameters.  
  
## Remarks  
 The overloads that have `I0`, `I1`, or `I2` parameters enable you to retrieve references to values in the [array](../vs140/array-class.md) without having to create an [index](../vs140/index-class.md) object.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array Class](../vs140/array-class.md)