---
title: "move_iterator::value_type"
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
  - "std.move_iterator.value_type"
  - "iterator/std::move_iterator::value_type"
  - "std::move_iterator::value_type"
  - "move_iterator.value_type"
  - "move_iterator::value_type"
  - "value_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_type typedef"
ms.assetid: 9f11803d-5a44-416a-9e5e-3b4d2375bd3d
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# move_iterator::value_type
The type `value_type` is a `move_iterator``typedef` based on the iterator trait `value_type`, and can be used interchangeably with it.  
  
## Syntax  
  
```  
typedef typename iterator_traits<RandomIterator>::value_type  
    value_type;  
```  
  
## Remarks  
 The type is a synonym for the iterator trait `typename iterator_traits<RandomIterator>::value_type`.  
  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [move_iterator Class](../vs140/move_iterator-class.md)   
 [\<iterator>](../vs140/-iterator-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)