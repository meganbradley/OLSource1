---
title: "array_view::operator() Operator"
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
  - amp/Concurrency::array_view::operator()
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator()
ms.assetid: e83cbd21-b9bd-4b17-a654-8ae08296a8c2
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# array_view::operator() Operator
Returns the value of the element that is specified by the parameter or parameters.  
  
## Syntax  
  
```  
value_type& operator() (  
   const index<_Rank>& _Index  
) const restrict(amp,cpu);  
  
typename details::_Projection_result_type<_Value_type,_Rank>::_Result_type operator() (  
   int _I  
) const restrict(amp,cpu);  
  
value_type& operator() (  
   int _I0,  
   int _I1  
) const restrict(amp,cpu);  
  
value_type& operator() (  
   int _I0,  
   int _I1,  
   int _I2  
) const restrict(amp,cpu);  
  
typename details::_Projection_result_type<_Value_type,_Rank>::_Const_result_type operator() (  
   int _I  
) const restrict(amp,cpu);  
  
```  
  
#### Parameters  
 `_Index`  
 The location of the element.  
  
 `_I0`  
 The index in the first dimension.  
  
 `_I1`  
 The index in the second dimension.  
  
 `_I2`  
 The index in the third dimension.  
  
 `_I`  
 The location of the element.  
  
## Return Value  
 The value of the element that is specified by the parameter or parameters.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array_view Class](../vs140/array_view-class.md)