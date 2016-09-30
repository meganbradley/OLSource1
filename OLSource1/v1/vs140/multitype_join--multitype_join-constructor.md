---
title: "multitype_join::multitype_join Constructor"
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
  - "agents/concurrency::multitype_join::multitype_join"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "multitype_join, constructor"
ms.assetid: d0fbafa3-b73f-4ba2-90e1-6fcc8bc4e387
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multitype_join::multitype_join Constructor
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> messaging block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> of sources for this <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> messaging block.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object within which the propagation task for the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> messaging block is scheduled.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object within which the propagation task for the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> messaging block is scheduled. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object used is implied by the schedule group.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> messaging block to copy from. Note that the original object is orphaned, making this a move constructor.  
  
## Remarks  
 The runtime uses the default scheduler if you do not specify the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameters.  
  
 Move construction is not performed under a lock, which means that it is up to the user to make sure that there are no light-weight tasks in flight at the time of moving. Otherwise, numerous races can occur, leading to exceptions or inconsistent state.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [multitype_join Class](../vs140/multitype_join-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)