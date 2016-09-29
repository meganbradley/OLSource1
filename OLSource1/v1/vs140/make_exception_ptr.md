---
title: "make_exception_ptr"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 4c3168fc-c0f3-4fda-8bf2-c372dd51f6f2
caps.latest.revision: 9
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# make_exception_ptr
Creates an [exception_ptr](../vs140/exception_ptr.md) object that holds a copy of an exception.  
  
## Syntax  
  
```vb  
template <class E>   
    exception_ptr make_exception_ptr(E Except);  
```  
  
#### Parameters  
 `Except`  
 The class with the exception to copy. Usually, you specify an [exception class](../vs140/exception-class.md) object as the argument to the `make_exception_ptr` function, although any class object can be the argument.  
  
## Return Value  
 An [exception_ptr](../vs140/exception_ptr.md) object pointing to a copy of the current exception for `Except`.  
  
## Remarks  
 Calling the `make_exception_ptr` function is equivalent to throwing a C++ exception, catching it in a catch block, and then calling the [current_exception](../vs140/current_exception.md) function to return an `exception_ptr` object that references the exception. The Microsoft implementation of the `make_exception_ptr` function is more efficient than throwing and then catching an exception.  
  
 An application typically does not require the `make_exception_ptr` function, and we discourage its use.  
  
## See Also  
 [\<exception>](../vs140/-exception-.md)   
 [Transporting Exceptions Between Threads](../vs140/transporting-exceptions-between-threads.md)