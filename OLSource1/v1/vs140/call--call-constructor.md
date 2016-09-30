---
title: "call::call Constructor"
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
  - "agents/concurrency::call::call"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "call, constructor"
ms.assetid: 8fa34cc5-8c85-4240-a989-dbabb63bfb3d
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# call::call Constructor
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> messaging block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A function that will be invoked for each accepted message.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A filter function which determines whether offered messages should be accepted.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object within which the propagation task for the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> messaging block is scheduled.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object within which the propagation task for the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> messaging block is scheduled. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object used is implied by the schedule group.  
  
## Remarks  
 The runtime uses the default scheduler if you do not specify the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameters.  
  
 The type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is a functor with signature <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> which is invoked by this <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> messaging block to process a message.  
  
 The type <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a functor with signature <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> which is invoked by this <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> messaging block to determine whether or not it should accept an offered message.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [call Class](../vs140/call-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)