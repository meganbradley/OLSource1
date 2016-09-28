---
title: "thread::detach Method"
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
  - "thread/std::thread::detach"
dev_langs: 
  - "C++"
ms.assetid: c733f060-31b9-4cb3-b42d-ed68d8be60e4
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# thread::detach Method
Detaches the associated thread. The operating system becomes responsible for releasing thread resources on termination.  
  
## Syntax  
  
```  
void detach();  
```  
  
## Remarks  
 After a call to `detach`, subsequent calls to [get_id](../vs140/thread--get_id-method.md) return [id](../vs140/thread--id-class.md).  
  
 If the thread that's associated with the calling object is not joinable, the function throws a [system_error](../vs140/system_error-class.md) that has an error code of `invalid_argument`.  
  
 If the thread that's associated with the calling object is invalid, the function throws a `system_error` that has an error code of `no_such_process`.  
  
## Requirements  
 **Header:** thread  
  
 **Namespace:** std  
  
## See Also  
 [thread Class](../vs140/thread-class.md)   
 [<thread\>](../vs140/-thread-.md)