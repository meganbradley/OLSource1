---
title: "single_assignment::single_assignment Constructor"
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
  - "agents/concurrency::single_assignment::single_assignment"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "single_assignment, constructor"
ms.assetid: dca350a1-5071-4d44-8806-47f3fca1ef67
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# single_assignment::single_assignment Constructor
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> messaging block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A filter function which determines whether offered messages should be accepted.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object within which the propagation task for the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> messaging block is scheduled.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object within which the propagation task for the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> messaging block is scheduled. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object used is implied by the schedule group.  
  
## Remarks  
 The runtime uses the default scheduler if you do not specify the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameters.  
  
 The type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is a functor with signature <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> which is invoked by this <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> messaging block to determine whether or not it should accept an offered message.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [single_assignment Class](../vs140/single_assignment-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)