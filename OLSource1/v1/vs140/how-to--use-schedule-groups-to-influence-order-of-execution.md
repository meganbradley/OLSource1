---
title: "How to: Use Schedule Groups to Influence Order of Execution"
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
  - "schedule groups, using [Concurrency Runtime]"
  - "using schedule groups [Concurrency Runtime]"
ms.assetid: 73124194-fc3a-491e-a23f-fbd7b5a4455c
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use Schedule Groups to Influence Order of Execution
In the Concurrency Runtime, the order in which tasks are scheduled is non-deterministic. However, you can use scheduling policies to influence the order in which tasks run. This topic shows how to use schedule groups together with the [concurrency::SchedulingProtocol](../vs140/policyelementkey-enumeration.md) scheduler policy to influence the order in which tasks run.  
  
 The example runs a set of tasks two times, each with a different scheduling policy. Both policies limit the maximum number of processing resources to two. The first run uses the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> policy, which is the default, and the second run uses the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> policy. Under the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> policy, the scheduler runs all tasks in one schedule group until each task finishes or yields. Under the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> policy, the scheduler moves to the next schedule group in a round-robin manner after just one task finishes or yields.  
  
 When each schedule group contains related tasks, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> policy typically results in improved performance because cache locality is preserved between tasks. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> policy enables tasks to make forward progress and is useful when you require scheduling fairness across schedule groups.  
  
## Example  
 This example defines the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class, which derives from [concurrency::agent](../vs140/agent-class.md). The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class performs a unit of work, yields the current context, and then performs another unit of work. The agent uses the [concurrency::wait](../vs140/wait-function.md) function to cooperatively yield the current context so that other contexts can run.  
  
 This example creates four <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> objects. To illustrate how to set scheduler policies to affect the order in which the agents run, the example associates the first two agents with one schedule group and the other two agents with another schedule group. The example uses the [concurrency::CurrentScheduler::CreateScheduleGroup](../vs140/currentscheduler--createschedulegroup-method.md) method to create the [concurrency::ScheduleGroup](../vs140/schedulegroup-class.md) objects. The example runs all four agents two times, each time with a different scheduling policy.  
  
 [!code[concrt-scheduling-protocol#1](../vs140/codesnippet/CPP/how-to--use-schedule-groups-to-influence-order-of-execution_1.cpp)]  
  
 This example produces the following output.  
  
 **Using EnhanceScheduleGroupLocality...**  
**group 0,task 0: first loop...**  
**group 0,task 1: first loop...**  
**group 0,task 0: waiting...**  
**group 1,task 0: first loop...**  
**group 0,task 1: waiting...**  
**group 1,task 1: first loop...**  
**group 1,task 0: waiting...**  
**group 0,task 0: second loop...**  
**group 1,task 1: waiting...**  
**group 0,task 1: second loop...**  
**group 0,task 0: finished...**  
**group 1,task 0: second loop...**  
**group 0,task 1: finished...**  
**group 1,task 1: second loop...**  
**group 1,task 0: finished...**  
**group 1,task 1: finished...**  
**Using EnhanceForwardProgress...**  
**group 0,task 0: first loop...**  
**group 1,task 0: first loop...**  
**group 0,task 0: waiting...**  
**group 0,task 1: first loop...**  
**group 1,task 0: waiting...**  
**group 1,task 1: first loop...**  
**group 0,task 1: waiting...**  
**group 0,task 0: second loop...**  
**group 1,task 1: waiting...**  
**group 1,task 0: second loop...**  
**group 0,task 0: finished...**  
**group 0,task 1: second loop...**  
**group 1,task 0: finished...**  
**group 1,task 1: second loop...**  
**group 0,task 1: finished...**  
**group 1,task 1: finished...** Both policies produce the same sequence of events. However, the policy that uses <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> starts both agents that are part of the first schedule group before it starts the agents that are part of the second group. The policy that uses <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> starts one agent from the first group and then starts the first agent in the second group.  
  
## Compiling the Code  
 Copy the example code and paste it in a Visual Studio project, or paste it in a file that is named <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and then run the following command in a Visual Studio Command Prompt window.  
  
 **cl.exe /EHsc scheduling-protocol.cpp**  
  
## See Also  
 [Schedule Groups](../vs140/schedule-groups.md)   
 [Asynchronous Agents](../vs140/asynchronous-agents.md)