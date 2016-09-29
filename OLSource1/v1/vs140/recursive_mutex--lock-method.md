---
title: "recursive_mutex::lock Method"
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
  - "mutex/std::recursive_mutex::lock"
dev_langs: 
  - "C++"
ms.assetid: c2b07478-b135-475f-8b64-9d3d3aae0fdd
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# recursive_mutex::lock Method
Blocks the calling thread until the thread obtains ownership of the `mutex`.  
  
## Syntax  
  
```cpp  
void lock();  
```  
  
## Remarks  
 If the calling thread already owns the `mutex`, the method returns immediately, and the previous lock remains in effect.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [recursive_mutex Class](../vs140/recursive_mutex-class.md)   
 [\<mutex>](../vs140/-mutex-.md)