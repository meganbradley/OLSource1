---
title: "set::cend"
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
  - std::set::cend
  - set/std::set::cend
  - std.set.cend
  - set.cend
  - set::cend
dev_langs: 
  - C++
helpviewer_keywords: 
  - cend method
ms.assetid: e0a96816-71cd-409d-8c78-4fba2b08e400
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# set::cend
Returns a `const` iterator that addresses the location just beyond the last element in a range.  
  
## Syntax  
  
```  
const_iterator cend() const;  
```  
  
## Return Value  
 A `const` bidirectional-access iterator that points just beyond the end of the range.  
  
## Remarks  
 `cend` is used to test whether an iterator has passed the end of its range.  
  
 You can use this member function in place of the `end()` member function to guarantee that the return value is `const_iterator`. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider `Container` to be a modifiable (non-`const`) container of any kind that supports `end()` and `cend()`.  
  
```cpp  
  
auto i1 = Container.end();  // i1 is Container<T>::iterator   
auto i2 = Container.cend(); // i2 is Container<T>::const_iterator  
```  
  
 The value returned by `cend` should not be dereferenced.  
  
## Requirements  
 **Header:** <set\>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [set::swap, set::begin, and set::end](../vs140/set--swap--set--begin--and-set--end.md)   
 [Standard Template Library](../vs140/standard-template-library.md)