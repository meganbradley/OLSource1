---
title: "array::operatorOperator"
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
  - "amp/Concurrency::array::operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator[]"
ms.assetid: 8a04e8cf-a73e-4e5d-8806-c783671cf324
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::operatorOperator
Returns the element that is at the specified index.  
  
## Syntax  
  
```  
value_type& operator[] (  
   const index<_Rank>& _Index  
) restrict(amp,cpu);  
  
const value_type& operator[] (  
   const index<_Rank>& _Index  
) const restrict(amp,cpu);  
  
typename details::_Projection_result_type<_Value_type,_Rank>::_Result_type operator[](int _I) restrict(amp,cpu);  
  
typename details::_Projection_result_type<_Value_type,_Rank>::_Const_result_type operator[](int _I) const restrict(amp,cpu);  
```  
  
#### Parameters  
 `_Index`  
 The index.  
  
 `_I`  
 The index.  
  
## Return Value  
 The element that is at the specified index.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array Class](../vs140/array-class.md)