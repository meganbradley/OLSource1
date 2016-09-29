---
title: "overwrite_buffer::overwrite_buffer Constructor"
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
  - "agents/concurrency::overwrite_buffer::overwrite_buffer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "overwrite_buffer, constructor"
ms.assetid: ebf8f81f-5641-4bca-b972-19fda917982c
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# overwrite_buffer::overwrite_buffer Constructor
Constructs an `overwrite_buffer` messaging block.  
  
## Syntax  
  
```  
overwrite_buffer();  
  
overwrite_buffer(  
   filter_method const& _Filter  
);  
  
overwrite_buffer(  
   Scheduler& _PScheduler  
);  
  
overwrite_buffer(  
   Scheduler& _PScheduler,  
   filter_method const& _Filter  
);  
  
overwrite_buffer(  
   ScheduleGroup& _PScheduleGroup  
);  
  
overwrite_buffer(  
   ScheduleGroup& _PScheduleGroup,  
   filter_method const& _Filter  
);  
```  
  
#### Parameters  
 `_Filter`  
 A filter function which determines whether offered messages should be accepted.  
  
 `_PScheduler`  
 The `Scheduler` object within which the propagation task for the `overwrite_buffer` messaging block is scheduled.  
  
 `_PScheduleGroup`  
 The `ScheduleGroup` object within which the propagation task for the `overwrite_buffer` messaging block is scheduled. The `Scheduler` object used is implied by the schedule group.  
  
## Remarks  
 The runtime uses the default scheduler if you do not specify the `_PScheduler` or `_PScheduleGroup` parameters.  
  
 The type `filter_method` is a functor with signature `bool (_Type const &)` which is invoked by this `overwrite_buffer` messaging block to determine whether or not it should accept an offered message.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [overwrite_buffer Class](../vs140/overwrite_buffer-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)