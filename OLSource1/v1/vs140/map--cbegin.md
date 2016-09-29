---
title: "map::cbegin"
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
  - "map/std::map::cbegin"
  - "std::map::cbegin"
  - "map::cbegin"
  - "std.map.cbegin"
  - "map.cbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cbegin method"
ms.assetid: d6c1dfef-6c45-4a3e-bd45-5257d3cc7685
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::cbegin
Returns a `const` iterator that addresses the location just beyond the last element in a range.  
  
## Syntax  
  
```  
  
const_iterator cbegin() const;  
  
```  
  
## Return Value  
 A `const` bidirectional iterator addressing the first element in the range, or the location just beyond the end of an empty range (for an empty range, `cbegin() == cend()`).  
  
## Remarks  
 With the return value of `cbegin`, the elements in the range cannot be modified.  
  
 You can use this member function in place of the `begin()` member function to guarantee that the return value is `const_iterator`. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider `Container` to be a modifiable (non-`const`) container of any kind that supports `begin()` and `cbegin()`.  
  
```cpp  
  
auto i1 = Container.begin();  // i1 is Container<T>::iterator   
auto i2 = Container.cbegin(); // i2 is Container<T>::const_iterator  
```  
  
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)