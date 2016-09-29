---
title: "concurrent_unordered_map::operatorOperator"
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
  - "concurrent_unordered_map/concurrency::concurrent_unordered_map::operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator[] operator"
ms.assetid: e2179a8f-fe44-4239-8c4b-7ed5dfc2c668
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_map::operatorOperator
Finds or inserts an element with the specified key. This method is concurrency-safe.  
  
## Syntax  
  
```  
mapped_type& operator[](const key_type& _Keyval);  
  
mapped_type& operator[](key_type && _Keyval);  
```  
  
#### Parameters  
 `_Keyval`  
 The key value to  
  
 find or insert.  
  
## Return Value  
 A reference to the data value of the found or inserted element.  
  
## Remarks  
 If the argument key value is not found, then it is inserted along with the default value of the data type.  
  
 `operator[]` may be used to insert elements into a map `m` using `m[_Key] = DataValue;`, where `DataValue` is the value of the `mapped_type` of the element with a key value of `_Key`.  
  
 When using `operator[]` to insert elements, the returned reference does not indicate whether an insertion is changing a pre-existing element or creating a new one. The member functions `find` and [insert](../VS_csharp/concurrent_unordered_map--insert-method.md) can be used to determine whether an element with a specified key is already present before an insertion.  
  
## Requirements  
 **Header:** concurrent_unordered_map.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_map Class](../VS_csharp/concurrent_unordered_map-class.md)