---
title: "agent::wait_for_one Method"
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
  - "agents/concurrency::agent::wait_for_one"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wait_for_one method"
ms.assetid: f53faa55-5a9e-4a54-a167-d92e450bb8fa
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# agent::wait_for_one Method
Waits for any one of the specified agents to complete its task.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The number of agent pointers present in the array <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An array of pointers to the agents to wait for.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A reference to a variable where the agent status will be placed.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A reference to a variable where the agent index will be placed.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The maximum time for which to wait, in milliseconds.  
  
## Remarks  
 An agent task is completed when the agent enters the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> states.  
  
 If the parameter <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> has a value other than the constant <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the exception [operation_timed_out](../vs140/operation_timed_out-class.md) is thrown if the specified amount of time expires before the agent has completed its task.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [agent Class](../vs140/agent-class.md)   
 [agent::wait Method](../vs140/agent--wait-method.md)   
 [agent::wait_for_all Method](../vs140/agent--wait_for_all-method.md)   
 [agent_status Enumeration](../vs140/agent_status-enumeration.md)