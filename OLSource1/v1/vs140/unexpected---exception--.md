---
title: "unexpected (&lt;exception&gt;)"
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
  - "std::unexpected"
  - "unexpected"
  - "std.unexpected"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unexpected function"
ms.assetid: 3d12f205-dc5d-4951-a3bc-61c0388835c3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unexpected (&lt;exception&gt;)
Calls the unexpected handler.  
  
## Syntax  
  
```  
  
void unexpected( );  
  
```  
  
## Remarks  
 The C++ Standard requires that `unexpected` is called when a function throws an exception that is not on its throw list. The current implementation does not support this. The example calls `unexpected` directly, which calls the unexpected handler.  
  
 The function calls an unexpected handler, a function of type `void`. If `unexpected` is called directly by the program, the unexpected handler is the one most recently set by a call to [set_unexpected](../vs140/set_unexpected---exception--.md).  
  
 An unexpected handler may not return to its caller. It may terminate execution by:  
  
-   Throwing an object of a type listed in the exception specification or an object of any type if the unexpected handler is called directly by the program.  
  
-   Throwing an object of type [bad_exception](../vs140/bad_exception-class.md).  
  
-   Calling [terminate](../vs140/terminate---exception--.md), **abort** or **exit**(`int`).  
  
 At program startup, the unexpected handler is a function that calls [terminate](../vs140/terminate---exception--.md).  
  
## Example  
 See [set_unexpected](../vs140/set_unexpected---exception--.md) for an example of the use of **unexpected.**  
  
## Requirements  
 **Header:** \<exception>  
  
 **Namespace:** std