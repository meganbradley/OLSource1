---
title: "completion_future::to_task Method"
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
  - "amprt/Concurrency::completion_future::to_task"
dev_langs: 
  - "C++"
ms.assetid: 79fd4965-3d35-44db-845c-450e20b2647a
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# completion_future::to_task Method
Returns a `task` object corresponding to the associated asynchronous operation.  
  
## Syntax  
  
```  
concurrency::task<void> to_task() const;  
```  
  
## Return Value  
 A `task` object corresponding to the associated asynchronous operation.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [completion_future Class](../vs140/completion_future-class.md)