---
title: "move_iterator::difference_type"
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
  - "iterator/std::move_iterator::difference_type"
  - "move_iterator::difference_type"
  - "difference_type"
  - "std::move_iterator::difference_type"
  - "move_iterator.difference_type"
  - "std.move_iterator.difference_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "difference_type typedef"
ms.assetid: 367e7f32-d2e1-4799-9c29-333a959cc522
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# move_iterator::difference_type
The type `difference_type` is a `move_iterator``typedef` based on the iterator trait `difference_type`, and can be used interchangeably with it.  
  
## Syntax  
  
```  
typedef typename iterator_traits<RandomIterator>::difference_type  
    difference_type;  
```  
  
## Remarks  
 The type is a synonym for the iterator trait `typename iterator_traits<RandomIterator>::pointer`.  
  
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [move_iterator Class](../vs140/move_iterator-class.md)   
 [<iterator\>](../vs140/-iterator-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)