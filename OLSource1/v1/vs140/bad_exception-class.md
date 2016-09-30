---
title: "bad_exception Class"
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
  - "std.bad_exception"
  - "bad_exception"
  - "std::bad_exception"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bad_exception class"
ms.assetid: 5ae2c4ef-c7ad-4469-8a9e-a773e86bb000
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bad_exception Class
The class describes an exception that can be thrown from an unexpected handler.  
  
## Syntax  
  
```  
class bad_exception    : public exception {};  
  
```  
  
## Remarks  
 [unexpected](../vs140/-exception--functions.md#unexpected) will throw a `bad_exception` instead of terminating or instead of calling another function specified with [set_unexpected](../vs140/-exception--functions.md#set_unexpected) if `bad_exception` is included in the throw list of a function.  
  
 The value returned by **what** is an implementation-defined C string. None of the member functions throw any exceptions.  
  
 For a list of members inherited by the `bad_exception` class, see [exception Class](../vs140/exception-class.md).  
  
## Example  
 See [set_unexpected](../vs140/-exception--functions.md#set_unexpected) for an example of the use of [unexpected](../vs140/-exception--functions.md#unexpected) throwing a `bad_exception`.  
  
## Requirements  
 **Header:** \<exception>  
  
 **Namespace:** std  
  
## See Also  
 [exception Class](../vs140/exception-class.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)