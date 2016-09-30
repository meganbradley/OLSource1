---
title: "join::join Constructor"
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
  - "agents/concurrency::join::join"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "join, constructor"
ms.assetid: 36177ccb-7de9-41e4-b710-73e2da533d80
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# join::join Constructor
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> messaging block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of inputs this <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> block will be allowed.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A filter function which determines whether offered messages should be accepted.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object within which the propagation task for the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> messaging block is scheduled.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object within which the propagation task for the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> messaging block is scheduled. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object used is implied by the schedule group.  
  
## Remarks  
 The runtime uses the default scheduler if you do not specify the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameters.  
  
 The type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is a functor with signature <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> which is invoked by this <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> messaging block to determine whether or not it should accept an offered message.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [join Class](../vs140/join-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)