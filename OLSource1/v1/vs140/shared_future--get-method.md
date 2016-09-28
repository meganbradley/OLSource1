---
title: "shared_future::get Method"
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
  - "future/std::shared_future::get"
dev_langs: 
  - "C++"
ms.assetid: 2cd9619a-4a67-4eeb-813a-a76310ce98d7
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# shared_future::get Method
Retrieves the result that's stored in the *associated asynchronous state*.  
  
## Syntax  
  
```  
const Ty& get() const;  
Ty& get() const;  
void get() const;  
```  
  
## Remarks  
 If the result is an exception, the method rethrows it. Otherwise, the result is returned.  
  
 Before it retrieves the result, this method blocks the current thread until the associated asynchronous state is ready.  
  
 For the partial specialization `shared_future<Ty&>`, the stored value is effectively a reference to the object that was passed to the *asynchronous provider* as the return value.  
  
 Because no stored value exists for the specialization `shared_future<void>`, the method returns `void`.  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
## See Also  
 [shared_future Class](../vs140/shared_future-class.md)   
 [<future\>](../vs140/-future-.md)