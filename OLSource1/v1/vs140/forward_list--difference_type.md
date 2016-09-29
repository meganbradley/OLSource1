---
title: "forward_list::difference_type"
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
  - "std.forward_list.difference_type"
  - "forward_list.difference_type"
  - "std::forward_list::difference_type"
  - "difference_type"
  - "forward_list::difference_type"
  - "forward_list/std::forward_list::difference_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "difference_type typedef"
ms.assetid: 9b2c82c0-522e-43ef-80ac-060e3257b729
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# forward_list::difference_type
A signed integer type that can be used to represent the number of elements of a forward list in a range between elements pointed to by iterators.  
  
## Syntax  
  
```  
typedef typename Allocator::difference_type difference_type;  
```  
  
## Remarks  
 `difference_type` describes an object that can represent the difference between the addresses of any two elements in the controlled sequence.  
  
## Requirements  
 **Header:** <forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [forward_list Class](../vs140/forward_list-class.md)