---
title: "Schedule Groups"
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
  - "schedule groups"
ms.assetid: 03523572-5891-4d17-89ce-fa795605f28b
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Schedule Groups
This document describes the role of schedule groups in the Concurrency Runtime. A *schedule group* affinitizes, or groups, related tasks together. Every scheduler has one or more schedule groups. Use schedule groups when you require a high degree of locality among tasks, for example, when a group of related tasks benefit from executing on the same processor node. Conversely, use scheduler instances when your application has specific quality requirements, for example, when you want to limit the amount of processing resources that are allocated to a set of tasks. For more information about scheduler instances, see [Scheduler Instances](../vs140/scheduler-instances.md).  
  
> [!TIP]
>  The Concurrency Runtime provides a default scheduler, and therefore you are not required to create one in your application. Because the Task Scheduler helps you fine-tune the performance of your applications, we recommend that you start with the [Parallel Patterns Library (PPL)](../vs140/parallel-patterns-library--ppl-.md) or the [Asynchronous Agents Library](../vs140/asynchronous-agents-library.md) if you are new to the Concurrency Runtime.  
  
 Every `Scheduler` object has a default schedule group for every scheduling node. A *scheduling node* maps to the underlying system topology. The runtime creates one scheduling node for every processor package or Non-Uniform Memory Architecture (NUMA) node, whichever number is larger. If you do not explicitly associate a task with a schedule group, the scheduler chooses which group to add the task to.  
  
 The `SchedulingProtocol` scheduler policy influences the order in which the scheduler executes the tasks in each schedule group. When `SchedulingProtocol` is set to `EnhanceScheduleGroupLocality` (which is the default), the Task Scheduler chooses the next task from the schedule group that it is working on when the current task finishes or cooperatively yields. The Task Scheduler searches the current schedule group for work before it moves to the next available group. Conversely, when `SchedulingProtocol` is set to `EnhanceForwardProgress`, the scheduler moves to the next schedule group after each task finishes or yields. For an example that compares these policies, see [How-to: Use Schedule Groups to Influence Order of Execution](../vs140/how-to--use-schedule-groups-to-influence-order-of-execution.md).  
  
 The runtime uses the [concurrency::ScheduleGroup](../vs140/schedulegroup-class.md) class to represent schedule groups. To create a `ScheduleGroup` object, call the [concurrency::CurrentScheduler::CreateScheduleGroup](../vs140/currentscheduler--createschedulegroup-method.md) or [concurrency::Scheduler::CreateScheduleGroup](../vs140/scheduler--createschedulegroup-method.md) method. The runtime uses a reference-counting mechanism to control the lifetime of `ScheduleGroup` objects, just as it does with `Scheduler` objects. When you create a `ScheduleGroup` object, the runtime sets the reference counter to one. The [concurrency::ScheduleGroup::Reference](../vs140/schedulegroup--reference-method.md) method increments the reference counter by one. The [concurrency::ScheduleGroup::Release](../vs140/schedulegroup--release-method.md) method decrements the reference counter by one.  
  
 Many types in the Concurrency Runtime let you associate an object together with a schedule group. For example, the [concurrency::agent](../vs140/agent-class.md) class and message block classes such as [concurrency::unbounded_buffer](../vs140/unbounded_buffer-class.md), [concurrency::join](../vs140/join-class.md), and [concurrency::timer](../vs140/timer-class.md), provide overloaded versions of the constructor that take a `ScheduleGroup` object. The runtime uses the `Scheduler` object that is associated with this `ScheduleGroup` object to schedule the task.  
  
 You can also use the [concurrency::ScheduleGroup::ScheduleTask](../vs140/schedulegroup--scheduletask-method.md) method to schedule a lightweight task. For more information about lightweight tasks, see [Lightweight Tasks](../vs140/lightweight-tasks.md).  
  
## Example  
 For an example that uses schedule groups to control the order of task execution, see [How-to: Use Schedule Groups to Influence Order of Task Execution](../vs140/how-to--use-schedule-groups-to-influence-order-of-execution.md).  
  
## See Also  
 [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md)   
 [Scheduler Instances](../vs140/scheduler-instances.md)   
 [How-to: Use Schedule Groups to Influence Order of Task Execution](../vs140/how-to--use-schedule-groups-to-influence-order-of-execution.md)