---
title: "array::operator std::vector&lt;_Value_type&gt; Operator"
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
  - amp/Concurrency::array::operator std::vector<_Value_type>
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator std::vector<_Value_type>
ms.assetid: 085af058-e29f-4f29-ade6-669f07d2ee81
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# array::operator std::vector&lt;_Value_type&gt; Operator
Uses `copy(*this, vector)` to implicitly convert the array to a [std::vector](../vs140/vector-class.md) object.  
  
## Syntax  
  
```  
operator std::vector<_Value_type>() const restrict(cpu);  
  
```  
  
#### Parameters  
 `_Value_type`  
 The data type of the elements of the vector.  
  
## Return Value  
 An object of type `vector<T>` that contains a copy of the data that is contained in the array.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array Class](../vs140/array-class.md)