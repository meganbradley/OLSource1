---
title: "&lt;tuple&gt;"
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
  - "<tuple>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tuple header [TR1]"
ms.assetid: e4ef5c2d-318b-44f6-8bce-fce4ecd796a3
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;tuple&gt;
Defines a template `tuple` whose instances hold objects of varying types.  
  
## Syntax  
  
```  
#include <tuple>  
```  
  
### Classes  
  
|||  
|-|-|  
|[tuple](../vs140/tuple-class.md)|Wraps a fixed-length sequence of elements.|  
|[tuple_element](../vs140/tuple_element-class--tuple-.md)|Wraps the type of a `tuple` element.|  
|[tuple_size](../vs140/tuple_size-class--tuple-.md)|Wraps `tuple` element count.|  
  
### Operators  
  
|||  
|-|-|  
|[operator==](../vs140/-tuple--operators.md#operator_eq_eq)|Comparison of `tuple` objects, equal|  
|[operator!=](../vs140/-tuple--operators.md#operator_neq)|Comparison of `tuple` objects, not equal|  
|[operator<](../vs140/-tuple--operators.md#operator_lt_)|Comparison of `tuple` objects, less than|  
|[operator<=](../vs140/-tuple--operators.md#operator_lt__eq)|Comparison of `tuple` objects, less than or equal|  
|[operator>](../vs140/-tuple--operators.md#operator_gt_)|Comparison of `tuple` objects, greater than|  
|[operator>=](../vs140/-tuple--operators.md#operator_gt__eq)|Comparison of `tuple` objects, greater than or equal|  
  
### Functions  
  
|||  
|-|-|  
|[get](../vs140/-tuple--functions.md#get_function)|Gets an element from a `tuple` object.|  
|[make_tuple](../vs140/-tuple--functions.md#make_tuple_function)|Makes a `tuple` from element values.|  
|[tie](../vs140/-tuple--functions.md#tie_function)|Makes a `tuple` from element references.|  
  
## See Also  
 [\<array>](../vs140/-array-.md)