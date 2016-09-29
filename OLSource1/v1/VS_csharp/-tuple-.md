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
|[tuple](../VS_csharp/tuple-class.md)|Wraps a fixed-length sequence of elements.|  
|[tuple_element](../VS_csharp/tuple_element-class--tuple-.md)|Wraps the type of a `tuple` element.|  
|[tuple_size](../VS_csharp/tuple_size-class--tuple-.md)|Wraps `tuple` element count.|  
  
### Operators  
  
|||  
|-|-|  
|[operator==](../VS_csharp/-tuple--operators.md#operator_eq_eq)|Comparison of `tuple` objects, equal|  
|[operator!=](../VS_csharp/-tuple--operators.md#operator_neq)|Comparison of `tuple` objects, not equal|  
|[operator<](../VS_csharp/-tuple--operators.md#operator_lt_)|Comparison of `tuple` objects, less than|  
|[operator<=](../VS_csharp/-tuple--operators.md#operator_lt__eq)|Comparison of `tuple` objects, less than or equal|  
|[operator>](../VS_csharp/-tuple--operators.md#operator_gt_)|Comparison of `tuple` objects, greater than|  
|[operator>=](../VS_csharp/-tuple--operators.md#operator_gt__eq)|Comparison of `tuple` objects, greater than or equal|  
  
### Functions  
  
|||  
|-|-|  
|[get](../VS_csharp/-tuple--functions.md#get_function)|Gets an element from a `tuple` object.|  
|[make_tuple](../VS_csharp/-tuple--functions.md#make_tuple_function)|Makes a `tuple` from element values.|  
|[tie](../VS_csharp/-tuple--functions.md#tie_function)|Makes a `tuple` from element references.|  
  
## See Also  
 [<array\>](../VS_csharp/-array-.md)