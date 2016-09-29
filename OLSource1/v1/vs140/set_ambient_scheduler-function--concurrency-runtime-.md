---
title: "set_ambient_scheduler Function (Concurrency Runtime)"
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
  - "pplconcrt/concurrency::set_ambient_scheduler"
dev_langs: 
  - "C++"
ms.assetid: 83b32fa3-ae98-4274-9b84-2cabc3cdcf68
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set_ambient_scheduler Function (Concurrency Runtime)
## Syntax  
  
```  
inline void set_ambient_scheduler(  
   std::shared_ptr<::Concurrency::scheduler_interface> _Scheduler  
);  
```  
  
#### Parameters  
 `_Scheduler`  
  
## Requirements  
 **Header:** pplconcrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)