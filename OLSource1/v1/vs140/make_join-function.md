---
title: "make_join Function"
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
  - "agents/concurrency::make_join"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "make_join function"
ms.assetid: 8634413d-05fd-42c7-8a35-c7f8a0fff980
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# make_join Function
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> messaging block from an optional <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and two or more input sources.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The message block type of the first source.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The message block type of the second source.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object within which the propagation task for the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> messaging block is scheduled.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The first source.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The second source.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Additional sources.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object within which the propagation task for the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> messaging block is scheduled. The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object used is implied by the schedule group.  
  
## Return Value  
 A <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> message block with two or more input sources.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [multitype_join Class](../vs140/multitype_join-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)