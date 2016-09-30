---
title: "agent::done Method"
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
  - "agents/concurrency::agent::done"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "done method"
ms.assetid: 557df23a-bd24-48ac-a336-5f12d9cdc542
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# agent::done Method
Moves an agent into the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> state, indicating that the agent has completed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the agent is moved to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> state, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> otherwise. An agent that has been canceled cannot be moved to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> state.  
  
## Remarks  
 This method should be called at the end of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method, when you know the execution of your agent has completed.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [agent Class](../vs140/agent-class.md)   
 [agent_status Enumeration](../vs140/agent_status-enumeration.md)