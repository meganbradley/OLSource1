---
title: "unbounded_buffer::unbounded_buffer Constructor"
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
  - "agents/concurrency::unbounded_buffer::unbounded_buffer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unbounded_buffer, constructor"
ms.assetid: 7608f40b-af72-49a6-8173-541ad9cfa4ce
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unbounded_buffer::unbounded_buffer Constructor
Constructs an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> messaging block.  
  
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
 [unbounded_buffer Class](../vs140/unbounded_buffer-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)