---
title: "Walkthrough: Adapting Existing Code to Use Lightweight Tasks"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "using lightweight tasks [Concurrency Runtime]"
  - "lightweight tasks, using [Concurrency Runtime]"
ms.assetid: 1edfe818-d274-46de-bdd3-e92967c9bbe0
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Adapting Existing Code to Use Lightweight Tasks
This topic shows how to adapt existing code that uses the Windows API to create and execute a thread to use a lightweight task.  
  
 A *lightweight task* is a task that you schedule directly from a [concurrency::Scheduler](../vs140/scheduler-class.md) or [concurrency::ScheduleGroup](../vs140/schedulegroup-class.md) object. Lightweight tasks are useful when you adapt existing code to use the scheduling functionality of the Concurrency Runtime.  
  
## Prerequisites  
 Before you start this walkthrough, read the topic [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md).  
  
## Example  
  
### Description  
 The following example illustrates typical usage of the Windows API to create and execute a thread. This example uses the [CreateThread](http://msdn.microsoft.com/library/windows/desktop/ms682453) function to call the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> on a separate thread.  
  
### Code  
 [!code[concrt-windows-threads#1](../vs140/codesnippet/CPP/walkthrough--adapting-existing-code-to-use-lightweight-tasks_1.cpp)]  
  
### Comments  
 This example produces the following output.  
  
 **Parameters = 50, 100** The following steps show how to adapt the code example to use the Concurrency Runtime to perform the same task.  
  
### To adapt the example to use a lightweight task  
  
1.  Add a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> directive for the header file concrt.h.  
  
     [!code[concrt-migration-lwt#2](../vs140/codesnippet/CPP/walkthrough--adapting-existing-code-to-use-lightweight-tasks_2.cpp)]  
  
2.  Add a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> directive for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> namespace.  
  
     [!code[concrt-migration-lwt#3](../vs140/codesnippet/CPP/walkthrough--adapting-existing-code-to-use-lightweight-tasks_3.cpp)]  
  
3.  Change the declaration of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> calling convention and to return <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
     [!code[concrt-migration-lwt#4](../vs140/codesnippet/CPP/walkthrough--adapting-existing-code-to-use-lightweight-tasks_4.cpp)]  
  
4.  Modify the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> structure to include a [concurrency::event](../vs140/event-class.md) object that signals to the main application that the task has finished.  
  
     [!code[concrt-migration-lwt#5](../vs140/codesnippet/CPP/walkthrough--adapting-existing-code-to-use-lightweight-tasks_5.cpp)]  
  
5.  Replace the call to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> with a call to the [concurrency::CurrentScheduler::ScheduleTask](../vs140/currentscheduler--scheduletask-method.md) method.  
  
     [!code[concrt-migration-lwt#6](../vs140/codesnippet/CPP/walkthrough--adapting-existing-code-to-use-lightweight-tasks_6.cpp)]  
  
6.  Replace the call to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> with a call to the [concurrency::event::wait](../vs140/event--wait-method.md) method to wait for the task to finish.  
  
     [!code[concrt-migration-lwt#7](../vs140/codesnippet/CPP/walkthrough--adapting-existing-code-to-use-lightweight-tasks_7.cpp)]  
  
7.  Remove the call to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
8.  Change the signature of the definition of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to match step 3.  
  
     [!code[concrt-migration-lwt#8](../vs140/codesnippet/CPP/walkthrough--adapting-existing-code-to-use-lightweight-tasks_8.cpp)]  
  
9. At the end of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function, call the [concurrency::event::set](../vs140/event--set-method.md) method to signal to the main application that the task has finished.  
  
     [!code[concrt-migration-lwt#9](../vs140/codesnippet/CPP/walkthrough--adapting-existing-code-to-use-lightweight-tasks_9.cpp)]  
  
10. Remove the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statement from <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Example  
  
### Description  
 The following completed example shows code that uses a lightweight task to call the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function.  
  
### Code  
 [!code[concrt-migration-lwt#1](../vs140/codesnippet/CPP/walkthrough--adapting-existing-code-to-use-lightweight-tasks_10.cpp)]  
  
### Comments  
  
## See Also  
 [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md)   
 [Scheduler Class](../vs140/scheduler-class.md)