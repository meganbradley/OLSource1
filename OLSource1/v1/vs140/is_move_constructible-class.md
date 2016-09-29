---
title: "is_move_constructible Class"
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
  - "is_move_constructible"
  - "std.is_move_constructible"
  - "std::is_move_constructible"
  - "type_traits/std::is_move_constructible"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_move_constructible"
ms.assetid: becdf076-7419-488d-a335-78adf2478b9b
caps.latest.revision: 14
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_move_constructible Class
Tests whether the type has a move constructor.  
  
## Syntax  
  
```  
template <class T>  
    struct is_move_constructible;  
```  
  
#### Parameters  
 T  
 The type to be evaluated  
  
## Remarks  
 A type predicate that evaluates to true if the type `T` can be constructed by using a move operation. This predicate is equivalent to `is_constructible<T, T&&>`.  
  
## Requirements  
 **Header:** <type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [<type_traits>](../vs140/-type_traits-.md)