---
title: "checked_array_iterator::difference_type"
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
  - checked_array_iterator.difference_type
  - checked_array_iterator::difference_type
  - difference_type
  - std::checked_array_iterator::difference_type
  - std.checked_array_iterator.difference_type
  - iterator/checked_array_iterator::difference_type
dev_langs: 
  - C++
helpviewer_keywords: 
  - difference_type typedef
ms.assetid: fb4ea46e-3f63-4fb6-b50e-0fa9ce555600
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# checked_array_iterator::difference_type
A type that provides the difference between two `checked_array_iterator`s referring to elements within the same container.  
  
## Syntax  
  
```  
typedef typename iterator_traits<_Iterator>::difference_type difference_type;  
```  
  
## Remarks  
 The `checked_array_iterator` difference type is the same as the iterator difference type.  
  
 See [checked_array_iterator::operator&#91;&#93;](../vs140/checked_array_iterator--operator.md) for a code sample.  
  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [checked_array_iterator Class](../vs140/checked_array_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)