---
title: "timer::timer Constructor"
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
  - "agents/concurrency::timer::timer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "timer, constructor"
ms.assetid: bb972fd8-24ec-4640-83b6-12fd58209e98
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# timer::timer Constructor
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> messaging block that will fire a given message after a specified interval.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of milliseconds that must elapse after the call to start for the specified message to be propagated downstream.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The value which will be propagated downstream when the timer elapses.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The target to which the timer will propagate its message.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 If true, indicates that the timer will fire periodically every <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> milliseconds.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object within which the propagation task for the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> messaging block is scheduled is scheduled.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object within which the propagation task for the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> messaging block is scheduled. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object used is implied by the schedule group.  
  
## Remarks  
 The runtime uses the default scheduler if you do not specify the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameters.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [timer Class](../vs140/timer-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)