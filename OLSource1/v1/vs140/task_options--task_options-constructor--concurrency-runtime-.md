---
title: "task_options::task_options Constructor (Concurrency Runtime)"
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
  - "ppltasks/concurrency::task_options::task_options"
dev_langs: 
  - "C++"
ms.assetid: 15fae9ca-f943-45f4-b202-551fe2926710
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# task_options::task_options Constructor (Concurrency Runtime)
Default list of task creation options  
  
## Syntax  
  
```  
task_options();  
  
task_options(  
   cancellation_token _Token  
);  
  
task_options(  
   task_continuation_context _ContinuationContext  
);  
  
task_options(  
   cancellation_token _Token,  
   task_continuation_context _ContinuationContext  
);  
  
template<  
   typename _SchedType  
>  
task_options(  
   std::shared_ptr<_SchedType> _Scheduler  
);  
  
task_options(  
   scheduler_interface& _Scheduler  
);  
  
task_options(  
   scheduler_ptr _Scheduler  
);  
  
task_options(  
   const task_options& _TaskOptions  
);  
```  
  
#### Parameters  
 `_SchedType`  
 `_Token`  
 `_ContinuationContext`  
 `_Scheduler`  
 `_TaskOptions`  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [task_options Class (Concurrency Runtime)](../vs140/task_options-class--concurrency-runtime-.md)