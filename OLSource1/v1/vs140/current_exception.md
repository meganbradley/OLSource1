---
title: "current_exception"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
ms.assetid: 333180ce-73df-4343-9704-ab6c19c81fc2
caps.latest.revision: 8
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# current_exception
Obtains a smart pointer to the current exception.  
  
## Syntax  
  
```vb  
exception_ptr current_exception();  
```  
  
## Return Value  
 An [exception_ptr](../vs140/exception_ptr.md) object pointing to the current exception.  
  
## Remarks  
 Call the `current_exception` function in a catch block. If an exception is in flight and the catch block can catch the exception, the `current_exception` function returns an `exception_ptr` object that references the exception. Otherwise, the function returns a null `exception_ptr` object.  
  
 The `current_exception` function captures the exception that is in flight regardless of whether the `catch` statement specifies an [exception-declaration](../vs140/try--throw--and-catch-statements--c---.md) statement.  
  
 The destructor for the current exception is called at the end of the `catch` block if you do not rethrow the exception. However, even if you call the `current_exception` function in the destructor, the function returns an `exception_ptr` object that references the current exception.  
  
 Successive calls to the `current_exception` function return `exception_ptr` objects that refer to different copies of the current exception. Consequently, the objects compare as unequal because they refer to different copies, even though the copies have the same binary value.  
  
## See Also  
 [<exception\>](../vs140/-exception-.md)   
 [Transporting Exceptions Between Threads](../vs140/transporting-exceptions-between-threads.md)