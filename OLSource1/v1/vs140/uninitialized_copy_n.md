---
title: "uninitialized_copy_n"
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
  - std.uninitialized_copy_n
  - uninitialized_copy_n
  - memory/std::uninitialized_copy_n
  - std::uninitialized_copy_n
dev_langs: 
  - C++
helpviewer_keywords: 
  - uninitialized_copy_n
  - uninitialized_copy_n function
ms.assetid: 3d443d83-9cb7-47a6-a3a5-ec6c373a239e
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# uninitialized_copy_n
Creates a copy of a specified number of elements from an input iterator. The copies are put in a forward iterator.  
  
## Syntax  
  
```  
template<class InputIterator, class Size, class ForwardIterator>  
    ForwardIterator uninitialized_copy_n(  
        InputIterator _First,   
        Size _Count,  
        ForwardIterator _Dest  
    );  
```  
  
#### Parameters  
 `_First`  
 An input iterator that refers to the object to copy.  
  
 `_Count`  
 A signed or unsigned integer type specifying the number of times to copy the object.  
  
 `_Dest`  
 A forward iterator that refers to where the new copies go.  
  
## Return Value  
 A forward iterator that addresses the first position beyond the destination. If the source range was empty, the iterator addresses `_First`*.*  
  
## Remarks  
 The template function effectively executes the following:  
  
 `for (; 0 < count; -- count)`  
  
 `new ((void *)&*` `_Dest` `++)`  
  
 `iterator_traits<InputIterator>::value_type(*` `_First` `++);`  
  
 `return dest;`  
  
 unless the code throws an exception. In that case, all constructed objects are destroyed and the exception is rethrown.  
  
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [<memory\>](../vs140/-memory-.md)