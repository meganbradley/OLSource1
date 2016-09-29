---
title: "prev"
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
  - "xutility/std::prev"
  - "std.prev"
  - "std::prev"
  - "prev"
  - "iterator/std::prev"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "prev"
  - "prev function"
ms.assetid: 96037942-82cd-4988-b39e-d03052384533
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# prev
Iterates in reverse a specified number of times and returns the new iterator position.  
  
## Syntax  
  
```  
template<class BidirectionalIterator>  
  BidirectionalIterator prev(  
    BidirectionalIterator _First,  
    typename iterator_traits<BidirectionalIterator>::difference_type  
        _Off = 1  
    );  
```  
  
#### Parameters  
 `_First`  
 The current position.  
  
 `_Off`  
 The number of times to iterate.  
  
## Property Value/Return Value  
 Returns the new iterator position after iterating `_Off` times.  
  
## Remarks  
 The template function returns `next` decremented `off` times.  
  
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [<iterator\>](../vs140/-iterator-.md)   
 [advance](../vs140/advance--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)