---
title: "rethrow_exception"
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
ms.assetid: 63cd325d-7585-4f6e-b2ba-a10ae397927b
caps.latest.revision: 9
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# rethrow_exception
Throws an exception passed as a parameter.  
  
## Syntax  
  
```vb  
void rethrow_exception(exception_ptr P);  
```  
  
#### Parameters  
 `P`  
 The caught exception to re-throw. If `P` is a null [exception_ptr](../vs140/exception_ptr.md), the function throws [std::bad_exception](../vs140/bad_exception-class.md).  
  
## Remarks  
 After you store a caught exception in an `exception_ptr` object, the primary thread can process the object. In your primary thread, call the `rethrow_exception` function together with the `exception_ptr` object as its argument. The `rethrow_exception` function extracts the exception from the `exception_ptr` object and then throws the exception in the context of the primary thread.  
  
## See Also  
 [\<exception>](../vs140/-exception-.md)   
 [Transporting Exceptions Between Threads](../vs140/transporting-exceptions-between-threads.md)