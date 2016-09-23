---
title: "make_greedy_join Function"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - agents/concurrency::make_greedy_join
dev_langs: 
  - C++
helpviewer_keywords: 
  - make_greedy_join function
ms.assetid: 0e1a1922-3c46-4898-9e58-4887c71c3ce7
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# make_greedy_join Function
Constructs a `greedy multitype_join` messaging block from an optional `Scheduler` or `ScheduleGroup` and two or more input sources.  
  
## Syntax  
  
```  
template<  
   typename _Type1,  
   typename _Type2,  
   typename... _Types  
>  
multitype_join<std::tuple<_Type1, _Type2, _Types...>, greedy> make_greedy_join(  
   Scheduler& _PScheduler,  
   _Type1_Item1,  
   _Type2_Item2,  
   _Types... _Items  
);  
  
template<  
   typename _Type1,  
   typename _Type2,  
   typename... _Types  
>  
multitype_join<std::tuple<_Type1, _Type2, _Types...>, greedy> make_greedy_join(  
   ScheduleGroup& _PScheduleGroup,  
   _Type1_Item1,  
   _Type2_Item2,  
   _Types... _Items  
);  
  
template<  
   typename _Type1,  
   typename _Type2,  
   typename... _Types  
>  
multitype_join<std::tuple<_Type1, _Type2, _Types...>, greedy> make_greedy_join(  
   _Type1_Item1,  
   _Type2_Item2,  
   _Types... _Items  
);  
```  
  
#### Parameters  
 `_Type1`  
 The message block type of the first source.  
  
 `_Type2`  
 The message block type of the second source.  
  
 `_PScheduler`  
 The `Scheduler` object within which the propagation task for the `multitype_join` messaging block is scheduled.  
  
 `_Item1`  
 The first source.  
  
 `_Item2`  
 The second source.  
  
 `_Items`  
 Additional sources.  
  
 `_PScheduleGroup`  
 The `ScheduleGroup` object within which the propagation task for the `multitype_join` messaging block is scheduled. The `Scheduler` object used is implied by the schedule group.  
  
## Return Value  
 A `greedy multitype_join` message block with two or more input sources.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [multitype_join Class](../vs140/multitype_join-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)