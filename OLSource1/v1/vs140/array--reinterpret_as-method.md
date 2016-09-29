---
title: "array::reinterpret_as Method"
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
  - "amp/Concurrency::array::reinterpret_as"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reinterpret_as method"
ms.assetid: 5bb42023-d8b0-4c2b-baa0-b9065c5cd7e7
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::reinterpret_as Method
Reinterprets the array through a one-dimensional `array_view`, which optionally may have a different value type than the source array.  
  
## Syntax  
  
```  
template <  
   typename _Value_type2  
>  
array_view<_Value_type2,1> reinterpret_as()restrict(amp,cpu);  
  
template <  
   typename _Value_type2  
>  
array_view<const _Value_type2,1> reinterpret_as() const restrict(amp,cpu);  
```  
  
#### Parameters  
 `_Value_type2`  
 The data type of the returned data.  
  
## Return Value  
 An `array_view` or const `array_view` object that is based on the `array`, with the element type reinterpreted from `T` to `ElementType` and the rank reduced from *N* to 1.  
  
## Remarks  
 Sometimes it is convenient to view a multi-dimensional array as if it is a linear, one-dimensional array, possibly with a different value type than the source array. You can use this method to achieve this.  
  
> [!CAUTION]
>  Reinterpreting an array object by using a different value type is a potentially unsafe operation. We recommend that you use this functionality carefully.  
  
 The following code provides an example.  
  
```cpp  
struct RGB { float r; float g; float b; };  
  
array<RGB,3>  a = ...;   
array_view<float,1> v = a.reinterpret_as<float>();   
  
assert(v.extent == 3*a.extent);  
```  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array Class](../vs140/array-class.md)