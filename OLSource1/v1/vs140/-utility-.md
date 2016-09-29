---
title: "&lt;utility&gt;"
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
  - "<utility>"
  - "utility/std::<utility>"
  - "std.<utility>"
  - "std::<utility>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "utility header"
ms.assetid: c4491103-5da9-47a1-9c2b-ed8bc64b0599
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;utility&gt;
Defines Standard Template Library (STL) types, functions, and operators that help to construct and manage pairs of objects, which are useful whenever two objects need to be treated as if they were one.  
  
## Syntax  
  
```  
#include <utility>  
  
```  
  
## Remarks  
 Pairs are widely used in the Standard C++ Library. They are required both as the arguments and return values for various functions and as element types for containers such as [map class](../vs140/map-class.md) and [multimap class](../vs140/multimap-class.md). The <utility\> header is automatically included by <map\> to assist in managing their key/value pair type elements.  
  
### Classes  
  
|||  
|-|-|  
|[tuple_element](../vs140/tuple_element-class--utility-.md)|A class that wraps the type of a `pair` element.|  
|[tuple_size](../vs140/tuple_size-class--utility-.md)|A class that wraps `pair` element count.|  
  
### Functions  
  
|||  
|-|-|  
|[forward](../vs140/-utility--functions.md#forward)|Preserves the reference type (either `lvalue` or `rvalue`) of the argument from being obscured by perfect forwarding.|  
|[get](../vs140/-utility--functions.md#get_function__lt_utility_gt_)|A function that gets an element from a `pair` object.|  
|[make_pair](../vs140/-utility--functions.md#make_pair)|A template helper function used to construct objects of type `pair`, where the component types are based on the data types passed as parameters.|  
|[move](../vs140/-utility--functions.md#move)|Returns the passed in argument as an `rvalue` reference.|  
|[swap](../vs140/-utility--functions.md#swap)|Exchanges the elements of two `pair` objects.|  
  
### Operators  
  
|||  
|-|-|  
|[operator!=](../vs140/-utility--operators.md#operator_neq)|Tests if the pair object on the left side of the operator is not equal to the pair object on the right side.|  
|[operator==](../vs140/-utility--operators.md#operator_eq_eq)|Tests if the pair object on the left side of the operator is equal to the pair object on the right side.|  
|[operator<](../vs140/-utility--operators.md#operator_lt_)|Tests if the pair object on the left side of the operator is less than the pair object on the right side.|  
|[operator<=](../vs140/-utility--operators.md#operator_lt__eq)|Tests if the pair object on the left side of the operator is less than or equal to the pair object on the right side.|  
|[operator>](../vs140/-utility--operators.md#operator_gt_)|Tests if the pair object on the left side of the operator is greater than the pair object on the right side.|  
|[operator>=](../vs140/-utility--operators.md#operator_gt__eq)|Tests if the pair object on the left side of the operator is greater than or equal to the pair object on the right side.|  
  
### Structs  
  
|||  
|-|-|  
|[identity](../vs140/identity-structure.md)||  
|[pair](../vs140/pair-structure.md)|A type that provides for the ability to treat two objects as a single object.|  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)