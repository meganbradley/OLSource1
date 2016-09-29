---
title: "thread::id Class"
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
  - "thread/std::thread::id"
dev_langs: 
  - "C++"
ms.assetid: d6c63d08-4737-4c46-bc82-93cee0fab182
caps.latest.revision: 10
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# thread::id Class
Provides a unique identifier for each thread of execution in the process.  
  
## Syntax  
  
```  
class thread::id {  
   id() _NOEXCEPT;  
};  
```  
  
## Remarks  
 The default constructor creates an object that does not compare equal to the `thread::id` object for any existing thread.  
  
 All default-constructed `thread::id` objects compare equal.  
  
## Requirements  
 **Header:** thread  
  
 **Namespace:** std  
  
## See Also  
 [thread Class](../vs140/thread-class.md)   
 [<thread\>](../vs140/-thread-.md)   
 [thread::get_id Method](../vs140/thread--get_id-method.md)