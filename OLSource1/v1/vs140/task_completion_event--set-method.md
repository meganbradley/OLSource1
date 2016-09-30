---
title: "task_completion_event::set Method"
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
  - "ppltasks/concurrency::task_completion_event::set"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "set method"
ms.assetid: c457eabc-18ca-4435-a9d0-b115395ccfca
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# task_completion_event::set Method
Sets the task completion event.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The result to set this event with.  
  
## Return Value  
 The method returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if it was successful in setting the event. It returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the event is already set.  
  
## Remarks  
 In the presence of multiple or concurrent calls to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, only the first call will succeed and its result (if any) will be stored in the task completion event. The remaining sets are ignored and the method will return false. When you set a task completion event, all the tasks created from that event will immediately complete, and its continuations, if any, will be scheduled. Task completion objects that have a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> other than <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> will pass the value  to their continuations.  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [task_completion_event Class](../vs140/task_completion_event-class.md)