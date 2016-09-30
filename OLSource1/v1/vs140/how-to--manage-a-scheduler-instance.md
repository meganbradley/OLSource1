---
title: "How to: Manage a Scheduler Instance"
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
  - "managing a scheduler instance [Concurrency Runtime]"
  - "scheduler instances, managing [Concurrency Runtime]"
ms.assetid: 2cc804f0-5ff3-498b-97f1-a9f67a005448
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Manage a Scheduler Instance
Scheduler instances let you associate specific scheduling policies with various kinds of workloads. This topic contains two basic examples that show how to create and manage a scheduler instance.  
  
 The examples create schedulers that use the default scheduler policies. For an example that creates a scheduler that uses a custom policy, see [How-to: Specify Specific Scheduler Policies](../vs140/how-to--specify-specific-scheduler-policies.md).  
  
### To manage a scheduler instance in your application  
  
1.  Create a [concurrency::SchedulerPolicy](../vs140/schedulerpolicy-class.md) object that contains the policy values for the scheduler to use.  
  
2.  Call the [concurrency::CurrentScheduler::Create](../vs140/currentscheduler--create-method.md) method or the [concurrency::Scheduler::Create](../vs140/scheduler--create-method.md) method to create a scheduler instance.  
  
     If you use the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> method, call the [concurrency::Scheduler::Attach](../vs140/scheduler--attach-method.md) method when you need to associate the scheduler with the current context.  
  
3.  Call the [CreateEvent](http://msdn.microsoft.com/library/windows/desktop/ms682396) function to create a handle to a non-signaled, auto-reset event object.  
  
4.  Pass the handle to the event object that you just created to the [concurrency::CurrentScheduler::RegisterShutdownEvent](../vs140/currentscheduler--registershutdownevent-method.md) method or the [concurrency::Scheduler::RegisterShutdownEvent](../vs140/scheduler--registershutdownevent-method.md) method. This registers the event to be set when the scheduler is destroyed.  
  
5.  Perform the tasks that you want the current scheduler to schedule.  
  
6.  Call the [concurrency::CurrentScheduler::Detach](../vs140/currentscheduler--detach-method.md) method to detach the current scheduler and restore the previous scheduler as the current one.  
  
     If you use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method, call the [concurrency::Scheduler::Release](../vs140/scheduler--release-method.md) method to decrement the reference count of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
7.  Pass the handle to the event to the [WaitForSingleObject](http://msdn.microsoft.com/library/windows/desktop/ms687032) function to wait for the scheduler to shut down.  
  
8.  Call the [CloseHandle](http://msdn.microsoft.com/library/windows/desktop/ms724211) function to close the handle to the event object.  
  
## Example  
 The following code shows two ways to manage a scheduler instance. Each example first uses the default scheduler to perform a task that prints out the unique identifier of the current scheduler. Each example then uses a scheduler instance to perform the same task again. Finally, each example restores the default scheduler as the current one and performs the task one more time.  
  
 The first example uses the [concurrency::CurrentScheduler](../vs140/currentscheduler-class.md) class to create a scheduler instance and associate it with the current context. The second example uses the [concurrency::Scheduler](../vs140/scheduler-class.md) class to perform the same task. Typically, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class is used to work with the current scheduler. The second example, which uses the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class, is useful when you want to control when the scheduler is associated with the current context or when you want to associate specific schedulers with specific tasks.  
  
 [!code[concrt-scheduler-instance#1](../vs140/codesnippet/CPP/how-to--manage-a-scheduler-instance_1.cpp)]  
  
 This example produces the following output.  
  
 **Using CurrentScheduler class...**  
**Current scheduler id: 0**  
**Creating and attaching scheduler...**  
**Current scheduler id: 1**  
**Detaching scheduler...**  
**Current scheduler id: 0**  
**Using Scheduler class...**  
**Current scheduler id: 0**  
**Creating scheduler...**  
**Attaching scheduler...**  
**Current scheduler id: 2**  
**Detaching scheduler...**  
**Current scheduler id: 0**   
## Compiling the Code  
 Copy the example code and paste it in a Visual Studio project, or paste it in a file that is named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and then run the following command in a Visual Studio Command Prompt window.  
  
 **cl.exe /EHsc scheduler-instance.cpp**  
  
## See Also  
 [Scheduler Instances](../vs140/scheduler-instances.md)   
 [How-to: Specify Specific Scheduler Policies](../vs140/how-to--specify-specific-scheduler-policies.md)