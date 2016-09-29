---
title: "cend"
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
  - "xutility/std::cend"
  - "std::cend"
  - "cend"
  - "iterator/std::cend"
dev_langs: 
  - "C++"
ms.assetid: a60f3363-2869-4c07-b5c7-052ddc1e9556
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cend
Retrieves a const iterator to the element that follows the last element in the specified container.  
  
## Syntax  
  
```cpp  
template<class Container>  
    auto cend(const Container& cont)   
        -> decltype(cont.end());  
  
```  
  
#### Parameters  
 `cont`  
 A container or initializer_list.  
  
## Return Value  
 A constant `cont.end()`.  
  
## Remarks  
 This function works with all STL containers and with [initializer_list](../vs140/initializer_list-class.md).  
  
 You can use this member function in place of the [end()](../vs140/end.md) template function to guarantee that the return value is `const_iterator`. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider `Container` to be a modifiable (non-`const`) container or `initializer_list` of any kind that supports `end()` and `cend()`.  
  
```cpp  
  
auto i1 = Container.end();  // i1 is Container<T>::iterator  
auto i2 = Container.cend(); // i2 is Container<T>::const_iterator  
```  
  
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [<iterator\>](../vs140/-iterator-.md)   
 [begin](../vs140/begin.md)   
 [cbegin](../vs140/cbegin.md)   
 [end](../vs140/end.md)