---
title: "array::cbegin"
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
  - std.array.cbegin
  - tr1::array::cbegin
  - std.tr1.array.cbegin
  - std::array::cbegin
  - array::cbegin
  - tr1.array.cbegin
  - std::tr1::array::cbegin
  - array.cbegin
  - array/std::tr1::array::cbegin
dev_langs: 
  - C++
helpviewer_keywords: 
  - cbegin method
ms.assetid: fe72c1f6-732a-4447-8fd3-4b764c97d921
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.mt: 
  - de-de
  - ja-jp
---
# array::cbegin
Returns a `const` iterator that addresses the first element in the range.  
  
## Syntax  
  
```  
const_iterator cbegin() const noexcept;  
```  
  
## Return Value  
 A `const` random-access iterator that points at the first element of the range, or the location just beyond the end of an empty range (for an empty range, `cbegin() == cend()`).  
  
## Remarks  
 With the return value of `cbegin`, the elements in the range cannot be modified.  
  
 You can use this member function in place of the `begin()` member function to guarantee that the return value is `const_iterator`. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider `Container` to be a modifiable (non-`const`) container of any kind that supports `begin()` and `cbegin()`.  
  
```cpp  
  
auto i1 = Container.begin();  // i1 is Container<T>::iterator   
auto i2 = Container.cbegin(); // i2 is Container<T>::const_iterator  
```  
  
## Requirements  
 **Header:** <array\>  
  
 **Namespace:** std  
  
## See Also  
 [<array\>](../vs140/-array-.md)   
 [array Class](../vs140/array-class--stl-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)