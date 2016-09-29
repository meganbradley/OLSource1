---
title: "call_once Function"
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
  - "mutex/std::call_once"
dev_langs: 
  - "C++"
ms.assetid: 594266fa-3486-42a1-b0a4-b431410059d8
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# call_once Function
Provides a mechanism for calling a specified callable object exactly once during execution.  
  
## Syntax  
  
```  
template<class Callable, class... Args>  
   void call_once(once_flag& Flag,  
      Callable F&&, Args&&... A);  
```  
  
#### Parameters  
 `Flag`  
 A [once_flag](../vs140/once_flag-structure.md) object that ensures that the callable object is only called once.  
  
 `F`  
 A callable object.  
  
 `A`  
 An argument list.  
  
## Remarks  
 If `Flag` is not valid, the function throws a [system_error](../vs140/system_error-class.md) that has an error code of `invalid_argument`. Otherwise, the template function uses its `Flag` argument to ensure that it calls `F(A...)` successfully exactly once, regardless of how many times the template function is called. If `F(A...)` exits by throwing an exception, the call was not successful.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [<mutex\>](../vs140/-mutex-.md)