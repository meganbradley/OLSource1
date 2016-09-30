---
title: "transformer::transformer Constructor"
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
  - "agents/concurrency::transformer::transformer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "transformer, constructor"
ms.assetid: 163a9b9f-91b8-4cbf-95ff-1103b71e25b4
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# transformer::transformer Constructor
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> messaging block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A function that will be invoked for each accepted message.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a target block to link with the transformer.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A filter function which determines whether offered messages should be accepted.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object within which the propagation task for the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> messaging block is scheduled.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object within which the propagation task for the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> messaging block is scheduled. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object used is implied by the schedule group.  
  
## Remarks  
 The runtime uses the default scheduler if you do not specify the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameters.  
  
 The type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is a functor with signature <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> which is invoked by this <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> messaging block to process a message.  
  
 The type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is a functor with signature <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> which is invoked by this <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> messaging block to determine whether or not it should accept an offered message.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [transformer Class](../vs140/transformer-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)