---
title: "ordered_message_processor::initialize Method"
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
  - "agents/concurrency::ordered_message_processor::initialize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "initialize method"
ms.assetid: ae6723ec-3ff9-4f26-8592-58f22a1cd6f0
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ordered_message_processor::initialize Method
Initializes the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object with the appropriate callback function, scheduler and schedule group.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the scheduler to be used for scheduling light-weight tasks.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the schedule group to be used for scheduling light-weight tasks.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The handler functor invoked during callback.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ordered_message_processor Class](../vs140/ordered_message_processor-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)