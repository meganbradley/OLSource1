---
title: "unordered_set::cend"
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
  - "unordered_set.cend"
  - "std.tr1.unordered_set.cend"
  - "std::tr1::unordered_set::cend"
  - "unordered_set/std::tr1::unordered_set::cend"
  - "unordered_set::cend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cend method"
ms.assetid: be20b2d8-c6aa-4a5b-aa96-7ecbf676bb0d
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::cend
Returns a `const` iterator that addresses the location just beyond the last element in a range.  
  
## Syntax  
  
```  
const_iterator cend() const;  
```  
  
## Return Value  
 A `const` forward-access iterator that points just beyond the end of the range.  
  
## Remarks  
 `cend` is used to test whether an iterator has passed the end of its range.  
  
 You can use this member function in place of the `end()` member function to guarantee that the return value is `const_iterator`. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider `Container` to be a modifiable (non-`const`) container of any kind that supports `end()` and `cend()`.  
  
```cpp  
  
auto i1 = Container.end();  // i1 is Container<T>::iterator   
auto i2 = Container.cend(); // i2 is Container<T>::const_iterator  
```  
  
 The value returned by `cend` should not be dereferenced.  
  
## Requirements  
 **Header:** <unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_set Class](../vs140/unordered_set-class.md)   
 [unordered_set::begin](../vs140/unordered_set--begin.md)