---
title: "agent::agent Constructor"
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
  - "agents/concurrency::agent::agent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "agent, constructor"
ms.assetid: d13a380a-e3fb-4932-8785-09b4cdb1f0e6
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# agent::agent Constructor
Constructs an agent.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object within which the execution task of the agent is scheduled.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object within which the execution task of the agent is scheduled. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object used is implied by the schedule group.  
  
## Remarks  
 The runtime uses the default scheduler if you do not specify the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameters.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [agent Class](../vs140/agent-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)