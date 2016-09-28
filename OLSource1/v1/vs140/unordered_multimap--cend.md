---
title: "unordered_multimap::cend"
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
  - "unordered_multimap.cend"
  - "std::tr1::unordered_multimap::cend"
  - "unordered_multimap::cend"
  - "std.tr1.unordered_multimap.cend"
  - "unordered_map/std::tr1::unordered_multimap::cend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cend method"
ms.assetid: 938f650f-dee0-4b75-8676-e620c762d383
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap::cend
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
 **Header:** <unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_multimap Class](../vs140/unordered_multimap-class.md)   
 [unordered_multimap::begin](../vs140/unordered_multimap--begin.md)