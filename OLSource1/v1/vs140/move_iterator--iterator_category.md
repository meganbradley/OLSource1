---
title: "move_iterator::iterator_category"
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
  - "move_iterator.iterator_category"
  - "std.move_iterator.iterator_category"
  - "iterator/std::move_iterator::iterator_category"
  - "std::move_iterator::iterator_category"
  - "iterator_category"
  - "move_iterator::iterator_category"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "iterator_category typedef"
ms.assetid: 4b8fa7b4-25be-447c-9d5a-4f9664cbd203
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# move_iterator::iterator_category
The type `iterator_category` is a `move_iterator``typedef` based on the iterator trait `iterator_category`, and can be used interchangeably with it.  
  
## Syntax  
  
```  
typedef typename iterator_traits<RandomIterator>::iterator_category  
    iterator_category;  
```  
  
## Remarks  
 The type is a synonym for the iterator trait `typename iterator_traits<RandomIterator>::iterator_category`.  
  
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [move_iterator Class](../vs140/move_iterator-class.md)   
 [<iterator\>](../vs140/-iterator-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)