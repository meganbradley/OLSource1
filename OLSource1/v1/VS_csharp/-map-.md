---
title: "&lt;map&gt;"
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
  - "std::<map>"
  - "std.<map>"
  - "<map>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "map header"
ms.assetid: bbf76680-7362-456e-88fa-ecda93561b6a
caps.latest.revision: 22
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# &lt;map&gt;
Defines the container template classes map and multimap and their supporting templates.  
  
## Syntax  
  
```  
#include <map>  
  
```  
  
## Members  
  
### Operators  
  
|Map version|Multimap version|Description|  
|-----------------|----------------------|-----------------|  
|[operator!= (map)](../VS_csharp/-map--operators.md#operator_neq)|[operator!= (multimap)](../VS_csharp/-map--operators.md#operator_neq)|Tests if the map or multimap object on the left side of the operator is not equal to the map or multimap object on the right side.|  
|[operator< (map)](../VS_csharp/-map--operators.md#operator_eq_eq)|[operator< (multimap)](../VS_csharp/-map--operators.md#operator_eq_eq)|Tests if the map or multimap object on the left side of the operator is less than the map or multimap object on the right side.|  
|[operator<= (map)](../VS_csharp/-map--operators.md#operator_lt_)|[operator<= (multimap)](../VS_csharp/-map--operators.md#operator_lt_)|Tests if the map or multimap object on the left side of the operator is less than or equal to the map or multimap object on the right side.|  
|[operator== (map)](../VS_csharp/-map--operators.md#operator_lt__eq)|[operator== (multimap)](../VS_csharp/-map--operators.md#operator_lt__eq)|Tests if the map or multimap object on the left side of the operator is equal to the map or multimap object on the right side.|  
|[operator> (map)](../VS_csharp/-map--operators.md#operator_gt_)|[operator> (multimap)](../VS_csharp/-map--operators.md#operator_gt_)|Tests if the map or multimap object on the left side of the operator is greater than the map or multimap object on the right side.|  
|[operator>= (map)](../VS_csharp/-map--operators.md#operator_gt__eq)|[operator>= (multimap)](../VS_csharp/-map--operators.md#operator_gt__eq)|Tests if the map or multimap object on the left side of the operator is greater than or equal to the map or multimap object on the right side.|  
  
### Specialized Template Functions  
  
|Map version|Multimap version|Description|  
|-----------------|----------------------|-----------------|  
|[swap (map)](../VS_csharp/-map--functions.md#swap)|[swap (multimap)](../VS_csharp/-map--functions.md#swap)|Exchanges the elements of two maps or multimaps.|  
  
### Classes  
  
|||  
|-|-|  
|[value_compare Class](../VS_csharp/value_compare-class---map--.md)|Provides a function object that can compare the elements of a map by comparing the values of their keys to determine their relative order in the map.|  
|[map Class](../VS_csharp/map-class.md)|Used for the storage and retrieval of data from a collection in which the each of the elements has a unique key with which the data is automatically ordered.|  
|[multimap Class](../VS_csharp/multimap-class.md)|Used for the storage and retrieval of data from a collection in which the each of the elements has a key with which the data is automatically ordered and the keys do not need to have unique values.|  
  
## See Also  
 [Header Files](../VS_csharp/c---standard-library-header-files.md)   
 [Thread Safety in the Standard C++ Library](../VS_csharp/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../Topic/Standard%20Template%20Library.md)